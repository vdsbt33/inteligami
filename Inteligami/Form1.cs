using Inteligami.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inteligami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            materialsGrid.DataSource = MaterialController.Instance.AvaibleStock;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            expensesGrid.DataSource = MaterialController.Instance.GetMaths(Convert.ToInt32(calcAmountNud.Text));
        }
    }
}
