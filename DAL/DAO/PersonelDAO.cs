using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
	public class PersonelDAO : PersonelDataContext
	{
		public static void PersonelEkle(PERSONEL pr)
		{
			try
			{
				db.PERSONELs.InsertOnSubmit(pr);
				db.SubmitChanges();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public static List<PERSONEL> PersonelGetir(int v)
		{
			return db.PERSONELs.Where(x=>x.UserNo == v).ToList();
		}
		public static List<PERSONEL> PersonelGetir(int v,string text)
		{
			return db.PERSONELs.Where(x => x.UserNo == v && x.Sifre == text).ToList();
		}
		public static List<PersonelDetayDTO> PersonelGetir()
		{
			List<PersonelDetayDTO> liste = new List<PersonelDetayDTO>();
			var list = (from p in db.PERSONELs
						join d in db.DEPARTMANs on p.DepartmanID equals d.ID
						join pz in db.POZISYONs on p.PozisyonID equals pz.ID
						select new
						{
							personelID = p.ID,
							ad = p.Ad,
							soyad = p.Soyad,
							sifre = p.Sifre,
							departman = d.DepartmanAd,
							pozisyon = pz.PozisyonAd,
							departmanID=d.ID,
							pozisyonID=p.PozisyonID,
							admin = p.Admin,
							maas = p.Maas,
							fotograf = p.Resim,
							dogumTarihi = p.DogumGunu,
							adres = p.Adres,
							kullaniciNo = p.UserNo,

						}).OrderBy(x=>x.personelID).ToList();
			foreach (var item in list)
			{
				PersonelDetayDTO dto = new PersonelDetayDTO();
				dto.PersonelId = item.personelID;
				dto.PersonelAd = item.ad;
				dto.PersonelSoyad = item.soyad;
				dto.Sifre = item.sifre;
				dto.DepartmanAd = item.departman;
				dto.PozisyonAd = item.pozisyon;
				dto.DepartmanAd = item.departman;
				dto.DepartmanID = item.departmanID;
				dto.PozisyonAd = item.pozisyon;
				dto.PozisyonID = item.pozisyonID;
				dto.Admin = item.admin;
				dto.Maas = item.maas;
				dto.Fotograf  = item.fotograf;
				dto.DogumTarihi = item.dogumTarihi;
				dto.Adres = item.adres;
				dto.KullaniciNo = item.kullaniciNo;
				liste.Add(dto);
			}
			return liste;
		}

		public static void PersonelGüncelle(PersonelDetayDTO pr)
		{
			try
			{
				PERSONEL per = db.PERSONELs.First(x => x.ID == pr.PersonelId);

				per.ID = pr.PersonelId;
				per.UserNo = pr.KullaniciNo;
				per.Ad = pr.PersonelAd;
				per.Soyad = pr.PersonelSoyad;
				per.Adres = pr.Adres;
				per.DepartmanID = pr.DepartmanID;
				per.PozisyonID = pr.PozisyonID;
				per.DogumGunu = pr.DogumTarihi;
				per.Admin = pr.Admin;
				per.Maas = pr.Maas;
				per.Sifre = pr.Sifre;
				per.Resim = pr.Fotograf;
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static void PersonelGüncelle(PozisyonDetayDTO detay)
		{
			List<PERSONEL> list = db.PERSONELs.Where(x => x.PozisyonID == detay.ID).ToList();
			foreach (var item in list) 
			{
				item.DepartmanID = detay.DepartmanId;

			}
			db.SubmitChanges();
		}

		public static void PersonelMaasGüncelle(MaasDetayDTO maas)
		{
			try
			{
				PERSONEL pr = db.PERSONELs.First(x=>x.ID == maas.PersonelId);
				pr.Maas = maas.MaasMiktar;
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static void Sil(int personelId)
		{
			try
			{
				

				PERSONEL per = db.PERSONELs.First(x => x.ID == personelId);
				db.PERSONELs.DeleteOnSubmit(per);
				db.SubmitChanges();
			
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
