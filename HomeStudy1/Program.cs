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

            Console.WriteLine("================================================================");

            //Automatic Properties
            var aperson = new AutoPerson () { Name = "Muzhik", Age = 34 };
           // aperson.Name = "Peter";
            //aperson.Age = 23;

            Console.WriteLine("my name is {0}, age = {1}",
                aperson.Name, aperson.Age);
            
            //Type Inference
            var name = "Proba";
            var age = 43;

            Console.WriteLine("name = {0}, age = {1},", name, age);
           
            //List <AutoPerson> people = new List <AutoPerson>();
            //people.Add(aperson);
            //AutoPerson aperson1 = new AutoPerson();
            //people.Add(aperson1);
            
            //Initializers
            List<AutoPerson> people = new List<AutoPerson>() {
                new AutoPerson { Name = "Scott", Age = 43 }, // read only properties
                new AutoPerson { Name = "Susan", Age = 15 },
                new AutoPerson { Name = "Ivan", Age = 16 },
                new AutoPerson { Name = "Peter", Age = 16 }
            };

            foreach (AutoPerson person in people)
            {
                Console.WriteLine(person.Name);
            }

            // Anonymous Types
            var anonymousPerson = new {Name = "Marion", Age = 5, Gender = "female"};
            var anonymousArray = new[] { new { Name = "Stoyan", Age = 51 }, 
                new { Name = "Stoyan", Age = 34 } }; // new { Type = "Product1", Price = 34.56}

            //Delegate
            LearnDeligate delegateTest = new LearnDeligate();
            delegateTest.Test();

            //Pseudo Event Driven Developement - pseude because for now it is incomplete

            person1.onIntroduce = OnIntroduce; // person1.onIntroduce += OnIntroduce; - ако искаме да закачаме повече от
            //един евент хендлър  на едно събитие.
            person1.IntroduceYourself();



            //  Extenssion Methods

            string myEmail = "21eqadad@yahoo.com";
            Console.WriteLine("This is valid email {0}", myEmail.IsValidEmailAddress());
            

            //LINQ Query - Language internal Query - такива заявки могат да се отправят към: обекти,xml, бази данни
            //IEnumerable - interface, който трябва да бъде имплементиран, за да се правят LINQ заявки към обекти, 
            //но само такива, които го имплементират. 
            var result = from p in people
                         where p.Name.StartsWith("S")
                         orderby p.Age descending
                         //  select p; - връща p
                         select new { p.Name, p.Age, sex = 2 }; // при всяка итерация и намерен резултат p създава обект и после го връща

            foreach (var personI in result)
            {
                Console.WriteLine("Found {0} {1}", personI.Name, personI.Age);
            } 
        }

        private static void OnIntroduce(string message)
        {

            Console.WriteLine("Hahhaha, This guy {0} introduced himself again", message);
        }
    }
}
