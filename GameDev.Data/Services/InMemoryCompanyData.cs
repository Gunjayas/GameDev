/*using GameDev.Data.Model;
using System; //It will perform services that simulate data access
using System.Collections.Generic;
using System.Linq;

namespace GameDev.Data.Services
{
    public class InMemoryCompanyData : ICompanyData
    {
        List<Company> companies; //it's like declaring a array

        public InMemoryCompanyData()
        {
            companies = new List<Company>() //filling the list
            {//populating that list
             new Company {Id=1,Name="Blizzard",Genre=GenreType.Rpg},
             new Company {Id=2,Name="EA",Genre=GenreType.Sports},
             new Company {Id=3,Name="Bandai Namco",Genre=GenreType.None}

            };
        }
        public void Add(Company company)
        {
            companies.Add(company);
            company.Id = companies.Max(r => r.Id) + 1 ;
        }

        public void Update(Company company)
        {
            var existing = Get(company.Id);
            if (existing != null) 
            {
                existing.Name = company.Name;
                existing.Genre = company.Genre;
            }
        }
        public Company Get(int id)
        {
            return companies.FirstOrDefault(r => r.Id == id);
        }
        

        public IEnumerable<Company> GetAll()
        {   //orderby is list method or arraymethod
            return companies.OrderBy(r => r.Name);        //it's enumerable so it's gonna loop one by one 
            
        }

        public void Delete(int id)
        {
            var company = Get(id);
            if (company != null)
            {
                companies.Remove(company);
            }
        }
    }
}
*/