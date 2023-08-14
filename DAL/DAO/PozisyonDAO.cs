using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
	public class PozisyonDAO : PersonelDataContext
	{
		public static void DepartmanEkle(POZISYON pzs)
		{
			try
			{
				db.POZISYONs.InsertOnSubmit(pzs);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static List<PozisyonDTO> PozisyonGetir()
		{
			try
			{
				var list = (from p in db.POZISYONs
							join d in db.DEPARTMANs on p.DepartmanID equals d.ID
							select new
							{
								pozisyonID = p.ID,
								pozisyonAd = p.PozisyonAd,
								departmanID = p.DepartmanID,
								departmanAd = d.DepartmanAd
							}
							).OrderBy(x => x.pozisyonID).ToList();
				List<PozisyonDTO> liste = new List<PozisyonDTO>();	
				foreach ( var item in list)
				{
					PozisyonDTO pzsDto = new PozisyonDTO();
					pzsDto.ID = item.pozisyonID;
					pzsDto.PozisyonAd = item.pozisyonAd;
					pzsDto.DepartmanID = item.departmanID;
					pzsDto.DepartmanAd = item.departmanAd;
					
					liste.Add(pzsDto);



					
				}
				return liste;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static void PozisyonGüncelle(PozisyonDetayDTO detay)
		{
			POZISYON pz = db.POZISYONs.First(x=>x.ID== detay.ID);
			pz.PozisyonAd = detay.PozisyonAd;
			pz.DepartmanID = detay.DepartmanId;
			db.SubmitChanges();
		}

		public static void Sil(int id)
		{
			try
			{
				POZISYON pz = db.POZISYONs.First(x => x.ID == id);
				db.POZISYONs.DeleteOnSubmit(pz);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
