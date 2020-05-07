using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Connect_Arduino
{

    public partial class Form1 : Form
    {

        ArduinoConnectSerial Arduino1 ;

        public Form1()
        {
            InitializeComponent();
            Arduino1 = new ArduinoConnectSerial(ButtonVerbinden, ButtonTrennen, ButtonBlinken, textBoxPort);
            ButtonTrennen.Visible = false;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Arduino1.Trennen();
        }
    }
}
