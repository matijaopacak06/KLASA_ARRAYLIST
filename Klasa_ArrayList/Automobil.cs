using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_ArrayList
{
    internal class Automobil
    {
        private string marka;

        public Automobil(string m)
        {
            this.marka = m;
        }

        public string DajMarku()
        {
            return marka;
        }
    }
}
