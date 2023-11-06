using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.OldFlow
{
    public class LowLevelService
    {
        public void CalledService()
        {
            Console.WriteLine("Low level Service responded !");
        }
    }
}
