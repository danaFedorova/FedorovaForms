using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedorovaForms
{
    public static class ExceptionStrings
    {
        public const string EmptyLogin = "Логин не может быть пустым.";
        public const string EmptyPassword1 = "Пропущено поле первого ввода пароля.";
        public const string EmptyPassword2 = "Пропущено поле второго ввода пароля.";
        public const string DifferentPasswords = "Пароли не совпадают!";
        public const string SameLoginPassword = "Логин и пароль не могут совпадать.";
        public const string PasswordLess10Chars = "Пароль не может быть менее 10 символов.";
        public const string PasswordNoNumber = "Пароль должен содержать хотя бы один символ    цифры.";
public const string PasswordNoExtraChar = "Пароль должен содержать хотя бы один    символ из @#$%^&*! .";
public const string PasswordNoUpperChar = "Пароль должен содержать хотя бы один    символ в верхнем регистре.";
public const string LoginForbidden = "Логин должен состоять только из цифр, букв и    символа _.";

        public const string NoConnectionDB = "Нет доступа к базе данных, проверьте подключение.";
public const string LoginAlreadyExists = "Уже существует пользователь с данным логином.";
}
}
