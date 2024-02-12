using System;
namespace class1
{

    internal class Program

    {
        private static void Main(string[] args)
        {   

            // //commonly used
            // const string fitName = "habeeb";
            // string firstName = "mr lawal";
            // char alphabet ='y';
            // bool isComing = true;
            // int networth = 3;
            // float @float = 6746.37f;
            // decimal @decimal = 47475793.9975m;
            // double @double = 464658374;

            // //not commonly used
            // sbyte age = 105;
            // byte ageee = 255;
            // short age3;
            // ushort  age4 = 65000;
            // uint age5;
            // long age6;
            // // ulong age7;
            // System.Console.WriteLine(fitName);
            // System.Console.WriteLine(firstName);
            // System.Console.WriteLine(@float);
            // System.Console.WriteLine(@decimal);
            // System.Console.WriteLine(@double);
            // System.Console.WriteLine(alphabet);
            // System.Console.WriteLine(isComing);
            
            // //casting
            //     //implict casting
            // int age7 = 45;
            // double age8 = age7;


            // // explicit casting

            // double age9 = 6555748;
            // int age10 = (int)age9;
            // System.Console.WriteLine(age10);

            // #region 
            // //operators

            // //-, + , /, %, ++, *, >, <, >>, &&


            // int number1 = 4;
            // int number2 = 2; 
            // number1++;
            // System.Console.WriteLine(number1 % number2);

            // //logical operator: &&, ||, !, ^


            // // assignment operator : =, +=, *=, %=, &=, !=,
            // //comparison: <, >, ==, !=, <=, >=
            // System.Console.WriteLine(number1 == number2);
            // #endregion


            // #region 
            // string fName = "deco";
            // string lName = "Habeeb";

            // string fullName = fName + " " + lName;
            // string interpulation = $"{fName} {lName}";
            // System.Console.WriteLine(fullName);
            // System.Console.WriteLine(interpulation);
            // string formatfullname = string.Format("my name is {0} {1}", fName, lName);
            // System.Console.WriteLine("my name is {0} {1}", fName, lName);
            // System.Console.WriteLine(formatfullname);
            // #endregion
            // #region 
            // // ascii value

            // #endregion

            // #region 
            // //convertion
            // string myAge = "true";
            // bool intAge=bool.Parse(myAge);
            // System.Console.WriteLine(intAge);
            // #endregion
            // #region 
            // //console input and output
            // System.Console.WriteLine("enter your name");
            // Console.ReadLine();
            // System.Console.WriteLine("enter your age");
            // bool iscompatible = int.TryParse(Console.ReadLine(), out int intAgenumber);
            // System.Console.WriteLine(iscompatible);
            // System.Console.WriteLine(intAgenumber);
          
            // #endregion


            #region 
            System.Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());
            if(age >= 14)
            {
                System.Console.WriteLine("you are eligible");
                if(age >= 19){
                    System.Console.WriteLine("you have passed the second step");
                }
            }
            else if(age > 20 && age >= 24)
            {
                System.Console.WriteLine("lets try your");

            }
            else {
                System.Console.WriteLine("you are not eligible");
            }
            #endregion


            #region 

            int bigger = Math.Max(5, 9);
            System.Console.WriteLine(bigger);
            int num5 = 8;
            int num8 = 10;
            int num9 = 17;
            if(num5 > num8 && num5 > num9){
                System.Console.WriteLine(num5);
            }else if (num5 < num8 && num9 > num5)
            {
                System.Console.WriteLine(num9);
            }else if (num8 > num5 && num8 > num9)
            {
                System.Console.WriteLine(num8);
            } else{
                System.Console.WriteLine(num9);

            }
            #endregion

            #region 
            int firstnumber = 18;
            int secondnumber = 19;
            int thirdnumber = 4;

            if(firstnumber > secondnumber)
            {
                if(firstnumber > thirdnumber)
                {
                    System.Console.WriteLine(firstnumber);
                }
            }
            else if(thirdnumber > secondnumber)
            {
                System.Console.WriteLine(thirdnumber);
            } else
            {
                System.Console.WriteLine(secondnumber);
            }
            #endregion


            #region 
            


            #endregion
        }

    }

}

