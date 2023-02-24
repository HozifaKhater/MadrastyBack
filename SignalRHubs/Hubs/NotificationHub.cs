
using MadrastyAPI.Models;
using Microsoft.AspNetCore.SignalR;
using System.Data;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace SignalRHubs.Hubs
{
    public class NotificationHub : Hub
    {
         SqlConnection myCN;
         SqlDataAdapter myDA;
     
        public async Task BroadcastChartData(string data, string connectionId) =>
            await Clients.Client(connectionId).SendAsync("broadcastchartdata", data);

        public override Task OnConnectedAsync()
        {
            //   UserHandler.ConnectedIds.Add(Context.ConnectionId);
            //con_sig.connection_id = Context.ConnectionId;
            //con_sig.save_in_signalir_connections();

            myCN = new SqlConnection("packet size=4096;user id=sa1;password=1234;data source=(local); persist security info=False;initial catalog=madrasty;Connect Timeout=5400;TrustServerCertificate=True");
            myCN.Open();
            myDA = new SqlDataAdapter(@"Exec [save_in_signalir_connections]  
            '" + Context.ConnectionId + @"'
            ", myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(myDA);
           myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            myCN.Close();



            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            //UserHandler.ConnectedIds.Remove(Context.ConnectionId);
            //con_sig.connection_id = Context.ConnectionId;
            //con_sig.delete_from_signalir_connections();

            myCN = new SqlConnection("packet size=4096;user id=sa1;password=1234;data source=(local); persist security info=False;initial catalog=madrasty;Connect Timeout=5400;TrustServerCertificate=True");
            myCN.Open();
            myDA = new SqlDataAdapter(@"Exec [delete_from_signalir_connections]  
            '" + Context.ConnectionId + @"'
            ", myCN);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(myDA);
            myDA.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // con_obj.myDT = New DataTable()
            DataSet myDS = new DataSet();
            myDA.Fill(myDS);
            // con_obj.myDS.Tables.Add(con_obj.myDT)
            myCN.Close();
            return base.OnDisconnectedAsync(exception);
        }

        public string GetConnectionId() => Context.ConnectionId;
    }
}
