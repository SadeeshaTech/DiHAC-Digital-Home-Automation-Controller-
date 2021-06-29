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

namespace Bluetooth_coder
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0, 0, 0);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Select();
            panel15.Visible = false;
            panel14.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            label7.ForeColor = Color.FromArgb(0, 131, 204);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 0);
            panel5.Enabled = false;
            panel6.Enabled = false;
            panel7.Enabled = false;
            label3.BackColor  = Color.FromArgb(0, 170, 250);
            label4.BackColor = Color.FromArgb(0, 131, 206);
            label6.BackColor = Color.FromArgb(0, 131, 206);
            panel9.Visible = false;
            panel10.Visible = false;
            

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(255,255,255);
            label4.ForeColor = Color.FromArgb(255, 255, 255);
            label6.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(255, 255, 255);
            label4.ForeColor = Color.FromArgb(255, 255, 255);
            label6.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel15.Visible = false;
            panel14.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            label3.BackColor = Color.FromArgb(0, 131, 206);
            label4.BackColor = Color.FromArgb(0, 170, 250);
            label6.BackColor = Color.FromArgb(0, 131, 206);
            panel9.Visible = true;
            panel10.Visible = true;
            tabControl1.Visible = false;

            label26.ForeColor = Color.FromArgb(0, 131, 204);
            label25.ForeColor = Color.FromArgb(0, 0, 0);
            bunifuCheckbox1.Visible = true;
            bunifuCheckbox2.Visible = true;
            bunifuCheckbox3.Visible = true;
            label30.Visible = true;
            label29.Visible = true;
            label28.Visible = true;
            label27.Visible = true;
            label41.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            textBox11.Visible = false;
            bunifuCircleProgressbar2.Visible = false;
            bunifuCircleProgressbar3.Visible = false;
            bunifuCircleProgressbar4.Visible = false;
            bunifuCheckbox1.Checked = false;
            bunifuCheckbox2.Checked = false;
            bunifuCheckbox3.Checked = false;


            // label24.ForeColor = Color.FromArgb(0, 0, 0);
            // label23.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
            panel2.Visible = true;
            panel9.Visible = true;
            panel14.Visible = true;
           // panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            //panel9.Visible = false;
            panel10.Visible = false;
           
           
            label3.BackColor = Color.FromArgb(0, 131, 206);
            label4.BackColor = Color.FromArgb(0, 131, 206);
            label6.BackColor = Color.FromArgb(0, 170, 250);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox1.Select();
            label7.ForeColor = Color.FromArgb(0, 131, 204);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 0);
            panel5.Enabled  = false;
            panel6.Enabled = false;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel7.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(0, 0, 0);
            label8.ForeColor = Color.FromArgb(0, 131, 204);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(0, 0, 0);
            panel5.Enabled = true;
            panel6.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel7.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(0, 0, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(0, 131, 204);
            label10.ForeColor = Color.FromArgb(0, 0, 0);
            panel5.Enabled = false;
            panel6.Enabled = true;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel7.Enabled = false;
            textBox4.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(0, 0, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 0);
            label10.ForeColor = Color.FromArgb(0, 131, 204);
            panel5.Enabled = false;
            panel6.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel7.Enabled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length != 14) {
                string message1 = "Please enter your mac address as following hint";
                string title1 = "Mac address Error";
                MessageBox.Show(message1, title1);
                textBox1.Text = "";               
                textBox1.Select();

            }

            else if (textBox2.Text == "")
            {
                string message2 = "Please enter COM Port number";
                string title2 = "COM Port Error";
                MessageBox.Show(message2, title2);
                textBox2.Text = "";
                textBox2.Select();
                label21.Visible = true;
            }

            else if (textBox1.Text == "")
            {
                string message3 = "Please enter your mac address";
                string title3 = "Mac address Error";
                MessageBox.Show(message3, title3);
                textBox1.Text = "";
                textBox1.Select();

            }
            else if (textBox3.Text == "")
            {
                string message4 = "Please enter a name for device";
                string title4 = "Device name Error";
                MessageBox.Show(message4, title4);
                textBox3.Text = "";
                textBox3.Select();

            }
            else if (textBox4.Text == "")
            {
                string message5 = "Please enter a password for device";
                string title5 = "Device password Error";
                MessageBox.Show(message5, title5);
                textBox4.Text = "";
                textBox4.Select();

            }
            else if (textBox5.Text == "")
            {
                string message6 = "Please enter Baud rate for device";
                string title6 = "Baud rate Error";
                MessageBox.Show(message6, title6);
                textBox5.Text = "";
                textBox5.Select();

            }
            else
            {
                panel8.Visible = true;
                timer1.Enabled = true;

            }
        }

        private void label11_MouseMove(object sender, MouseEventArgs e)
        {
            label11.ForeColor = Color.FromArgb(0, 131, 204);
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            label11.ForeColor = Color.FromArgb(0, 0, 0);
            label20.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void label20_MouseMove(object sender, MouseEventArgs e)
        {
            label20.ForeColor = Color.FromArgb(0, 131, 204);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
            textBox3.Text = "HC-05";
            textBox4.Text = "1234";
            textBox1.Text = "2039,54,9e0081";
            textBox5.Text = "38400";
            comboBox1.Text = "Slave";
            comboBox2.Text = "Specified address mode";
            textBox2.Text = "";



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label21.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 10;
            bunifuCircleProgressbar1.Text = bunifuCircleProgressbar1.Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuCircleProgressbar1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgressbar1_StyleChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuCircleProgressbar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuCircleProgressbar1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }

        private void bunifuCircleProgressbar1_Paint(object sender, PaintEventArgs e)
        {

            if (bunifuCircleProgressbar1.Value == 10) {
                label22.Text = "COM Port configuring....";

            }
            if (bunifuCircleProgressbar1.Value == 20)
            {
                label22.Text = "Starting serial data communication";

            }
            if (bunifuCircleProgressbar1.Value == 30)
            {
                label22.Text = "Device name is uploaded";

            }
            if (bunifuCircleProgressbar1.Value == 40)
            {
                label22.Text = "Pairing password is uploaded";

            }
            if (bunifuCircleProgressbar1.Value == 50)
            {
                label22.Text = "Role of the device is uploaded";

            }
            if (bunifuCircleProgressbar1.Value == 60)
            {
                label22.Text = "Device name is uploaded";

            }
            if (bunifuCircleProgressbar1.Value == 70)
            {
                label22.Text = "Connection mode is uploaded";

            }
            if (bunifuCircleProgressbar1.Value == 80)
            {
                label22.Text = "Mac address & Bauad rate are uploaded";

            }
            if (bunifuCircleProgressbar1.Value == 90)
            {
                label22.Text = "Finalizing uploaded data";

            }
            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Enabled = false;
                serialPort1.PortName = "COM" + textBox2.Text;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        if (comboBox1.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox1.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox2.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox1.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox3.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox3.Text.Length < 32)&& (textBox3.Text.Length >=10))
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox3.Text.Length < 10)
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else if ((textBox3.Text.Length < 32) && (textBox3.Text.Length >= 10))
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox4.Text.Length < 10)
                        {
                            textBox6.Text = (textBox4.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox5.Text.Length < 10)
                        {
                            textBox6.Text = (textBox5.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox3.Text.Length; t++)
                        {
                            serialPort1.Write(textBox3.Text.Substring(t, 1));

                        }
                        for (int tt = textBox3.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox4.Text.Length; s++)
                        {
                            serialPort1.Write(textBox4.Text.Substring(s, 1));

                        }
                        for (int ss = textBox4.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox5.Text.Length; x++)
                        {
                            serialPort1.Write(textBox5.Text.Substring(x, 1));

                        }
                        for (int xx = textBox5.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////




                        if (comboBox1.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox1.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox2.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int ii = 0; ii < 14; ii++)
                        {
                            serialPort1.Write(textBox1.Text.Substring(ii, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox3.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox3.Text.Length < 32) && (textBox3.Text.Length >= 10))
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox3.Text.Length < 10)
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else if ((textBox3.Text.Length < 32) && (textBox3.Text.Length >= 10))
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////

                        if (textBox4.Text.Length < 10)
                        {
                            textBox6.Text = (textBox4.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox5.Text.Length < 10)
                        {
                            textBox6.Text = (textBox5.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int p = 0; p < textBox3.Text.Length; p++)
                        {
                            serialPort1.Write(textBox3.Text.Substring(p, 1));

                        }
                        for (int v = textBox3.Text.Length; v < 32; v++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int d = 0; d < textBox4.Text.Length; d++)
                        {
                            serialPort1.Write(textBox4.Text.Substring(d, 1));

                        }
                        for (int q = textBox4.Text.Length; q < 10; q++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int k = 0; k < textBox5.Text.Length; k++)
                        {
                            serialPort1.Write(textBox5.Text.Substring(k, 1));

                        }
                        for (int w = textBox5.Text.Length; w < 10; w++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////



                        if (comboBox1.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox1.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox2.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int kkk = 0; kkk < 14; kkk++)
                        {
                            serialPort1.Write(textBox1.Text.Substring(kkk, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox3.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox3.Text.Length < 32) && (textBox3.Text.Length >= 10))
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox3.Text.Length < 10)
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else if ((textBox3.Text.Length < 32) && (textBox3.Text.Length >= 10))
                        {
                            textBox6.Text = (textBox3.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////

                        if (textBox4.Text.Length < 10)
                        {
                            textBox6.Text = (textBox4.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox5.Text.Length < 10)
                        {
                            textBox6.Text = (textBox5.Text.Length).ToString();
                            serialPort1.Write(textBox6.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int kkkk = 0; kkkk < textBox3.Text.Length; kkkk++)
                        {
                            serialPort1.Write(textBox3.Text.Substring(kkkk, 1));

                        }
                        for (int h = textBox3.Text.Length; h < 32; h++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int hh = 0; hh < textBox4.Text.Length; hh++)
                        {
                            serialPort1.Write(textBox4.Text.Substring(hh, 1));

                        }
                        for (int hhh = textBox4.Text.Length; hhh < 10; hhh++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int hhhh = 0; hhhh < textBox5.Text.Length; hhhh++)
                        {
                            serialPort1.Write(textBox5.Text.Substring(hhhh, 1));

                        }
                        for (int g = textBox5.Text.Length; g < 10; g++)
                        {
                            serialPort1.Write("*");

                        }
                        if (radioButton1.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        if (radioButton2.Checked == true)
                        {
                            serialPort1.Write("2");
                        }
                        /////////////////////////////////////////////////



                        serialPort1.Close();


                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }
                panel8.Visible = false;
                bunifuCircleProgressbar1.Value = 0;
                string message10 = "All the data are uploading completed";
                string title10 = "Bluetooth Coder";
                MessageBox.Show(message10, title10);
                
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            label26.ForeColor = Color.FromArgb(0, 131, 204);
           // label23.ForeColor = Color.FromArgb(0, 0, 0);
            //label24.ForeColor = Color.FromArgb(0, 0, 0);
            label25.ForeColor = Color.FromArgb(0, 0, 0);
            panel10.Visible = true;
            tabControl1.Visible = false;

            bunifuCheckbox1.Visible = true;
            bunifuCheckbox2.Visible = true;
            bunifuCheckbox3.Visible = true;
            label30.Visible = true;
            label29.Visible = true;
            label28.Visible = true;
            label27.Visible = true;
            
            if ((bunifuCheckbox1.Checked == true) || (bunifuCheckbox2.Checked == true) || (bunifuCheckbox3.Checked == true))
            {
                label41.Visible = true;
                label31.Visible = true;
                label32.Visible = true;
                textBox11.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
            }

            if (bunifuCheckbox1.Checked == true)
            {
                bunifuCircleProgressbar2.Visible = true;
            }
            else {
                bunifuCircleProgressbar2.Visible = false;
            }
            if (bunifuCheckbox2.Checked == true)
            {
                bunifuCircleProgressbar3.Visible = true;
            }
            else
            {
                bunifuCircleProgressbar3.Visible = false;
            }
            if (bunifuCheckbox3.Checked == true)
            {
                bunifuCircleProgressbar4.Visible = true;
            }
            else
            {
                bunifuCircleProgressbar4.Visible = false;
            }

        }

        private void label25_Click(object sender, EventArgs e)
        {
            label25.ForeColor = Color.FromArgb(0, 131, 204);
            //label23.ForeColor = Color.FromArgb(0, 0, 0);
            //label24.ForeColor = Color.FromArgb(0, 0, 0);
            label26.ForeColor = Color.FromArgb(0, 0, 0);
            panel10.Visible = true;
            tabControl1.Visible = true;
            bunifuCircleProgressbar2.Visible = false;
            bunifuCircleProgressbar3.Visible = false;
            bunifuCircleProgressbar4.Visible = false;

            bunifuCheckbox1.Visible = false;
            bunifuCheckbox2.Visible = false;
            bunifuCheckbox3.Visible = false;
            label30.Visible = false;
            label29.Visible = false;
            label28.Visible = false;
            label27.Visible = false;
            label41.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            textBox11.Visible = false;
            radioButton4.Visible = false;
            radioButton3.Visible = false;
        }

        private void label24_Click(object sender, EventArgs e)
        {
           // label24.ForeColor = Color.FromArgb(0, 131, 204);
           // label23.ForeColor = Color.FromArgb(0, 0, 0);
           // label26.ForeColor = Color.FromArgb(0, 0, 0);
           // label25.ForeColor = Color.FromArgb(0, 0, 0);
            //panel10.Visible = true;

        }

        private void label23_Click(object sender, EventArgs e)
        {
           // label23.ForeColor = Color.FromArgb(0, 131, 204);
            //label26.ForeColor = Color.FromArgb(0, 0, 0);
            //label24.ForeColor = Color.FromArgb(0, 0, 0);
            //label25.ForeColor = Color.FromArgb(0, 0, 0);
            //panel10.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)

        {
            if (bunifuCheckbox1.Checked == true)
            {
                panel11.Enabled = true;
            }
            else {
                panel11.Enabled = false;
            }
            if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar2.Location = new Point(207, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar2.Location = new Point(120, 120);
                bunifuCircleProgressbar3.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar2.Location = new Point(120, 120);
                bunifuCircleProgressbar4.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar2.Location = new Point(60, 120);
                bunifuCircleProgressbar3.Location = new Point(207, 120);
                bunifuCircleProgressbar4.Location = new Point(357, 120);

            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar3.Location = new Point(120, 120);
                bunifuCircleProgressbar4.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar3.Location = new Point(207, 120);

            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar4.Location = new Point(207, 120);

            }

            if ((bunifuCheckbox1.Checked == true) || (bunifuCheckbox2.Checked == true) || (bunifuCheckbox3.Checked == true)) {
                label31.Visible = true;
                label32.Visible = true;
                label41.Visible = true;
                textBox11.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Visible = true;

            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == false))
            {
                label31.Visible = false;
                label32.Visible = false;
                label41.Visible = false;
                textBox11.Visible = false;
                radioButton4.Visible = false;
                radioButton3.Visible = false;
            }
            if (bunifuCheckbox1.Checked == true)
            {
                bunifuCircleProgressbar2.Visible = true;

            }
            else {
                bunifuCircleProgressbar2.Visible = false;
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked == true)
            {
                panel12.Enabled = true;
            }
            else
            {
                panel12.Enabled = false;
            }
            if ((bunifuCheckbox1.Checked == true) || (bunifuCheckbox2.Checked == true) || (bunifuCheckbox3.Checked == true))
            {
                label31.Visible = true;
                label32.Visible = true;
                label41.Visible = true;
                textBox11.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == false))
            {
                label31.Visible = false;
                label32.Visible = false;
                label41.Visible = false;
                textBox11.Visible = false;
                radioButton4.Visible = false;
                radioButton3.Visible = false;
            }
            if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar3.Location = new Point(207, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar2.Location = new Point(120, 120);
                bunifuCircleProgressbar3.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar3.Location = new Point(120, 120);
                bunifuCircleProgressbar4.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar2.Location = new Point(60, 120);
                bunifuCircleProgressbar3.Location = new Point(207, 120);
                bunifuCircleProgressbar4.Location = new Point(357, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar2.Location = new Point(120, 120);
                bunifuCircleProgressbar4.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar2.Location = new Point(207, 120);

            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar4.Location = new Point(207, 120);

            }


            if (bunifuCheckbox2.Checked == true)
            {
                bunifuCircleProgressbar3.Visible = true;

            }
            else
            {
                bunifuCircleProgressbar3.Visible = false;
            }
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox3.Checked == true)
            {
                panel13.Enabled = true;
            }
            else
            {
                panel13.Enabled = false;
            }
            if ((bunifuCheckbox1.Checked == true) || (bunifuCheckbox2.Checked == true) || (bunifuCheckbox3.Checked == true))
            {
                label31.Visible = true;
                label32.Visible = true;
                label41.Visible = true;
                textBox11.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == false))
            {
                label31.Visible = false;
                label32.Visible = false;
                label41.Visible = false;
                textBox11.Visible = false;
                radioButton4.Visible = false;
                radioButton3.Visible = false;
            }
            if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar4.Location = new Point(207, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar2.Location = new Point(120, 120);
                bunifuCircleProgressbar4.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar3.Location = new Point(120, 120);
                bunifuCircleProgressbar4.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == true))
            {

                bunifuCircleProgressbar2.Location = new Point(60, 120);
                bunifuCircleProgressbar3.Location = new Point(207, 120);
                bunifuCircleProgressbar4.Location = new Point(357, 120);

            }


            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar2.Location = new Point(120, 120);
                bunifuCircleProgressbar3.Location = new Point(280, 120);

            }
            else if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar3.Location = new Point(207, 120);

            }
            else if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == false))
            {

                bunifuCircleProgressbar2.Location = new Point(207, 120);

            }
            if (bunifuCheckbox3.Checked == true)
            {
                bunifuCircleProgressbar4.Visible = true;

            }
            else
            {
                bunifuCircleProgressbar4.Visible = false;
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                string message1 = "Please enter COM Port number";
                string title1 = "COM Port Error";
                MessageBox.Show(message1, title1);
                textBox11.Text = "";
                textBox11.Select();
                label40.Visible = true;
            }
            
                else if ((bunifuCheckbox1.Checked == true)&&(textBox7.Text == ""))
                {
                    string message2 = "Please enter a name for device 01";
                    string title2 = "Detail Error in device 01";
                    MessageBox.Show(message2, title2);
                }
                else if ((bunifuCheckbox1.Checked == true) && (textBox8.Text == ""))
                {
                    string message3 = "Please enter a pairing password for device 01";
                    string title3 = "Detail Error in device 01";
                    MessageBox.Show(message3, title3);
                }
                else if ((bunifuCheckbox1.Checked == true) && (textBox10.Text == ""))
                {
                    string message4 = "Please enter a Baud rate for device 01";
                    string title4 = "Detail Error in device 01";
                    MessageBox.Show(message4, title4);
                }
                else if ((bunifuCheckbox1.Checked == true) && ((textBox9.Text == "") || (textBox9.Text.Length != 14)))
                {
                    string message5 = "Please enter mac address for device 01 according to below instruction";
                    string title5 = "Detail Error in device 01";
                    MessageBox.Show(message5, title5);
                }
            

            
                else if ((bunifuCheckbox2.Checked == true)&&(textBox13.Text == ""))
                {
                    string message6 = "Please enter a name for device 02";
                    string title6 = "Detail Error in device 02";
                    MessageBox.Show(message6, title6);
                }
                else if ((bunifuCheckbox2.Checked == true) && (textBox14.Text == ""))
                {
                    string message7 = "Please enter a pairing password for device 02";
                    string title7 = "Detail Error in device 02";
                    MessageBox.Show(message7, title7);
                }
                else if ((bunifuCheckbox2.Checked == true) && (textBox16.Text == ""))
                {
                    string message8 = "Please enter a Baud rate for device 02";
                    string title8 = "Detail Error in device 02";
                    MessageBox.Show(message8, title8);
                }
                else if ((bunifuCheckbox2.Checked == true) && ((textBox15.Text == "") || (textBox15.Text.Length != 14)))
                {
                    string message9 = "Please enter mac address for device 02 according to below instruction";
                    string title9 = "Detail Error in device 02";
                    MessageBox.Show(message9, title9);
                }
            

           
                else if ((bunifuCheckbox3.Checked == true)&&(textBox17.Text == ""))
                {
                    string message10 = "Please enter a name for device 03";
                    string title10 = "Detail Error in device 03";
                    MessageBox.Show(message10, title10);
                }
                else if ((bunifuCheckbox3.Checked == true) && (textBox18.Text == ""))
                {
                    string message11 = "Please enter a pairing password for device 03";
                    string title11 = "Detail Error in device 03";
                    MessageBox.Show(message11, title11);
                }
                else if ((bunifuCheckbox3.Checked == true) && (textBox20.Text == ""))
                {
                    string message12 = "Please enter a Baud rate for device 03";
                    string title12 = "Detail Error in device 03";
                    MessageBox.Show(message12, title12);
                }
                else if ((bunifuCheckbox3.Checked == true) && ((textBox19.Text == "") || (textBox19.Text.Length != 14)))
                {
                    string message13 = "Please enter mac address for device 03 according to below instruction";
                    string title13 = "Detail Error in device 03";
                    MessageBox.Show(message13, title13);
                }
            
            else {

                if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == false)) {
                    textBox21.Text = "0";
                    timer9.Enabled = true;

                }
                if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == false))
                {
                    textBox21.Text = "0";
                    timer10.Enabled = true;

                }
                if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == true))
                {
                    textBox21.Text = "0";
                    timer11.Enabled = true;

                }
                if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == false))
                {
                    textBox21.Text = "0";
                    timer5.Enabled = true;

                }
                if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == false) && (bunifuCheckbox3.Checked == true))
                {
                    textBox21.Text = "0";
                    timer6.Enabled = true;

                }
                if ((bunifuCheckbox1.Checked == false) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == true))
                {
                    textBox21.Text = "0";
                    timer7.Enabled = true;

                }
                if ((bunifuCheckbox1.Checked == true) && (bunifuCheckbox2.Checked == true) && (bunifuCheckbox3.Checked == true))
                {
                    textBox21.Text = "0";
                    timer8.Enabled = true;

                }

            }


        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label40.Visible = false;
        }

        private void label31_Click(object sender, EventArgs e)
        {
            textBox7.Text = "HC-05";
            textBox13.Text = "HC-05";
            textBox17.Text = "HC-05";
            textBox8.Text = "1234";
            textBox14.Text = "1234";
            textBox18.Text = "1234";
            comboBox3.Text = "Slave";
            comboBox5.Text = "Slave";
            comboBox7.Text = "Slave";
            comboBox4.Text = "Specified address mode";
            comboBox6.Text = "Specified address mode";
            comboBox8.Text = "Specified address mode";
            textBox9.Text = "2039,56,9e0081";
            textBox15.Text = "2039,56,9e0081";
            textBox19.Text = "2039,56,9e0081";
            textBox10.Text = "9600";
            textBox16.Text = "9600";
            textBox20.Text = "9600";

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar2.Value = bunifuCircleProgressbar2.Value + 10;
            bunifuCircleProgressbar2.Text = bunifuCircleProgressbar2.Value.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar3.Value = bunifuCircleProgressbar3.Value + 10;
            bunifuCircleProgressbar3.Text = bunifuCircleProgressbar3.Value.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar4.Value = bunifuCircleProgressbar4.Value + 10;
            bunifuCircleProgressbar4.Text = bunifuCircleProgressbar4.Value.ToString();
        }

        private void bunifuCircleProgressbar2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void bunifuCircleProgressbar3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgressbar4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar2.Value == 0) {
                timer2.Enabled = true;

            }
            if ((bunifuCircleProgressbar2.Value == 100)&&(bunifuCircleProgressbar3.Value == 0))
            {
                timer2.Enabled = false;
                timer3.Enabled = true;
            }
            if (bunifuCircleProgressbar3.Value == 100)
            {
                timer3.Enabled = false;
                serialPort1.PortName = "COM" + textBox11.Text;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        if (comboBox3.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox3.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox4.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox9.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox7.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox7.Text.Length < 10)
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox8.Text.Length < 10)
                        {
                            textBox12.Text = (textBox8.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox10.Text.Length < 10)
                        {
                            textBox12.Text = (textBox10.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox7.Text.Length; t++)
                        {
                            serialPort1.Write(textBox7.Text.Substring(t, 1));

                        }
                        for (int tt = textBox7.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox8.Text.Length; s++)
                        {
                            serialPort1.Write(textBox8.Text.Substring(s, 1));

                        }
                        for (int ss = textBox8.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox10.Text.Length; x++)
                        {
                            serialPort1.Write(textBox10.Text.Substring(x, 1));

                        }
                        for (int xx = textBox10.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////




                        if (comboBox5.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox5.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox6.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox15.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox13.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox13.Text.Length < 10)
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox14.Text.Length < 10)
                        {
                            textBox12.Text = (textBox14.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox16.Text.Length < 10)
                        {
                            textBox12.Text = (textBox16.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox13.Text.Length; t++)
                        {
                            serialPort1.Write(textBox13.Text.Substring(t, 1));

                        }
                        for (int tt = textBox13.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox14.Text.Length; s++)
                        {
                            serialPort1.Write(textBox14.Text.Substring(s, 1));

                        }
                        for (int ss = textBox14.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox16.Text.Length; x++)
                        {
                            serialPort1.Write(textBox16.Text.Substring(x, 1));

                        }
                        for (int xx = textBox16.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////



                        if (comboBox3.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox3.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox4.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox9.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox7.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox7.Text.Length < 10)
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox8.Text.Length < 10)
                        {
                            textBox12.Text = (textBox8.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox10.Text.Length < 10)
                        {
                            textBox12.Text = (textBox10.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox7.Text.Length; t++)
                        {
                            serialPort1.Write(textBox7.Text.Substring(t, 1));

                        }
                        for (int tt = textBox7.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox8.Text.Length; s++)
                        {
                            serialPort1.Write(textBox8.Text.Substring(s, 1));

                        }
                        for (int ss = textBox8.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox10.Text.Length; x++)
                        {
                            serialPort1.Write(textBox10.Text.Substring(x, 1));

                        }
                        for (int xx = textBox10.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }

                        if (radioButton4.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        if (radioButton3.Checked == true)
                        {
                            serialPort1.Write("2");
                        }
                        /////////////////////////////////////////////////



                        serialPort1.Close();


                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }

                bunifuCircleProgressbar2.Value = 0;
                bunifuCircleProgressbar3.Value = 0;
                textBox21.Text = "4";

            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar2.Value == 0)
            {
                timer2.Enabled = true;

            }
            if ((bunifuCircleProgressbar2.Value == 100) && (bunifuCircleProgressbar4.Value == 0))
            {
                timer2.Enabled = false;
                timer4.Enabled = true;
            }

            if (bunifuCircleProgressbar4.Value == 100)
            {
                timer4.Enabled = false;
                serialPort1.PortName = "COM" + textBox11.Text;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        if (comboBox3.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox3.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox4.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox9.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox7.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox7.Text.Length < 10)
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox8.Text.Length < 10)
                        {
                            textBox12.Text = (textBox8.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox10.Text.Length < 10)
                        {
                            textBox12.Text = (textBox10.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox7.Text.Length; t++)
                        {
                            serialPort1.Write(textBox7.Text.Substring(t, 1));

                        }
                        for (int tt = textBox7.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox8.Text.Length; s++)
                        {
                            serialPort1.Write(textBox8.Text.Substring(s, 1));

                        }
                        for (int ss = textBox8.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox10.Text.Length; x++)
                        {
                            serialPort1.Write(textBox10.Text.Substring(x, 1));

                        }
                        for (int xx = textBox10.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////




                        if (comboBox3.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox3.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox4.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox9.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox7.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox7.Text.Length < 10)
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox8.Text.Length < 10)
                        {
                            textBox12.Text = (textBox8.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox10.Text.Length < 10)
                        {
                            textBox12.Text = (textBox10.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox7.Text.Length; t++)
                        {
                            serialPort1.Write(textBox7.Text.Substring(t, 1));

                        }
                        for (int tt = textBox7.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox8.Text.Length; s++)
                        {
                            serialPort1.Write(textBox8.Text.Substring(s, 1));

                        }
                        for (int ss = textBox8.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox10.Text.Length; x++)
                        {
                            serialPort1.Write(textBox10.Text.Substring(x, 1));

                        }
                        for (int xx = textBox10.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////



                        if (comboBox7.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox7.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox8.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox19.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox17.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox17.Text.Length < 10)
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox18.Text.Length < 10)
                        {
                            textBox12.Text = (textBox18.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox20.Text.Length < 10)
                        {
                            textBox12.Text = (textBox20.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox17.Text.Length; t++)
                        {
                            serialPort1.Write(textBox17.Text.Substring(t, 1));

                        }
                        for (int tt = textBox17.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox18.Text.Length; s++)
                        {
                            serialPort1.Write(textBox18.Text.Substring(s, 1));

                        }
                        for (int ss = textBox18.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox20.Text.Length; x++)
                        {
                            serialPort1.Write(textBox20.Text.Substring(x, 1));

                        }
                        for (int xx = textBox20.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }

                        if (radioButton4.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        if (radioButton3.Checked == true)
                        {
                            serialPort1.Write("2");
                        }
                        /////////////////////////////////////////////////



                        serialPort1.Close();


                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }

                bunifuCircleProgressbar2.Value = 0;
                bunifuCircleProgressbar4.Value = 0;
                textBox21.Text = "5";
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {

            if (bunifuCircleProgressbar3.Value == 0)
            {
                timer3.Enabled = true;

            }
            if ((bunifuCircleProgressbar3.Value == 100) && (bunifuCircleProgressbar4.Value == 0))
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
            }
            if (bunifuCircleProgressbar4.Value == 100)
            {
                timer4.Enabled = false;
                serialPort1.PortName = "COM" + textBox11.Text;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        if (comboBox5.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox5.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox6.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox15.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox13.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox13.Text.Length < 10)
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox14.Text.Length < 10)
                        {
                            textBox12.Text = (textBox14.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox16.Text.Length < 10)
                        {
                            textBox12.Text = (textBox16.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox13.Text.Length; t++)
                        {
                            serialPort1.Write(textBox13.Text.Substring(t, 1));

                        }
                        for (int tt = textBox13.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox14.Text.Length; s++)
                        {
                            serialPort1.Write(textBox14.Text.Substring(s, 1));

                        }
                        for (int ss = textBox14.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox16.Text.Length; x++)
                        {
                            serialPort1.Write(textBox16.Text.Substring(x, 1));

                        }
                        for (int xx = textBox16.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////




                        if (comboBox5.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox5.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox6.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox15.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox13.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox13.Text.Length < 10)
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox14.Text.Length < 10)
                        {
                            textBox12.Text = (textBox14.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox16.Text.Length < 10)
                        {
                            textBox12.Text = (textBox16.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox13.Text.Length; t++)
                        {
                            serialPort1.Write(textBox13.Text.Substring(t, 1));

                        }
                        for (int tt = textBox13.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox14.Text.Length; s++)
                        {
                            serialPort1.Write(textBox14.Text.Substring(s, 1));

                        }
                        for (int ss = textBox14.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox16.Text.Length; x++)
                        {
                            serialPort1.Write(textBox16.Text.Substring(x, 1));

                        }
                        for (int xx = textBox16.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////



                        if (comboBox7.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox7.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox8.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox19.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox17.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox17.Text.Length < 10)
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox18.Text.Length < 10)
                        {
                            textBox12.Text = (textBox18.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox20.Text.Length < 10)
                        {
                            textBox12.Text = (textBox20.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox17.Text.Length; t++)
                        {
                            serialPort1.Write(textBox17.Text.Substring(t, 1));

                        }
                        for (int tt = textBox17.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox18.Text.Length; s++)
                        {
                            serialPort1.Write(textBox18.Text.Substring(s, 1));

                        }
                        for (int ss = textBox18.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox20.Text.Length; x++)
                        {
                            serialPort1.Write(textBox20.Text.Substring(x, 1));

                        }
                        for (int xx = textBox20.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }

                        if (radioButton4.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        if (radioButton3.Checked == true)
                        {
                            serialPort1.Write("2");
                        }
                        /////////////////////////////////////////////////



                        serialPort1.Close();


                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }

                bunifuCircleProgressbar3.Value = 0;
                bunifuCircleProgressbar4.Value = 0;
                textBox21.Text = "6";
            }

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar2.Value == 0)
            {
                timer2.Enabled = true;

            }
            if ((bunifuCircleProgressbar2.Value == 100) && (bunifuCircleProgressbar3.Value == 0) && (bunifuCircleProgressbar4.Value == 0))
            {
                timer2.Enabled = false;
                timer3.Enabled = true;
            }
            if ((bunifuCircleProgressbar2.Value == 100) && (bunifuCircleProgressbar3.Value == 100) && (bunifuCircleProgressbar4.Value == 0))
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
            }
            if (bunifuCircleProgressbar4.Value == 100)
            {
                timer4.Enabled = false;
                serialPort1.PortName = "COM" + textBox11.Text;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        if (comboBox3.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox3.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox4.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox9.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox7.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox7.Text.Length < 10)
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox8.Text.Length < 10)
                        {
                            textBox12.Text = (textBox8.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox10.Text.Length < 10)
                        {
                            textBox12.Text = (textBox10.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox7.Text.Length; t++)
                        {
                            serialPort1.Write(textBox7.Text.Substring(t, 1));

                        }
                        for (int tt = textBox7.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox8.Text.Length; s++)
                        {
                            serialPort1.Write(textBox8.Text.Substring(s, 1));

                        }
                        for (int ss = textBox8.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox10.Text.Length; x++)
                        {
                            serialPort1.Write(textBox10.Text.Substring(x, 1));

                        }
                        for (int xx = textBox10.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////




                        if (comboBox5.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox5.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox6.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox15.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox13.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox13.Text.Length < 10)
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox14.Text.Length < 10)
                        {
                            textBox12.Text = (textBox14.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox16.Text.Length < 10)
                        {
                            textBox12.Text = (textBox16.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox13.Text.Length; t++)
                        {
                            serialPort1.Write(textBox13.Text.Substring(t, 1));

                        }
                        for (int tt = textBox13.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox14.Text.Length; s++)
                        {
                            serialPort1.Write(textBox14.Text.Substring(s, 1));

                        }
                        for (int ss = textBox14.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox16.Text.Length; x++)
                        {
                            serialPort1.Write(textBox16.Text.Substring(x, 1));

                        }
                        for (int xx = textBox16.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////



                        if (comboBox7.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox7.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox8.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox19.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox17.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox17.Text.Length < 10)
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox18.Text.Length < 10)
                        {
                            textBox12.Text = (textBox18.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox20.Text.Length < 10)
                        {
                            textBox12.Text = (textBox20.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox17.Text.Length; t++)
                        {
                            serialPort1.Write(textBox17.Text.Substring(t, 1));

                        }
                        for (int tt = textBox17.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox18.Text.Length; s++)
                        {
                            serialPort1.Write(textBox18.Text.Substring(s, 1));

                        }
                        for (int ss = textBox18.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox20.Text.Length; x++)
                        {
                            serialPort1.Write(textBox20.Text.Substring(x, 1));

                        }
                        for (int xx = textBox20.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }

                        if (radioButton4.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        if (radioButton3.Checked == true)
                        {
                            serialPort1.Write("2");
                        }
                        /////////////////////////////////////////////////



                        serialPort1.Close();


                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }
                bunifuCircleProgressbar2.Value = 0;
                bunifuCircleProgressbar3.Value = 0;
                bunifuCircleProgressbar4.Value = 0;
                textBox21.Text = "7";
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar2.Value == 0) {
                timer2.Enabled = true;

            }
            

            if (bunifuCircleProgressbar2.Value == 100)
            {
                
                timer2.Enabled = false;
                serialPort1.PortName = "COM" + textBox11.Text;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        if (comboBox3.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox3.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox4.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox9.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox7.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox7.Text.Length < 10)
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox8.Text.Length < 10)
                        {
                            textBox12.Text = (textBox8.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox10.Text.Length < 10)
                        {
                            textBox12.Text = (textBox10.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox7.Text.Length; t++)
                        {
                            serialPort1.Write(textBox7.Text.Substring(t, 1));

                        }
                        for (int tt = textBox7.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox8.Text.Length; s++)
                        {
                            serialPort1.Write(textBox8.Text.Substring(s, 1));

                        }
                        for (int ss = textBox8.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox10.Text.Length; x++)
                        {
                            serialPort1.Write(textBox10.Text.Substring(x, 1));

                        }
                        for (int xx = textBox10.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////




                        if (comboBox3.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox3.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox4.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox9.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox7.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox7.Text.Length < 10)
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox8.Text.Length < 10)
                        {
                            textBox12.Text = (textBox8.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox10.Text.Length < 10)
                        {
                            textBox12.Text = (textBox10.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox7.Text.Length; t++)
                        {
                            serialPort1.Write(textBox7.Text.Substring(t, 1));

                        }
                        for (int tt = textBox7.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox8.Text.Length; s++)
                        {
                            serialPort1.Write(textBox8.Text.Substring(s, 1));

                        }
                        for (int ss = textBox8.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox10.Text.Length; x++)
                        {
                            serialPort1.Write(textBox10.Text.Substring(x, 1));

                        }
                        for (int xx = textBox10.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////



                        if (comboBox3.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox3.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox4.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox9.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox7.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox7.Text.Length < 10)
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox7.Text.Length < 32) && (textBox7.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox7.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox8.Text.Length < 10)
                        {
                            textBox12.Text = (textBox8.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox10.Text.Length < 10)
                        {
                            textBox12.Text = (textBox10.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox7.Text.Length; t++)
                        {
                            serialPort1.Write(textBox7.Text.Substring(t, 1));

                        }
                        for (int tt = textBox7.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox8.Text.Length; s++)
                        {
                            serialPort1.Write(textBox8.Text.Substring(s, 1));

                        }
                        for (int ss = textBox8.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox10.Text.Length; x++)
                        {
                            serialPort1.Write(textBox10.Text.Substring(x, 1));

                        }
                        for (int xx = textBox10.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }

                        if (radioButton4.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        if (radioButton3.Checked == true)
                        {
                            serialPort1.Write("2");
                        }
                        /////////////////////////////////////////////////



                        serialPort1.Close();


                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }

                bunifuCircleProgressbar2.Value = 0;
                
                textBox21.Text = "1";
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar3.Value == 0) {
                timer3.Enabled = true;

            }

                if (bunifuCircleProgressbar3.Value == 100)
            {
                timer3.Enabled = false;
                serialPort1.PortName = "COM" + textBox11.Text;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        if (comboBox5.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox5.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox6.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox15.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox13.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox13.Text.Length < 10)
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox14.Text.Length < 10)
                        {
                            textBox12.Text = (textBox14.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox16.Text.Length < 10)
                        {
                            textBox12.Text = (textBox16.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox13.Text.Length; t++)
                        {
                            serialPort1.Write(textBox13.Text.Substring(t, 1));

                        }
                        for (int tt = textBox13.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox14.Text.Length; s++)
                        {
                            serialPort1.Write(textBox14.Text.Substring(s, 1));

                        }
                        for (int ss = textBox14.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox16.Text.Length; x++)
                        {
                            serialPort1.Write(textBox16.Text.Substring(x, 1));

                        }
                        for (int xx = textBox16.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////




                        if (comboBox5.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox5.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox6.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox15.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox13.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox13.Text.Length < 10)
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox14.Text.Length < 10)
                        {
                            textBox12.Text = (textBox14.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox16.Text.Length < 10)
                        {
                            textBox12.Text = (textBox16.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox13.Text.Length; t++)
                        {
                            serialPort1.Write(textBox13.Text.Substring(t, 1));

                        }
                        for (int tt = textBox13.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox14.Text.Length; s++)
                        {
                            serialPort1.Write(textBox14.Text.Substring(s, 1));

                        }
                        for (int ss = textBox14.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox16.Text.Length; x++)
                        {
                            serialPort1.Write(textBox16.Text.Substring(x, 1));

                        }
                        for (int xx = textBox16.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////



                        if (comboBox5.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox5.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox6.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox15.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox13.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox13.Text.Length < 10)
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox13.Text.Length < 32) && (textBox13.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox13.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox14.Text.Length < 10)
                        {
                            textBox12.Text = (textBox14.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox16.Text.Length < 10)
                        {
                            textBox12.Text = (textBox16.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox13.Text.Length; t++)
                        {
                            serialPort1.Write(textBox13.Text.Substring(t, 1));

                        }
                        for (int tt = textBox13.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox14.Text.Length; s++)
                        {
                            serialPort1.Write(textBox14.Text.Substring(s, 1));

                        }
                        for (int ss = textBox14.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox16.Text.Length; x++)
                        {
                            serialPort1.Write(textBox16.Text.Substring(x, 1));

                        }
                        for (int xx = textBox16.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }

                        if (radioButton4.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        if (radioButton3.Checked == true)
                        {
                            serialPort1.Write("2");
                        }
                        /////////////////////////////////////////////////



                        serialPort1.Close();


                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }

                bunifuCircleProgressbar3.Value = 0;
                
                textBox21.Text = "2";
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar4.Value == 0) {

                timer4.Enabled = true;
            }


                if (bunifuCircleProgressbar4.Value == 100)
            {
                timer4.Enabled = false;
                serialPort1.PortName = "COM" + textBox11.Text;
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        if (comboBox7.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox7.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox8.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox19.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox17.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox17.Text.Length < 10)
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox18.Text.Length < 10)
                        {
                            textBox12.Text = (textBox18.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox20.Text.Length < 10)
                        {
                            textBox12.Text = (textBox20.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox17.Text.Length; t++)
                        {
                            serialPort1.Write(textBox17.Text.Substring(t, 1));

                        }
                        for (int tt = textBox17.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox18.Text.Length; s++)
                        {
                            serialPort1.Write(textBox18.Text.Substring(s, 1));

                        }
                        for (int ss = textBox18.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox20.Text.Length; x++)
                        {
                            serialPort1.Write(textBox20.Text.Substring(x, 1));

                        }
                        for (int xx = textBox20.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////




                        if (comboBox7.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox7.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox8.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox19.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox17.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox17.Text.Length < 10)
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox18.Text.Length < 10)
                        {
                            textBox12.Text = (textBox18.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox20.Text.Length < 10)
                        {
                            textBox12.Text = (textBox20.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox17.Text.Length; t++)
                        {
                            serialPort1.Write(textBox17.Text.Substring(t, 1));

                        }
                        for (int tt = textBox17.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox18.Text.Length; s++)
                        {
                            serialPort1.Write(textBox18.Text.Substring(s, 1));

                        }
                        for (int ss = textBox18.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox20.Text.Length; x++)
                        {
                            serialPort1.Write(textBox20.Text.Substring(x, 1));

                        }
                        for (int xx = textBox20.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }
                        /////////////////////////////////////////////////



                        if (comboBox7.Text == "Slave")
                        {
                            serialPort1.Write("0");
                        }
                        else if (comboBox7.Text == "Slave-loop")
                        {

                            serialPort1.Write("2");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }



                        if (comboBox8.Text == "Specified address mode")
                        {
                            serialPort1.Write("0");
                        }
                        else
                        {
                            serialPort1.Write("1");
                        }

                        for (int i = 0; i < 14; i++)
                        {
                            serialPort1.Write(textBox19.Text.Substring(i, 1));

                        }

                        /////////////////////////////////////////
                        if (textBox17.Text.Length < 10)
                        {
                            serialPort1.Write("0");

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("3");

                        }
                        /////////////////////////////////////////////

                        if (textBox17.Text.Length < 10)
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else if ((textBox17.Text.Length < 32) && (textBox17.Text.Length >= 10))
                        {
                            textBox12.Text = (textBox17.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(1, 1));

                        }
                        else
                        {

                            serialPort1.Write("2");

                        }
                        /////////////////////////////////////////////


                        if (textBox18.Text.Length < 10)
                        {
                            textBox12.Text = (textBox18.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////

                        if (textBox20.Text.Length < 10)
                        {
                            textBox12.Text = (textBox20.Text.Length).ToString();
                            serialPort1.Write(textBox12.Text.Substring(0, 1));

                        }
                        else
                        {

                            serialPort1.Write("0");

                        }
                        /////////////////////////////////////////////


                        for (int t = 0; t < textBox17.Text.Length; t++)
                        {
                            serialPort1.Write(textBox17.Text.Substring(t, 1));

                        }
                        for (int tt = textBox17.Text.Length; tt < 32; tt++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////

                        for (int s = 0; s < textBox18.Text.Length; s++)
                        {
                            serialPort1.Write(textBox18.Text.Substring(s, 1));

                        }
                        for (int ss = textBox18.Text.Length; ss < 10; ss++)
                        {
                            serialPort1.Write("*");

                        }
                        ////////////////////////////////////////////////

                        for (int x = 0; x < textBox20.Text.Length; x++)
                        {
                            serialPort1.Write(textBox20.Text.Substring(x, 1));

                        }
                        for (int xx = textBox20.Text.Length; xx < 10; xx++)
                        {
                            serialPort1.Write("*");

                        }

                        if (radioButton4.Checked == true)
                        {
                            serialPort1.Write("1");
                        }
                        if (radioButton3.Checked == true)
                        {
                            serialPort1.Write("2");
                        }
                        /////////////////////////////////////////////////



                        serialPort1.Close();


                    }
                    catch
                    {
                        MessageBox.Show("There was an error. Please make sure that the correct port was selected, and the device, plugged in.");
                    }
                }

                bunifuCircleProgressbar4.Value = 0;
                textBox21.Text = "3";
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text == "1") {
                timer9.Enabled = false;
                string message10 = "All the data are uploading completed";
                string title10 = "Bluetooth Coder";
                MessageBox.Show(message10, title10);
            }

            if (textBox21.Text == "2")
            {
                timer10.Enabled = false;
                string message1 = "All the data are uploading completed";
                string title1 = "Bluetooth Coder";
                MessageBox.Show(message1, title1);
            }
            if (textBox21.Text == "3")
            {
                timer11.Enabled = false;
                string message2 = "All the data are uploading completed";
                string title2 = "Bluetooth Coder";
                MessageBox.Show(message2, title2);
            }
            if (textBox21.Text == "4")
            {
                timer5.Enabled = false;
                string message3 = "All the data are uploading completed";
                string title3 = "Bluetooth Coder";
                MessageBox.Show(message3, title3);
            }
            if (textBox21.Text == "5")
            {
                timer6.Enabled = false;
                string message4 = "All the data are uploading completed";
                string title4 = "Bluetooth Coder";
                MessageBox.Show(message4, title4);
            }
            if (textBox21.Text == "6")
            {
                timer7.Enabled = false;
                string message5 = "All the data are uploading completed";
                string title5 = "Bluetooth Coder";
                MessageBox.Show(message5, title5);
            }
            if (textBox21.Text == "7")
            {
                timer8.Enabled = false;
                string message6 = "All the data are uploading completed";
                string title6 = "Bluetooth Coder";
                MessageBox.Show(message6, title6);
            }


        }

        private void bunifuCheckbox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label32_MouseMove(object sender, MouseEventArgs e)
        {
            label32.ForeColor = Color.FromArgb(0, 131, 204);
        }

        private void label31_MouseMove(object sender, MouseEventArgs e)
        {
            label31.ForeColor = Color.FromArgb(0, 131, 204);
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            label31.ForeColor = Color.FromArgb(0, 0, 0);
            label32.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
