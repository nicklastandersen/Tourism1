using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using TuristApp5.Annotations;
using TuristApp5.Model;

namespace TuristApp5.ViewModel
{
    class MainViewModel :INotifyPropertyChanged
    {
        private Common _common = Common.Instance;

        public Common Common
        {
            get { return _common; }
            set { _common = value; }
        }



        private Kategori oplevroskilde = new Kategori("Oplev Roskilde", "ms-appx:///assets/roskilde.png");
        private Kategori sovgodt = new Kategori("Sov Godt", "ms-appx:///assets/sovgodt.png");
        private Kategori spisgodt = new Kategori("Spis Godt", "ms-appx:///assets/spisgodt.png");
        private Kategori turforslag = new Kategori("Tur Forslag", "ms-appx:///assets/turforslag.png");
        private Kategori goorange = new Kategori("GO ORANGE", "ms-appx:///assets/goorange.png");
        private Kategori transport = new Kategori("Transport", "ms-appx:///assets/transport.png");


        public Kategori Oplevroskilde
        {
            get { return oplevroskilde; }
            set { oplevroskilde = value; }
        }

        public Kategori Sovgodt
        {
            get { return sovgodt; }
            set { sovgodt = value; }
        }

        public Kategori Spisgodt
        {
            get { return spisgodt; }
            set { spisgodt = value; }
        }

        public Kategori Turforslag
        {
            get { return turforslag; }
            set { turforslag = value; }
        }

        public Kategori Goorange
        {
            get { return goorange; }
            set { goorange = value; }
        }

        public Kategori Transport
        {
            get { return transport; }
            set { transport = value; }
        }


        public MainViewModel()
        {
            Transport = Common.Instance.Kategori[5];

        }





        #region 

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
