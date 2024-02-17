using System;
namespace class1
{

    internal class Program

    {
        private static void Main(string[] args)
        {   
            oddNumber();

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


            // #region 
            // // System.Console.WriteLine("enter your age");
            // int age = int.Parse(Console.ReadLine());
            // if(age >= 14)
            // {
            //     System.Console.WriteLine("you are eligible");
            //     if(age >= 19){
            //         System.Console.WriteLine("you have passed the second step");
            //     }
            // }
            // else if(age > 20 && age >= 24)
            // {
            //     System.Console.WriteLine("lets try your");

            // }
            // else {
            //     System.Console.WriteLine("you are not eligible");
            // }
            // #endregion


            // #region 

            // int bigger = Math.Max(5, 9);
            // System.Console.WriteLine(bigger);
            // int num5 = 8;
            // int num8 = 10;
            // int num9 = 17;
            // if(num5 > num8 && num5 > num9){
            //     System.Console.WriteLine(num5);
            // }else if (num5 < num8 && num9 > num5)
            // {
            //     System.Console.WriteLine(num9);
            // }else if (num8 > num5 && num8 > num9)
            // {
            //     System.Console.WriteLine(num8);
            // } else{
            //     System.Console.WriteLine(num9);

            // }
            // #endregion

            // #region 
            // int firstnumber = 18;
            // int secondnumber = 19;
            // int thirdnumber = 4;

            // if(firstnumber > secondnumber)
            // {
            //     if(firstnumber > thirdnumber)
            //     {
            //         System.Console.WriteLine(firstnumber);
            //     }
            // }
            // else if(thirdnumber > secondnumber)
            // {
            //     System.Console.WriteLine(thirdnumber);
            // } else
            // {
            //     System.Console.WriteLine(secondnumber);
            // }
            // #endregion


            // #region

            // //switch
            // System.Console.WriteLine("please your figure");
           
            // int number2 = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("enter another figure");
            // int number3 = int.Parse(Console.ReadLine());

            
            // switch(number3){
            //     case > 2:
            //     int totall = number3 * number2;
            //     if(totall > 0){
            //         System.Console.WriteLine("your result is greater than 0 {0}", totall );

            //     } else {
            //         System.Console.WriteLine("your result is less than 0 {0}", totall);
            //     }
            //     break;
            //     case < 2:
            //     int totall2 = number3 / number2;
            //     if(totall2 < 0){
            //          System.Console.WriteLine("your result is less than 0{0}", totall2);
            //     } else {
            //         System.Console.WriteLine("your result is greater than 0 {0}", totall2);
            //     }

               
            //     break;
            //     default:
            //     System.Console.WriteLine("number doesnt exist");
            //     break;
                

            // }

            // #region 
            // // while loop, do while loop, forEach loop, For loop
            // int ii = 2;

            // while(ii < 12)
            // {
            //     int number = ii++;
            //     System.Console.WriteLine(number);
            // }

            // //do while loop

            // // do{
            // //     System.Console.WriteLine(number);
            // // }
            // // while(number > 0);
            // // {

            // // }
            // #endregion

            // #region 
            // //for loop
            // for(int i = 2; i <= 10; i+=2)
            // {
            //     System.Console.WriteLine(i);
            // }

            // for(int v = 10; v >= 1; v--)
            // {
            //     System.Console.WriteLine(v);
            // }

            // for(int iv = 1; iv <= 12; iv++)
            // {
            //     System.Console.WriteLine($"2 * {iv}= {2*iv}");
            // }

            // #endregion

            

            




            // #endregion
        }

        public static void oddNumber()
        {
            // int sum = 0;
            // for(int i = 0; i <= 11; i++)
            // {
            //     sum++;
                
            //     System.Console.WriteLine(sum);
            //     System.Console.WriteLine(i);

            // }

            // //continue, break only works with a for loop

            // int sum11 = 0;
            // for(int i= 1; i <= 11; i++ )
            // {
            //     if(i % 2 == 1)
            //     {
            //         if(i == 7)
            //         {
            //             continue;

            //         }
            //         sum11 = sum11 + i;
            //         System.Console.WriteLine(sum11);
            //     }
            // }
            
            // int number = 1;
            // while(true)
            // {
            //     if(number % 15 ==0)
            //     {
            //         break;
            //     }
            //     Console.Write(number + " ");
            //     number++;
            // }
            
            
            //write  a number that print on a console from 1 - n, the number n should be read from the console input
            // int number2 = 0;
            // System.Console.WriteLine("enter a number");
            // int user=int.Parse(Console.ReadLine());
            // while(number2 < user)
            // {
            //     number2++;
            //     System.Console.WriteLine(number2);
            // }

            //write a number that can print from 1-n that are not divisible by 3 and 7 simultaenously
           
            System.Console.WriteLine("please enter your desired number");
            int answer= int.Parse(Console.ReadLine());
            for(int i= 1;  i < answer; i++)
            {
                if(i % 3 == 0 && i % 7 == 0 )
                {
                  
                    System.Console.WriteLine('_');
                    continue;
                }
                
                System.Console.Write($"{i} ");
            }
            System.Console.WriteLine("enter a figure");
            int userr= int.Parse(Console.ReadLine());
            for(int i = 1; i <=userr ; i++ )
            {
       
                System.Console.WriteLine(i);
            }

            for(int i = 1; i < 10; i++)
            {
                System.Console.Write("when i = {i}");
                for(int j = 1; j <= i; j++)
                {
                    System.Console.Write($"{j}");
                    
                }
                System.Console.WriteLine();
            }


            
        }



    }

}

