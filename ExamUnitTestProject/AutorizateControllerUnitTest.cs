using exam.controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExamUnitTestProject
{
    [TestClass]
    public class AutorizateControllerUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindUserByLoginAndPassword_EmptyLogin_ThrowException()
        {
            AutorizateController autorizateController = new AutorizateController();
            autorizateController.FindUserByLoginAndPassword("", "pass1");
        }

        [TestMethod]
        public void FindUserByLoginAndPassword_EmptyPassword_ThrowExceptionWithErrorParse()
        {
            AutorizateController autorizateController = new AutorizateController();

            string expected = "Ошибка. Пароль не заполнен !";
            string actual = "";
            try
            {
            autorizateController.FindUserByLoginAndPassword("login6", "");
            }
            catch(Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindUserByLoginAndPassword_UserNoyFound_ThrowException()
        {
            AutorizateController autorizateController = new AutorizateController();
            autorizateController.FindUserByLoginAndPassword("1", "1");
        }
    }
}
