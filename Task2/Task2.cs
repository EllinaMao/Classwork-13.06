using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Задание 2
Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру. Например, если
пользователь ввёл five, приложение должно вывести на
экран 5.
  */
namespace Task2
{
    internal class Task2
    {
        internal static int? ConverterStoI(string source)
        {
            int num = -1;
            bool check = false;
            try
            {
                source = source.ToLower();

                switch (source)
                {
                    case "ноль":
                    case "zero":
                        num = 0;
                        break;
                    case "один":
                    case "one":
                        num = 1;
                        break;
                    case "два":
                    case "two":
                        num = 2;
                        break;
                    case "три":
                    case "three":
                        num = 3;
                        break;
                    case "четыре":
                    case "four":
                        num = 4;
                        break;
                    case "пять":
                    case "five":
                        num = 5;
                        break;
                    case "шесть":
                    case "six":
                        num = 6;
                        break;
                    case "семь":
                    case "seven":
                        num = 7;
                        break;
                    case "восемь":
                    case "eight":
                        num = 8;
                        break;
                    case "девять":
                    case "nine":
                        num = 9;
                        break;
                    default:
                        check = true;
                        throw new Exception("Необрабатываемая надпись");
                        break;
                }

                return num;
            }
            catch (Exception ex) when (check== true)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
