using exam.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace exam.controllers
{
    public class AutorizateController
    {
        public Users FindUserByLoginAndPassword(string login, string password)
        {
            if(login == "")
            {
                throw new Exception("Логин не заполнен !");
            }
            if (password == "")
            {
                throw new Exception("Пароль не заполнен !");
            }
            Users user;
            user = DbConnection.Examentities.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            if(user == null)
            {
                throw new Exception("Пользователя с такими данными не существует !");
            }
            return user;
        }
    }
}
