using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Connect_Arduino
{
    class ArduinoConnectSerial
    {

        private SerialPort Verbindung;
        private Button ButtonVerbinden;
        private Button ButtonTrennen;
        private Button ButtonBlinken;
        private TextBox TextBoxPort;


        public ArduinoConnectSerial(object _ButtonVerbinden, object _ButtonTrennen, object _ButtonBlinken, object _TextBoxPort)
        {
            ButtonVerbinden = (Button)_ButtonVerbinden;
            ButtonVerbinden.Click += new EventHandler(ButtonVerbinden_Click);

            ButtonTrennen = (Button)_ButtonTrennen;
            ButtonTrennen.Click += new EventHandler(ButtonTrennen_Click);

            ButtonBlinken = (Button)_ButtonBlinken;
            ButtonBlinken.Click += new EventHandler(ButtonBlinken_Click);

            TextBoxPort = (TextBox)_TextBoxPort;
         }
        
        private void ButtonVerbinden_Click(object sender, EventArgs e)
        {
            Verbinden(TextBoxPort.Text);
            ButtonVerbinden.Visible = false;
            ButtonTrennen.Visible = true;
        }

        private void ButtonTrennen_Click(object sender, EventArgs e)
        {
            Trennen();
            ButtonVerbinden.Visible = true;
            ButtonTrennen.Visible = false;
        }

        private void ButtonBlinken_Click(object sender, EventArgs e)
        {
            NachrichtSenden("blink");
        }

        public void NachrichtSenden(string nachricht)
        {
            if (Verbindung != null && Verbindung.IsOpen)
            {
                Verbindung.WriteLine(nachricht);
            }
        }

        public void Verbinden(string port)
        {
            Verbindung = new SerialPort(port, 9600);
            Verbindung.NewLine = "\n";
            Verbindung.Open();
            NachrichtSenden("verbunden");
          }

        public void Trennen() //TODO: mehr Befehle  einfügen
        {
            if (Verbindung != null && Verbindung.IsOpen)
            {
                NachrichtSenden("trennen");
                Verbindung.Close();
            }

        }

    }
}
