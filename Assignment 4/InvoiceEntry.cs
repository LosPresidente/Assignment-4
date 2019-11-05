using System;
using System.Collections.Generic;

namespace Assignment_4
{
    class InvoiceEntry
    {
        //I am not sure if he wants a List or just an array
        int[] lineNo;
        int Qnty;

        //wiring up the InvoiceEntry and the Item Aggregation relationship to they can talk to each other
        List<Item> ItemObjects = new List<Item>();
        public InvoiceEntry(){}
        
        public InvoiceEntry(string invoiceString){}

        public void setIE_IRelationship(Item polozka){
            ItemObjects.Add(polozka);
        }


        public InvoiceEntry(int[] lineNo, int Qnty){
            this.lineNo = lineNo;
            this.Qnty = Qnty;
        }

        public int getLineNumber(){
            //I am not sure if 0 is the number to put in here
            return lineNo[0];
        }

        public void setLineNumber(int lineNum){
            this.lineNo[0] = lineNum;
        }

        public int getQnty(){
            return Qnty;
        }
    }
}
