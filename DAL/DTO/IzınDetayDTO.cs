using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
	public class IzınDetayDTO
	{
		public int PersonelId { get; set; }
		public int KullaniciNo { get; set; }
		public string PersonelAd { get; set; }
		public string PersonelSoyad { get; set; }
		public string DepartmanAd { get; set; }
		public string PozisyonAd { get; set; }
		public int DepartmanID { get; set; }
		public int PozisyonID { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string Aciklama { get; set; }
        public int Süre { get; set; }
        public string IzinDurumAd { get; set; }
        public int IzınDurumID { get; set; }
        public int IzinID { get; set; }
    }
}
