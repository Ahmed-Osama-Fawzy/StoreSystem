using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class;

namespace Store_System.AppClasses
{
    internal class User
    {
        public int  UserID { get; set; }
        public string Date { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public DataBase DB = new DataBase("dbo", "Users");
        public bool Insert()
        {
            Login Users = new Login(Username, Password);
            bool Inserted = false;
            if (!Users.SearchAccount())
            {
                Inserted = DB.Insert("Username", Username, "false","Password",Password,"false","AccountType",AccountType,"false"); 
            }
            else
            {
                MessageBox.Show("هذا الحساب موجود مسبقا");
            }
            return Inserted;
        }
    }
}
