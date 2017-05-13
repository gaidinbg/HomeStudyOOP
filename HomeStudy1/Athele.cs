using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStudy1
{
    class Athele : Person
    {
        private string sport;

        
       public string Sport
       {
           get {return sport;}
           set {sport = value;}
       }
        public Athele (string name, int age, string sport) : base (name, age, Person.BrainSize.small)
        {
            this.sport = sport;
        }

          public override void IntroduceYourself()
        {

            Console.WriteLine("I'm Athlete.");
            base.IntroduceYourself();
            Console.WriteLine( "my sport is {0}", Sport);
            //My name ist {0} and my age is {1}, my nationality is {2}, FNumber = {3}", name, Age, Nationality,FNumber);
             
        }
 
    }
}
