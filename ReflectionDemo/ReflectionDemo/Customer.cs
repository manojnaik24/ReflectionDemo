using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class Customer
    {
        public int a,b;
        public int Id { get; set; }

        public string Name { get; set; }    


        Customer() {

            Id = 1;
            Name = "Manoj kaumr naik";

        }
        public  Customer(int ID,string Name)
        {
            this.Id = ID;
            this.Name = Name;

        }
        public void CustomerFirstMethod()
        {

        }
        public void CustomerSecondMethod(int Id,string name)
        {

        }
        
    }
}
