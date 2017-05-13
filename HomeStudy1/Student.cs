using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStudy1
{
    class Student : Person
    {
        private string fNumber;

        public string FNumber
        {
            get { return fNumber; }
            set { fNumber = value; }

        }

        public Student()
            : this("Default", 0, "")
        { 
        
        }
        public Student (string name, int age, string fNumber ) : base (name, age, Person.BrainSize.large)
        {
            this.fNumber = fNumber;
        }

        public override void IntroduceYourself()
        {

            Console.WriteLine("I'm Student.");
            base.IntroduceYourself();
            Console.WriteLine( "FNumber = {0}", FNumber);
            //My name ist {0} and my age is {1}, my nationality is {2}, FNumber = {3}", name, Age, Nationality,FNumber);
             
        }
 
    }
}
