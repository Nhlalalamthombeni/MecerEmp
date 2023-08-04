using System;
using System.Security.Cryptography.X509Certificates;

namespace MecerEmp
{ 
    class program
    {
        static void Main(string[] args)
        {
          /*  lebo lebo = new lebo();
            lebo.checkin();
            lebo.checkout();  
            
            ((ReportProgress)lebo).weeklyMeetings();

            lalah La = new lalah();
            La.checkin();
            La.checkout();

            Leyana lee = new Leyana();
            lee.checkin();
            lee.checkout();

            sivu siv = new sivu();
            siv.checkin();
            siv.checkout();

            ReportProgress report = new ReportProgress();
            report.weeklyMeetings(); */   

            lebo lebog = new lebo();
            ((ReportProgress)lebog).weeklyMeetings();


        }

        public class lebo : IControls, ReportProgress
        {
            public void checkin()
            {
                Console.WriteLine("Checked in via Ms teams working from home ");
            }

            public void checkout()
            {
                Console.WriteLine("requested some time off");
            }

            void ReportProgress.monthlyMeetings()
            {
                throw new NotImplementedException();
            }

            void ReportProgress.weeklyMeetings()
            {
                throw new NotImplementedException();
            }
        }


        public class lalah : IControls, WorkHours
        {
            public void checkin()
            {
                Console.WriteLine("coming in late");
            }

            public void checkout()
            {
                Console.WriteLine("checked out on Ms teams at 5");
            }

            void WorkHours.salaryRate()
            {
                throw new NotImplementedException();
            }
        }



        public class Leyana : IControls
        {
            public void checkin()
            {
                Console.WriteLine("checked in at 8");
            }

            public void checkout()
            {
                Console.WriteLine("checked out late today");
            }
        }


        public class sivu : IControls
        {
            public void checkin()
            {
                Console.WriteLine("checked in early today");
            }

            public void checkout()
            {
                Console.WriteLine("checked out at 6");
            }
        }




    }
    interface IControls
    {
        void checkin();
        void checkout();
    }
    interface ReportProgress
    {
        void weeklyMeetings();
        void monthlyMeetings();
    }

    interface WorkHours
    {
        void salaryRate();
    }
}
