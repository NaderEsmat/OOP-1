using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Assignment1_OOP
{

    #region Q1 Struct
    public struct Point
    {
        private double X;
        private double Y;

        public double Point_Y
        {
            get { return Y; }

            set
            {
                Y = value;
            }
        }

        public Double Point_X
        {
            get { return X; }

            set
            {

                X = value;
            }
        }

        public double Distance()
        {

            return Math.Abs(Y - X);
        }

    }
    #endregion


    #region Q2 struct Person 
    public struct Person
    {
        private string name;
        private double age;

        public double Age
        {
            get { return age; }
            set { age = value; }
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void PrintData()
        {
            Console.WriteLine($" Name is {name} and  Age = {age}");
        }


    }
        #endregion

    // Part 2 

    public class HireDate
    {
        private int day;
        private int month;
        private int year; 


       public HireDate(int Day , int Month , int Year)
        {
          day = Day;
          month = Month;
          year = Year;
        }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }


    }

    public enum Gender

    {
        Male , 
        Female
    }

    //public enum Security
    //{
    //    Guest , 
    //    Developer ,
    //    Secretary , 
    //    DBA
    //}


    public class Employee
    {

        private int id;
        private string name;
        private string security;
        private int salary;
        private HireDate hiredate;
        private Gender gender;

        public Employee(int id , string name , Gender gender , string security , int salary , HireDate hiredate)
        {
           
            Name = name;
            Security = security;
            Salary = salary;         
            Gender = gender;                 
            ID = id;
            HireDate = hiredate;
            
        }

        public Gender Gender

        {
            get { return gender; }
            set
            {

                if (gender != Gender.Male && gender != Gender.Female)
                {
                    Console.WriteLine("Gender must be Male or Female only");
                }
                gender = value;
            }
        }



        public int Salary
        {
            get { return salary; }
            set
            {
                if ( value > 0)
                {
                    salary = value;
                }
                else
                {
                    salary = default;
                }
               
            }
        }


        public string Security
        {
            get { return security; }
            set { security = value; }
        }

        public HireDate HireDate

        {
            get { return hiredate; }
            set { hiredate = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int ID
        {
            get { return id; }

            set
            { 
                if( value > 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                }
                
            }

        }

        public override string ToString()
        {
            return $"{name}  {gender}  {id}  {security}  {string.Format("{0:C}", salary)}  {hiredate}";
        }


    }
    


    internal class Program
    {
        static void Main(string[] args)
        {

            // Part 1 : 

            #region Q1 

            //1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.


            //Point P1 = new Point();

            //do
            //{
            //    Console.WriteLine("Enter point X : ");
            //    P1.Point_X = double.Parse(Console.ReadLine());

            //    if (P1.Point_X <= 0)
            //    {
            //        Console.WriteLine("Invalid input! X must be greater than 0");
            //    }
            //} while (P1.Point_X <= 0);

            //do
            //{
            //    Console.WriteLine("Enter point Y : ");
            //    P1.Point_Y = double.Parse(Console.ReadLine());

            //    if (P1.Point_Y <= 0)
            //    {
            //        Console.WriteLine("Invalid input! Y must be greater than 0 ");
            //    }
            //} while (P1.Point_Y <= 0);

            //Console.WriteLine($"The Distance = " + P1.Distance());

            #endregion


            #region Q2

            //  Create a struct called "Person" with properties "Name" and "Age".
            //  Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


            //Person person1 = new Person();
            // Person person2 = new Person();
            // Person person3 = new Person();

            //Console.WriteLine("Enter Name of First person : ");
            //person1.Name = Console.ReadLine();


            //do
            //{

            //    Console.WriteLine("Enter Age of First person : ");
            //    person1.Age = int.Parse(Console.ReadLine());

            //    if (person1.Age <= 0)
            //    {
            //        Console.WriteLine("  Please Enter a valid Data  ");
            //    }

            //} while (person1.Age <= 0);


            //Console.WriteLine("Enter Name of Second person : ");
            //person2.Name = Console.ReadLine();


            //do
            //{

            //    Console.WriteLine("Enter Age of Second person : ");
            //    person2.Age = int.Parse(Console.ReadLine());

            //    if (person2.Age <= 0)
            //    {
            //        Console.WriteLine("  Please Enter a valid Data  ");
            //    }

            //} while (person2.Age <= 0);


            //Console.WriteLine("Enter Name of Third person : ");
            //person3.Name = Console.ReadLine();


            //do
            //{

            //    Console.WriteLine("Enter Age of Third person : ");
            //    person3.Age = int.Parse(Console.ReadLine());

            //    if (person3.Age <= 0)
            //    {
            //        Console.WriteLine("  Please Enter a valid Data  ");
            //    }

            //} while (person3.Age <= 0);


            //person3.PrintData(); 
            #endregion

            // Part 2 : 

                HireDate hiredate1 = new HireDate(15 , 12 , 2023);
                HireDate hiredate2 = new HireDate(23, 4, 2020);
                HireDate hiredate3 = new HireDate(18, 9, 1990);


                Employee E1 = new Employee(111 , "Nader" , Gender.Male , "DBA",15000,hiredate1);
                Employee E2 = new Employee(222, "Shehab", Gender.Male, "Guest", 12350, hiredate2);
                Employee E3 = new Employee(333, "Fatma", Gender.Female, "officer", 9800, hiredate3);


            Employee[] arr = {E1 , E2 , E3};
                                   
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


              
            

           




        }
    }
}
