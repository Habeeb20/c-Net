using System;
namespace class1
{

    internal class Program

    {
        private static void Main(string[] args)
        {   

            //commonly used
            const string fitName = "habeeb";
            string firstName = "mr lawal";
            char alphabet ='y';
            bool isComing = true;
            int networth = 3;
            float @float = 6746.37f;
            decimal @decimal = 47475793.9975m;
            double @double = 464658374;

            //not commonly used
            sbyte age = 105;
            byte ageee = 255;
            short age3;
            ushort  age4 = 65000;
            uint age5;
            long age6;
            // ulong age7;
            System.Console.WriteLine(fitName);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(@float);
            System.Console.WriteLine(@decimal);
            System.Console.WriteLine(@double);
            System.Console.WriteLine(alphabet);
            System.Console.WriteLine(isComing);
            
            //casting
                //implict casting
            int age7 = 45;
            double age8 = age7;


            // explicit casting

            double age9 = 6555748;
            int age10 = (int)age9;
            System.Console.WriteLine(age10);

            #region 
            //operators

            //-, + , /, %, ++, *, >, <, >>, &&


            int number1 = 4;
            int number2 = 2; 
            number1++;
            System.Console.WriteLine(number1 % number2);

            //logical operator: &&, ||, !, ^


            // assignment operator : =, +=, *=, %=, &=, !=,
            //comparison: <, >, ==, !=, <=, >=
            System.Console.WriteLine(number1 == number2);
            #endregion


            #region 
            string fName = "deco";
            string lName = "Habeeb";

            string fullName = fName + " " + lName;
            string interpulation = $"{fName} {lName}";
            System.Console.WriteLine(fullName);
            System.Console.WriteLine(interpulation);
            string formatfullname = string.Format("my name is {0} {1}", fName, lName);
            System.Console.WriteLine("my name is {0} {1}", fName, lName);
            System.Console.WriteLine(formatfullname);
            #endregion
            #region 
            // ascii value

            #endregion

            #region 
            //convertion
            string myAge = "true";
            bool intAge=bool.Parse(myAge);
            System.Console.WriteLine(intAge);
            #endregion
            #region 
            //console input and output
            System.Console.WriteLine("enter your name");
            Console.ReadLine();
            System.Console.WriteLine("enter your age");
            bool iscompatible = int.TryParse(Console.ReadLine(), out int intAgenumber);
            System.Console.WriteLine(iscompatible);
            System.Console.WriteLine(intAgenumber);
          
            #endregion
        }

    }

}

