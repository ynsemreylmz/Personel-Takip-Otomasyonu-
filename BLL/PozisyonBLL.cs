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
	public class PozisyonBLL
	{
		public static void PozisyonEkle(POZISYON pzs)
		{
			PozisyonDAO.DepartmanEkle(pzs);
		}

		public static List<PozisyonDTO> PozisyonGetir()
		{
			return PozisyonDAO.PozisyonGetir();
		}

		public static void PozisyonGüncelle(PozisyonDetayDTO detay, bool control)
		{
			PozisyonDAO.PozisyonGüncelle(detay);
			if(control)
			{
				PersonelDAO.PersonelGüncelle(detay);	
			}
		}

		public static void Sil(int id)
		{
			PozisyonDAO.Sil(id);
		}
	}
}
