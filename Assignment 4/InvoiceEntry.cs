//Joanna Summerlin, Ryan Gross, Ian Bilek

using System;
using System.Collections.Generic;

namespace Assignment_4
{
    class InvoiceEntry
    {
        //I am not sure if he wants a List or just an array
        int lineNo;
        int Qnty;

        //wiring up the InvoiceEntry and the Item Aggregation relationship to they can talk to each other
        List<Item> ItemObjects = new List<Item>();
        public InvoiceEntry(){}
        
        public InvoiceEntry(string invoiceString){}

        public InvoiceEntry(int lineNo, Item item, int ReqQantity){}

        public void setIE_IRelationship(Item polozka){
            ItemObjects.Add(polozka);
        }


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
    }
}
