using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace PolymorphsimDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.CalculateSalary(20000, "B.Tech", "Manager");

            ProjectManager pm = new ProjectManager();
            pm.CalculateReferralIncentives(12, 15);

            Console.WriteLine(  "-----------------------");
            CEO ceo = new CEO();
            ceo.CalculateReferralIncentives(13, 15);
            ceo.JoiningDate = DateTime.Now;
            Console.WriteLine("Ceo decided joining date=" + ceo.JoiningDate);
            HR hr = new HR();
            hr.JoiningDate = ceo.JoiningDate;
            
            Console.WriteLine("Hr decided joining date + grace 2 days=" + hr.JoiningDate);
            Console.Read();


        }
    }
}
