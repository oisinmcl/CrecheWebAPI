using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCrecheRepository.Models.Repositories
{
    public interface ICrecheRepository
    {
        IEnumerable<Creche> SelectAll();
        Creche SelectByID(int id);
        void Insert(Creche obj);
        void Update(Creche obj);
        void Delete(int id);
        void Save();

    }
}
