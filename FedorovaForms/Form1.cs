namespace FedorovaForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public static bool checkDoctorData(string login,
string password,
string repPassword)
        {
            if (login == null || login.Length == 0)
            {
                throw new Exception("Логин не может быть пустым.");
            }

            if (password == null || password.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyPassword1);
            }
            if (repPassword == null || repPassword.Length == 0)
            {
                throw new Exception(ExceptionStrings.EmptyPassword2);
            }

            if (password != repPassword)
            {
                throw new Exception(ExceptionStrings.DifferentPasswords);
            }
            if (login == password)
            {
                throw new Exception(ExceptionStrings.SameLoginPassword);
            }

            if (password.Length < 10)
            {
                throw new Exception(ExceptionStrings.PasswordLess10Chars);
            }
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions
            .Regex(@"[0-9]");
            if (!regex.IsMatch(password))
            {
                throw new Exception(ExceptionStrings.PasswordNoNumber);
            }
            regex = new System.Text.RegularExpressions.Regex(@"[@#$%^&*!]");
            if (!regex.IsMatch(password))
            {
                throw new Exception(ExceptionStrings.PasswordNoExtraChar);
            }
            regex = new System.Text.RegularExpressions.Regex(@"[A-ZА-Я]");
            if (!regex.IsMatch(password))
            {
                throw new Exception(ExceptionStrings.PasswordNoUpperChar);
            }

            regex = new System.Text.RegularExpressions.Regex(@"^[0-9A-ZА-Яa-zа-я_]+$");
            if (!regex.IsMatch(login))
            {
                throw new Exception(ExceptionStrings.LoginForbidden);
            }

            return true;
        }

        public IDatabaseController controller = null;
        public IDoctorEntry onRegisterClick(string login, string password, string repPassword)
        {
            if (checkDoctorData(login, password, repPassword))
            {
                if (controller.tryConnectDB())
                {
                    if (controller.tryCreateAccount(login, password))
                    {
                        IDoctorEntry doctor = controller.getNewDoctorEntry();
                        controller.login(doctor.Login, doctor.Password);
                        return doctor;
                    }
                    else
                    {
                        throw new Exception(ExceptionStrings.LoginAlreadyExists);
                    }
                }
                else
                {
                    throw new Exception(ExceptionStrings.NoConnectionDB);
                }
            }
            return null;
        }
    }

    public interface IDoctorEntry
    {
        public string ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public interface IDatabaseController
    {
        public bool tryConnectDB();
        public bool tryCreateAccount(string login, string password);
        public IDoctorEntry getNewDoctorEntry();
        public bool login(string login, string password);
    }
}
