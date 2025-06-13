namespace Task1
{
/*
Задание 1
Создайте приложение калькулятор для перевода числа
из одной системы исчисления в другую. Пользователь с помощью меню выбирает направление перевода. Например,
из десятичной в двоичную. После выбора направления,
пользователь вводит число в исходной системе исчисления.
Приложение должно перевести число в требуемую систему. Предусмотреть случай выхода за границы диапазона,
определяемого типом int, неправильный ввод.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] options = {
                "Десятичная → Двоичная",
                "Двоичная → Десятичная",
                "Десятичная → Шестнадцатеричная",
                "Шестнадцатеричная → Десятичная",
                "Выход"
            };

            Calculator calc = new Calculator();

            while (true)
            {
                int choice = Menu.ShowMenu(options);

                if (choice == 4) // "Выход"
                    break;

                int fromBase = 10, toBase = 2;
                string prompt = "";

                switch (choice)
                {
                    case 0:
                        fromBase = 10; toBase = 2;
                        prompt = "Введите десятичное число:";
                        break;
                    case 1:
                        fromBase = 2; toBase = 10;
                        prompt = "Введите двоичное число:";
                        break;
                    case 2:
                        fromBase = 10; toBase = 16;
                        prompt = "Введите десятичное число:";
                        break;
                    case 3:
                        fromBase = 16; toBase = 10;
                        prompt = "Введите шестнадцатеричное число:";
                        break;
                }

                Console.Clear();
                Console.WriteLine(prompt);
                string input = Input.UserInput.GetStringFromUser();

                try
                {
                    string result = calc.CalculatorTo(input, fromBase, toBase);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }                
        }




    }
}
