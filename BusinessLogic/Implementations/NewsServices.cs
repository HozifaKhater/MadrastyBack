using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class NewsServices : INewsServices
    {
        private readonly IDatabaseContext _db;
        public NewsServices(IDatabaseContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse> GetNews()
        {
            var dalResponse = await _db.ExecuteQuery("get_news");
            return new ServiceResponse(dalResponse);
        }
    }
}
