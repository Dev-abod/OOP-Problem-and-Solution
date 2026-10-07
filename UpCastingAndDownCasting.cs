



public class clsPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hi, My name is {Name} and a Im Age is {Age}");
        }
        
    }

public class clsEmployee : clsPerson
    {
        public string Company { get; set; }
        public float Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"I Work at {Company} and a Im Salary is {Salary}");
        }
       
        
    }


int main()
{
            // Upcasting
            clsEmployee employee = new clsEmployee { Name = "john", Salary = 2000, Age = 20, Company = "Alromana" };
            clsPerson person = employee;
            person.Greet();


            // Downcasting Done
            clsPerson person1 = new clsEmployee { Name = "john", Salary = 2000, Age = 20, Company = "Alromana" };
            clsEmployee employee1 = (clsEmployee)person1;
            employee1.Work();

            // DowCasting not done is Invalid
            clsPerson person2 = new clsPerson { Name = "john", Age = 20 };
            clsEmployee employee2 = (clsEmployee)person2;
            employee2.Work();
}
