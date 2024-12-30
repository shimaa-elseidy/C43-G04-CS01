using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;
        //Address


        #region Apply Encapsulation User [ Setter - Getter ] Method
        // Apply Encapsulation User [ Setter - Getter ] Method
        // Setter Id
        //public void SetId(int id)
        //{
        //    this.id = id;
        //    // This ====> refere to class or struct (Employee)
        //}

        // Getter Id
        //public int GetId()
        //{
        //    return id;
        //}

        // setter Name
        //public void SetName(string name)
        //{
        //    if (name.Length >= 8 && name.Length <= 15)
        //        this.name = name;
        //}
        // Getter Name
        //public string GetName()
        //{
        //    return name;
        //}
        // setter Salary
        //public void SetSalary(double salary)
        //{
        //    this.salary = salary;
        //}
        // Getter Salary
        //public double GetSalary()
        //{
        //    return salary;
        //}

        //public Employee (int id, string name, double salary)
        //{
        //    //this.id = id;
        //    this.SetId(id);

        //    //this.name = name;
        //    this.SetName(name);


        //    //this.salary = salary;
        //    this.SetSalary(salary);
        //}
        //public override string ToString()
        //{
        //    return $"Id : {id} :: Name : {name}  :: Salary : {salary}";
        //}
        #endregion
        #region Apply Encapsulation using Properties
        // Apply Encapsulation using Properties
        // 1.--------------- Full Property --------------------
        // through it i can access private attribute

        // id
        //public int Id
        //{
        //    //set
        //    set
        //    {
        //     id = value;
        //    }
        //    //get
        //    get
        //    {
        //     return id;
        //    }
        //}
        // name
        //public string Name
        //{
        //    // Set
        //    set 
        //    {
        //        if (value.Length>8)
        //        {
        //            name = value;
        //        }
                
        //    }
        //    // Get
        //    get
        //    {
        //        return name;
        //    }
        //}
        // salary
        //public double Salary
        //{
        //    // Set
        //    set
        //    {
        //        if (value>0)
        //        {
        //            salary = value;
        //        }
                
        //    }
        //    // Get
        //    get
        //    {
        //        return salary;
        //    }
        //}

        // 2. --------------- Automatic Property ---------------
             // msh m7taga acreate private attribute
            // public string Address { set; get; } 


        // 3. --------------- Special Property [Indexer] -------

        #endregion
    }
}
