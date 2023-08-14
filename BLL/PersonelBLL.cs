using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class PersonelBLL
	{
		public static PersonelDTO GetAll()
		{
			PersonelDTO dto = new PersonelDTO();
			dto.Departmanlar = DepartmanDAO.DepartmanGetir();
			dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
			dto.Personeller = PersonelDAO.PersonelGetir();
			
			return dto;
		}

		public static bool IsUnique(int v)
		{
			List<PERSONEL> list = PersonelDAO.PersonelGetir(v);
			if(list.Count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
			
		}

		public static void PersonelEkle(PERSONEL pr)
		{
			PersonelDAO.PersonelEkle(pr);
		}

		public static List<PERSONEL> PersonelGetir(int v, string text)
		{
			return PersonelDAO.PersonelGetir(v,text);
		}

		public static void PersonelGüncelle(PersonelDetayDTO pr)
		{
			PersonelDAO.PersonelGüncelle(pr);
		}

		public static void Sil(int personelId)
		{
			PersonelDAO.Sil(personelId);
		}
	}
}
