using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
    /*
             Задание 3
        Создайте класс «Заграничный паспорт». Вам необходимо
        хранить информацию о номере паспорта, ФИО владельца,
        дате выдачи и т.д. Предусмотреть механизмы для инициализации полей класса. Если значение для инициализации
        неверное, генерируйте исключение.*/
    internal class ForeinPassport
    {
        private string _fullName = string.Empty; 
        public string FullName
        {
            get => _fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Full name cannot be empty.", nameof(FullName));
                _fullName = value;
            }
        }

        private string _passportNumber = string.Empty; 
        public string PassportNumber
        {
            get => _passportNumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Passport number cannot be empty.", nameof(PassportNumber));
                _passportNumber = value;
            }
        }

        private DateTime _theDateOfIssue;
        public DateTime TheDateOfIssue
        {
            get => _theDateOfIssue;
            private set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Date of issue cannot be in the future.", nameof(TheDateOfIssue));
                _theDateOfIssue = value;
            }
        }

        public ForeinPassport(string fullName, string passportNumber, DateTime theDateOfIssue)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name cannot be empty.", nameof(fullName));
            if (string.IsNullOrWhiteSpace(passportNumber))
                throw new ArgumentException("Passport number cannot be empty.", nameof(passportNumber));
            if (theDateOfIssue > DateTime.Now)
                throw new ArgumentException("Date of issue cannot be in the future.", nameof(theDateOfIssue));

            FullName = fullName;
            PassportNumber = passportNumber;
            TheDateOfIssue = theDateOfIssue;
        }
    }
}
