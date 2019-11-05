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

        //This method is not done yet
        public void addInvEntry(Item item, int ReqQuantity, int lineNo){
            lineNo+=1;
            InvoiceEntry invoice = new InvoiceEntry(lineNo, item, ReqQuantity);


        }

        public void removeInvEntry(int lineNo){
            
        }
    }
}
