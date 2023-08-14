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
	public class MaasBLL
	{
		public static MaasDTO GetAll()
		{
			MaasDTO dto = new MaasDTO();
			dto.Departmanlar = DepartmanDAO.DepartmanGetir();
			dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
			dto.Personeller = PersonelDAO.PersonelGetir();
			dto.Aylar = MaasDAO.GetAylar();
			

			if (UserStatic.Admin)
			{
				dto.Maaslar = MaasDAO.MaasGetir();

			}
			else
			{
				dto.Maaslar = MaasDAO.MaasGetir().Where(x => x.PersonelId == UserStatic.PersonelId).ToList();
			}
			return dto;
		}

		public static void MaasEkle(MAA maas,bool control)
		{
			MaasDAO.MaasEkle(maas);
			if (control)
			{	
				MaasDetayDTO dto = new MaasDetayDTO();
				dto.PersonelId = maas.PersonelID;
				dto.MaasMiktar = maas.Miktar; 
				PersonelDAO.PersonelMaasGüncelle(dto);
			}
		}

		public static void MaasGüncelle(MaasDetayDTO maas, bool control)
		{
			MaasDAO.MaasGuncelle(maas);
			if(control)
			{
				PersonelDAO.PersonelMaasGüncelle(maas);
			}
		}

		public static void Sil(int maasID)
		{
			MaasDAO.Sil(maasID);
		}
	}
}
