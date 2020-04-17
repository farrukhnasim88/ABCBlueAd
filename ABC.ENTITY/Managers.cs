using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.ENTITY
{
    public class Managers
    {

        private int managerID;
        private string managerFN;
        private string managerLN;
        private string managerPhone;

       
        public string ManagerFN { get => managerFN; set => managerFN = value; }
        public string ManagerLN { get => managerLN; set => managerLN = value; }
        public string ManagerPhone { get => managerPhone; set => managerPhone = value; }
        public int ManagerID { get => managerID; set => managerID = value; }



    }
}
