using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.ENTITY
{
    public class Adverts
    {

        public int adID;
        public string adTitle;
        public int adCost;
        public DateTime startDate;
        public DateTime endDate;
        public int frequency;
        //private int BrandID;

        public int AdID { get => adID; set => adID = value; }
        public string AdTitle { get => adTitle; set => adTitle = value; }
        public int AdCost { get => adCost; set => adCost = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int Frequency { get => frequency; set => frequency = value; }
        public int BrandID { get => BrandID; set => BrandID = value; }
    }
}
