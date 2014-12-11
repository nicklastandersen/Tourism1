using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using TuristApp5.Model;

namespace TuristApp5.ViewModel
{
    class Common
    {
        private Common()
        {
            kategorier = new ObservableCollection<Kategori>();
        }

        public void Addkategori(Kategori kategori)
        {
            kategorier.Add(kategori);
        }

        

        private static Common _instance=new Common();

        public static Common Instance
        {
            get { return _instance; }
        }

        private ObservableCollection<Kategori> kategorier;


        private static Kategori _SelectedKategori;

        public static Kategori SelectedKategori { get; set; }
    }
}
