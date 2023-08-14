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
	public class IsBLL
	{
		public static IsDTO GetAll()
		{	
			IsDTO dto = new IsDTO();
			
			dto.Departmanlar = DepartmanDAO.DepartmanGetir();
			dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
			dto.Personeller = PersonelDAO.PersonelGetir();
			dto.Durumlar = IsDAO.DurumGetir();
			if (UserStatic.Admin)
			{
				dto.Isler = IsDAO.IsGetir();

			}
			else
			{
				dto.Isler = IsDAO.IsGetir().Where(x => x.PersonelId == UserStatic.PersonelId).ToList();
			}




		
			
			return dto;
			
			
			
		}

		public static void IsEkle(I iss)
		{
			IsDAO.IsEkle(iss);
		}

		public static void IsGüncelle(IsDetayDTO dto)
		{
			IsDAO.IsGüncelle(dto);
		}

		public static void IsGüncelle(int isid)
		{
			IsDAO.IsGüncelle(isid);
		}

		public static void Sil(int isID)
		{
			IsDAO.Sil(isID);
		}
	}
}
