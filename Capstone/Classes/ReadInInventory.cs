using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    class ReadInInventory
    {
        private string filePath;
        private int Cost;
        private int InitialQuantity;
        private int Product;
        private int Slotld;

        public ReadInInventory (string filePath)
        {
            this.filePath = filePath;
        }

    }
}
