using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
	public class PozisyonDetayDTO
	{
        public int ID { get; set; }
        public int DepartmanId { get; set; }
        public int EskiDepartmanId { get; set; }
        public string PozisyonAd { get; set; }
    }
}
