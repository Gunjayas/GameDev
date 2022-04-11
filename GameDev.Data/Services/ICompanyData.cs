using GameDev.Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev.Data.Services
{
    public interface ICompanyData
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
        void Add(Company company);
        void Update(Company company);
        void Delete(int id);
    }
    
}
