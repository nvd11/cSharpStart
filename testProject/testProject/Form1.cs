using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using com.model;
using compassModels.model;
using com.testProject.test;

namespace com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void btnTest1_Click(object sender, EventArgs e)
        {
            this.tbClientName.Text = "hello";

        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            Product prod = new Product();
            prod.ProdName = "prodName1";

            this.tbClientName.Text = prod.ProdName;


        }
      
        private void btnTestOdbc_Click(object sender, EventArgs e)
        {
            OdbcTest ot = new OdbcTest();
            ot.connectODBC();


        }





     
    }
}
