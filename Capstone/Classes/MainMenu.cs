using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;
using System.IO;

namespace Capstone.Classes
{
    public class MainMenu 
    {
        List<ItemGeneral> itemsBought = new List<ItemGeneral>();
        public void Display()
        {
            PrintHeader();
            VendingMachine vendomatic = new VendingMachine();
            
            

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pick Yo Option");
                Console.WriteLine("1) Display Veding Machine items");
                Console.WriteLine("2) Purchase");
                string input = Console.ReadLine();
                string[] sloots = vendomatic.Slots;
                

                if (input == "1")
                {
                    
                    for (int i = 0; i < sloots.Length; i++)
                    {
                        
                        Console.WriteLine(sloots[i] +" "+ vendomatic.GetQuantityRemaining(sloots[i]) +" "+ vendomatic.GetItemAtSlot(sloots[i]).Name + " " + vendomatic.GetItemAtSlot(sloots[i]).Cost);
                    }
                    
                }
                if(input == "2")
                {
                    while (true)
                    {


                        Console.WriteLine("Please Choose Below");
                        Console.WriteLine("1) Feed Money");
                        Console.WriteLine("2) Select Product");
                        Console.WriteLine("3) Finish Transaction");
                        string inputTwo = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        if (inputTwo == "1")
                        {

                            Console.WriteLine("Please enter amount in 1's, 5's, 10's or 20's");
                            string money = Console.ReadLine();
                              vendomatic.FeedMoney( int.Parse(money));
                            Console.WriteLine("Current balance is $" + vendomatic.CurrentBalance);


                        }
                        if(inputTwo == "2")
                        {

                            Console.WriteLine("Enter selected product code");
                            string userSelection = Console.ReadLine();
                            try
                            {  for (int i = 0; i < sloots.Length -1 ; i++)
                                {
                                    if (userSelection == sloots[i] )
                                    {
                                        itemsBought.Add( vendomatic.Purchase(sloots[i]));
                                        Console.WriteLine("Here is your Item and current balance is " + vendomatic.CurrentBalance);
                                      
                                    }
                                }
                                //Console.WriteLine("Quantity remaining of selectd item is " + vendomatic.GetQuantityRemaining("slotID"));

                            }
                            catch(Exception ex )
                            {
                                Console.WriteLine("Sorry, your selection is invalid. Please try again");
                                Console.WriteLine(ex.Message);
                            }

                        }
                        if(inputTwo == "3")
                        {
                            Change coins = new Change(vendomatic.CurrentBalance);
                             
                            for(int i=0; i< itemsBought.Count; i++)
                            {
                                Console.WriteLine(itemsBought[i].Consume());
                            }
                            Console.WriteLine("Your money back is:");
                            Console.WriteLine("In Quarters "+ coins.Quarters);
                            Console.WriteLine("In Dimes " + coins.Dimes);
                            Console.WriteLine("In Nickles " + coins.Nickels);
                            vendomatic.ReturnChange();
                            Console.WriteLine("Current Vendo Matic Balace is "+vendomatic.CurrentBalance);

                        }



                    }
                }
                
                
            }


        }
        private void PrintHeader()
        {
            Console.WriteLine("Waddup Bitches It's the Vendo-Matic 500");
        }

    }
}
