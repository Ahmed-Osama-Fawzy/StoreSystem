using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Store_System.AppClasses;
namespace Store_System.Bills.CustomerBills
{
    public partial class EnterCustomer : Form
    {
        public EnterCustomer()
        {
            InitializeComponent();
            AppClasses.Customer customer = new AppClasses.Customer();
            Clients.DataSource = customer.GetCustomers();
        }

        private void EnterCustomer_Load(object sender, EventArgs e)
        {
            String search = Clients.Text;

            if (String.IsNullOrEmpty(search))
            {
                Clients.Items.Clear();
                Clients.Items.AddRange(_animals.ToArray());
            }

            var items = (from a in _animals
                         where a.StartsWith(search)
                         select a).ToArray<String>();

            Clients.Items.Clear();
            Clients.Items.AddRange(items);
        }
    }
}
