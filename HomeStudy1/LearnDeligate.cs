using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStudy1
{
    // Delegates can be described even in separated class/file, containing  all our delegates 
    //and used from there
    public delegate double MathAction (double num);
    public delegate void  MyDelegate(string message);
    //public delegate void MyEventHandler (object sender /* обектът, който праща съобщението, нофиайва, натиска спусака*/,
    //EventArgs args /* някакви аргументи*/); // пълноправен евент хендлър в C# както е прието да бъде.
    class LearnDeligate
    {
        public double  Double (double num)
        {
            return 2 * num;
        }

        public  void Test()
        {
            LearnDeligate c = new LearnDeligate();
            // LearnDeligate p = new LearnDeligate(); if this method is static, but the method to which the delegate points
            //is non static method.
            //1. Named Method
           // MathAction d1 = Double;

            //Another way to write/to assign value (another method) to delegate
            MathAction d1 = new MathAction(Double); // MathAction d1 = new MathAction(p.Double); if this method is static, but the method to which the delegate points
            //is non static method.
             Console.WriteLine("the delegate says {0}",d1(3.14));

            //2nd way to assign function as value to variable using  anonymous function/method 
            //Anonymous Method/function. "delegate" is a keyword for defining anonymous functions
            d1 = delegate(double num)
            {
                return num * num;
            };

            Console.WriteLine("the delegate says {0}",d1(3.14));

            //3th  way to assign value to delegate using  Lambda Expressions/Statements. Lambda is equal/actually anonymous function.  
            d1 = x => x * x * x; //This is expression and expressions always are being evaluated to certain value; 
            //Expression is a "word" in our language. Statement is "whole statement like 
            //sentence/couple of words". E.g for statement - if-else construction
           // d1 = (x,y)=> { x++; return x * x * x; }; //this is lambda statement - {} always use return, cause it is unknow otherwise
            //what should be returned as a result from the statement. Lambda is in () if it has more than 1 param. But the delegate 
            //and the function to which it is pointing should also be stated with more than one param.
        
            Console.WriteLine("the delegate says {0}", d1(3.14));

            //  FUnctional Developement
            Console.WriteLine("Functional Calculator: {0}",c.Calculate(d1, 2) );

            // Console.WriteLine("Functional calculator {0}", p.Calculate(s => s * s, 2.71));

            // Console.WriteLine("Functional calculator {0}", p.Calculate(delegate(double num) { return num * num; }, 2.71));

        }

        //  FUnctional Developement - универсален калкулатор, който може да приема различни функции като вход. парам.
        public double Calculate(MathAction action, double num)
        {

            return action(num);
        }
    }
}
