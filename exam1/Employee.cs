using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    class Employee
    {
      
        private double salesWeekly;
        private double COMMISSION = .07;
        private double FEDERAL_TAX = .18;
        private double SOCIAL_SECURITY = .06;
        private double grossPay;
        private double federalTax;
        private double socialSecurity;
        private double netPay;

        public Employee() 
        { 
        }

        public Employee(double weeklySales)
        {
            salesWeekly=weeklySales;
        }
            public double GrossPay()
             {
                grossPay = (salesWeekly * COMMISSION);
                return grossPay;
             }
            public double CalculateFederalTax(double payGross)
            {
                federalTax = (payGross * FEDERAL_TAX);
                return federalTax;
            }
            public double CalculateSocialSecurity(double payGross)
            {
                socialSecurity=(payGross*SOCIAL_SECURITY);
                return socialSecurity;
            }
            public double NetPay(double payGross,double socialSecurityTax,double federalTax)
            {
            
                netPay=(payGross-(socialSecurityTax+federalTax));
                return netPay;
            }
    } 
}

