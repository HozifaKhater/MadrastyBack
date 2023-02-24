using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Responses;
using  BusinessLogic.ViewModels;
using  System;
using  System.Collections.Generic;
using  System.Data.SqlClient;
using  System.Data;
using  System.Linq;
using  System.Reflection;
using  System.Text;
using  System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class CountryService : ICountryService
    {
        private readonly IDatabaseContext _db;

        public CountryService(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> SaveCountry(Country country)
        {
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter { ParameterName = nameof(country.Name), Value = country.Name });
            param.Add(new SqlParameter { ParameterName = nameof(country.Description), Value = country.Description });
            
            DataTable dt = _db.CreateDataTable(country.Cities);

            param.Add(new SqlParameter { ParameterName = "detailsData", Value = dt });

            var result = await _db.ExecuteNonQuery("Insert_SUS_CNTRY", param);

            return new ServiceResponse(result);
        }
    }
}
