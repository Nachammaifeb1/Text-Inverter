using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextInverterClient.ServiceReference1;
namespace TextInverterClient
{
    public partial class Form1 : Form
    {
        TextInverterWebServiceSoapClient obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            obj = new TextInverterWebServiceSoapClient();
            string inverted = obj.TextInverter(txtinput.Text);
            MessageBox.Show("Inverted string is :"+inverted);


        }
    }
}
