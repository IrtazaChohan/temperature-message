using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperature_message
{
    public partial class Frmtemperaturemessage : Form
    {
        public Frmtemperaturemessage()
        {
            InitializeComponent();
        }

        private void btnFormOpen_Click(object sender, EventArgs e)
        {
            FrmUser f = new FrmUser();
            //f.Show();

            f.ShowDialog();

        }

        private void Frmtemperaturemessage_Load(object sender, EventArgs e)
        {

        }

        int temperature = 0;
        private void btnCalcuate_Click(object sender, EventArgs e)
        {
            temperature = int.Parse(txttemperature.Text);
            if(temperature < 0)
            {
                lblResult.Text = "Freezing weather!";
                lblResult.Visible = true;
            }
            else if(temperature >= 0 && temperature < 10)
            {
                lblResult.Text = "Very Cold weather";
                lblResult.Visible = true;
            }
            else if (temperature >= 10 && temperature < 20)
            {
                lblResult.Text = "Cold weather";
                lblResult.Visible = true;
            }
            else if (temperature >= 20 && temperature < 30)
            {
                lblResult.Text = "Normal";
                lblResult.Visible = true;
            }
            else if (temperature >= 30 && temperature < 40)
            {
                lblResult.Text = "Its Hot";
                lblResult.Visible = true;
            }
            else if (temperature >= 40)
            {
                lblResult.Text = "Its Very Hot!";
                lblResult.Visible = true;
            }
        }
    }
}
