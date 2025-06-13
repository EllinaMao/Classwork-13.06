using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    /*Пользователь вводит в строку с клавиатуры логическое
выражение. Например, 3>2 или 7<3. Программа должна
посчитать результат введенного выражения и дать результат true или false. В строке могут быть только целые числа
и операторы: <, >, <=, >=, ==, !=. Для обработки ошибок
ввода используйте механизм исключений.*/
    internal class LoficArifmetic
    {
        public static bool ConverUserToBool(string input)
        {
            // Регулярное выражение для поиска двух целых чисел и оператора между ними
            string pattern = @"^\s*(-?\d+)\s*(<=|>=|==|!=|<|>)\s*(-?\d+)\s*$";
            var match = Regex.Match(input, pattern);

            if (!match.Success)
                throw new ArgumentException("Invalid input format. Example: 3>2");

            int left = int.Parse(match.Groups[1].Value);
            string op = match.Groups[2].Value;
            int right = int.Parse(match.Groups[3].Value);

            return op switch
            {
                "<" => left < right,
                ">" => left > right,
                "<=" => left <= right,
                ">=" => left >= right,
                "==" => left == right,
                "!=" => left != right,
                _ => throw new ArgumentException("Unknown operator.")
            };
        }
    }
}