using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
	public class IzınDAO : PersonelDataContext
	{
		
		public static List<IZINDURUM> DurumGetir()
		{
			return db.IZINDURUMs.ToList();
		}
		public static void IzınEkle(IZIN iz)
		{
			try
			{
				db.IZINs.InsertOnSubmit(iz);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static List<IzınDetayDTO> IzinGetir()
		{
			List<IzınDetayDTO> liste = new List<IzınDetayDTO>();
			var list = (from i in db.IZINs
						join p in db.PERSONELs on i.PersonelID equals p.ID
						join d in db.IZINDURUMs on i.IzinDurumID equals d.ID
						select new
						{
							userNo = p.UserNo,
							ad = p.Ad,
							soyad = p.Soyad,
							durumad = d.IzinDurumAd,
							durumID = i.IzinDurumID,
							baslamaTarihi = i.IzinBaslamaTarihi,
							bitisTarihi = i.IzinBitisTarihi,
							personelID = i.PersonelID,
							izinID = i.ID,
							aciklama = i.Aciklama,
							sure = i.Sure,
							departmanID = p.DepartmanID,
							pozisyonId = p.PozisyonID,

						}).OrderBy(x=>x.baslamaTarihi).ToList();
			foreach (var item in list)
			{
				IzınDetayDTO dto = new IzınDetayDTO();
				dto.PersonelAd = item.ad;
				dto.BaslamaTarihi = item.baslamaTarihi;
				dto.BitisTarihi = item.bitisTarihi;
				dto.KullaniciNo = item.userNo;
				dto.PersonelAd = item.ad;
				dto.PersonelSoyad = item.soyad;
				dto.Aciklama = item.aciklama;
				dto.IzinDurumAd = item.durumad;
				dto.IzınDurumID = item.durumID;
				dto.IzinID = item.izinID;
				dto.Süre = item.sure;
				dto.DepartmanID = item.departmanID;
				dto.PozisyonID = item.pozisyonId;
				liste.Add(dto);


			}

			return liste;
		}

		public static void IzinGüncelle(IzınDetayDTO detaydto)
		{
			try
			{
				IZIN iz = db.IZINs.First(x=>x.ID == detaydto.IzinID);
				iz.Aciklama = detaydto.Aciklama;
				iz.IzinBaslamaTarihi = detaydto.BaslamaTarihi;
				iz.IzinBitisTarihi = detaydto.BitisTarihi;
				iz.Sure = detaydto.Süre;
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static void IzinGüncelle(int izinID, int onay)
		{

			try
			{
				IZIN iz = db.IZINs.First(x => x.ID == izinID);
				iz.IzinDurumID = onay;
				
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static void Sil(int izinID)
		{
			try
			{
				IZIN iz = db.IZINs.First(x => x.ID == izinID);
				db.IZINs.DeleteOnSubmit(iz);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
