using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class WonkaBar : CandyItem
    {
        public override double Cost => 1.25;
        public override string Name => "Wonka Bar";
        public override string Slot => "A1";
    }
}
