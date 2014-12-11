using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristApp5.Model;

namespace TuristApp5.ViewModel
{
    class Common
    {
        private Common()
        {

        }

        private static Common _instance=new Common();

        public static Common Instance
        {
            get { return _instance; }
        }

        private static Kategori _SelectedKategori;

        public static Kategori SelectedKategori { get; set; }
    }
}
