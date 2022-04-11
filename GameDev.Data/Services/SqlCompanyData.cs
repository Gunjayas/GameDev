using GameDev.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Data.Services
{
    public class SqlCompanyData : ICompanyData
    {
        private readonly GameDevDbContext db;

        public SqlCompanyData(GameDevDbContext db)
        {
            this.db = db;
        }
        public void Add(Company company)
        {
            db.Companies.Add(company);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var company = db.Companies.Find(id);
            db.Companies.Remove(company);
            db.SaveChanges();
        }

        public Company Get(int id)
        {
            return db.Companies.FirstOrDefault(r => r.Id ==id);
        }

        public IEnumerable<Company> GetAll()
        {
            return from r in db.Companies
                   orderby r.Name
                   select r;
        }

        public void Update(Company company)
        {
            var entry = db.Entry(company);
            entry.State = EntityState.Modified;
            db.SaveChanges();

        }
    }
}
