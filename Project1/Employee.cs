using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Employee
    {
        public string name { get; set; }
        public decimal salary { get; set; }
        public decimal monSalary => salary * 30;
        protected List<Employee> friends;
        //Main 
        public Employee()
        {
            //Initialize the list of employee
            this.friends = new List<Employee>();
        }

        public void AddFriend(Employee friend)
        {
            if (this.name == friend.name)
            {
                Console.WriteLine("You can not add a friend from the same person");
            }
            else
            {
                this.friends.Add(friend);
            }
        }
    }
}
