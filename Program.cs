using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hi
{
    internal class Program
    {
        static void MyMethood3()
        {
            Console.WriteLine("DOY you want to make an arithmetic operation ? n / y ");
            string gg = Console.ReadLine();

            switch (gg)
            {


                case "n":
                    Console.WriteLine("Worng Operation..");
                    break;
                case "y":
                    MyMethood2();
                    break;
            }

        }
        static void MyMethood2()
        {

          // do
            {
                Console.WriteLine("Enter number 1 :-");
                decimal num3;
                decimal.TryParse(Console.ReadLine(), out num3);
                Console.WriteLine("Enter Number 2 :-");
                decimal num2;
                decimal.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine("Enter Operation from (+, -, *./) :-");
                string operation = Console.ReadLine();

                {
                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine(string.Format("{0} + {1} = {2}", num3, num2, num3 + num2));
                            break;
                        case "-":

                            Console.WriteLine(string.Format("{0} - {1} = {2}", num3, num2, num3 - num2));

                            break;
                        case "*":
                            Console.WriteLine(string.Format("{0} * {1} = {2}", num3, num2, num3 * num2));
                            break;

                        case "/":
                            Console.WriteLine(string.Format("{0} / {1} = {2}", num3, num2, num3 / num2));
                            break;
                        default:
                            Console.WriteLine("Worng Operation..");
                            break;
                    }
                    MyMethood3();

                }



            }//while (true);
        }
        static void MyMethood1()
        {

            Console.WriteLine("Please enter your name ");

            string num1 = Console.ReadLine();
            Console.WriteLine("Hi Mr:" + num1);
            MyMethood3();                     
        } 
        
        
        static void Main(string[] args)
        { 

            MyMethood1();
            
                {
               
            }
            
        }
    }
}

        
  
