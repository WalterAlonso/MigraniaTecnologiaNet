using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigraineData
{
    public interface IMigraineDAO
    {
        void registerMigraine(migraine migraine);

        List<migraine> getMigraines();
    }
}
