using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic.Hubs
{
    public class AppNotificationHub : Hub
    {
        SqlConnection myCN;
        SqlDataAdapter myDA;

        public override async Task OnConnectedAsync()
        {
            // here we will update user in database
            myCN = new SqlConnection("packet size=4096;user id=sa;password=Thank$123;data source=(local); persist security info=False;initial catalog=madrasty;Connect Timeout=5400;TrustServerCertificate=True");
            //  myCN = new SqlConnection("Server=tcp:madrasty-sql.database.windows.net,1433;Initial Catalog=madrasty;Persist Security Info=False;User ID=sysadmin;Password=Thank$123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            // here we will update the user on database
            myCN = new SqlConnection("packet size=4096;user id=sa;password=Thank$123;data source=(local); persist security info=False;initial catalog=madrasty;Connect Timeout=5400;TrustServerCertificate=True");
            //  myCN = new SqlConnection("Server=tcp:madrasty-sql.database.windows.net,1433;Initial Catalog=madrasty;Persist Security Info=False;User ID=sysadmin;Password=Thank$123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
            await base.OnDisconnectedAsync(exception);
        }
        public string GetConnectionId() => Context.ConnectionId;

        //protected override void Dispose(bool disposing)
        //{
        //    // 
        //    base.Dispose(disposing);
        //}
    }
}
