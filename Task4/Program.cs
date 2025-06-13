namespace Task4
{/*Задание 4
Пользователь вводит в строку с клавиатуры логическое
выражение. Например, 3>2 или 7<3. Программа должна
посчитать результат введенного выражения и дать результат true или false. В строке могут быть только целые числа
и операторы: <, >, <=, >=, ==, !=. Для обработки ошибок
ввода используйте механизм исключений.*/
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите в строку с клавиатуры логическое\r\nвыражение. Например, 3>2 или 7<3.");
            string input = Input.UserInput.GetStringFromUser();
            bool result = LoficArifmetic.ConverUserToBool(input);
            Console.WriteLine(result);

        }
    }
}
