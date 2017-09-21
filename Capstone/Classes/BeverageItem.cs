using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
   public class BeverageItem : ItemGeneral
    {

        //public override decimal Cost => this.Cost;
        //public override string Name => this.Name;
        public override string Consume()
        {
            return "Glug Glug, Yum!";
        }

        public BeverageItem (string name, decimal cost) : base(name, cost)
        {
          
        }

       
    }
}
