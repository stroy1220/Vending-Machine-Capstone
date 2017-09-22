using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
   public class InvalidSlotSelectionException : VendingMachineException
    {
       
        public string Invalid()
        {
            return "Selection does not exist";
        }
        //while selection is within range; proceed with transaction
        //if not in range ; return error/menu

    }
}
