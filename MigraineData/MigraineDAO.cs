using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigraineData
{
    public class MigraineDAO : IMigraineDAO
    {        
        public void registerMigraine(migraine migraine)
        {
            var transaction = DBM.getInstance().Database.BeginTransaction();
            migraine.date = DateTime.Now;
            //DateTime.ParseExact(Fn,
            //                            "dd-MM-yyyy",
            //                            CultureInfo.CreateSpecificCulture("es-Es"));
            DBM.getInstance().migraine.Add(migraine);
            //DBM.getInstance().Entry(migraine).State = EntityState.Added;
            DBM.save(transaction);
        }

        public List<migraine> getMigraines()
        {
            return DBM.getInstance().migraine.Select(x => x).ToList();
        }
    }
}
