using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApiCrecheRepository.Models.Repositories
{
    public class CrecheRepository : ICrecheRepository
    {
        private CrecheDBContext db = null;

        public CrecheRepository()
        {
            this.db = new CrecheDBContext();
        }

        public CrecheRepository(CrecheDBContext db)
        {
            this.db = db;
        }

        public IEnumerable<Creche> SelectAll()
        {
            return db.Creches.OrderBy(a => a.ChildName).ToList();
        }

        public Creche SelectByID(int id)
        {
            return db.Creches.Find(id);
        }

        public void Insert(Creche obj)
        {
            db.Creches.Add(obj);
        }

        public void Update(Creche obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Creche existing = db.Creches.Find(id);
            db.Creches.Remove(existing);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

}
