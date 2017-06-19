using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigraineData
{
    public class DBM
    {
        private static MigraineDBEntities migraineContext;// = new MigraineDBEntities();
        private DBM()
        {
        }

        public static MigraineDBEntities getInstance()
        {
            if (migraineContext == null)
            {
                migraineContext = new MigraineDBEntities();
            }
            return migraineContext;
        }

        public static DbContextTransaction beginTransaction()
        {
            return getInstance().Database.BeginTransaction();
        }
        
        
        public static void save(DbContextTransaction transaction)
        {
            try
            {
                migraineContext.SaveChanges();
                transaction.Commit();
            }
            catch(Exception ex)
            {
                transaction.Rollback();
                transaction.Dispose();
                throw;
            }            
        }


    }
}
