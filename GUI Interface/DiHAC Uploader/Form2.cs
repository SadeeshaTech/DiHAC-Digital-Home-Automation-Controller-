using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DiHAC_Uploader
{
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();
            
            
        }
       


        private void label8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                string message1 = "COM Port number must be entered";
                string title1 = "COM Port number error";
                MessageBox.Show(message1, title1);
            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == false) && (bunifuCheckbox4.Checked == false) && (bunifuCheckbox5.Checked == false))
            {
                string message2 = "You must edit your configurations first";
                string title2 = "Configuration Error";
                MessageBox.Show(message2, title2);
            }
            else {
                
                //serialPort1.Close();
                serialPort1.PortName = "COM" + textBox1.Text;

                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();

                        if (bunifuCheckbox1.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }
                        if (bunifuCheckbox2.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }
                        if (bunifuCheckbox3.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }
                        if (bunifuCheckbox4.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }
                        if (bunifuCheckbox5.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        textBox55.Text = (textBox2.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));

                        if (bunifuCheckbox12.Checked == true)
                        {
                            textBox55.Text = (textBox4.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else if (bunifuCheckbox11.Checked == true)
                        {
                            textBox55.Text = (textBox5.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }

                        textBox55.Text = (textBox11.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));

                        textBox55.Text = (textBox12.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));

                        textBox55.Text = (textBox13.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));

                        textBox55.Text = (textBox14.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));

                        textBox55.Text = (textBox15.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));

                        for (int i = 0; i < 10; i++)
                        {
                            serialPort1.Write(textBox3.Text.Substring(i, 1));

                        }

                        if (textBox2.Text.Length != 9)
                        {
                            for (int q = 0; q < textBox2.Text.Length; q++)
                            {
                                serialPort1.Write(textBox2.Text.Substring(q, 1));

                            }
                            for (int qq = textBox2.Text.Length; qq < 9; qq++)
                            {
                                serialPort1.Write("*");

                            }
                        }
                        else if (textBox2.Text.Length == 9)
                        {
                            for (int q = 0; q < 9; q++)
                            {
                                serialPort1.Write(textBox2.Text.Substring(q, 1));

                            }
                        }
                        if (bunifuCheckbox12.Checked == true)
                        {
                            if (textBox4.Text.Length != 3)
                            {
                                for (int w = 0; w < textBox4.Text.Length; w++)
                                {
                                    serialPort1.Write(textBox4.Text.Substring(w, 1));

                                }
                                for (int ww = textBox4.Text.Length; ww < 3; ww++)
                                {
                                    serialPort1.Write("*");

                                }
                            }
                            else if (textBox4.Text.Length == 3)
                            {
                                for (int w = 0; w < 3; w++)
                                {
                                    serialPort1.Write(textBox4.Text.Substring(w, 1));

                                }
                            }
                        }
                        if (bunifuCheckbox11.Checked == true)
                        {
                            if (textBox5.Text.Length != 3)
                            {
                                for (int r = 0; r < textBox5.Text.Length; r++)
                                {
                                    serialPort1.Write(textBox5.Text.Substring(r, 1));

                                }
                                for (int rr = textBox5.Text.Length; rr < 3; rr++)
                                {
                                    serialPort1.Write("*");

                                }
                            }
                            else if (textBox5.Text.Length == 3)
                            {
                                for (int r = 0; r < 3; r++)
                                {
                                    serialPort1.Write(textBox5.Text.Substring(r, 1));

                                }
                            }
                        }

                        for (int t = 0; t < 10; t++)
                        {
                            serialPort1.Write(textBox6.Text.Substring(t, 1));

                        }
                        if (textBox7.Text.Length != 0)
                        {
                            for (int y = 0; y < 10; y++)
                            {
                                serialPort1.Write(textBox7.Text.Substring(y, 1));

                            }
                        }
                        else if (textBox7.Text.Length == 0)
                        {
                            for (int y = 0; y < 10; y++)
                            {
                                serialPort1.Write("*");

                            }
                        }

                        if (textBox8.Text.Length != 0)
                        {
                            for (int u = 0; u < 10; u++)
                            {
                                serialPort1.Write(textBox8.Text.Substring(u, 1));

                            }
                        }
                        else if (textBox8.Text.Length == 0)
                        {
                            for (int u = 0; u < 10; u++)
                            {
                                serialPort1.Write("*");

                            }
                        }

                        if (textBox9.Text.Length != 0)
                        {
                            for (int o = 0; o < 10; o++)
                            {
                                serialPort1.Write(textBox9.Text.Substring(o, 1));

                            }
                        }
                        else if (textBox9.Text.Length == 0)
                        {
                            for (int o = 0; o < 10; o++)
                            {
                                serialPort1.Write("*");

                            }
                        }

                        if (textBox10.Text.Length != 0)
                        {
                            for (int p = 0; p < 10; p++)
                            {
                                serialPort1.Write(textBox10.Text.Substring(p, 1));

                            }
                        }
                        else if (textBox10.Text.Length == 0)
                        {
                            for (int p = 0; p < 10; p++)
                            {
                                serialPort1.Write("*");

                            }
                        }
                        if (textBox11.Text.Length != 3)
                        {
                            for (int a = 0; a < textBox11.Text.Length; a++)
                            {
                                serialPort1.Write(textBox11.Text.Substring(a, 1));

                            }
                            for (int aa = textBox11.Text.Length; aa < 3; aa++)
                            {
                                serialPort1.Write("*");

                            }
                        }
                        if (textBox11.Text.Length == 3)
                        {
                            for (int a = 0; a < 3; a++)
                            {
                                serialPort1.Write(textBox11.Text.Substring(a, 1));

                            }
                        }

                        if (textBox12.Text.Length != 3)
                        {
                            for (int d = 0; d < textBox12.Text.Length; d++)
                            {
                                serialPort1.Write(textBox12.Text.Substring(d, 1));

                            }
                            for (int d = textBox12.Text.Length; d < 3; d++)
                            {
                                serialPort1.Write("*");

                            }
                        }
                        if (textBox12.Text.Length == 3)
                        {
                            for (int d = 0; d < 3; d++)
                            {
                                serialPort1.Write(textBox12.Text.Substring(d, 1));

                            }
                        }

                        if (textBox13.Text.Length != 3)
                        {
                            for (int f = 0; f < textBox13.Text.Length; f++)
                            {
                                serialPort1.Write(textBox13.Text.Substring(f, 1));

                            }
                            for (int f = textBox13.Text.Length; f < 3; f++)
                            {
                                serialPort1.Write("*");

                            }
                        }
                        if (textBox13.Text.Length == 3)
                        {
                            for (int f = 0; f < 3; f++)
                            {
                                serialPort1.Write(textBox13.Text.Substring(f, 1));

                            }
                        }

                        if (textBox14.Text.Length != 3)
                        {
                            for (int g = 0; g < textBox14.Text.Length; g++)
                            {
                                serialPort1.Write(textBox14.Text.Substring(g, 1));

                            }
                            for (int g = textBox14.Text.Length; g < 3; g++)
                            {
                                serialPort1.Write("*");

                            }
                        }
                        if (textBox14.Text.Length == 3)
                        {
                            for (int g = 0; g < 3; g++)
                            {
                                serialPort1.Write(textBox14.Text.Substring(g, 1));

                            }

                        }

                        if (textBox15.Text.Length != 3)
                        {
                            for (int h = 0; h < textBox15.Text.Length; h++)
                            {
                                serialPort1.Write(textBox15.Text.Substring(h, 1));

                            }
                            for (int h = textBox15.Text.Length; h < 3; h++)
                            {
                                serialPort1.Write("*");

                            }
                        }
                        if (textBox15.Text.Length == 3)
                        {
                            for (int h = 0; h < 3; h++)
                            {
                                serialPort1.Write(textBox15.Text.Substring(h, 1));

                            }

                        }
                        if (textBox17.Text.Length < 10)
                        {
                            textBox55.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox18.Text.Length < 10)
                        {
                            textBox55.Text = (textBox18.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox19.Text.Length < 10)
                        {
                            textBox55.Text = (textBox19.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox20.Text.Length < 10)
                        {
                            textBox55.Text = (textBox20.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox21.Text.Length < 10)
                        {
                            textBox55.Text = (textBox21.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox25.Text.Length < 10)
                        {
                            textBox55.Text = (textBox25.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox24.Text.Length < 10)
                        {
                            textBox55.Text = (textBox24.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox23.Text.Length < 10)
                        {
                            textBox55.Text = (textBox23.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox22.Text.Length < 10)
                        {
                            textBox55.Text = (textBox22.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox28.Text.Length < 10)
                        {
                            textBox55.Text = (textBox28.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox27.Text.Length < 10)
                        {
                            textBox55.Text = (textBox27.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox26.Text.Length < 10)
                        {
                            textBox55.Text = (textBox26.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox29.Text.Length < 10)
                        {
                            textBox55.Text = (textBox29.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (textBox30.Text.Length < 10)
                        {
                            textBox55.Text = (textBox30.Text.Length).ToString();
                            serialPort1.Write(textBox55.Text.Substring(0, 1));
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        if (bunifuiOSSwitch1.Value == true)
                        {
                            serialPort1.Write("1");
                        }
                        else
                        {
                            serialPort1.Write("0");
                        }

                        for (int j = 0; j < textBox17.Text.Length; j++)
                        {
                            serialPort1.Write(textBox17.Text.Substring(j, 1));

                        }
                        for (int j1 = textBox17.Text.Length; j1 < 10; j1++)
                        {
                            serialPort1.Write("*");

                        }

                        for (int k = 0; k < textBox18.Text.Length; k++)
                        {
                            serialPort1.Write(textBox18.Text.Substring(k, 1));

                        }
                        for (int k1 = textBox18.Text.Length; k1 < 10; k1++)
                        {
                            serialPort1.Write("*");

                        }

                        for (int l = 0; l < textBox19.Text.Length; l++)
                        {
                            serialPort1.Write(textBox19.Text.Substring(l, 1));

                        }
                        for (int l1 = textBox19.Text.Length; l1 < 10; l1++)
                        {
                            serialPort1.Write("*");

                        }

                        for (int z = 0; z < textBox20.Text.Length; z++)
                        {
                            serialPort1.Write(textBox20.Text.Substring(z, 1));

                        }
                        for (int z1 = textBox20.Text.Length; z1 < 10; z1++)
                        {
                            serialPort1.Write("*");

                        }

                        for (int x = 0; x < textBox21.Text.Length; x++)
                        {
                            serialPort1.Write(textBox21.Text.Substring(x, 1));

                        }
                        for (int x1 = textBox21.Text.Length; x1 < 10; x1++)
                        {
                            serialPort1.Write("*");

                        }

                        for (int c = 0; c < textBox25.Text.Length; c++)
                        {
                            serialPort1.Write(textBox25.Text.Substring(c, 1));

                        }
                        for (int c1 = textBox25.Text.Length; c1 < 10; c1++)
                        {
                            serialPort1.Write("*");

                        }

                        for (int v = 0; v < textBox24.Text.Length; v++)
                        {
                            serialPort1.Write(textBox24.Text.Substring(v, 1));

                        }
                        for (int v1 = textBox24.Text.Length; v1 < 10; v1++)
                        {
                            serialPort1.Write("*");

                        }
                        serialPort1.Close();
                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }


                label8.Enabled = false;
                label123.Enabled = true;
                string message3 = "First stage data uploading is completed";
                string title3 = "DiHAC Message Unit";
                MessageBox.Show(message3, title3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            label17.ForeColor = Color.FromArgb(0, 0, 0);
            label17.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void label17_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuCheckbox10_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox10.Checked == true)
            {
                textBox7.Enabled = true;
                textBox12.Enabled = true;

            }
            else {
                textBox7.Enabled = false;
                textBox12.Enabled = false;
            }
          
        }

        private void bunifuCheckbox9_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox9.Checked == true)
            {
                textBox8.Enabled = true;
                textBox13.Enabled = true;

            }
            else
            {
                textBox8.Enabled = false;
                textBox13.Enabled = false;
            }

        }

        private void bunifuCheckbox8_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox8.Checked == true)
            {
                textBox9.Enabled = true;
                textBox14.Enabled = true;

            }
            else
            {
                textBox9.Enabled = false;
                textBox14.Enabled = false;
            }

        }

        private void bunifuCheckbox7_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox7.Checked == true)
            {
                textBox10.Enabled = true;
                textBox15.Enabled = true;

            }
            else
            {
                textBox10.Enabled = false;
                textBox15.Enabled = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {
                comboBox1.Enabled = true;
                textBox16.Enabled = false;
                if (comboBox1.Text == "Mobitel")
                {
                    textBox2.Text = "*100#";
                }
                else if (comboBox1.Text == "Dialog")
                {
                    textBox2.Text = "*#456#";
                }
                else if (comboBox1.Text == "Hutch")
                {
                    textBox2.Text = "*344#";
                }
                else if (comboBox1.Text == "Airtel")
                {
                    textBox2.Text = "*550#";
                }
                else if (comboBox1.Text == "Etisalat")
                {
                    textBox2.Text = "*134#";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox1.Enabled = false;
                textBox16.Enabled = true;
                textBox2.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mobitel") {
                textBox2.Text = "*100#";
            }
            else if (comboBox1.Text == "Dialog")
            {
                textBox2.Text = "*#456#";
            }
            else if (comboBox1.Text == "Hutch")
            {
                textBox2.Text = "*344#";
            }
            else if (comboBox1.Text == "Airtel")
            {
                textBox2.Text = "*550#";
            }
            else if (comboBox1.Text == "Etisalat")
            {
                textBox2.Text = "*134#";
            }
           
        }

        private void bunifuCheckbox12_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox12.Checked == true) {
                bunifuCheckbox11.Checked = false;
                comboBox2.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled  = false;
            }
        }

        private void bunifuCheckbox11_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox11.Checked == true)
            {
                bunifuCheckbox12.Checked = false;
                comboBox2.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled  = true;
                textBox5.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Sri Lanka") {
                textBox4.Text = "94";
            }
            if (comboBox2.Text == "India")
            {
                textBox4.Text = "91";
            }
            if (comboBox2.Text == "USA")
            {
                textBox4.Text = "1";
            }
            if (comboBox2.Text == "England")
            {
                textBox4.Text = "44";
            }
            if (comboBox2.Text == "Australia") {
                textBox4.Text = "61";
            }
            if (comboBox2.Text == "China")
            {
                textBox4.Text = "86";
            }
            if (comboBox2.Text == "Russia")
            {
                textBox4.Text = "7";
            }
            if (comboBox2.Text == "Singapore")
            {
                textBox4.Text = "65";
            }
            if (comboBox2.Text == "New zealand")
            {
                textBox4.Text = "64";
            }
            if (comboBox2.Text == "Algeria")
            {
                textBox4.Text = "213";
            }
            if (comboBox2.Text == "Argentina")
            {
                textBox4.Text = "54";
            }
            if (comboBox2.Text == "Austria")
            {
                textBox4.Text = "43";
            }
            if (comboBox2.Text == "Bahrain")
            {
                textBox4.Text = "973";
            }
            if (comboBox2.Text == "Bangladesh")
            {
                textBox4.Text = "880";
            }
            
            if (comboBox2.Text == "Belarus")
            {
                textBox4.Text = "375";
            }
            if (comboBox2.Text == "Belgium")
            {
                textBox4.Text = "32";
            }
            if (comboBox2.Text == "Brazil")
            {
                textBox4.Text = "55";
            }
            if (comboBox2.Text == "Canada")
            {
                textBox4.Text = "1";
            }
            if (comboBox2.Text == "Chile")
            {
                textBox4.Text = "56";
            }
            if (comboBox2.Text == "Colombia")
            {
                textBox4.Text = "57";
            }
            if (comboBox2.Text == "Cuba")
            {
                textBox4.Text = "53";
            }
            if (comboBox2.Text == "Denmark")
            {
                textBox4.Text = "45";
            }
            if (comboBox2.Text == "Finland")
            {
                textBox4.Text = "358";
            }
            if (comboBox2.Text == "France")
            {
                textBox4.Text = "33";
            }
            if (comboBox2.Text == "Germany")
            {
                textBox4.Text = "49";
            }
            if (comboBox2.Text == "Greece")
            {
                textBox4.Text = "30";
            }
            if (comboBox2.Text == "Greenland")
            {
                textBox4.Text = "299";
            }
            if (comboBox2.Text == "Iceland")
            {
                textBox4.Text = "354";
            }
            if (comboBox2.Text == "Indonesia")
            {
                textBox4.Text = "62";
            }
            if (comboBox2.Text == "Iran")
            {
                textBox4.Text = "98";
            }
            if (comboBox2.Text == "Iraq")
            {
                textBox4.Text = "964";
            }
            if (comboBox2.Text == "Ireland")
            {
                textBox4.Text = "353";
            }
            if (comboBox2.Text == "Italy")
            {
                textBox4.Text = "39";
            }
            if (comboBox2.Text == "Japan")
            {
                textBox4.Text = "81";
            }
            if (comboBox2.Text == "Kenya")
            {
                textBox4.Text = "254";
            }
            if (comboBox2.Text == "Kuwait")
            {
                textBox4.Text = "965";
            }
            if (comboBox2.Text == "Libya")
            {
                textBox4.Text = "218";
            }
            if (comboBox2.Text == "Malaysia")
            {
                textBox4.Text = "60";
            }
            if (comboBox2.Text == "Mexico")
            {
                textBox4.Text = "52";
            }
            if (comboBox2.Text == "Nepal")
            {
                textBox4.Text = "977";
            }
            if (comboBox2.Text == "Netherland")
            {
                textBox4.Text = "31";
            }
            if (comboBox2.Text == "North Korea")
            {
                textBox4.Text = "850";
            }
            if (comboBox2.Text == "Pakistan")
            {
                textBox4.Text = "92";
            }
            if (comboBox2.Text == "Philippines")
            {
                textBox4.Text = "63";
            }
            if (comboBox2.Text == "Saudi Arabia")
            {
                textBox4.Text = "966";
            }
            if (comboBox2.Text == "South Africa")
            {
                textBox4.Text = "27";
            }
            if (comboBox2.Text == "South Korea")
            {
                textBox4.Text = "82";
            }
            if (comboBox2.Text == "Sweden")
            {
                textBox4.Text = "46";
            }
            if (comboBox2.Text == "Switzerland")
            {
                textBox4.Text = "41";
            }
            if (comboBox2.Text == "Syria")
            {
                textBox4.Text = "963";
            }
            if (comboBox2.Text == "Taiwan")
            {
                textBox4.Text = "886";
            }
            if (comboBox2.Text == "Thailand")
            {
                textBox4.Text = "66";
            }
            if (comboBox2.Text == "Turkey")
            {
                textBox4.Text = "90";
            }
            if (comboBox2.Text == "Ukraine")
            {
                textBox4.Text = "380";
            }
            if (comboBox2.Text == "Vietnam")
            {
                textBox4.Text = "84";
            }
            if (comboBox2.Text == "Zimbabwe")
            {
                textBox4.Text = "263";
            }
            
        }

        private void label35_MouseMove(object sender, MouseEventArgs e)
        {
            label35.ForeColor = Color.FromArgb(255, 255, 255);
            label35.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {

            label47.ForeColor = Color.FromArgb(0, 0, 0);
            label47.BackColor = Color.FromArgb(243, 242, 247);
            label35.ForeColor = Color.FromArgb(0, 0, 0);
            label35.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void label35_Click(object sender, EventArgs e)
        {
            textBox18.Text = "slot one";
            textBox19.Text = "slot two";
            textBox20.Text = "slot three";
            textBox21.Text = "slot four";
            textBox17.Text = "Alex";

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {
            if ((textBox2.Text == "") || (textBox3.Text == "") || ((textBox4.Text == "") && (textBox5.Text == "")))
            {
                string message4 = "You must provide all the required details for device SIM settings";
                string title4 = "DiHAC Message Unit";
                MessageBox.Show(message4, title4);
            }
            else if ((textBox6.Text == "") || (textBox11.Text == ""))
            {
                string message5 = "You must provide User SIM settings";
                string title5 = "DiHAC Message Unit";
                MessageBox.Show(message5, title5);
            }
            else {
                bunifuCheckbox1.Checked = true;
                groupBox1.Visible = false;
                pictureBox5.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                bunifuCircleProgressbar1.Visible = true;
                groupBox6.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label15.Visible = true;
                bunifuCheckbox1.Visible = true;
                bunifuCheckbox2.Visible = true;
                bunifuCheckbox3.Visible = true;
                bunifuCheckbox4.Visible = true;
                bunifuCheckbox5.Visible = true;
                panel21.Visible = true;
            }
            if (textBox7.Text == "") {
                textBox7.Text = "**********";
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "**********";
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "**********";
            }
            if (textBox10.Text == "")
            {
                textBox10.Text = "**********";
            }
            if (textBox12.Text == "")
            {
                textBox12.Text = "***";
            }
            if (textBox13.Text == "")
            {
                textBox13.Text = "***";
            }
            if (textBox14.Text == "")
            {
                textBox14.Text = "***";
            }
            if (textBox15.Text == "")
            {
                textBox15.Text = "***";
            }
           
        }

        private void label17_MouseMove_1(object sender, MouseEventArgs e)
        {
            label17.ForeColor = Color.FromArgb(255, 255, 255);
            label17.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void label47_Click(object sender, EventArgs e)
        {
            if ((textBox17.Text == "") || (textBox18.Text == "") || (textBox19.Text == "") || (textBox20.Text == "") || (textBox21.Text == ""))
            {

                string message6 = "You must provide all the relay details";
                string title6 = "DiHAC Message Unit";
                MessageBox.Show(message6, title6);
            }
            else if ((bunifuiOSSwitch1.Value == true) && (textBox30.Text == ""))
            {
                string message7 = "You must provide power off code";
                string title7 = "DiHAC Message Unit";
                MessageBox.Show(message7, title7);
            }
            else if ((bunifuCheckbox13.Checked == true)&& (comboBox5.Text == "2")&& ((textBox24.Text == "") || (textBox25.Text == "")))  {
                string message8 = "You must provide external relay details";
                string title8 = "DiHAC Message Unit";
                MessageBox.Show(message8, title8);
            }
            else if ((bunifuCheckbox13.Checked == true) && (comboBox5.Text == "4") && ((textBox24.Text == "") || (textBox25.Text == "") || (textBox23.Text == "") || (textBox22.Text == "")))
            {
                string message9 = "You must provide external relay details";
                string title9 = "DiHAC Message Unit";
                MessageBox.Show(message9, title9);
            }
            else if ((bunifuCheckbox13.Checked == true) && (comboBox5.Text == "8") && ((textBox24.Text == "") || (textBox25.Text == "") || (textBox23.Text == "") || (textBox22.Text == "") || (textBox26.Text == "") || (textBox27.Text == "") || (textBox28.Text == "") || (textBox29.Text == "")))
            {
                string message10 = "You must provide external relay details";
                string title10 = "DiHAC Message Unit";
                MessageBox.Show(message10, title10);
            }
            else
            {
                bunifuCheckbox2.Checked = true;
                groupBox2.Visible = false;
                pictureBox5.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                bunifuCircleProgressbar1.Visible = true;
                groupBox6.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label15.Visible = true;
                bunifuCheckbox1.Visible = true;
                bunifuCheckbox2.Visible = true;
                bunifuCheckbox3.Visible = true;
                bunifuCheckbox4.Visible = true;
                bunifuCheckbox5.Visible = true;
                panel21.Visible = true;
            }
            
        }

        private void label47_MouseMove(object sender, MouseEventArgs e)
        {
            label47.ForeColor = Color.FromArgb(255, 255, 255);
            label47.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            label35.ForeColor = Color.FromArgb(0, 0, 0);
            label35.BackColor = Color.FromArgb(255, 255, 255);

            label47.ForeColor = Color.FromArgb(0, 0, 0);
            label47.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            label47.ForeColor = Color.FromArgb(0, 0, 0);
            label47.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void bunifuCheckbox13_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox13.Checked == true)
            {
                comboBox5.Enabled = true;
                label41.Enabled = true;
                comboBox5.Text = "-Select-";
                textBox22.Text = "slot four";
                textBox23.Text = "slot three";
                textBox24.Text = "slot two";
                textBox25.Text = "slot one";
                textBox26.Text = "slot seven";
                textBox27.Text = "slot six";
                textBox28.Text = "slot five";
                textBox29.Text = "slot eight";
            }
            else {
                comboBox5.Enabled = false;
                label41.Enabled = false;
                comboBox5.Text = "-Select-";
                comboBox5.Text = "-Select-";
                textBox22.Text = "slot four";
                textBox23.Text = "slot three";
                textBox24.Text = "slot two";
                textBox25.Text = "slot one";
                textBox26.Text = "slot seven";
                textBox27.Text = "slot six";
                textBox28.Text = "slot five";
                textBox29.Text = "slot eight";
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label42.Enabled = false;
                textBox22.Enabled = false;
                textBox23.Enabled = false;
                textBox24.Enabled = false;
                textBox25.Enabled = false;
                textBox28.Enabled = false;
                textBox27.Enabled = false;
                textBox26.Enabled = false;
                textBox29.Enabled = false;

            }
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                label49.Enabled = true;
                textBox30.Enabled = true;

            }
            else {
                label49.Enabled = false;
                textBox30.Enabled = false;
            }
        }

        private void label68_Click(object sender, EventArgs e)
        {
            textBox44.Text = "HC-05";
            textBox39.Text = "1234";
            textBox42.Text = "9600";
            textBox43.Text = "2039,56,9e0081";
            comboBox3.Text = "Slave";
            comboBox4.Text = "Specified address mode";

        }

        private void bunifuCheckbox14_OnChange(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Slave")
            {
                label70.Visible = false;
            }
            else {
                label70.Visible = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Specified address mode")
            {
                label71.Visible = false;
            }
            else {
                label71.Visible = true;
            }
        }

        private void label68_MouseMove(object sender, MouseEventArgs e)
        {
            label68.ForeColor = Color.FromArgb(255, 255, 255);
            label68.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            label68.ForeColor = Color.FromArgb(0, 0, 0);
            label68.BackColor = Color.FromArgb(255, 255, 255);
            label52.ForeColor = Color.FromArgb(0, 0, 0);
            label52.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            label52.ForeColor = Color.FromArgb(0, 0, 0);
            label52.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void label52_MouseMove(object sender, MouseEventArgs e)
        {
            label52.ForeColor = Color.FromArgb(255, 255, 255);
            label52.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void label52_Click(object sender, EventArgs e)
        {
            if ((textBox39.Text == "") || (textBox42.Text == "") || (textBox43.Text == "") || (textBox44.Text == ""))
            {
                string message1 = "You must provide all the bluetooth instructions";
                string title1 = "DiHAC Message Unit";
                MessageBox.Show(message1, title1);
            }
            else if (textBox43.TextLength != 14) {
                label14.Visible = true;
            }
            else if ((textBox42.Text != "9600")&&(textBox42.Text != "19200")&&(textBox42.Text != "38400")&& (textBox42.Text != "57600")&& (textBox42.Text != "115200") && (textBox42.Text != "230400")&& (textBox42.Text != "460800"))
            {
                string message5 = "Baud rate must be one of them : 9600,19200,38400,57600,115200,230400,460800";
                string title5 = "DiHAC Message Unit";
                MessageBox.Show(message5, title5);
            }
            else if ((textBox31.Text == "") || (textBox32.Text == "") || (textBox36.Text == "") || (textBox37.Text == "") || (textBox38.Text == ""))
            {
                DialogResult dr1 = MessageBox.Show("Do you want to ignore this empty mac addresses?", "DiHAC Message Unit", MessageBoxButtons.YesNo);
                if (dr1 == DialogResult.Yes)
                {
                    if (textBox38.Text == "")
                    {
                        textBox38.Text = "0000,00,000000";
                    }
                    if (textBox37.Text == "")
                    {
                        textBox37.Text = "0000,00,000000";
                    }
                    if (textBox36.Text == "")
                    {
                        textBox36.Text = "0000,00,000000";
                    }
                    if (textBox32.Text == "")
                    {
                        textBox32.Text = "0000,00,000000";
                    }
                    if (textBox31.Text == "")
                    {
                        textBox31.Text = "0000,00,000000";
                    }

                }
                else if (dr1 == DialogResult.No)
                {
                    label7.Visible = true;
                    if (textBox38.Text == "")
                    {
                        textBox38.Select();
                    }
                    else if (textBox37.Text == "")
                    {
                        textBox37.Select();
                    }
                    else if (textBox36.Text == "")
                    {
                        textBox36.Select();
                    }
                    else if (textBox32.Text == "")
                    {
                        textBox32.Select();
                    }
                    else if (textBox31.Text == "")
                    {
                        textBox31.Select();
                    }
                }
            }
            else if ((comboBox3.Text != "Slave") || (comboBox4.Text != "Specified address mode"))
            {

                DialogResult dr = MessageBox.Show("Role of the device and connection mode are defferent from default settings. Hence voice control section of the DiHAC device will not be work properly.Do you want set these instructions to default configuration?", "DiHAC Message Unit", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    comboBox3.Text = "Slave";
                    comboBox4.Text = "Specified address mode";
                }
                else if (dr == DialogResult.No)
                {
                    bunifuCheckbox3.Checked = true;
                    groupBox3.Visible = false;
                }
            }
            else
            {
                bunifuCheckbox3.Checked = true;
                groupBox3.Visible = false;
                pictureBox5.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                bunifuCircleProgressbar1.Visible = true;
                groupBox6.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label15.Visible = true;
                bunifuCheckbox1.Visible = true;
                bunifuCheckbox2.Visible = true;
                bunifuCheckbox3.Visible = true;
                bunifuCheckbox4.Visible = true;
                bunifuCheckbox5.Visible = true;
                panel21.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label94_Click(object sender, EventArgs e)
        {
            textBox47.Text = "1.0";
            textBox46.Text = "2.0";
            textBox45.Text = "3.6";
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label94_MouseMove(object sender, MouseEventArgs e)
        {
            label94.ForeColor = Color.FromArgb(255, 255, 255);
            label94.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void label72_Click(object sender, EventArgs e)
        {
            if ((textBox45.Text == "") || (textBox46.Text == "") || (textBox47.Text == ""))
            {
                string message4 = "Please enter battery limitations";
                string title4 = "DiHAC Message Unit";
                MessageBox.Show(message4, title4);

            }
            else if ((float.Parse(textBox47.Text) > 3.7) || (float.Parse(textBox46.Text) > 3.7) || (float.Parse(textBox45.Text) > 3.7))
            {
                string message1 = "Battery volatge limits must be lower than 3.7V.";
                string title1 = "Device power limitation Error";
                MessageBox.Show(message1, title1);

            }
            else if ((radioButton3.Checked == false) && (radioButton4.Checked == false) && (radioButton5.Checked == false) && (radioButton6.Checked == false) && (radioButton7.Checked == false)) {
                string message2 = "You must give the higher security permission for one of them";
                string title2 = "DiHAC Message Unit";
                MessageBox.Show(message2, title2);
            }
            else if (textBox33.Text == "")
            {
                string message3 = "Please enter the emergency instruction code.(Maximum characters should be 10)";
                string title3 = "DiHAC Message Unit";
                MessageBox.Show(message3, title3);
                textBox33.Select();
            }
            
            else
            {
                bunifuCheckbox4.Checked = true;
                groupBox4.Visible = false;
                float dead = float.Parse(textBox47.Text);
                textBox47.Text = dead.ToString("0.0");
                float ON = float.Parse(textBox46.Text);
                textBox46.Text = ON.ToString("0.0");
                float OFF = float.Parse(textBox45.Text);
                textBox45.Text = OFF.ToString("0.0");
                pictureBox5.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                bunifuCircleProgressbar1.Visible = true;
                groupBox6.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label15.Visible = true;
                bunifuCheckbox1.Visible = true;
                bunifuCheckbox2.Visible = true;
                bunifuCheckbox3.Visible = true;
                bunifuCheckbox4.Visible = true;
                bunifuCheckbox5.Visible = true;
                panel21.Visible = true;
            }
        }

        private void label72_MouseMove(object sender, MouseEventArgs e)
        {
            label72.ForeColor = Color.FromArgb(255, 255, 255);
            label72.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {
            label94.ForeColor = Color.FromArgb(0, 0, 0);
            label94.BackColor = Color.FromArgb(255, 255, 255);
            label72.ForeColor = Color.FromArgb(0, 0, 0);
            label72.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            label72.ForeColor = Color.FromArgb(0, 0, 0);
            label72.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void label130_Click(object sender, EventArgs e)
        {
            textBox51.Text = "50";
            textBox50.Text = "18";
            textBox49.Text = "0";
            textBox52.Text = "0";
            textBox53.Text = "Nothing";
            textBox54.Text = "Nothing";
        }

        private void label130_MouseMove(object sender, MouseEventArgs e)
        {
            label130.ForeColor = Color.FromArgb(255, 255, 255);
            label130.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void label111_MouseMove(object sender, MouseEventArgs e)
        {
            label111.ForeColor = Color.FromArgb(255, 255, 255);
            label111.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void panel18_MouseMove(object sender, MouseEventArgs e)
        {
            label130.ForeColor = Color.FromArgb(0, 0, 0);
            label130.BackColor = Color.FromArgb(255, 255, 255);
            label111.ForeColor = Color.FromArgb(0, 0, 0);
            label111.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void panel16_MouseMove(object sender, MouseEventArgs e)
        {
            label111.ForeColor = Color.FromArgb(0, 0, 0);
            label111.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label111_Click(object sender, EventArgs e)
        {
            if ((textBox50.Text == "") || (textBox51.Text == ""))
            {
                string message3 = "Please provide temperature limits";
                string title3 = "DiHAC Message Unit";
                MessageBox.Show(message3, title3);
            }
            else if ((textBox49.Text == "") || (textBox53.Text == ""))
            {
                DialogResult dr2 = MessageBox.Show("Do you want to ignore customize temperaure level 1?", "DiHAC Message Unit", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    textBox49.Text = "0";
                    textBox53.Text = "Nothing";

                }
                else if (dr2 == DialogResult.No)
                {
                    textBox49.Select();
                }
            }
            else if ((textBox52.Text == "") || (textBox54.Text == ""))
            {
                DialogResult dr3 = MessageBox.Show("Do you want to ignore customize temperaure level 2?", "DiHAC Message Unit", MessageBoxButtons.YesNo);
                if (dr3 == DialogResult.Yes)
                {
                    textBox52.Text = "0";
                    textBox54.Text = "Nothing";

                }
                else if (dr3 == DialogResult.No)
                {
                    textBox52.Select();
                }
            }
            else if ((textBox34.Text == "") || (textBox35.Text == "") || (textBox40.Text == "") || (textBox41.Text == "") || (textBox48.Text == "")) {
                DialogResult dr4 = MessageBox.Show("Do you want to ignore user identities section?", "DiHAC Message Unit", MessageBoxButtons.YesNo);
                if (dr4 == DialogResult.Yes)
                {
                    if (textBox48.Text == "") {
                        textBox48.Text = "Person";
                    }
                    if (textBox41.Text == "")
                    {
                        textBox41.Text = "Person";
                    }
                    if (textBox40.Text == "")
                    {
                        textBox40.Text = "Person";
                    }
                    if (textBox35.Text == "")
                    {
                        textBox35.Text = "Person";
                    }
                    if (textBox34.Text == "")
                    {
                        textBox34.Text = "Person";
                    }

                }
                else if (dr4 == DialogResult.No)
                {
                    if (textBox48.Text == "")
                    {
                        textBox48.Select();
                    }
                    else if (textBox41.Text == "")
                    {
                        textBox41.Select();
                    }
                    else if (textBox40.Text == "")
                    {
                        textBox40.Select();
                    }
                    else if (textBox35.Text == "")
                    {
                        textBox35.Select();
                    }
                    else if (textBox34.Text == "")
                    {
                        textBox34.Select();
                    }
                }
            }
            else
            {
                bunifuCheckbox5.Checked = true;
                groupBox5.Visible = false;
                pictureBox5.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                bunifuCircleProgressbar1.Visible = true;
                groupBox6.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label15.Visible = true;
                bunifuCheckbox1.Visible = true;
                bunifuCheckbox2.Visible = true;
                bunifuCheckbox3.Visible = true;
                bunifuCheckbox4.Visible = true;
                bunifuCheckbox5.Visible = true;
                panel21.Visible = true;
            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label55.Text = "+" + textBox11.Text + textBox6.Text;
            label56.Text = "+" + textBox12.Text + textBox7.Text;
            label57.Text = "+" + textBox13.Text + textBox8.Text;
            label61.Text = "+" + textBox14.Text + textBox9.Text;
            label69.Text = "+" + textBox15.Text + textBox10.Text;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            bunifuCircleProgressbar1.Visible = false;
            groupBox6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            bunifuCheckbox1.Visible = false;
            bunifuCheckbox2.Visible = false;
            bunifuCheckbox3.Visible = false;
            bunifuCheckbox4.Visible = false;
            bunifuCheckbox5.Visible = false;
            panel21.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label80.Text = "+" + textBox11.Text + textBox6.Text;
            label79.Text = "+" + textBox12.Text + textBox7.Text;
            label78.Text = "+" + textBox13.Text + textBox8.Text;
            label77.Text = "+" + textBox14.Text + textBox9.Text;
            label73.Text = "+" + textBox15.Text + textBox10.Text;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            bunifuCircleProgressbar1.Visible = false;
            groupBox6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            bunifuCheckbox1.Visible = false;
            bunifuCheckbox2.Visible = false;
            bunifuCheckbox3.Visible = false;
            bunifuCheckbox4.Visible = false;
            bunifuCheckbox5.Visible = false;
            panel21.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label116.Text = "+" + textBox11.Text + textBox6.Text;
            label115.Text = "+" + textBox12.Text + textBox7.Text;
            label114.Text = "+" + textBox13.Text + textBox8.Text;
            label113.Text = "+" + textBox14.Text + textBox9.Text;
            label112.Text = "+" + textBox15.Text + textBox10.Text;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            bunifuCircleProgressbar1.Visible = false;
            groupBox6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            bunifuCheckbox1.Visible = false;
            bunifuCheckbox2.Visible = false;
            bunifuCheckbox3.Visible = false;
            bunifuCheckbox4.Visible = false;
            bunifuCheckbox5.Visible = false;
            panel21.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            bunifuCircleProgressbar1.Visible = false;
            groupBox6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            bunifuCheckbox1.Visible = false;
            bunifuCheckbox2.Visible = false;
            bunifuCheckbox3.Visible = false;
            bunifuCheckbox4.Visible = false;
            bunifuCheckbox5.Visible = false;
            panel21.Visible = false;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(1,202,254);
            label2.ForeColor = Color.FromArgb(0,0,0);
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 0, 0);
            label2.ForeColor = Color.FromArgb(1, 202, 254);
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 0, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 0);
            label3.ForeColor = Color.FromArgb(1, 202, 254);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 0, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            label4.ForeColor = Color.FromArgb(1, 202, 254);
            label5.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 0, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label5.ForeColor = Color.FromArgb(1, 202, 254);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 0, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 0);
            label8.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label8.BackColor  = Color.FromArgb(1, 202, 254);
        }

        private void panel20_MouseMove(object sender, MouseEventArgs e)
        {
            label8.BackColor  = Color.FromArgb(255,255,255);
            label123.BackColor = Color.FromArgb(255, 255, 255);
            label124.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 10;
            bunifuCircleProgressbar1.Text = bunifuCircleProgressbar1.Value.ToString();
        }

        private void bunifuCircleProgressbar1_Paint(object sender, PaintEventArgs e)
        {
            

            

            if (bunifuCircleProgressbar1.Value == 100) {

                timer1.Enabled = false;
                string message3 = "All the data uploading is completed";
                string title3 = "DiHAC Message Unit";
                MessageBox.Show(message3, title3);


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            pictureBox5.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            bunifuCircleProgressbar1.Visible = false;
            groupBox6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            bunifuCheckbox1.Visible = false;
            bunifuCheckbox2.Visible = false;
            bunifuCheckbox3.Visible = false;
            bunifuCheckbox4.Visible = false;
            bunifuCheckbox5.Visible = false;
            panel21.Visible = false;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "2") {
                label39.Enabled = true;
                label40.Enabled = true;
                textBox25.Enabled = true;
                textBox24.Enabled = true;
                
                label37.Enabled = false;
                label38.Enabled = false;
                label41.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label42.Enabled = false;
                
                textBox22.Enabled = false;
                textBox23.Enabled = false;
                textBox28.Enabled = false;
                textBox27.Enabled = false;
                textBox26.Enabled = false;
                textBox29.Enabled = false;
            }
            if (comboBox5.Text == "4") {
                label37.Enabled = true;
                label38.Enabled = true;
                label39.Enabled = true;
                label40.Enabled = true;
                
                textBox22.Enabled = true;
                textBox23.Enabled = true;
                textBox24.Enabled = true;
                textBox25.Enabled = true;
                
                
                label41.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label42.Enabled = false;
               
                textBox28.Enabled = false;
                textBox27.Enabled = false;
                textBox26.Enabled = false;
                textBox29.Enabled = false;
            }
            if (comboBox5.Text == "8") {
                label37.Enabled = true;
                label38.Enabled = true;
                label39.Enabled = true;
                label40.Enabled = true;
                label41.Enabled = true;
                label44.Enabled = true;
                label45.Enabled = true;
                label46.Enabled = true;
                label42.Enabled = true;
                textBox22.Enabled = true;
                textBox23.Enabled = true;
                textBox24.Enabled = true;
                textBox25.Enabled = true;
                textBox28.Enabled = true;
                textBox27.Enabled = true;
                textBox26.Enabled = true;
                textBox29.Enabled = true;
                
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            label17.ForeColor = Color.FromArgb(0, 0, 0);
            label17.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            label68.ForeColor = Color.FromArgb(0, 0, 0);
            label68.BackColor = Color.FromArgb(255, 255, 255);
            label52.ForeColor = Color.FromArgb(0, 0, 0);
            label52.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch2.Value == true)
            {
                radioButton3.Enabled = true;
                label109.Enabled = true;
                textBox33.Enabled = true;
            }
            else {
                radioButton3.Enabled = false;
                
            }

            if ((bunifuiOSSwitch2.Value == false)&& (bunifuiOSSwitch3.Value == false)&& (bunifuiOSSwitch4.Value == false)&& (bunifuiOSSwitch5.Value == false)&& (bunifuiOSSwitch6.Value == false))
            {
                label109.Enabled = false;
                textBox33.Enabled = false;

            }
            
        }

        private void bunifuiOSSwitch3_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch3.Value == true)
            {
                radioButton4.Enabled = true;
                label109.Enabled = true;
                textBox33.Enabled = true;
            }
            else
            {
                radioButton4.Enabled = false;
                
            }
            if ((bunifuiOSSwitch2.Value == false) && (bunifuiOSSwitch3.Value == false) && (bunifuiOSSwitch4.Value == false) && (bunifuiOSSwitch5.Value == false) && (bunifuiOSSwitch6.Value == false))
            {
                label109.Enabled = false;
                textBox33.Enabled = false;

            }
        }

        private void bunifuiOSSwitch4_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch4.Value == true)
            {
                radioButton5.Enabled = true;
                label109.Enabled = true;
                textBox33.Enabled = true;
            }
            else
            {
                radioButton5.Enabled = false;
                
            }
            if ((bunifuiOSSwitch2.Value == false) && (bunifuiOSSwitch3.Value == false) && (bunifuiOSSwitch4.Value == false) && (bunifuiOSSwitch5.Value == false) && (bunifuiOSSwitch6.Value == false))
            {
                label109.Enabled = false;
                textBox33.Enabled = false;

            }
        }

        private void bunifuiOSSwitch5_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch5.Value == true)
            {
                radioButton6.Enabled = true;
                label109.Enabled = true;
                textBox33.Enabled = true;
            }
            else
            {
                radioButton6.Enabled = false;
                
            }
            if ((bunifuiOSSwitch2.Value == false) && (bunifuiOSSwitch3.Value == false) && (bunifuiOSSwitch4.Value == false) && (bunifuiOSSwitch5.Value == false) && (bunifuiOSSwitch6.Value == false))
            {
                label109.Enabled = false;
                textBox33.Enabled = false;

            }
        }

        private void bunifuiOSSwitch6_OnValueChange(object sender, EventArgs e){
        
            if (bunifuiOSSwitch6.Value == true)
            {
                radioButton7.Enabled = true;
                label109.Enabled = true;
                textBox33.Enabled = true;
            }
            else
            {
                radioButton7.Enabled = false;
                
            }
            if ((bunifuiOSSwitch2.Value == false) && (bunifuiOSSwitch3.Value == false) && (bunifuiOSSwitch4.Value == false) && (bunifuiOSSwitch5.Value == false) && (bunifuiOSSwitch6.Value == false))
            {
                label109.Enabled = false;
                textBox33.Enabled = false;

            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {
            label72.ForeColor = Color.FromArgb(0, 0, 0);
            label72.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            label111.ForeColor = Color.FromArgb(0, 0, 0);
            label111.BackColor = Color.FromArgb(243, 242, 247);
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label123_Click(object sender, EventArgs e)
        {
           

            serialPort1.Close();
            serialPort1.PortName = "COM" + textBox1.Text;

            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();

                    for (int b = 0; b < textBox23.Text.Length; b++)
                    {
                        serialPort1.Write(textBox23.Text.Substring(b, 1));

                    }
                    for (int b1 = textBox23.Text.Length; b1 < 10; b1++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int n = 0; n < textBox22.Text.Length; n++)
                    {
                        serialPort1.Write(textBox22.Text.Substring(n, 1));

                    }
                    for (int n1 = textBox22.Text.Length; n1 < 10; n1++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int m = 0; m < textBox28.Text.Length; m++)
                    {
                        serialPort1.Write(textBox28.Text.Substring(m, 1));

                    }
                    for (int m1 = textBox28.Text.Length; m1 < 10; m1++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int Q = 0; Q < textBox27.Text.Length; Q++)
                    {
                        serialPort1.Write(textBox27.Text.Substring(Q, 1));

                    }
                    for (int Q1 = textBox27.Text.Length; Q1 < 10; Q1++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int W = 0; W < textBox26.Text.Length; W++)
                    {
                        serialPort1.Write(textBox26.Text.Substring(W, 1));

                    }
                    for (int W1 = textBox26.Text.Length; W1 < 10; W1++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int E = 0; E < textBox29.Text.Length; E++)
                    {
                        serialPort1.Write(textBox29.Text.Substring(E, 1));

                    }
                    for (int E1 = textBox29.Text.Length; E1 < 10; E1++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int R = 0; R < textBox30.Text.Length; R++)
                    {
                        serialPort1.Write(textBox30.Text.Substring(R, 1));

                    }
                    for (int R1 = textBox30.Text.Length; R1 < 10; R1++)
                    {
                        serialPort1.Write("*");

                    }


                    if (textBox44.Text.Length < 10)
                    {
                        textBox55.Text = (textBox44.Text.Length).ToString();
                        serialPort1.Write("0");
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else if (textBox44.Text.Length >= 10)
                    {
                        textBox55.Text = (textBox44.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                        serialPort1.Write(textBox55.Text.Substring(1, 1));
                    }

                    if (textBox39.Text.Length < 10)
                    {
                        textBox55.Text = (textBox39.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (textBox42.Text.Length < 10)
                    {
                        textBox55.Text = (textBox42.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (comboBox3.Text == "Slave")
                    {
                        serialPort1.Write("0");
                    }
                    else if (comboBox3.Text == "Master")
                    {
                        serialPort1.Write("1");
                    }
                    else
                    {
                        serialPort1.Write("2");
                    }


                    if (comboBox4.Text == "Specified address mode")
                    {
                        serialPort1.Write("0");
                    }
                    else
                    {
                        serialPort1.Write("1");
                    }

                    for (int T = 0; T < textBox44.Text.Length; T++)
                    {
                        serialPort1.Write(textBox44.Text.Substring(T, 1));

                    }
                    for (int T = textBox44.Text.Length; T < 32; T++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int Y = 0; Y < textBox39.Text.Length; Y++)
                    {
                        serialPort1.Write(textBox39.Text.Substring(Y, 1));

                    }
                    for (int Y = textBox39.Text.Length; Y < 10; Y++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int U = 0; U < textBox42.Text.Length; U++)
                    {
                        serialPort1.Write(textBox42.Text.Substring(U, 1));

                    }
                    for (int U = textBox42.Text.Length; U < 10; U++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int I = 0; I < 14; I++)
                    {
                        serialPort1.Write(textBox43.Text.Substring(I, 1));

                    }

                    for (int O = 0; O < 14; O++)
                    {
                        serialPort1.Write(textBox38.Text.Substring(O, 1));

                    }

                    for (int P = 0; P < 14; P++)
                    {
                        serialPort1.Write(textBox37.Text.Substring(P, 1));

                    }

                    for (int A = 0; A < 14; A++)
                    {
                        serialPort1.Write(textBox36.Text.Substring(A, 1));

                    }

                    for (int S = 0; S < 14; S++)
                    {
                        serialPort1.Write(textBox32.Text.Substring(S, 1));

                    }

                    serialPort1.Close();


                }
                catch
                {
                    MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                }
            }


            label123.Enabled = false;
            label124.Enabled = true;
            string message3 = "Second stage data uploading is completed";
            string title3 = "DiHAC Message Unit";
            MessageBox.Show(message3, title3);
        }

        private void label124_Click(object sender, EventArgs e)
        {
            
            serialPort1.Close();
            serialPort1.PortName = "COM" + textBox1.Text;

            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();

                    for (int D = 0; D < 14; D++)
                    {
                        serialPort1.Write(textBox31.Text.Substring(D, 1));

                    }

                    if (bunifuiOSSwitch2.Value == true)
                    {
                        serialPort1.Write("1");
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (bunifuiOSSwitch3.Value == true)
                    {
                        serialPort1.Write("1");
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (bunifuiOSSwitch4.Value == true)
                    {
                        serialPort1.Write("1");
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (bunifuiOSSwitch5.Value == true)
                    {
                        serialPort1.Write("1");
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (bunifuiOSSwitch6.Value == true)
                    {
                        serialPort1.Write("1");
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (radioButton3.Checked == true)
                    {
                        serialPort1.Write("1");
                    }
                    else if (radioButton4.Checked == true)
                    {
                        serialPort1.Write("2");
                    }
                    else if (radioButton5.Checked == true)
                    {
                        serialPort1.Write("3");
                    }
                    else if (radioButton6.Checked == true)
                    {
                        serialPort1.Write("4");
                    }
                    else if (radioButton7.Checked == true)
                    {
                        serialPort1.Write("5");
                    }

                    if (bunifuiOSSwitch7.Value == true)
                    {
                        serialPort1.Write("1");
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (textBox33.Text.Length < 10)
                    {
                        textBox55.Text = (textBox33.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    for (int F = 0; F < textBox33.Text.Length; F++)
                    {
                        serialPort1.Write(textBox33.Text.Substring(F, 1));

                    }
                    for (int F = textBox33.Text.Length; F < 10; F++)
                    {
                        serialPort1.Write("*");

                    }

                    for (int G = 0; G < 3; G++)
                    {
                        serialPort1.Write(textBox47.Text.Substring(G, 1));

                    }

                    for (int H = 0; H < 3; H++)
                    {
                        serialPort1.Write(textBox46.Text.Substring(H, 1));

                    }

                    for (int J = 0; J < 3; J++)
                    {
                        serialPort1.Write(textBox45.Text.Substring(J, 1));

                    }

                    textBox55.Text = (textBox51.Text.Length).ToString();
                    serialPort1.Write(textBox55.Text.Substring(0, 1));

                    textBox55.Text = (textBox50.Text.Length).ToString();
                    serialPort1.Write(textBox55.Text.Substring(0, 1));

                    textBox55.Text = (textBox49.Text.Length).ToString();
                    serialPort1.Write(textBox55.Text.Substring(0, 1));

                    textBox55.Text = (textBox52.Text.Length).ToString();
                    serialPort1.Write(textBox55.Text.Substring(0, 1));

                    if (textBox53.Text.Length < 10)
                    {
                        textBox55.Text = (textBox53.Text.Length).ToString();
                        serialPort1.Write("0");
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else if (textBox53.Text.Length >= 10)
                    {
                        textBox55.Text = (textBox53.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                        serialPort1.Write(textBox55.Text.Substring(1, 1));
                    }

                    if (textBox54.Text.Length < 10)
                    {
                        textBox55.Text = (textBox54.Text.Length).ToString();
                        serialPort1.Write("0");
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else if (textBox54.Text.Length >= 10)
                    {
                        textBox55.Text = (textBox54.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                        serialPort1.Write(textBox55.Text.Substring(1, 1));
                    }

                    if (textBox48.Text.Length < 10)
                    {
                        textBox55.Text = (textBox48.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (textBox41.Text.Length < 10)
                    {
                        textBox55.Text = (textBox41.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (textBox40.Text.Length < 10)
                    {
                        textBox55.Text = (textBox40.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (textBox35.Text.Length < 10)
                    {
                        textBox55.Text = (textBox35.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    if (textBox34.Text.Length < 10)
                    {
                        textBox55.Text = (textBox34.Text.Length).ToString();
                        serialPort1.Write(textBox55.Text.Substring(0, 1));
                    }
                    else
                    {
                        serialPort1.Write("0");
                    }

                    for (int K = 0; K < textBox51.Text.Length; K++)
                    {
                        serialPort1.Write(textBox51.Text.Substring(K, 1));

                    }
                    for (int K = textBox51.Text.Length; K < 3; K++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int L = 0; L < textBox50.Text.Length; L++)
                    {
                        serialPort1.Write(textBox50.Text.Substring(L, 1));

                    }
                    for (int L = textBox50.Text.Length; L < 3; L++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int Z = 0; Z < textBox49.Text.Length; Z++)
                    {
                        serialPort1.Write(textBox49.Text.Substring(Z, 1));

                    }
                    for (int Z = textBox49.Text.Length; Z < 3; Z++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int X = 0; X < textBox52.Text.Length; X++)
                    {
                        serialPort1.Write(textBox52.Text.Substring(X, 1));

                    }
                    for (int X = textBox52.Text.Length; X < 3; X++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int C = 0; C < textBox53.Text.Length; C++)
                    {
                        serialPort1.Write(textBox53.Text.Substring(C, 1));

                    }
                    for (int C = textBox53.Text.Length; C < 20; C++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int V = 0; V < textBox54.Text.Length; V++)
                    {
                        serialPort1.Write(textBox54.Text.Substring(V, 1));

                    }
                    for (int V = textBox54.Text.Length; V < 20; V++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int B = 0; B < textBox48.Text.Length; B++)
                    {
                        serialPort1.Write(textBox48.Text.Substring(B, 1));

                    }
                    for (int B = textBox48.Text.Length; B < 10; B++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int N = 0; N < textBox41.Text.Length; N++)
                    {
                        serialPort1.Write(textBox41.Text.Substring(N, 1));

                    }
                    for (int N = textBox41.Text.Length; N < 10; N++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int M = 0; M < textBox40.Text.Length; M++)
                    {
                        serialPort1.Write(textBox40.Text.Substring(M, 1));

                    }
                    for (int M = textBox40.Text.Length; M < 10; M++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int Mm = 0; Mm < textBox35.Text.Length; Mm++)
                    {
                        serialPort1.Write(textBox35.Text.Substring(Mm, 1));

                    }
                    for (int Mm = textBox35.Text.Length; Mm < 10; Mm++)
                    {
                        serialPort1.Write("*");
                    }

                    for (int Nn = 0; Nn < textBox34.Text.Length; Nn++)
                    {
                        serialPort1.Write(textBox34.Text.Substring(Nn, 1));

                    }
                    for (int Nn = textBox34.Text.Length; Nn < 10; Nn++)
                    {
                        serialPort1.Write("*");
                    }

                    serialPort1.Close();


                }
                catch
                {
                    MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                }
            }
            bunifuCircleProgressbar1.Value = 0;
            label124.Enabled = false;
            label8.Enabled = true;
            timer1.Enabled = true;
            
        }

        private void label125_Click(object sender, EventArgs e)
        {
            bunifuCheckbox5.Checked = false;
            bunifuCheckbox1.Checked = false;
            bunifuCheckbox2.Checked = false;
            bunifuCheckbox3.Checked = false;
            bunifuCheckbox4.Checked = false;
        }

        private void label123_MouseMove(object sender, MouseEventArgs e)
        {
            label123.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void label124_MouseMove(object sender, MouseEventArgs e)
        {
            label124.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void label125_MouseMove(object sender, MouseEventArgs e)
        {
            label125.BackColor = Color.FromArgb(1, 202, 254);
        }

        private void panel21_MouseMove(object sender, MouseEventArgs e)
        {
            label125.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
     }

