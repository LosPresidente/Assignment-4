using System;
using System.Collections.Generic;

namespace HW4
{
    class Program
    {
            static void Main(string[] args)
        {

            

        }
        /* Crazy Lazrig's code I am not going to worry about right now.
        static char menu(){
            Console.WriteLine("\n\nInvoice Menu");
            Console.WriteLine("---------------------");
            Console.WriteLine("1-add item to invoice");
            Console.WriteLine("2-remove item from invoice");
            Console.WriteLine("3-print Invoice");
            Console.WriteLine("4-Inventory Items");
            Console.WriteLine("====================");
            Console.WriteLine("Select 1,2,3,4 or 0 to Exit :");
            char ch =Console.ReadKey().KeyChar; 
        return ch;
        }        
        static void Main(string[] args)
        { char ch;
          int j =1;
            // creating a list of item objects, Which are the items we have and their available quantity in stock
            List<Item> items = new List<Item>{new Item(122," groceries  #1", 1.99f, 30),new Item(124," groceries  #2", 3.99f, 10), new Item(126," groceries  #6", 5.99f, 20)};
            // creating one invoice object
            Invoice inv1 = new Invoice(1231,"12/11/2018");
        
            do{
                ch = menu();
                switch (ch) {
                    case '1':  // before we add item we want to show to the user all available items
                            Console.WriteLine("\nCurrent list of available items:");
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("{0,4} {1,6} {2,15} {3,6} {4,5}","idx","ID","Item Descr","U.Price","Availble Qty");
                            Console.WriteLine("------------------------------------------------------------");
                            j =1;
                            foreach(Item i in items){
                                Console.Write($"{j,4}");
                                i.displayItem();
                                j++;
                            }
                            Console.WriteLine("------------------------------------------------------------");
                            // ask the user which item in the displayed list he wants to add to the invoice
                            Console.WriteLine("Enter the index of the item you want to add ?");
                            int idx = int.Parse( Console.ReadLine());
                            if (idx >0 && idx <= items.Count){  // make sure a correct index was entred
                                Console.WriteLine("Enter Qnty :");
                                int q = int.Parse( Console.ReadLine());
                                // check if there is sufficient quantity of this item  available 
                                if (! inv1.addInvEntry(items[idx-1], q))  // the list indexes start at 0
                                       Console.WriteLine("Item not found or Qnty not sufficient");
                                else {
                                    Console.WriteLine("Item added to invoice, available quantity adjusted, and the remaining qty is");
                                    items[idx-1].displayItem();
                                }
                            }
                               else {Console.WriteLine("Please enter correct Item index");}
                            break;
                    case '2': // before we remove item from the invoice we want to show the user the invoice so he can pick the item to remove 
                            Console.WriteLine("\nInvoice items:");
                            Console.WriteLine("---------------------------------");
                            inv1.printInvoice();
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("Enter the line# for the item you want to remove ?");
                            int idxRmv = int.Parse( Console.ReadLine());
                            if(inv1.removeInvEntry(idxRmv)) // this method should return a boolean to show if item successfully removed
                                Console.WriteLine("item successfully removed and Qty updated");
                            break;
                    case '3':  // just display the invoice 
                        inv1.printInvoice();
                        break;
                    case '4': // show list of the items and their available quantities
                            Console.WriteLine("\n Available items:");
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("{0,4} {1,6} {2,15} {3,6} {4,5}","idx","ID","Item Descr","U.Price","Availble Qty");
                            Console.WriteLine("------------------------------------------------------------");
                            j=1;
                            foreach(Item i in items){
                                Console.Write($"{j,4}");  // display index in 4 spaces
                                i.displayItem();
                                j++;
                            }
                            Console.WriteLine("------------------------------------------------------------");
                            break;
                }

            }while (ch!='0');  // exit the program when user enters 0
            */
        
    }
}
