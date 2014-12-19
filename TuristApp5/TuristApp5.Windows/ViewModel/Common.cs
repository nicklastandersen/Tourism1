using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TuristApp5.Annotations;
using TuristApp5.Model;
using TuristApp5.View;

namespace TuristApp5.ViewModel
{
    class Common : INotifyPropertyChanged
    {
        private static Common instance;
        private ObservableCollection<Kategori> _kategori;
        private ObservableCollection<BeskrivelseModel> _beskrivelse;
        private Kategori _selectedKategori;
        private BeskrivelseModel _selectedBeskrivelse;


        public ObservableCollection<Kategori> Kategori
        {
            get { return _kategori; }
            set { _kategori = value; }
        }
        public ObservableCollection<BeskrivelseModel> Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public Kategori SelectedKategori
        {
            get { return _selectedKategori; }
            set { _selectedKategori = value; OnPropertyChanged("SelectedKategori");
                ((Frame)Window.Current.Content).Navigate(typeof(Underkategori));
            }
        }

        public BeskrivelseModel SelectedBeskrivelse
        {
            get { return _selectedBeskrivelse; }
            set { _selectedBeskrivelse = value; }
        }


        private Common()
        {

            //Kategori

         _kategori = new ObservableCollection<Kategori>();
         Kategori oplevroskilde = new Kategori("Oplev Roskilde", "ms-appx:///assets/roskilde.png");
         Kategori sovgodt = new Kategori("Sov Godt", "ms-appx:///assets/sovgodtpng");
         Kategori spisgodt = new Kategori("Spis Godt", "ms-appx:///assets/spisgodt.png");
         Kategori turforslag = new Kategori("Tur Forslag", "ms-appx:///assets/turforslag.png");
         Kategori goorange = new Kategori("GO ORANGE", "ms-appx:///assets/goorange.png");
         Kategori transport = new Kategori("Transport", "ms-appx:///assets/transport.png");
            _kategori.Add(oplevroskilde);
            _kategori.Add(sovgodt);
            _kategori.Add(spisgodt);
            _kategori.Add(turforslag);
            _kategori.Add(goorange);
            _kategori.Add(transport);


            //Beskrivelse - Underkategori

           _beskrivelse = new ObservableCollection<BeskrivelseModel>();


           BeskrivelseModel oplevroskilde1 = new BeskrivelseModel() { Navn1 = "Vikingeskibsmuseet", Billed1 = "ms-appx:///assets/Vikingeskibsmuseet.JPG", Beskrivelse1 = "Vikingeskibsmuseet er et museum i Roskilde. Museets tema er skibe, søfart og bådebygningskultur fra Vikingetiden. I mange årtier før udgravningen af skibene, som blev påbegyndt i 1962, kendte de lokale fiskere på Roskilde Fjord til et gammelt skib på bunden af fjorden. Skibet kaldte de for Margreteskibet, da de mente, at det stammede tilbage fra Margrete 1.'s tid. Det skulle senere vise sig, at der var mange flere skibe, og at de var endnu ældre. Men allerede i 1920'erne blev der fjernet sten og trædele fra skibene, blandt andet et kølsvin og de blev fotograferet. Kølsvinet endte sine dage i en brændeovn en kold vinterdag under 2. verdenskrig.", Hjemmeside = "http://www.vikingeskibsmuseet.dk/" };
            Kategori[0].Beskrivelse.Add(oplevroskilde1);

            BeskrivelseModel oplevroskilde2 = new BeskrivelseModel() { Navn1 = "Roskilde Domkirke", Billed1 = "ms-appx:///assets/roskildedomkirke.JPG", Beskrivelse1 = "Roskilde Domkirke har været kongefamiliens gravkirke gennem århundreder og er optaget på UNESCO's liste over verdens umistelige kulturarv.", Hjemmeside = "http://www.roskildedomkirke.dk/" };
            Kategori[0].Beskrivelse.Add(oplevroskilde2);



            BeskrivelseModel sovgodt1 = new BeskrivelseModel() {Navn1 = "Hotel Roskilde"};
            Kategori[1].Beskrivelse.Add(sovgodt1);

         


            BeskrivelseModel spisgodt1 = new BeskrivelseModel() {Navn1 = "Jensens Bøfhus"};
            Kategori[2].Beskrivelse.Add(spisgodt1);

            BeskrivelseModel turforslag1 = new BeskrivelseModel() {Navn1 = "Cykeltur i skoven"};
            Kategori[3].Beskrivelse.Add(turforslag1);

            BeskrivelseModel goorange1 = new BeskrivelseModel() {Navn1 = "Oplev Gimle & Go Orange"};
            Kategori[4].Beskrivelse.Add(goorange1);

            BeskrivelseModel transport1 = new BeskrivelseModel() {Navn1 = "Lokalbus"};
            Kategori[5].Beskrivelse.Add(transport1);


      

        }

        public static Common Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Common();
                }
                return instance;
            }
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
