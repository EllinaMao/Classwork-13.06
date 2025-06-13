namespace Task3
{/*
  Задание 3
Создайте класс «Заграничный паспорт». Вам необходимо
хранить информацию о номере паспорта, ФИО владельца,
дате выдачи и т.д. Предусмотреть механизмы для инициализации полей класса. Если значение для инициализации
неверное, генерируйте исключение.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Пример корректных данных
                var passport = new ForeinPassport(
                    fullName: "Олексей Иванов Папайков",
                    passportNumber: "AB1234567",
                    theDateOfIssue: new DateTime(2020, 5, 15)
                );

                Console.WriteLine("Паспорт успешно создан!");
                Console.WriteLine($"ФИО: {passport.FullName}");
                Console.WriteLine($"Номер: {passport.PassportNumber}");
                Console.WriteLine($"Дата выдачи: {passport.TheDateOfIssue:dd.MM.yyyy}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
