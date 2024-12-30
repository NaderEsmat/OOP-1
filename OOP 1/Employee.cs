using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    //internal struct Employee
    //{
    //    private int id;
    //    private string name;
    //    private double salary;



        #region Setters and Getters
        // Applying Setters and getters : 


        // Setter Function : 

        //public void SetId(int id)
        //{
        //    this.id = id; // this keword tell me that the variable of this is the class member 
        //}

        //// Getter : 

        //public int GetId()
        //{
        //    return id;
        //}

        //// name setter

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //// name Getter
        //public string GetName()
        //{
        //    return name;
        //}

        //// Salary setter
        //public void SetSalary(double salary)
        //{
        //    this.salary = salary;
        //}

        //// salary getter
        //public double GetSalary()
        //{
        //    return salary;
        //}

        //public Employee(int id, string name, double salary)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;

        //}

        //public override string ToString()
        //{
        //    return $"id = {id} and Name : {name} and salary = {salary}";
        //} 
        #endregion



        #region Full property 
        // accessing Data through properties : 

        // 1. Full property 


        // property for ID : 
        //public int Id 
        //{
        //    set
        //    {
        //         if (value > 0)
        //        id = value;
        //    }
        //    get
        //    {
        //        return id;
        //    }
        //}

        //// Name Property
        //public string Name
        //{
        //    set
        //    {
        //        name = value;
        //    }
        //    get
        //    {
        //        return name;
        //    }
        //}

        //// Salary property : 

        //public double Salary
        //{
        //    set
        //    {
        //        if (value > 0)
        //        { salary = value; }
        //    }
        //    get
        //    {
        //        return salary;
        //    }

        //} 
        #endregion



        #region Automatic Prperty


        // Same as full property but it does it automatically
        // it creates the private member and put its set and get functions all in this code line :

        // public string Adress { set; get; }

        // Note : it only if the set and get  function set has no logic 

        // if i want to write logic in set --->> Can't use it  .. must ude Full peoperty 
        #endregion


        #region Indexers 

        // 3. special .. (Indexer)  

        // What is it ? 
        // Let me to deal with arrays easily through [] square brakets 
        // has special name which is " this  " --->  must be with this name <--- 



















        #endregion








    }


