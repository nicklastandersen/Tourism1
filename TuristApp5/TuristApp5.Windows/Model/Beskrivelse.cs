using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristApp5.Model
{
    class Beskrivelse
    {
        private string _navn1;
        private string _beskrivelse1;
        private string _telefon;
        private string _hjemmeside;
        private string _aabningstider;

        public string Navn1
        {
            get { return _navn1; }
            set { _navn1 = value; }
        }

        public string Beskrivelse1
        {
            get { return _beskrivelse1; }
            set { _beskrivelse1 = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Hjemmeside
        {
            get { return _hjemmeside; }
            set { _hjemmeside = value; }
        }

        public string Aabningstider
        {
            get { return _aabningstider; }
            set { _aabningstider = value; }
        }


        public Beskrivelse(string navn1, string telefon, string beskrivelse1, string hjemmeside, string aabningstider)
        {
            _navn1 = navn1;
            _telefon = telefon;
            _beskrivelse1 = beskrivelse1;
            _hjemmeside = hjemmeside;
            _aabningstider = aabningstider;
        }




    }
}
