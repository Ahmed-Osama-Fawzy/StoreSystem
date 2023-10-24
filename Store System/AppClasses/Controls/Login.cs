using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class;

namespace Store_System.AppClasses
{
    internal class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public int ID { get; set; }
        public DataBase DB = new DataBase("dbo", "Users");
        public Login(string U , string P) 
        {
            Username = U;
            Password = P;
        }
        public bool SearchAccount()
        {
            bool Finded = false;
            DataTable dt = DB.Select("ID","Username", "Password", "AccountType");
            if(dt.Rows.Count > 0 )
            {
                for(int i = 0 ; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (Convert.ToString(dr["Username"]) == Username && Convert.ToString(dr["Password"]) == Password)
                    {
                        AccountType = Convert.ToString(dr["AccountType"]);
                        ID = Convert.ToInt32(dr["ID"]);
                        Finded = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا لا يوجد مستخدمين ختي الان");
            }
            return Finded;
        }
        public string Type() 
        {
            if (!string.IsNullOrEmpty(AccountType))
                return AccountType; 
           return null;
        }
    }
}
