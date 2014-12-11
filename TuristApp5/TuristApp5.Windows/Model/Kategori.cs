using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristApp5.Model
{
    class Kategori
    {
        private string _navn;
        private string _billede;
       
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Billede
        {
            get { return _billede; }
            set { _billede = value; }
        }

        public Kategori(string navn, string billede)
        {
            _navn = navn;
            _billede = billede;
        }


        public override string ToString()
        {
            return _navn;
        }
    }
}
