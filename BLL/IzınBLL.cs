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
	public class IzınBLL
	{
		public static IzınDTO GetAll()
		{
			IzınDTO dto = new IzınDTO();
			dto.Departmanlar = DepartmanDAO.DepartmanGetir();
			dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
			dto.IzinDurumlar = IzınDAO.DurumGetir();
			dto.Izinler = IzınDAO.IzinGetir();

			if (UserStatic.Admin)
			{
				dto.Izinler = IzınDAO.IzinGetir();

			}
			else
			{
				dto.Izinler = IzınDAO.IzinGetir().Where(x => x.PersonelId == UserStatic.PersonelId).ToList();
			}
			return dto;
		}

		public static void IzınEkle(IZIN iz)
		{
			IzınDAO.IzınEkle(iz);
		}

		public static void IzınGüncelle(IzınDetayDTO detaydto)
		{
			IzınDAO.IzinGüncelle(detaydto);
		}
		public static void IzınGüncelle(int izinID, int onay)
		{
			IzınDAO.IzinGüncelle(izinID, onay);
		}

		public static void Sil(int izinID)
		{
			IzınDAO.Sil(izinID);
		}
	}
}
