using GameDev.Data.Model;
using GameDev.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameDev.Web.Api
{
    public class CompanyController : ApiController
    {
        private readonly ICompanyData db;

        public CompanyController(ICompanyData db)
        {
            this.db = db;
        }
        public IEnumerable<Company> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
