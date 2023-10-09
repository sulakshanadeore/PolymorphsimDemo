using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Employee
    {
        //check the parameter number,types,sequence is different
        //but has method same name  and it is in the same class, Overloaded method
        public virtual void CalculateReferralIncentives(int empid, int NoOfPeopleReferred)
        {
            Console.WriteLine( "Incentives=  " + 10000);

        }


        public void CalculateSalary(int bs,int empid,string designation)
        {
            double sal=0;
            if (designation=="Manager")
            {
                sal=bs + (bs + 1000) * .10;
            }
            Console.WriteLine($"the salary for {empid} = {sal}");

        }

        public bool CalculateSalary(int bs, DateTime joining, string designation)
        {
            double sal=0;
            if (joining.Year <1999)
            {
                sal = bs + (bs + 1000) * .20;
            }
            Console.WriteLine($"the salary for {designation} = {sal}");

            return false;

        }

        public void CalculateSalary(int bs, string qualification, string designation)
        {
            double sal = 0;
            if ((designation == "Manager")&& (qualification=="B.Tech"))
            {
                sal = bs+(bs + 1000) * .15;
            }
            Console.WriteLine($"the salary for {designation} with {qualification}  = {sal}");

        }

        public void CalculateSalary( string qualification, int bs, string designation)
        {
            double sal = 0;
            if ((designation == "Manager") && (qualification=="MCS"))
            {
                sal = bs+(bs + 1000) * .12;
            }
            Console.WriteLine($"the salary for {designation} = {sal}");

        }

        public void CalculateSalary(int bs)
        {
            double sal =bs+ (bs + 1000) * .12;
            Console.WriteLine( sal);

        }

    }
}
