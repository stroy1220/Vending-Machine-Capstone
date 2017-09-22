using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
   public class VendingMachine 
    {

        private decimal currentBalance;
        private Dictionary<string, List<ItemGeneral>>inventory;
        private ReadInInventory inventorysource;
        //private TransactionFileLog transactionLogger;

        public decimal CurrentBalance
        {
            get { return this.currentBalance; }
        }
        public string [] Slots
        {
            get {return inventory.Keys.ToArray() ; }
        }

        public void FeedMoney(int dollars)
        {
            this.currentBalance = Convert.ToDecimal(dollars);
        }
        public ItemGeneral GetItemAtSlot (string slotID)
        {
            List<ItemGeneral> list = inventory[slotID];
            return list[0];
        }
        public VendingMachine()
        {
            inventorysource = new ReadInInventory ("vendingmachine.csv");
            inventory = inventorysource.GetInventory();
        }
        public VendingMachine(Dictionary<string, List<ItemGeneral>> inventory)
        {
            this.inventory = inventory;
        }

        

    }
}
