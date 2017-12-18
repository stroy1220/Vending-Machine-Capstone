# Vending-Machine-Capstone
Module 1 Capstone - Vending Machine Software You’ve been asked to develop an application for the newest vending machine distributor, Umbrella Corp. They’ve released a new vending machine (Vendo-Matic 500) that is integrated with everyone’s bank accounts allowing customers to purchase products right from their computers for convenience sake.

The requirements for the application are listed below:

The vending machine needs to dispense beverages, candy, chips, and gum. a. Each vending machine item has a Name and a Price.
A main menu should display when the software is run presenting the following options:
(1)	Display Vending Machine Items (2)	Purchase

Vending machine inventory is stocked via an input file.
The vending machine is automatically restocked each time the application runs.
When the customer selects (1) Display Vending Machine Items they are presented a list of all items in the vending machine with its quantity remaining. a.	Each vending machine product has a slot identifier and a purchase price. b.	Each slot in the vending machine has enough room for 5 of that product. c.	Every product is initially stocked to the maximum amount. d.	A product which has run out should indicate it is SOLD OUT.
When the customer selects (2) Purchase they are guided through the purchasing process menu:
(1)	Feed Money (2)	Select Product (3)	Finish Transaction Current Money Provided: $2.00

The purchase process flow is as follows a. Selecting (1) Feed Money A customer can repeatedly feed money into the machine in whole dollar amounts (e.g. $1, $2, $5, $10). i.	The Current Money Provided indicates how much money the customer has fed into the machine. b. Selecting (2) Select Product allows the customer to select a product to purchase. i. If the product code does not exist, the customer is informed and returned to the Purchase menu. ii.	If a product is sold out, the customer is informed and returned to the Purchase menu.
iii.	If a valid product is selected it is dispensed to the customer. iv.	After the product is dispensed, the machine should update its balance accordingly and return the customer to the Purchase menu.
c.	Selecting (3) Finish Transaction allows the customer to complete the transaction and receive any remaining change back. i.	The customer’s money is returned using nickels, dimes, and quarters (using the smallest amount of coins possible). ii.	The machine’s current balance should be updated to $0 remaining. iii.	The item(s) will be “consumed” and a message printed depending on the item type:
All chip items will return “Crunch Crunch, Yum!”
All candy items will return “Munch Munch, Yum!”
All drink items will return “Glug Glug, Yum!”
All gum items will return “Chew Chew, Yum!” 8. All purchases must be audited to prevent theft from the vending machine a.	Each purchase should generate a line in a file called Log.txt b.	The audit entry should be in the format
01/01/2016 12:00:00 PM FEED MONEY: $5.00 $5.00 01/01/2016 12:00:15 PM FEED MONEY: $5.00 $10.00 01/01/2016 12:00:20 PM Crunchie B4 $10.00 $8.50 01/01/2016 12:01:25 PM Cowtales B2 $8.50 $7.50 01/01/2016 12:01:35 PM GIVE CHANGE: $7.50 $0.00

Please provide unit tests demonstrating your code works correctly.

Vending Machine Data File The input file that stocks the vending machine products is a pipe | delimited file. Each line is a separate product in the file and follows the below format

Column Name Description Slot Location The slot location in the vending machine where the product is set. Product Name The display name of the vending machine product Price The purchase price for the product.

An example input file has been provided with your repository.

  
Sales Report The output sales report file is also pipe delimited for consistency. Each line is a separate product with the number of sales for the applicable product. At the end of the report is a blank line followed by TOTAL SALES $dollar amount indicating the gross sales from the vending machine.
