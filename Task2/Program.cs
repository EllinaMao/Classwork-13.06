namespace Task2
{/*
  * Задание 2
Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру. Например, если
пользователь ввёл five, приложение должно вывести на
экран 5.
  */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введте словами цифру от 0 до 9. Приложение должно перевести слово в цифру.");
            string UserInput = Input.UserInput.GetStringFromUser();
            int? num = Task2.ConverterStoI(UserInput);
            if (num is int val)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Error");
            }



        }
    }
}
