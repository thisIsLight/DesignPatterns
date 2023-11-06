using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class SavingData
    {
        public static void SaveToFile(Journal myJournal)
        {
            File.WriteAllText("My Journal", myJournal.ToString());
        }
    }
}
