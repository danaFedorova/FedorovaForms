using FedorovaForms;
using Microsoft.VisualBasic.Logging;
using NUnit.Framework;
using static FedorovaForms.RegisterForm;

namespace FedorovaTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// ���������� ������ ��� �heckDoctorData.
        /// � ������� �������� ������ ������ � �������, ��������������� �����������.
        /// </summary>
        [TestCase("DoctorSuperBest123!")]
        [TestCase("DoctorSuperBest123$")]
        [TestCase("DoctorSuperBest13@")]
        [TestCase("DoctorSuperBest13#")]
        [TestCase("DoctorSuper$Best13")]
        [TestCase("DoctorSuperbest13%")]
        [TestCase("DoctorSuperBest13^")]
        [TestCase("DoctorSuperBes&t13")]
        [TestCase("Doctorsu*perBest13")]
        public void T_001_�heckDoctorData_BaseFlow(string value)
        {
            //���������� ������
            String login = "myname_doctor";
            String password = value;
            String repPassword = value;
            //��������� ��������
            bool expectedReturnValue = true;
            //���������� ���������� ��� ����������� ��������
            bool actualReturnValue = false;
            //Assert ��� ��������� ����������
            Assert.DoesNotThrow(() =>
            {
                actualReturnValue = RegisterForm.checkDoctorData(login, password, repPassword);
            });
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }

        // ������ �����.
        /// ������������ ������� ���� ����� ������ ������.
        /// </summary>
        [Test]
        public void T_002_�heckDoctorData_EmptyLogin()
        {
            //���������� ������
            String login = "";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            //��������� ��������
            String expectedExceptionMessage = "����� �� ����� ���� ������.";
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ ������ ������.
        /// ������������ ������� ���� ����� ������� �������� ������ ������.
        /// </summary>
        [Test]
        public void T_003_�heckDoctorData_EmptyPassword1()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "";
            String repPassword = "DoctorSuperBest123!";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.EmptyPassword1;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ ������ ������.
        /// ������������ ������� ���� ����� ������� �������� ������ ������.
        /// </summary>
        [Test]
        public void T_004_�heckDoctorData_EmptyPassword2()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.EmptyPassword2;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ �� ���������.
        /// ������������ ���� � ���� ������ ������ ������.
        /// </summary>
        [Test]
        public void T_005_�heckDoctorData_DifferentPasswords()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSupeBest123!";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.DifferentPasswords;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ����� � ������ ���������.
        /// ������������ ���� � ���� ������ � ������ ���� � �� �� ������.
        /// </summary>
        [Test]
        public void T_006_�heckDoctorData_SameLoginPassword()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "myname_doctor";
            String repPassword = "myname_doctor";
            //��������� ��������

            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.SameLoginPassword;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ ����� 10 ��������.
        /// ������������ ���� ������ ����� 10 ��������.
        /// </summary>
        [Test]
        public void T_007_�heckDoctorData_PasswordLess10Chars()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "Doc123!";
            String repPassword = "Doc123!";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.PasswordLess10Chars;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ �� �������� ����.
        /// ������������ ���� ������ ��� ����.
        /// </summary>
        [Test]
        public void T_008_�heckDoctorData_PasswordNoNumber()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest!";
            String repPassword = "DoctorSuperBest!";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.PasswordNoNumber;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ �� �������� ������������.
        /// ������������ ���� ������ ��� �������� �@#$%^&*!�.
        /// </summary>
        [Test]
        public void T_009_�heckDoctorData_PasswordNoExtraChar()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123";
            String repPassword = "DoctorSuperBest123";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.PasswordNoExtraChar;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ������ �� �������� ����� � ������� ��������.
        /// ������������ ���� ������ ��� ���� � ������� ��������.
        /// </summary>
        [Test]
        public void T_010_�heckDoctorData_PasswordNoUpperChar()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "doctorsuperbest123!";
            String repPassword = "doctorsuperbest123!";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.PasswordNoUpperChar;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ����������� ������ ������.
        /// ����� �������� ����������� �������.
        /// </summary>
        [Test]
        public void T_011_�heckDoctorData_LoginForbidden()
        {
            //���������� ������
            String login = "myname_doctor!";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.LoginForbidden;
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                RegisterForm.checkDoctorData(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        public static class ManageClass
        {
            public static int index = 3;
            public static IDatabaseController GetDatabaseController()
            {
#if DEBUG
                switch (index)
                {
                    case 0: throw new NotImplementedException(); break;
                    case 1: return new MockDatabaseController_NoConnection(); break;
                    case 2: return new MockDatabaseController_LoginExists(); break;
                    case 3: return new MockDatabaseController_OK(); break;
                }
                return null;
#else
throw new NotImplementedException();
#endif
            }
#if DEBUG
            public class MockDoctorEntry : IDoctorEntry
            {
                public string ID { get; set; }
                public string Login { get; set; }
                public string Password { get; set; }
            }
            public class MockDatabaseController_NoConnection : IDatabaseController
            {
                public IDoctorEntry getNewDoctorEntry() { throw new NotImplementedException(); }
                public bool login(string login, string password)
                {
                    throw new NotImplementedException();
                }
                public bool tryConnectDB() { return false; }
                public bool tryCreateAccount(string login, string password)
                {
                    throw new
                NotImplementedException();
                }
            }
            public class MockDatabaseController_LoginExists : IDatabaseController
            {
                public IDoctorEntry getNewDoctorEntry() { throw new NotImplementedException(); }
                public bool login(string login, string password) { return true; }
                public bool tryConnectDB() { return true; }
                public bool tryCreateAccount(string login, string password) { return false; }
            }

            public class MockDatabaseController_OK : IDatabaseController
            {
                MockDoctorEntry doctorEntry;
                public IDoctorEntry getNewDoctorEntry() { return doctorEntry; }
                public bool login(string login, string password) { return true; }
                public bool tryConnectDB() { return true; }
                public bool tryCreateAccount(string login, string password)
                {
                    doctorEntry = new
                MockDoctorEntry()
                    { ID = "1", Login = login, Password = password }; return true;
                }
            }
#endif
        }

        /// <summary>
        /// ����������� �������.
        /// ������� ����������� ��������.
        /// </summary>
        [Test]
        public void T_012_onRegisterClick_BasicFlow()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            //���������� ������
            RegisterForm registerForm = new RegisterForm();
            registerForm.controller = new ManageClass.MockDatabaseController_OK();
            IDoctorEntry doctorEntry = null;
            //Assert ��� ��������� ����������
            Assert.DoesNotThrow(() =>
            {
                doctorEntry = registerForm.onRegisterClick(login, password, repPassword);
            });
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.IsNotNull(doctorEntry);
            Assert.AreEqual(doctorEntry.Login, login);
            Assert.AreEqual(doctorEntry.Password, password);
        }

        /// <summary>
        /// ���������� ����������� � ��.
        /// ��� ������� � ���� ������, ������� �� ����� ������������������.
        /// </summary>
        [Test]
        public void T_013_onRegisterClick_NoConnectionDB()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.NoConnectionDB;
            RegisterForm registerForm = new RegisterForm();
            registerForm.controller = new ManageClass.MockDatabaseController_NoConnection();
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                registerForm.onRegisterClick(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        /// <summary>
        /// ���������� ����������� � ��.
        /// ��� ������� � ���� ������, ������� �� ����� ������������������.
        /// </summary>
        [Test]
        public void T_014_onRegisterClick_LoginAlreadyExists()
        {
            //���������� ������
            String login = "myname_doctor";
            String password = "DoctorSuperBest123!";
            String repPassword = "DoctorSuperBest123!";
            //��������� ��������
            String expectedExceptionMessage = FedorovaForms.ExceptionStrings.LoginAlreadyExists;
            RegisterForm registerForm = new RegisterForm();
            registerForm.controller = new ManageClass.MockDatabaseController_LoginExists();
            //Assert ��� ��������� ����������
            Exception? exception = Assert.Throws<Exception>(() =>
            {
                registerForm.onRegisterClick(login, password, repPassword);
            });
            Assert.IsNotNull(exception);
            //Assert ��� �������� ���������� � ����������� ��������
            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }
    }
}