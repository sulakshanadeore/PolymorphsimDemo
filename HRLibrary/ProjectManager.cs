using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class ProjectManager : Employee
    {
        //Overriding means Same signature and same name as that of the base class method.
        //Two things in override
        //1) Override--means I want the base class logic +  change the implementation/logic of the method.
        //Pre-requisite  required from the base class
        //a) the method  must be marked as virtual,abstract,override
        ////public override void CalculateReferralIncentives(int empid, int NoOfPeopleReferred)

        //    2) hide----i dont want any logic from my base class, totally different logic and so hiding the base logic
        //public new void CalculateReferralIncentives(int empid, int NoOfPeopleReferred)

        public override void CalculateReferralIncentives(int empid, int NoOfPeopleReferred)
        {
            Console.WriteLine("PM Referrals");
            double inc = 0;
            if (NoOfPeopleReferred > 10 && NoOfPeopleReferred < 20)
            {
                inc = 16000;
            }
            else
            {
                //inc = 10000;
                base.CalculateReferralIncentives(empid, NoOfPeopleReferred);
            }
            Console.WriteLine($"The incentive amount to be paid={inc} for {empid}");

        }

        private int _projectCnt;

        public virtual int ProjectCount
        {
            get { return _projectCnt; }
            set { _projectCnt = value; }
        }

    }


    public class CEO : ProjectManager
    {

        public override sealed void CalculateReferralIncentives(int empid, int NoOfPeopleReferred)
        {
            Console.WriteLine("CEO Referrals");
            base.CalculateReferralIncentives(empid, NoOfPeopleReferred);
            int spInc = 5000;
            Console.WriteLine("Additional Amount=" + spInc);
        }


        public override int ProjectCount { get; set; }

        private DateTime _joiningDate;

        public DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { _joiningDate = value; }
        }





    }

    public class HR : CEO
    {
        //public override  void CalculateReferralIncentives(int empid, int NoOfPeopleReferred)
        //{ 
        
        
        //}
        public override int ProjectCount { get; set; }

        private DateTime _joiningDate;

        public  new DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { 

                _joiningDate = value;
                              
                _joiningDate=_joiningDate.AddDays(2);
            
            }
        }


    }

}
