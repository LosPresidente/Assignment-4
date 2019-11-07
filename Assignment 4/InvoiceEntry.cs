//Joanna Summerlin, Ryan Gross, Ian Bilek

using System;
using System.Collections.Generic;

namespace Assignment_4
{
    class InvoiceEntry
    {
        //I am not sure if he wants a List or just an array
        public int lineNo;
        public int Qnty;

        public Item ItemObjects;

        //wiring up the InvoiceEntry and the Item Aggregation relationship to they can talk to each other
        //List<Item> ItemObjects = new List<Item>();
        //Item item = new Item();
        public InvoiceEntry(){}
        
        public InvoiceEntry(string invoiceString){}

        public InvoiceEntry(int lineNo, Item ItemObjects, int ReqQantity){}

        // public void setIE_IRelationship(Item polozka){
        //     ItemObjects.Add(polozka);
        // }


        public InvoiceEntry(int lineNo, int Qnty){
            this.lineNo = lineNo;
            this.Qnty = Qnty;
        }

        public int getLineNumber(){
            //I am not sure if 0 is the number to put in here
            return lineNo;
        }

        public void setLineNumber(int lineNum){
            this.lineNo = lineNum;
        }

        public int getQnty(){
            return Qnty;
        }

//the
        public string getDescription()
        {
            return ItemObjects.getItemDescription();
        }
        public float getUnitPrice()
        {
            return ItemObjects.getPrice();
        }

        public void displayInfo()
        {
            
            float price = getUnitPrice();

            float total = (Qnty * price);

            Console.WriteLine("Line #: {0}", lineNo);
            Console.WriteLine("Description: {0}", getDescription());
            Console.WriteLine("Quantity: {0}", Qnty);
            Console.WriteLine("Unit Price: {0}", getUnitPrice());
            Console.WriteLine("Total: {0}", total);
        }
    }
}
