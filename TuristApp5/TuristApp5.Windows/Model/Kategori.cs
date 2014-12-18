using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristApp5.Model
{
    public class Kategori : INotifyCollectionChanged
    {
        private string _navn;
        private string _billede;
        private List<BeskrivelseModel> _beskrivelse; 
       
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
            _beskrivelse = new List<BeskrivelseModel>();
        }




        public List<BeskrivelseModel> Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public Kategori()
        {
            _beskrivelse = new List<BeskrivelseModel>();
        }
        

        public override string ToString()
        {
            return _navn;
        }

        #region 

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        #endregion

    }

}
