using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
	public class IsDetayDTO
	{
		public string Baslik { get; set; }
		public int KullaniciNo { get; set; }
		public string PersonelAd { get; set; }
		public string PersonelSoyad { get; set; }
		public string DepartmanAd { get; set; }
		public string PozisyonAd { get; set; }
		public int DepartmanID { get; set; }
		public int PozisyonID { get; set; }
		public string Icerik { get; set; }
        public string IsDurumAd { get; set; }
        public int IsDurumID { get; set; }
		public DateTime IsBaslama { get; set; }
		public DateTime IsBitis { get; set; }
        public int IsID { get; set; }
		public int PersonelId { get; set; }

	}
}
