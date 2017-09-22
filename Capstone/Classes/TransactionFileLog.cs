using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
   public class TransactionFileLog
    {

        private string filepath;

        public TransactionFileLog(string filepath)
        {
            filepath = "Vending Machine Log";
            string cd = Directory.GetCurrentDirectory();
            string vmLog = Path.Combine(cd, filepath);
        }

        public void RecordCompleteTransaction(decimal initialAmount)
        {

        }

        public void RecordDeposit(decimal depositAmount, decimal finalBalance)
        {

        }

        public void RecordPurchase(string productName, string slotid, decimal initialBalance, decimal finalBalance)
        {

        }
        public void WriteTransaction(string message)
        {

        }

       


    }
}
