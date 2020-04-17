using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.ENTITY
{
    public class Brands
    {

        public int brandID;
        public string brandName;
        public int clientID;
        public int managerID;


        public int BrandID { get => brandID; set => brandID = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int ManagerID { get => managerID; set => managerID = value; }
    }
}
