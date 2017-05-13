using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStudy1
{
    class Person : IIntroducable
    {
        //4 auto properties
        //   public string Name { get; set; }
        // public int Age { get; set; }
        
        protected string name;
        private int age;
        private double temp;
        private static int counter = 0;
        private static string nationality = "bulgarian";
        public const double PI = 3.14;
        public readonly double OnlyRead = 3.4;
        public enum BrainSize

        {
            small = 1300, middle = 1350, large = 1400
        }

        private Brain brain;

        public MyDelegate onIntroduce;
        // public event MyDelegate onIntroduce; - ако искаме да закачаме повече от един евент хендлър на едно и също събитие

        static Person()
        {
            nationality = "albanian";
        }
        public static int Counter
        {
            get { return counter; }
        }

        public static string Nationality
        {
            get { return nationality; }
            set {nationality = value;}
        }
        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        public int Age
        {
            get { return age;}
            set { age = value; }
        }
        
        public double Balance
        {
            get { return 3.14 * age; }
        }

        public Person () : this("Default", 0)
        {
            //this.name = "default";
            //this.age = 0;
}
     //working horse
        public Person (string name, int age, Person.BrainSize size = Person.BrainSize.middle)
        {
            this.name = name;
            this.age = age;
            this.brain = new Brain(size);
            //Age = age;
            //Name = name;
            counter++;
            OnlyRead = Age * 2.7;
        }

        public Person(int age, string name) : this (name, age)
        {
            //this.name = name;
            //this.age = age;
            //Age = age;
            //Name = name;

        }

        public virtual void IntroduceYourself ()
        {

                if(onIntroduce != null)
                {
                    onIntroduce("Name:" + Name + "; " +"Age:" + Age);
                }

                        Console.WriteLine("my name ist {0} and my age is {1}, my nationality is {2}. My Brain tells me I'm {3}",
                            name, age, nationality, brain.Think());

        }

        public static double GetNationalIncome()
        {
            return counter * 120;


        }

    private class Brain
    {

        private Person.BrainSize size;

        public Person.BrainSize Size
        {
            get { return size; }
            set { size = value; }
        }

        public Brain () : this(Person.BrainSize.middle)
        {

        }
        public Brain (Person.BrainSize size)
        {

            this.size = size;
        }

        public string Think()
        {

           if(size >= Person.BrainSize.middle )
           {
               return "smart";

           }
           return "stupid";
        }
    }
     /*   public string GetName () 
        {
            return name;
        }

        public void SetName (string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        } */
    }
}
