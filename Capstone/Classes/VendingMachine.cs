using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    public class VendingMachine : VendingMachineException
    {

        private decimal currentBalance;
        private Dictionary<string, List<ItemGeneral>> inventory;
        private ReadInInventory inventorysource;
        //private TransactionFileLog transactionLogger;

        public decimal CurrentBalance
        {
            get { return this.currentBalance; }
        }
        public string[] Slots
        {
            get { return inventory.Keys.ToArray(); }
        }

        public void FeedMoney(int dollars)
        {
            this.currentBalance = Convert.ToDecimal(dollars);
        }
        public ItemGeneral GetItemAtSlot(string slotID)
        {
            List<ItemGeneral> list = inventory[slotID];
            return list[0];
        }
        public VendingMachine()
        {
            inventorysource = new ReadInInventory("vendingmachine.csv");
            inventory = inventorysource.GetInventory();
        }
        public VendingMachine(Dictionary<string, List<ItemGeneral>> inventory)
        {
            this.inventory = inventory;
        }

        public int GetQuantityRemaining(string slotID)
        {
            return inventory[slotID].Count;
        }

        public ItemGeneral Purchase(string slotID)
        {
            //try
            //{

                for (int i = 0; i < Slots.Length - 1; i++)
                {
                    if (slotID == Slots[i])
                    {
                        if (inventory[slotID].Count > 0)
                        {
                            if (this.currentBalance >= inventory[slotID][1].Cost)
                            {
                                return inventory[slotID][0];
                            }

                        }

                    }

                }
            return null;
            //}
            //catch (Exception ex)
            //{
            //    if (slotID != Slots[i])
            //    {
            //        InvalidSlotSelectionException no = new InvalidSlotSelectionException();
            //        return ex.Message;

            //    }
            //    else if(inventory[slotID].Count <= 0)
            //    {
            //        return OutOfStockException;
            //    }
                
            //    else if (this.currentBalance < inventory[slotID][1].Cost)
            //    {
            //        return InsufficientFundsException;
            //    }
            //}

        }

        public Change ReturnChange()
        {
            Change money = new Change(this.currentBalance);
            this.currentBalance = 0;
            return money;
        }



    }
}
