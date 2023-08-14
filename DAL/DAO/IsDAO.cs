using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
	public class IsDAO : PersonelDataContext
	{
		public static List<ISDURUM> DurumGetir()
		{
			return db.ISDURUMs.ToList();
		}

		public static void IsEkle(I iss)
		{
			try
			{
				db.Is.InsertOnSubmit(iss);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static List<IsDetayDTO> IsGetir()
		{
			List<IsDetayDTO> liste = new List<IsDetayDTO>();
			var list  =(from i in db.Is
						join p in db.PERSONELs on i.PersonelID equals p.ID
						join d in db.DEPARTMANs on p.DepartmanID equals d.ID
						join pz in db.POZISYONs on p.PozisyonID equals pz.ID
						join durum in db.ISDURUMs on i.IsDurumID equals durum.ID
						select new
						{
							isID=i.ID,
							baslik = i.Baslik,
							icerik = i.Icerik,
							baslamaTarihi = i.IsBaslamaTarihi,
							bitisTarihi = i.IsBitisTarihi,
							userno = p.UserNo,
							ad=p.Ad,
							soyad=p.Soyad,
							personelID = i.PersonelID,
							departman = d.DepartmanAd,
							pozisyon = pz.PozisyonAd,
							departmanID = p.DepartmanID,
							pozisyonID = p.PozisyonID,
							IsDurum = durum.IsDurumAd,
							IsDurumID = i.IsDurumID

						}).OrderBy(x=> x.baslamaTarihi).ToList();

			foreach (var item in list)
			{
				IsDetayDTO dto = new IsDetayDTO();
				dto.IsID = item.isID;
				dto.Baslik = item.baslik;
				dto.Icerik = item.icerik;
				dto.IsBaslama = item.baslamaTarihi;
				dto.IsBitis = item.bitisTarihi;
				dto.KullaniciNo = item.userno;
				dto.PersonelAd = item.ad;
				dto.PersonelSoyad = item.soyad;
				dto.DepartmanAd = item.departman;
				dto.PozisyonAd = item.pozisyon;
				dto.DepartmanID	= item.departmanID;
				dto.PozisyonID = item.pozisyonID;
				dto.IsDurumAd = item.IsDurum;
				dto.IsDurumID = item.IsDurumID;
				dto.PersonelId = item.personelID;
				liste.Add(dto);
			}
			return liste;
		}

		public static void IsGüncelle(IsDetayDTO dto)
		{
			try
			{
				I iss = db.Is.First(x=>x.ID==dto.IsID);
				iss.Baslik = dto.Baslik; 
				iss.Icerik = dto.Icerik;
				iss.PersonelID = dto.PersonelId;
				iss.IsDurumID =dto.IsDurumID;
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static void IsGüncelle(int isid)
		{
			I iss = db.Is.First(x=>x.ID == isid);
			if (UserStatic.Admin)
			{
				iss.IsDurumID = OnayStatic.Onaylandı;
			}
			else
			{
				iss.IsDurumID = OnayStatic.Tamamlandı;
			}
			db.SubmitChanges();
		}

		public static void Sil(int isID)
		{
			try
			{
				I iss = db.Is.First(x => x.ID == isID);
				db.Is.DeleteOnSubmit(iss);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
