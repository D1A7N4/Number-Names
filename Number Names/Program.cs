using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            do
            {
                Console.WriteLine("Please enter a positive integer input no greater than 1000000 or enter END to stop the program");
                number = Console.ReadLine();
                if (int.Parse(number) == 1000000)
                {
                    Console.WriteLine("One Million");
                }
                else if (number.Length == 6)
                {
                    Console.WriteLine(Hundred(number, 3) + Ten(number, 3) + Unit(number, 3) + "Thousand " + Hundred(number, 0) + Ten(number, 0) + Unit(number, 0));
                }
                else if (number.Length == 5)
                {
                    Console.WriteLine(Ten(number, 3) + Unit(number, 3) + "Thousand " + Hundred(number, 0) + Ten(number, 0) + Unit(number, 0));
                }
                else if (number.Length == 4)
                {
                    Console.WriteLine(Unit(number, 3) + "Thousand " + Hundred(number, 0) + Ten(number, 0) + Unit(number, 0));
                }
                else if (number.Length == 3)
                {
                    Console.WriteLine(Hundred(number, 0) + Ten(number, 0) + Unit(number, 0));
                }
                else if (number.Length == 2)
                {
                    Console.WriteLine(Ten(number, 0) + Unit(number, 0));
                }
                else if (number.Length == 1)
                {
                    Console.WriteLine(Unit(number, 0));
                }
            } while (number != "END");
        }
        static string Hundred(string number, int k)
        {
            if (number[number.Length - (3 + k)]=='1')
            {
                if(number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "One Hundred ";
                }
                else
                {
                    return "One Hundred and ";
                }
            }
            else if (number[number.Length - (3 + k)] == '2')
            {
                if (number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "Two Hundred ";
                }
                else
                {
                    return "Two Hundred and ";
                }
            }
            else if (number[number.Length - (3 + k)] == '3')
            {
                if (number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "Three Hundred ";
                }
                else
                {
                    return "Three Hundred and ";
                }
            }
            else if (number[number.Length - (3 + k)] == '4')
            {
                if (number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "Four Hundred ";
                }
                else
                {
                    return "Four Hundred and ";
                }
            }
            else if (number[number.Length - (3 + k)] == '5')
            {
                if (number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "Five Hundred ";
                }
                else
                {
                    return "Five Hundred and ";
                }
            }
            else if (number[number.Length - (3 + k)] == '6')
            {
                if (number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "Six Hundred ";
                }
                else
                {
                    return "Six Hundred and ";
                }
            }
            else if (number[number.Length - (3 + k)] == '7')
            {
                if (number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "Seven Hundred ";
                }
                else
                {
                    return "Seven Hundred and ";
                }
            }
            else if (number[number.Length - (3 + k)] == '8')
            {
                if (number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "Eight Hundred ";
                }
                else
                {
                    return "Eight Hundred and ";
                }
            }
            else if (number[number.Length - (3 + k)] == '9')
            {
                if (number[number.Length - (2 + k)] == '0' & number[number.Length - (1 + k)] == '0')
                {
                    return "Nine Hundred ";
                }
                else
                {
                    return "Nine Hundred and ";
                }
            }
            else
            {
                return "";
            }
        }
        static string Ten(string number, int k)
        {
            if (number[number.Length - (2 + k)] == '1')
            {
                if (number[number.Length - (1 + k)] == '1')
                {
                    return "Eleven ";
                }
                else if (number[number.Length - (1 + k)] == '2')
                {
                    return "Twelve ";
                }
                else if (number[number.Length - (1 + k)] == '3')
                {
                    return "Thriteen ";
                }
                else if (number[number.Length - (1 + k)] == '4')
                {
                    return "Fourteen ";
                }
                else if (number[number.Length - (1 + k)] == '5')
                {
                    return "Fifteen ";
                }
                else if (number[number.Length - (1 + k)] == '6')
                {
                    return "Sixteen ";
                }
                else if (number[number.Length - (1 + k)] == '7')
                {
                    return "Seventeen ";
                }
                else if (number[number.Length - (1 + k)] == '8')
                {
                    return "Eighteen ";
                }
                else if (number[number.Length - (1 + k)] == '9')
                {
                    return "Nineteen ";
                }
                else
                {
                    return "Ten ";
                }

            }
            else if (number[number.Length - (2 + k)] == '2')
            {
                return "Twenty ";
            }
            else if (number[number.Length - (2 + k)] == '3')
            {
                return "Thirty ";
            }
            else if (number[number.Length - (2 + k)] == '4')
            {
                return "Fourty ";
            }
            else if (number[number.Length - (2 + k)] == '5')
            {
                return "Fifty ";
            }
            else if (number[number.Length - (2 + k)] == '6')
            {
                return "Sixty ";
            }
            else if (number[number.Length - (2 + k)] == '7')
            {
                return "Seventy ";
            }
            else if (number[number.Length - (2 + k)] == '8')
            {
                return "Eighty ";
            }
            else if (number[number.Length - (2 + k)] == '9')
            {
                return "Ninety ";
            }
            else
            {
                return "";
            }
        }
        static string Unit(string number, int k)
        {
            if(number.Length >= (2+k))
            {
                if (number[number.Length - (2 + k)] == '1')
                {
                    return "";
                }
                else
                {
                    return unitbody(number, k);
                }
            }
            else
            {
                return unitbody(number, k);
            }
        }
        static string unitbody(string number, int k)
        {
            if (number[number.Length - (1 + k)] == '1')
            {
                return "One ";
            }
            else if (number[number.Length - (1 + k)] == '2')
            {
                return "Two ";
            }
            else if (number[number.Length - (1 + k)] == '3')
            {
                return "Three ";
            }
            else if (number[number.Length - (1 + k)] == '4')
            {
                return "Four ";
            }
            else if (number[number.Length - (1 + k)] == '5')
            {
                return "Five ";
            }
            else if (number[number.Length - (1 + k)] == '6')
            {
                return "Six ";
            }
            else if (number[number.Length - (1 + k)] == '7')
            {
                return "Seven ";
            }
            else if (number[number.Length - (1 + k)] == '8')
            {
                return "Eight ";
            }
            else if (number[number.Length - (1 + k)] == '9')
            {
                return "Nine ";
            }
            else
            {
                return "";
            }
        }
    }
}
