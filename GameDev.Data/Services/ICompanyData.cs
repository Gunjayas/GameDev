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
    }
}
