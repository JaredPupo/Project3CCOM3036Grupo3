using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccom3036Project3
{
    public partial class receipt : Form
    {
        public receipt()
        {
            InitializeComponent();
            
        }
        private void receipt_Load(object sender, EventArgs e)
        {
            fullname.Text = Form1.fullname;
            flight.Text = Form1.flight;
            flighttime.Text = Form1.flighttime;
            price.Text = Form1.price;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
