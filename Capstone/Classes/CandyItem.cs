using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class CandyItem
    {
        //private string name;
        //private string slot;

        public virtual double Cost
        {
            get { return 0; }
        }

        public virtual string Slot
        {
            get { return ""; }
        }


        public virtual string Name
        {
            get { return ""; }

        }



    }
}
