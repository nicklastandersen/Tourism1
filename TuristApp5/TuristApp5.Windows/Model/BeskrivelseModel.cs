using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TuristApp5.Annotations;

namespace TuristApp5.Model
{
    public class BeskrivelseModel : INotifyPropertyChanged
    {
        private string _navn1;
        private string _beskrivelse1;
        private string _telefon;
        private string _hjemmeside;
        private string _aabningstider;
        private string _billed1;
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

        public string Billed1
        {
            get { return _billed1; }
            set { _billed1 = value; }
        }
        public override string ToString()
        {
            return Navn1.ToString();
        }

        #region 

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

}
