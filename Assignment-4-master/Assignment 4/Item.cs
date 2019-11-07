//Joanna Summerlin, Ryan Gross, Ian Bilek
using System;
using System.Collections.Generic;

namespace Assignment_4
{
    class Item
    {
        public int ID;
        public string description;
        public float availableQty;
        public float unitPrice;

        //this is the constructors
        public Item(){}

        public Item(int ID, string description, float unitPrice, int availableQty){
            this.ID = ID;
            this.description = description;
            this.unitPrice = unitPrice;
            this.availableQty = availableQty;
        }

        //this is not a constructor, but helps maintain the Dependency relationship with Invoice class

        public int relationshipItemSide(){return 1;}

//this method updates the quantity of product available, it does make sure the quantity is >0
        public void updateAvlblQty(int ID){
            // string slovo;
             //int cislo

            // Console.WriteLine($"Current quantity of {description} is {availableQty}");
            // Console.WriteLine($"If you would like to add/subtract quantity of this object, please type in 'plus' or 'minus' followed by the quantity.");
            // slovo = Console.ReadLine();
            // if(slovo == "plus"){
            //     cislo = int.Parse(Console.ReadLine());
            //     availableQty = availableQty + cislo;
            //     Console.WriteLine($"The new Quantity for {description} is {availableQty}");
            // }else if(slovo == "minus"){
            //     cislo = int.Parse(Console.ReadLine());
            //     if((availableQty - cislo)<0){
            //         Console.WriteLine($"You are trying to subtrack more than available quanitity, please subtrack smaller number");
            //     }else if((availableQty - cislo)>= 0){
            //         availableQty = availableQty - cislo;
            //         Console.WriteLine($"The new quantity of {description} is {availableQty}");
            //     }
            // }else{
            //     Console.WriteLine($"This word is not recognized, please enter in 'plus' or 'minus'");
            // }
            availableQty = availableQty + ID;
            
        }

        public float getPrice(){
            return unitPrice;
        }

        public string getItemDescription(){
            return description;
        }

        public int getItemID(){
            return ID;
        }

        public void displayItem()
        {
            Console.WriteLine($" Item's ID is: {ID}, the description is: {description}, the available quantity is: {availableQty}, and the price is: {unitPrice}");
        }
    }
}
