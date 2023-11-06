using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Journal
    {
        #region Private properties
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        #endregion

        #region Private methods
        public void AddEntry(string entry)
        {
            entries.Add(entry);
            count++;
        }
        public void RemoveEntry(int index) {
            entries.RemoveAt(index);
            count--;
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
        #endregion

    }
}
