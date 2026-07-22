using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{


    class employee
    {
        public int employee_id;
        public string employee_name;
        public double employee_salary;

        public employee()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Employee Payroll System");
            Console.WriteLine("-----------------------");
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Employee ID:");
            employee_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            employee_name = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary:");
            employee_salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID : " + employee_id);
            Console.WriteLine("Employee Name : " + employee_name);
            Console.WriteLine("Employee Salary : " + employee_salary);
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("----------Salary Calculation----------");
        }

    }

    class FulltimeEmployee : employee
    {
        public override void CalculateSalary()
        {
            double HRA = employee_salary * .20;
            double DA = employee_salary * .10;
            double NetSalary = employee_salary + HRA + DA;
            Console.WriteLine("Net Salary : " + NetSalary);
        }
    }

    class ParttimeEmployee : employee
    {
        public override void CalculateSalary()
        {
            double NetSalary = employee_salary;
            Console.WriteLine("Net Salary : " + NetSalary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Employee Type:");
            Console.WriteLine("1. Full-time");
            Console.WriteLine("2. Part-time");
            Console.Write("Enter your choice (1 or 2): ");
            string choice = Console.ReadLine();

            employee emp = null;

            if (choice == "1")
            {
                emp = new FulltimeEmployee();
            }
            else if (choice == "2")
            {
                emp = new ParttimeEmployee();
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting program.");
                    return;
            }

            emp.AcceptDetails();
            emp.DisplayDetails();
            emp.CalculateSalary();
        }
    }
}
