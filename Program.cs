using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {

            string a1 = null;
            bool m = true;
            string input_type;
            string reference= "1234cfrk";
            do
            {
                do
                {
                    Console.WriteLine("Please enter the input type :");
                    Console.WriteLine("1 or c - Celsius");
                    Console.WriteLine("2 or f - Fahrenheit");
                    Console.WriteLine("3 or r - Reamur");
                    Console.WriteLine("4 or k - Kelvin");

                    input_type = Console.ReadLine();
                    if (input_type.Length == 1 )
                    {
                       if (!(reference.IndexOf(input_type) == -1))
                        {
                            m = false;
                        }
                       
                    }
                    else
                    {
                        m = true;
                    }
                

                if (m) { Console.WriteLine("The given input type is wrong. "); }
                } while (m);
                m = true;
                do
                {

                    Console.WriteLine("Please enter the input (temperature) value:");
                    string input_value = Console.ReadLine();
                    float j;
                    if (float.TryParse(input_value, out j))
                    {
                        m = false;
                        print_out(conv_cels(input_type, j));
                    }
                    else
                    {
                        Console.WriteLine("The entered data could not be used. ");
                    }
                } while (m);


                Console.WriteLine("Do you want to continue using the software (y/n)?");
                a1 = Console.ReadLine();
            } while (a1.Equals("y"));

        }

        private static string[,] conv_cels(string input_type, float temp) {
            string[,] answer= new string[2,4];
            float c=0;
            
           
            switch (input_type)
            {
                 
                case "1": //celsius
                    c = temp; 
                    break;
                case "c": //celsius
                    c = temp;
                    break;
                case "2"://fahrenheit
                    c = fahrenheit(temp);
                    break;
                case "f"://fahrenheit
                    c = fahrenheit(temp);
                    break;
                case "3"://kelvin
                    c = kelvin(temp);
                    break;
                case "k"://kelvin
                    c = kelvin(temp);
                    break;
                case "4"://reamur
                    c = reamur(temp);
                    break;
                case "r"://reamur
                    c = reamur(temp);
                    break;
                default :
                    break;

            }

            answer[0, 0] = "Celsius: ";
            answer[0, 1] = "Fahrenheit: ";
            answer[0, 2] = "Kelvin: ";
            answer[0, 3] = "Reamur: ";

            answer[1,0] = c.ToString(); //celsius;
            answer[1,1] = (c * 1.8f + 32).ToString(); //fahrenheit;
            answer[1,2] = (c + 273.15f).ToString();// kelvin;
            answer[1,3] = (c * 0.8f).ToString();//reamur;

            return answer;
        }

        private static float fahrenheit(float temp)
        {
            return (temp - 32) * (5f / 9f);
        }

        private static float kelvin (float temp)
        {
            return temp - 273.15f;
        }

        private static float reamur(float temp)
        {
            return temp * 1.25f;
        }

        private static void print_out(string[,] answer)
        {

          
            for (int i = 0; i < answer.GetLength(1); i++)
            {
                Console.WriteLine(answer[0, i] + " " + answer[1, i]);
              
            }
            
            return;
        }
    }
}
