using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStudy1
{

    public enum Days
    {
        Mo, Tu, We, Th, Fr, Sa, Su
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(); //"Kurcho", 23
            //Fields 1
            //person1.name = "stoyan";
            //person1.age = 53;
            //console.writeline("my name ist {0} and my age is {1}", person1.name, person1.age);

            //2.  getter and setter
            // person1.SetName("Stoyan");
            // person1.SetAge(52);

            //Console.WriteLine("my name ist {0} and my age is {1}", person1.GetName(), person1.GetAge());

            //3 Properties
            //person1.Name = "stoyan";
            //person1.Age = 45;
            //Console.WriteLine("my name ist {0} and my age is {1}", person1.Name, person1.Age);

            //4 auto properties
      person1.IntroduceYourself();

          Person person2 = new Person("Stoyna", 43);

            // Fields 1
            //    person2.name = "Alex";
            //    person2.age = 20;
            //    Console.WriteLine("my name ist {0} and my age is {1}", person1.name, person1.age);

            //2.  getter and setter
            //person2.SetName("alex");
            //person2.SetAge(25);
            //Console.WriteLine("my name ist {0} and my age is {1}", person2.GetName(), person2.GetAge());

            //3 Properties
            //person2.Name = "Maina";
            //person2.Age = 34;
            // Console.WriteLine("my name ist {0} and my age is {1}", person2.Name, person2.Age);

            //4 auto properties
           person2.IntroduceYourself();
            Console.WriteLine("Amount of instances created is {0}", Person.Counter);
            Console.WriteLine("Income is {0}", Person.GetNationalIncome());

         //   Console.WriteLine("only for reading {0}",person2.OnlyRead);
        

            Person.Nationality = "german";
           // person2.IntroduceYourself();

            Student Alex = new Student("Vuk", 23,"12345");
           // Alex.IntroduceYourself();

            Athele Petko = new Athele("Petko", 18, "box");
            Petko.IntroduceYourself();

            Handler Father = new Handler(person2);
            Father.MakeItTalk();
            Handler Teacher = new Handler(Alex);
            Teacher.MakeItTalk();
            Handler Coach = new Handler(Petko);
            Coach.MakeItTalk();

            Console.WriteLine((int)Days.Fr);

            Manager<Student> Door = new Manager<Student>();
            Door.AddEntity(Alex);
            Door.AddEntity(Alex);
            Door.AddEntity(Alex);
            Console.WriteLine(Door.GetNumberOfEntities());
            Student rm = Door.RemoveEntity();
            Console.WriteLine(Door.GetNumberOfEntities());
            Console.WriteLine("{0} left the room",rm.Name);
           

        }

      
    }
}
