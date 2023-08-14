using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
	public class MaasDAO : PersonelDataContext
	{
		public static List<AYLAR> GetAylar()
		{
			return db.AYLARs.ToList();
		}

		public static void MaasEkle(MAA maas)
		{
			try
			{
				db.MAAs.InsertOnSubmit(maas);
				db.SubmitChanges();

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static List<MaasDetayDTO> MaasGetir()
		{
			List<MaasDetayDTO> liste = new List<MaasDetayDTO>();
			var list =(from m in db.MAAs
					   join p in db.PERSONELs on m.PersonelID equals p.ID
					   join ay in db.AYLARs on m.AyID equals ay.ID
					   select new
					   {
						   userno=p.UserNo,
						   ad=p.Ad,
						   soyad=p.Soyad,
						   maasmiktar =m.Miktar,
						   maasyil = m.Yıl,
						   maasay=ay.Ay,
						   eskimaas=m.Miktar,
						   maasID=m.ID,
						   personelID = p.ID,
						   departmanID =p.DepartmanID,
						   pozisyonID =p.PozisyonID,
						   maasAyID = m.AyID
					   }).OrderBy(x=> x.maasyil).ToList();
			foreach (var item in list)
			{
				MaasDetayDTO dto = new MaasDetayDTO();
				dto.KullaniciNo = item.userno;
				dto.PersonelAd = item.ad;
				dto.PersonelSoyad = item.soyad;
				dto.MaasMiktar = item.maasmiktar;
				dto.MaasYıl = item.maasyil;
				dto.MaasAy = item.maasay;
				dto.MaasID = item.maasID;
				dto.PersonelId = item.personelID;
				dto.DepartmanID = item.departmanID;
				dto.PozisyonID = item.pozisyonID;
				dto.MaasAyID = item.maasAyID;
				dto.EskiMaas = item.eskimaas;
				liste.Add(dto);
			}
			return liste;

		}

		public static void MaasGuncelle(MaasDetayDTO maas)
		{

			try
			{
				MAA m = db.MAAs.First(x => x.ID == maas.MaasID);
				m.AyID = maas.MaasAyID;
				m.Miktar = maas.MaasMiktar;
				m.Yıl = maas.MaasYıl;
				
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static void Sil(int maasID)
		{
			try
			{
				MAA maas = db.MAAs.First(x=>x.ID == maasID);
				db.MAAs.DeleteOnSubmit(maas);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
