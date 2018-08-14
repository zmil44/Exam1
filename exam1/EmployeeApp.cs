using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    class EmplyoeeApp
    {
        static void Main(string[] args)
        {
            
            string firstName = "John";
            string lastName = "Doe";
            double weeklySales = 24755.95;
            double federalTax, socialSecurityTax, payGross, payNet;
            Console.WriteLine("Weekly information for " + firstName + " " + lastName);
            Console.WriteLine("Sales: " + "{0:c2}", weeklySales);
            Employee newEmployee = new Employee(weeklySales);
            payGross = newEmployee.GrossPay();
            federalTax=newEmployee.CalculateFederalTax(payGross);
            socialSecurityTax=newEmployee.CalculateSocialSecurity(payGross);
            payNet=newEmployee.NetPay(payGross,socialSecurityTax,federalTax);
            DisplayResults(payGross, federalTax, socialSecurityTax, payNet);

            
        }
        public static void DisplayResults(double payGross,double federalTax,double socialSecurityTax,double payNet)
        {
            Console.WriteLine("\nGross Pay: " + "{0:c2}", payGross);
            Console.WriteLine("Federal Tax: " + "{0:c2}", federalTax);
            Console.WriteLine("Social Security: " + "{0:c2}", socialSecurityTax);
            Console.WriteLine("Take Home Pay: " + "{0:c2}", payNet);
        }

    }
}
