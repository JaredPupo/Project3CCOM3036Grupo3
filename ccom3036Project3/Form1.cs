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

namespace ccom3036Project3
{
    public partial class Form1 : Form
    {
        private IFlightRepository flightRepository;
        private ICustomerRepository customerRepository;
        private IBookingRepository bookingRepository;
        public static string fullname;
        public static string flight;
        public static string flighttime;
        public static string price;
        
        public Form1()
        {
            InitializeComponent();

            flightRepository = new FlightRepository();
            customerRepository = new CustomerRepository();
            bookingRepository = new BookingRepository();

        }

        private void Idayvueltapanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idayvuelta_Click(object sender, EventArgs e)
        {
            idapanel.Visible = false;
            idalabel.Visible = false;
            idaflight1.Visible = false;
            idaflight1label.Visible = false;
            idaflight2label.Visible = false;
            idaflight2.Visible = false;
            Idayvueltapanel.Visible = true;
            iyvlabel.Visible = true;
            iyvflight1.Visible = true;
            iyvflight1label.Visible = true;
            iyvflight2label.Visible = true;
            iyvflight2.Visible = true;
            bookflightbutton.Visible = true;
            bookflightpanel.Visible = true;
            bookinglabel.Visible = true;
            Flightname.Visible = true;
            fnamelabel.Visible = true;
            fnametext.Visible = true;
            lnametext.Visible = true;
            lastnamelabel.Visible = true;
            flightPrice.Visible = true;
            flightTimeLabel.Visible = true;
            flightPriceLabel.Visible = true;
            flightPrice.Visible = true;
            flightTimeBox.Visible = true; 
            bookflightbutton.Visible = true;
        }

        private void idabutton_Click(object sender, EventArgs e)
        {
            Idayvueltapanel.Visible = false;
            iyvlabel.Visible = false;
            iyvflight1.Visible = false;
            iyvflight1label.Visible = false;
            iyvflight2label.Visible = false;
            iyvflight2.Visible = false;
            idapanel.Visible = true;
            idalabel.Visible = true;
            idaflight1.Visible = true;
            idaflight1label.Visible = true;
            idaflight2label.Visible = true;
            idaflight2.Visible = true;
            bookflightbutton.Visible = true;
            bookflightpanel.Visible = true;
            bookinglabel.Visible = true;
            Flightname.Visible = true;
            fnamelabel.Visible = true;
            fnametext.Visible = true;
            lnametext.Visible = true;
            lastnamelabel.Visible = true;
            flightPriceLabel.Visible = true;
            flightPrice.Visible = true;
            flightTimeLabel.Visible = true;
            flightTimeBox.Visible = true;
            flightPriceLabel.Visible = true;
            flightPrice.Visible = true;
            bookflightbutton.Visible = true;
        }

        private void iyvflight1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iyvflight1_Click(object sender, MouseEventArgs e)
        {
            iyvflight2.BackColor = Color.LightGray;
            iyvflight1.BackColor = Color.LightBlue;
            Flightname.Text = iyvflight1label.Text;
            flightPrice.Text = "$300";

        }

        private void iyvflight1label_Click(object sender, EventArgs e)
        {
            iyvflight2.BackColor = Color.LightGray;
            iyvflight1.BackColor = Color.LightBlue;
            Flightname.Text = iyvflight1label.Text;
            flightPrice.Text = "$300";
        }

        private void iyvflight2label_Click(object sender, EventArgs e)
        {
            iyvflight1.BackColor = Color.LightGray;
            iyvflight2.BackColor = Color.LightBlue;
            Flightname.Text = iyvflight2label.Text;
            flightPrice.Text = "$400";
        }

        private void iyvflight2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void iyvflight2_Click(object sender, MouseEventArgs e)
        {
            iyvflight1.BackColor = Color.LightGray;
            iyvflight2.BackColor = Color.LightBlue;
            Flightname.Text = iyvflight2label.Text;
            flightPrice.Text = "$400";

        }

        private void idaflight1label_MouseClick(object sender, MouseEventArgs e)
        {
            idaflight2.BackColor = Color.LightGray;
            idaflight1.BackColor = Color.LightBlue;
            Flightname.Text = idaflight1label.Text;
            flightPrice.Text = "$100";
        }

        private void idaflight1_MouseClick(object sender, MouseEventArgs e)
        {
            idaflight2.BackColor = Color.LightGray;
            idaflight1.BackColor = Color.LightBlue;
            Flightname.Text = idaflight1label.Text;
            flightPrice.Text = "$100";
        }

        private void idaflight2label_MouseClick(object sender, MouseEventArgs e)
        {
            idaflight1.BackColor = Color.LightGray;
            idaflight2.BackColor = Color.LightBlue;
            Flightname.Text = idaflight2label.Text;
            flightPrice.Text = "$100";
        }

        private void idaflight2_MouseClick(object sender, MouseEventArgs e)
        {
            idaflight1.BackColor = Color.LightGray;
            idaflight2.BackColor = Color.LightBlue;
            Flightname.Text = idaflight2label.Text;
            flightPrice.Text = "$100";

        }

        private void bookflightbutton_Click(object sender, EventArgs e)
        {
            if (Flightname.Text == "" || fnametext.Text == "" || lnametext.Text == "" || flightTimeBox.Text == "Select Time")
            {
                MessageBox.Show("Enter correct Values", "Missing Values");
            }
            else
            {
                fullname = fnametext.Text + " " + lnametext.Text;
                flight = Flightname.Text;
                flighttime = flightTimeBox.Text;
                price = flightPrice.Text;

                receipt form2 = new receipt();
                form2.Show();
                Hide();
            }
        }

        private void flightTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

