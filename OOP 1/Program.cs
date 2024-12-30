using System.Reflection.Metadata;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // The Demo With Classes and Structs in same Project

            #region Struct

           // Point p1;
            // DEclaration of variable of type Point .. in Stack 
            // Allocate un-intallized object of 8 bytes ... 4 bytes for x and 4 for y

            //  Console.WriteLine(p1.X);   --> invalid cause it is un assigned 

            //p1.X = 10;
            //p1.Y = 12;
            //Console.WriteLine(p1.x);   // Valid
            //Console.WriteLine(p1.y);

            //  p1 = new Point();
            // Call the Constructor 

            //   Console.WriteLine(p1.X);
            //  Console.WriteLine(p1.Y); 
            #endregion

            #region Encapsulation


            /* OOP 4 main Consepts : 

               1- Encapsulation
               2- Inhertiance
               3- Polymerphism
               4- Abstraction
               */


            // 1. Encapsulation 

            // separates the data defenition from its use 

            // without encapsulation : 
            // End user can access the data itself 
            // No Data Validation 
            // no readonly field 

            // How to apply Encap ? --> 
            // 1. Male all date members private not public
            // 2. Access these data with either : setters and getters .... or ... properties 

            //  Employee E1 = new Employee();  // uses the default constructor ( CLR created it --> unseen ) accessing the data with setters and getters

            // Employee E1 = new Employee(1, "Nader", 14000);   // uses the parameterized constructor and getters 

            //E1.SetId(1);
            //E1.SetName("Nader");
            //E1.SetSalary(15000);

            //Console.WriteLine(E1.GetName());
            //Console.WriteLine(E1.GetSalary());
            //Console.WriteLine(E1.GetId()); 

            // Console.WriteLine(E1);







            //Employee E1 = new Employee();

            //E1.Id = 1;                             // as Setters
            //E1.Name = "Nader Esmat";
            //E1.Salary = 14500;
            //E1.Adress ="Alexandria";


            //Console.WriteLine(E1.Id);               // as Getters
            //Console.WriteLine(E1.Salary);
            //Console.WriteLine(E1.Name);
            //Console.Write(E1.Adress);




            #endregion


            #region Class and Constructor chaining


            // Class : is referecne type : stored in Heap 

            //    Car c1;

            // 1. Declare object from Type Car (Reference) in Heap 
            // 2. c1 now can refer to any object of type Car or inherited from it 
            // 3. c1 now refers to Null 


            //  c1 = new Car(1,"BMW",220);

            // 1. Allocate number of bytes in the Heap for the object (depending on the number of members and their type )
            // 2. Initialize the Allocated bytes with the default values of datatypes
            // 3. Calls the User Defind constructor if exists 
            // 4. Assign the object to the reference 


            //   Console.WriteLine(c1);


            // CLR will Generate parameterless constructor (The Deafult Constructor)
            // This Does nothing  
            #endregion

            /*
                in the Class : any User defined Constructor replace the Default Constructor
                in the Struct : The default contructor is not replaced 

                    Class is reference type
                    Struct is value type 

                   Class : objects are intiallized due to the " new " keword through the CLR
                   Struct : intiaillized without the use of new keyword 
             
             * */

        }
    }
}
