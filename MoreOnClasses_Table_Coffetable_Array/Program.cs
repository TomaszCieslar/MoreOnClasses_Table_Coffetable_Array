using System;

namespace MoreOnClasses_Table_Coffetable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a project named "Tables2", based on the "Tables" project.

            // In it, create a class "CoffeeTable" that inherits from "Table". Its method “ShowData", 
            //besides writing the width and height, must display "(Coffee table)." 

            //Create an array that contains 5 tables and 5 coffee tables.The tables must have random sizes between 50 and 200 cm, 
            //and the coffee tables from 40 to 120 cm.Show all their data.


            Table[] myTables = new Table[5];
            CoffeeTable[] myCoffeeTable = new CoffeeTable[5];



            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {  
                myTables[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                myTables[i].ShowData();

                myCoffeeTable[i] = new CoffeeTable(rnd.Next(40,121), rnd.Next(40,121));
                myCoffeeTable[i].ShowData();
            }

           
            Console.ReadLine();
        }

    }
}
