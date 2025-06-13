using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{/*Задание 1
Создайте приложение калькулятор для перевода числа
из одной системы исчисления в другую. Пользователь с помощью меню выбирает направление перевода. Например,
из десятичной в двоичную. После выбора направления,
пользователь вводит число в исходной системе исчисления.
Приложение должно перевести число в требуемую систему. Предусмотреть случай выхода за границы диапазона,
определяемого типом int, неправильный ввод.*/
    internal class Calculator
    {
        public string CalculatorTo(string input, int fromBase, int toBase)
        {
            try
            {

                int number = Convert.ToInt32(input, fromBase);
                if (number < int.MinValue || number > int.MaxValue)
                    throw new ArgumentException("Число выходит за пределы типа int.");
                return Convert.ToString(number, toBase).ToUpper();
            }

            catch (FormatException)
            {
                throw new ArgumentException("Некорректный ввод числа.");
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Число выходит за пределы типа int.");
            }
        }
    }


}
