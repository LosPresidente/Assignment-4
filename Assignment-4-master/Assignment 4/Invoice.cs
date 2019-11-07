//Joanna Summerlin, Ryan Gross, Ian Bilek
using System;
using System.Collections.Generic;

namespace Assignment_4
{
    class Invoice
    {
        int InvNum;
        string invDate;
        float total;
        int quant;

        int lineNo = 0;

        //Here I will set up the Composition relationship with the InvoiceEntry
        public List<InvoiceEntry> IEObjects = new List<InvoiceEntry>();
        public void setI_IE_Relationship(string invoiceString){
            InvoiceEntry IE = new InvoiceEntry(invoiceString);
            IEObjects.Add(IE);
        }

        //In here I will set up the Dependency relationship with the Item Class

        //idk why we have to create a method with nothing in it . . .
        public void relationshipMethodInvoice(){}

        public void dependencyMethod(Item item){
            //here the r should be assigned to "1"
            int r = item.relationshipItemSide();
        }

        //based on Main only InvNum and date are needed, total will be calculated later (I think)
        public Invoice(int InvNum, string invDate){
            this.InvNum = InvNum;
            this.invDate = invDate;
        }

        //So this method takes in the information needed for the invoice entry line, increases the line by 1 (new line), calls invoiceEntry Constructor to create a new line
        public bool addInvEntry(Item item, int ReqQuantity){
            
            //InvoiceEntry line;
            //here I check if the quantity is even available
            if(item.availableQty < ReqQuantity)
            {
                Console.WriteLine($"Requested quantity is not available, please select smaller quantity");
                return false;
            }else if(item.availableQty > ReqQuantity)
            {
                lineNo = lineNo + 1;
                //updateLineNumbers(lineNo);
                InvoiceEntry invEntry = new InvoiceEntry(lineNo, item, ReqQuantity);
                item.availableQty = item.availableQty - ReqQuantity;
                IEObjects.Add(invEntry);
                return true;
            }
            return false;
        }
        //this method removes InvoiceEntry line, has to put the item quantity back
        public bool removeInvEntry(int idxRmv)
        {
            lineNo = idxRmv;
            
            //Console.WriteLine($"lineNo is {lineNo} idxRmv is: {idxRmv}");
            InvoiceEntry removeLine = null;

            foreach(InvoiceEntry i in IEObjects)
            {
               if(lineNo == i.getLineNumber())
               {
                   removeLine = i;
               }
            }

            if(removeLine != null)
            {
                quant = removeLine.getQnty();

                foreach(InvoiceEntry i in IEObjects){
                    i.quantityUpdate();
                }
                IEObjects.Remove(removeLine);
                updateLineNumbers(lineNo);
                return true;
            }
            return false;
        }



        public void updateLineNumbers(int lineNum){
            lineNum = 0;
            foreach(InvoiceEntry i in IEObjects){
                lineNum = lineNum++;
            }
        }

        //this method takes in all the information and prints an invoice, prolly need foreach loop to loops through the lines
        public void printInvoice()
        {

            Console.WriteLine("Invoice # {0}  Date: {1}", InvNum, invDate);
            Console.WriteLine("  L#       Description    Quantity   U.Price    Total");
            Console.WriteLine("-------  --------------  ---------  ---------  -------");

            foreach(InvoiceEntry i in IEObjects)
            {
                //updateLineNumbers();
                i.displayInfo();
            }

            Console.WriteLine("-------  --------------  ---------  ---------  -------");
            Console.WriteLine("-------  --------------  ---------  ---------  " );
        }
    }
}
