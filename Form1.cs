using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Runtime.Serialization;


namespace Brunvoll_utplasseringsprosjekt
{
    public partial class Form1 : Form
    {
        public void max()
        {
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            int min1 = 0;
            int min2 = 0;
            int min3 = 0;
            Int32.TryParse(textBox1.Text, out max1);
            Int32.TryParse(textBox2.Text, out max2);
            Int32.TryParse(textBox3.Text, out max3);
            Int32.TryParse(textBox12.Text, out min1);
            Int32.TryParse(textBox11.Text, out min2);
            Int32.TryParse(textBox10.Text, out min3);

            if (max1 < min1)
            {
                textBox1.ForeColor = Color.Red;
                textBox12.ForeColor = Color.Red;
                textBox9.ForeColor = Color.Red;
                textBox4.ForeColor = Color.Red;

            }
            else if (max2 < min2)
            {
                textBox2.ForeColor = Color.Red;
                textBox8.ForeColor = Color.Red;
                textBox11.ForeColor = Color.Red;
                textBox5.ForeColor = Color.Red;
            }
            else if (max3 < min3)
            {
                textBox3.ForeColor = Color.Red;
                textBox7.ForeColor = Color.Red;
                textBox10.ForeColor = Color.Red;
                textBox6.ForeColor = Color.Red;
            }
            else if (max1 == min1)
            {
                textBox1.ForeColor = Color.Green;
                textBox12.ForeColor = Color.Green;
                textBox9.ForeColor = Color.Green;
                textBox4.ForeColor = Color.Green;

            }
            else if (max2 == min2)
            {
                textBox2.ForeColor = Color.Green;
                textBox8.ForeColor = Color.Green;
                textBox11.ForeColor = Color.Green;
                textBox5.ForeColor = Color.Green;
            }
            else if (max3 == min3)
            {
                textBox3.ForeColor = Color.Green;
                textBox7.ForeColor = Color.Green;
                textBox10.ForeColor = Color.Green;
                textBox6.ForeColor = Color.Green;
            }
        }

        public void placementMax()
        {
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            int max4 = 0;
            int min1 = 0;
            int min2 = 0;
            int min3 = 0;
            int min4 = 0;
            Int32.TryParse(textBox17.Text, out max1);
            Int32.TryParse(textBox20.Text, out max2);
            Int32.TryParse(textBox25.Text, out max3);
            Int32.TryParse(textBox30.Text, out max4);
            Int32.TryParse(textBox15.Text, out min1);
            Int32.TryParse(textBox18.Text, out min2);
            Int32.TryParse(textBox23.Text, out min3);
            Int32.TryParse(textBox27.Text, out min4);

            if (max1 == min1)
            {
                textBox14.ForeColor = Color.Green;
                textBox15.ForeColor = Color.Green;
                textBox16.ForeColor = Color.Green;
                textBox17.ForeColor = Color.Green;

            }
            else if (max2 == min2)
            {
                textBox21.ForeColor = Color.Green;
                textBox18.ForeColor = Color.Green;
                textBox19.ForeColor = Color.Green;
                textBox20.ForeColor = Color.Green;
            }
            else if (max3 == min3)
            {
                textBox26.ForeColor = Color.Green;
                textBox23.ForeColor = Color.Green;
                textBox24.ForeColor = Color.Green;
                textBox25.ForeColor = Color.Green;
            }
            else if (max4 == min4)
            {
                textBox31.ForeColor = Color.Green;
                textBox27.ForeColor = Color.Green;
                textBox29.ForeColor = Color.Green;
                textBox30.ForeColor = Color.Green;
            }
            else if (max1 != min1)
            {
                textBox14.ForeColor = Color.Red;
                textBox15.ForeColor = Color.Red;
                textBox16.ForeColor = Color.Red;
                textBox17.ForeColor = Color.Red;

            }
            else if (max2 != min2)
            {
                textBox21.ForeColor = Color.Red;
                textBox18.ForeColor = Color.Red;
                textBox19.ForeColor = Color.Red;
                textBox20.ForeColor = Color.Red;
            }
            else if (max3 != min3)
            {
                textBox26.ForeColor = Color.Red;
                textBox23.ForeColor = Color.Red;
                textBox24.ForeColor = Color.Red;
                textBox25.ForeColor = Color.Red;
            }
            else if (max4 != min4)
            {
                textBox31.ForeColor = Color.Red;
                textBox27.ForeColor = Color.Red;
                textBox29.ForeColor = Color.Red;
                textBox30.ForeColor = Color.Red;
            }

        }

        public void tunnelCounterDual()
        {
            int tuntracker = 0;
            Int32.TryParse(textBox11.Text, out tuntracker);
            tuntracker++;
            tuntracker++;
            textBox11.Text = tuntracker.ToString();
        }

        public void tunnelCounterSINGLE()
        {
            int tuntracker = 0;
            Int32.TryParse(textBox11.Text, out tuntracker);
            tuntracker++;
            textBox11.Text = tuntracker.ToString();
        }

        public void azimuthCounter()
        {
            int azitracker = 0;
            Int32.TryParse(textBox12.Text, out azitracker);
            azitracker++;
            textBox12.Text = azitracker.ToString();
        }
        public void azimuthPropCounter()
        {
            int azitracker = 0;
            Int32.TryParse(textBox10.Text, out azitracker);
            azitracker++;
            textBox10.Text = azitracker.ToString();
        }

        public void aziBowCounter()
        {
            int aziBow = 0;
            Int32.TryParse(textBox18.Text, out aziBow);
            aziBow++;
            textBox18.Text = aziBow.ToString();
        }

        public void aziSternCounter()
        {
            int aziStern = 0;
            Int32.TryParse(textBox15.Text, out aziStern);
            aziStern++;
            textBox15.Text = aziStern.ToString();
        }

        public void tunBowCounter()
        {
            int tunBow = 0;
            Int32.TryParse(textBox27.Text, out tunBow);
            tunBow++;
            textBox27.Text = tunBow.ToString();
        }

        public void tunSternCounter()
        {
            int tunStern = 0;
            Int32.TryParse(textBox23.Text, out tunStern);
            tunStern++;
            textBox23.Text = tunStern.ToString();
        }

        public void export()
        {
            using (var bmp = new Bitmap(panel1.Width, panel1.Height))
            {
                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    bmp.Save(sfd.FileName, format);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button12.Visible = false;
            button15.Visible = false;
            button1.Visible = false;


            panel1.AllowDrop = true;
            panel2.AllowDrop = true;
            panel3.AllowDrop = true;
            panel5.AllowDrop = true;
            panel4.AllowDrop = true;
            panel6.AllowDrop = true;
            BC_5_panel_azimuth.AllowDrop = true;

            panel1.DragEnter += panel_DragEnter;
            panel2.DragEnter += panel_DragEnter;
            panel3.DragEnter += panel_DragEnter;
            panel5.DragEnter += panel_DragEnter;
            panel4.DragEnter += panel_DragEnter;
            panel6.DragEnter += panel_DragEnter;
            BC_5_panel_azimuth.DragEnter += panel_DragEnter;

            panel1.DragDrop += panel_DragDrop;
            panel2.DragDrop += panel_DragDrop;
            panel3.DragDrop += panel_DragDrop;
            panel5.DragDrop += panel_DragDrop;
            panel4.DragDrop += panel_DragDrop;
            panel6.DragDrop += panel_DragDrop;
            BC_5_panel_azimuth.DragDrop += panel_DragDrop;

            Getthruster();

        }

        private thrusters Getthruster()
        {
            string text = File.ReadAllText(@"../../thrusters.json");
            var test = JsonConvert.DeserializeObject<thrusters>(text);
            int aziCounter = 0;
            int aziStern = 0;
            int aziBow = 0;
            int aziPropCounter = 0;
            int tunCounter = 0;
            int tunStern = 0;
            int tunBow = 0;

            foreach (var i in test.thruster)
            {

                var type = i.type;
                var placement = i.placement;

                if (type == "azimuth")
                {
                    aziCounter++;
                    if (placement == "stern")
                    {
                        aziStern++;
                    }
                    else if (placement == "bow")
                    {
                        aziBow++;
                    }

                }
                else if (type == "tunnel")
                {
                    tunCounter++;
                    if (placement == "stern")
                    {
                        tunStern++;
                    }
                    else if (placement == "bow")
                    {
                        tunBow++;
                    }
                }
                else if (type == "azimuth_propulsion")
                {
                    aziPropCounter++;
                }
            }

            textBox1.Text = aziCounter.ToString();
            textBox2.Text = tunCounter.ToString();
            textBox3.Text = aziPropCounter.ToString();

            textBox17.Text = aziStern.ToString();
            textBox20.Text = aziBow.ToString();

            textBox25.Text = tunStern.ToString();
            textBox30.Text = tunBow.ToString();



            thrusters x = null;
            return x;
        }

        public class thrusters
        {
            public List<thrusteritem> thruster { get; set; }
        }

        public class thrusteritem
        {
            public int id { get; set; }
            public string type { get; set; }
            public string placement { get; set; }
        }

        private void BC_5_panel_azimuth_Click(object sender, EventArgs e)
        {
            azimuthCounter();
            placementMax();
            max();
            azimuth();
        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            placementMax();
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;

            placementMax();
            max();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            export();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            azimuthCounter();
            azimuthWO();
            placementMax();
            max();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tunnelCounterSINGLE();
            Tunnel();
            max();
            placementMax();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BC_5_panel_azimuth.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button1.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button12.Visible = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button12.Visible = false;
            button1.Visible = false;

            BC_5_panel_azimuth.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tunnelCounterSINGLE();
            TunnelWO();
            placementMax();
            max();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tunnelCounterDual();
            TwoTunnelsWO();
            max();
            placementMax();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel5.Controls.Clear();
            panel4.Controls.Clear();
            panel6.Controls.Clear();
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";

            textBox3.ForeColor = Color.Black;
            textBox7.ForeColor = Color.Black;
            textBox10.ForeColor = Color.Black;
            textBox6.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            textBox8.ForeColor = Color.Black;
            textBox11.ForeColor = Color.Black;
            textBox5.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
            textBox12.ForeColor = Color.Black;
            textBox9.ForeColor = Color.Black;
            textBox4.ForeColor = Color.Black;
            textBox14.ForeColor = Color.Red;
            textBox15.ForeColor = Color.Red;
            textBox16.ForeColor = Color.Red;
            textBox17.ForeColor = Color.Red;
            textBox21.ForeColor = Color.Red;
            textBox18.ForeColor = Color.Red;
            textBox19.ForeColor = Color.Red;
            textBox20.ForeColor = Color.Red;
            textBox26.ForeColor = Color.Red;
            textBox23.ForeColor = Color.Red;
            textBox24.ForeColor = Color.Red;
            textBox25.ForeColor = Color.Red;
            textBox31.ForeColor = Color.Red;
            textBox27.ForeColor = Color.Red;
            textBox29.ForeColor = Color.Red;
            textBox30.ForeColor = Color.Red;
            textBox13.Text = "Missing screen";
            textBox18.Text = "";
            textBox15.Text = "";
            textBox23.Text = "";
            textBox27.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tunnelCounterDual();
            TwoTunnelsDP();
            placementMax();
            max();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tunnelCounterDual();
            TwoTunnels();
            placementMax();
            max();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screen();
            placementMax();
            max();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button12.Visible = false;

            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button1.Visible = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            azimuthPropCounter();
            azimuthPropWO();
            max();
            placementMax();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button12.Visible = true;

            button15.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button1.Visible = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            azimuthPropCounter();
            azimuthProp();
            max();
            placementMax();
        }

        public void azimuth()
        {
            var test = new Button();

            test.BackgroundImage = Properties.Resources.BC_5_panel_azimuth;
            test.BackgroundImage.Tag = "screen";
            test.BackgroundImageLayout = ImageLayout.Stretch;
            test.Height = 130;
            test.Name = "azimuth";
            test.Tag = "azimuth";
            test.Width = 150;
            BC_5_panel_azimuth.Controls.Add(test);
            test.DragDrop += panel_DragDrop;
            test.AllowDrop = true;
            test.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            test.MouseEnter += delegate
            {
                if (BC_5_panel_azimuth.Controls.Contains(test))
                {
                    if (test.BackgroundImage.Tag == "screen")
                    {
                        textBox13.Text = "";
                    };
                    placementMax();
                    test.DoDragDrop(test, DragDropEffects.Move);
                    if (panel2.Controls.Contains(test))
                    {
                        aziBowCounter();
                    }
                    else if (panel5.Controls.Contains(test))
                    {
                        aziSternCounter();
                    }
                }
                else
                {
                    ControlExtension.Draggable(test, true);

                }
            };
        }

        public void azimuthWO()
        {
            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_panel_azimuth_wo_monitor;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Height = 130;
            btn.Width = 100;
            btn.Tag = "azimuthWO";
            button1.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                if (button1.Controls.Contains(btn))
                {
                    placementMax();
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    if (panel2.Controls.Contains(btn))
                    {
                        aziBowCounter();
                    }
                    else if (panel5.Controls.Contains(btn))
                    {
                        aziSternCounter();
                    }
                }
                else
                {
                    ControlExtension.Draggable(btn, true);

                }
            };
        }

        public void Tunnel()
        {
            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_panel_tunnel;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage.Tag = "screen";
            btn.Height = 130;
            btn.Width = 160;
            btn.Tag = "tunnel-single";
            button4.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                if (button4.Controls.Contains(btn))
                {
                    if (btn.BackgroundImage.Tag == "screen")
                    {
                        textBox13.Text = "";
                    };
                    placementMax();
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    if (panel2.Controls.Contains(btn))
                    {
                        tunBowCounter();
                    }
                    else if (panel5.Controls.Contains(btn))
                    {
                        tunSternCounter();
                    }
                }
                else
                {
                    ControlExtension.Draggable(btn, true);

                }
            };
        }

        public void TunnelWO()
        {
            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_panel_tunnel_wo_monitor;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Height = 130;
            btn.Width = 100;
            btn.Tag = "tunnel-single-wo-monitor";
            button6.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                if (button6.Controls.Contains(btn))
                {
                    placementMax();
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    if (panel2.Controls.Contains(btn))
                    {
                        tunBowCounter();
                    }
                    else if (panel5.Controls.Contains(btn))
                    {
                        tunSternCounter();
                    }
                }
                else
                {
                    ControlExtension.Draggable(btn, true);

                }
            };
        }

        public void TwoTunnelsDP()
        {

            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_panel_two_tunnels_dp;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage.Tag = "screen";
            btn.Height = 130;
            btn.Tag = "tunnel-dual-dp";
            btn.Width = 225;
            button8.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                if (button8.Controls.Contains(btn))
                {
                    if (btn.BackgroundImage.Tag == "screen")
                    {
                        textBox13.Text = "";
                    };
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    placementMax();
                    if (panel2.Controls.Contains(btn))
                    {
                        tunBowCounter();
                        tunBowCounter();
                    }
                    else if (panel5.Controls.Contains(btn))
                    {
                        tunSternCounter();
                        tunSternCounter();
                    }
                }
                else
                {
                    ControlExtension.Draggable(btn, true);

                }
            };
        }

        public void TwoTunnelsWO()
        {
            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_panel_two_tunnels_wo_monitor___Copy;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Height = 130;
            btn.Tag = "tunnel-dual-wo-monitor";
            btn.Width = 100;
            button9.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                if (button9.Controls.Contains(btn))
                {
                    placementMax();
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    if (panel2.Controls.Contains(btn))
                    {
                        tunBowCounter();
                        tunBowCounter();

                    }
                    else if (panel5.Controls.Contains(btn))
                    {
                        tunSternCounter();
                        tunSternCounter();
                    }
                }
                else
                {
                    ControlExtension.Draggable(btn, true);

                }
            };
        }

        public void TwoTunnels()
        {
            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_panel_two_tunnels;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage.Tag = "screen";
            btn.Tag = "tunnel-dual";
            btn.Height = 130;
            btn.Width = 160;
            button7.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                if (button7.Controls.Contains(btn))
                {
                    if (btn.BackgroundImage.Tag == "screen")
                    {
                        textBox13.Text = "";
                    };
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    placementMax();
                    if (panel2.Controls.Contains(btn))
                    {
                        tunBowCounter();
                        tunBowCounter();
                    }
                    else if (panel5.Controls.Contains(btn))
                    {
                        tunSternCounter();
                        tunSternCounter();
                    }
                }
                else
                {
                    ControlExtension.Draggable(btn, true);

                }
            };
        }

        public void screen()
        {
            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_common_monitor;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage.Tag = "screen";
            btn.Tag = "monitor";
            btn.Height = 450;
            btn.Width = 210;
            button2.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                if (button2.Controls.Contains(btn))
                {
                    if (btn.BackgroundImage.Tag == "screen")
                    {
                        textBox13.Text = "";
                    };
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    placementMax();
                }
                else
                {
                    ControlExtension.Draggable(btn, true);
                }
            };
        }

        public void azimuthProp()
        {
            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_panel_azimuth_propulsion;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackgroundImage.Tag = "screen";
            btn.Tag = "azimuth-propulsion";
            btn.Height = 130;
            btn.Width = 160;
            button14.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                placementMax();
                if (button14.Controls.Contains(btn))
                {
                    if (btn.BackgroundImage.Tag == "screen")
                    {
                        textBox13.Text = "";
                    };
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    panel2.BackColor = Color.DarkRed;
                    panel5.BackColor = Color.DarkRed;
                    panel1.BackColor = Color.DarkRed;

                }
                else
                {
                    panel2.BackColor = Color.Gainsboro;
                    panel5.BackColor = Color.DimGray;
                    panel1.BackColor = Color.LightGray;
                    ControlExtension.Draggable(btn, true);

                }
            };
        }

        public void azimuthPropWO()
        {
            var btn = new Button();
            btn.BackgroundImage = Properties.Resources.BC_5_panel_azimuth_wo_monitor_propulsion;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Height = 130;
            btn.Width = 100;
            btn.Tag = "azimuth-propulsion-wo";
            button13.Controls.Add(btn);
            btn.DragDrop += panel_DragDrop;
            btn.AllowDrop = true;
            btn.MouseLeave += delegate
            {
                placementMax();
                max();
            };
            btn.MouseEnter += delegate
            {
                if (button13.Controls.Contains(btn))
                {
                    btn.DoDragDrop(btn, DragDropEffects.Move);
                    panel2.BackColor = Color.DarkRed;
                    panel5.BackColor = Color.DarkRed;
                    panel1.BackColor = Color.DarkRed;
                    placementMax();
                }
                else
                {
                    panel2.BackColor = Color.Gainsboro;
                    panel5.BackColor = Color.DimGray;
                    panel1.BackColor = Color.LightGray;
                    ControlExtension.Draggable(btn, true);
                    placementMax();
                }
            };
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveProgress();
        }

        public void SaveProgress()
        {
            List<saves> items = new List<saves>();

            foreach (Control c in panel2.Controls)
            {
                StringBuilder builder = new StringBuilder();
                Enumerable
                   .Range(65, 26)
                    .Select(m => ((char)m).ToString())
                    .Concat(Enumerable.Range(97, 26).Select(m => ((char)m).ToString()))
                    .Concat(Enumerable.Range(0, 10).Select(m => m.ToString()))
                    .OrderBy(m => Guid.NewGuid())
                    .Take(11)
                    .ToList().ForEach(m => builder.Append(m));
                string id = builder.ToString();

                var type = "";

                if (c.Tag == null)
                {
                    type = "unknown";
                }
                else
                {
                    type = c.Tag.ToString();
                }

                Point locationOnForm = c.FindForm().PointToClient(c.Parent.PointToScreen(c.Location));

                var location = locationOnForm.ToString();

                var saveItem = new saves
                {
                    id = id,
                    type = type,
                    zone = "bow",
                    location = location
                };

                items.Add(saveItem);
            }

            foreach (Control c in panel5.Controls)
            {
                StringBuilder builder = new StringBuilder();
                Enumerable
                   .Range(65, 26)
                    .Select(b => ((char)b).ToString())
                    .Concat(Enumerable.Range(97, 26).Select(b => ((char)b).ToString()))
                    .Concat(Enumerable.Range(0, 10).Select(b => b.ToString()))
                    .OrderBy(b => Guid.NewGuid())
                    .Take(11)
                    .ToList().ForEach(b => builder.Append(b));
                string id = builder.ToString();

                var type = "";

                if (c.Tag == null)
                {
                    type = "unknown";
                }
                else
                {
                    type = c.Tag.ToString();
                }

                Point locationOnForm = c.FindForm().PointToClient(c.Parent.PointToScreen(c.Location));

                var location = locationOnForm.ToString();

                var saveItem = new saves
                {
                    id = id,
                    type = type,
                    zone = "stern",
                    location = location
                };

                items.Add(saveItem);
            }

            foreach (Control c in panel3.Controls)
            {
                StringBuilder builder = new StringBuilder();
                Enumerable
                   .Range(65, 26)
                    .Select(f => ((char)f).ToString())
                    .Concat(Enumerable.Range(97, 26).Select(f => ((char)f).ToString()))
                    .Concat(Enumerable.Range(0, 10).Select(f => f.ToString()))
                    .OrderBy(f => Guid.NewGuid())
                    .Take(11)
                    .ToList().ForEach(f => builder.Append(f));
                string id = builder.ToString();

                var type = "";

                if (c.Tag == null)
                {
                    type = "unknown";
                }
                else
                {
                    type = c.Tag.ToString();
                }

                Point locationOnForm = c.FindForm().PointToClient(c.Parent.PointToScreen(c.Location));

                var location = locationOnForm.ToString();

                var saveItem = new saves
                {
                    id = id,
                    type = type,
                    zone = "propulsion",
                    location = location
                };

                items.Add(saveItem);
            }

            foreach (Control c in panel4.Controls)
            {
                StringBuilder builder = new StringBuilder();
                Enumerable
                   .Range(65, 26)
                    .Select(l => ((char)l).ToString())
                    .Concat(Enumerable.Range(97, 26).Select(l => ((char)l).ToString()))
                    .Concat(Enumerable.Range(0, 10).Select(l => l.ToString()))
                    .OrderBy(l => Guid.NewGuid())
                    .Take(11)
                    .ToList().ForEach(l => builder.Append(l));
                string id = builder.ToString();

                var type = "";

                if (c.Tag == null)
                {
                    type = "unknown";
                }
                else
                {
                    type = c.Tag.ToString();
                }

                Point locationOnForm = c.FindForm().PointToClient(c.Parent.PointToScreen(c.Location));

                var location = locationOnForm.ToString();

                var saveItem = new saves
                {
                    id = id,
                    type = type,
                    zone = "screen-left",
                    location = location
                };

                items.Add(saveItem);
            }

            foreach (Control c in panel6.Controls)
            {
                StringBuilder builder = new StringBuilder();
                Enumerable
                   .Range(65, 26)
                    .Select(o => ((char)o).ToString())
                    .Concat(Enumerable.Range(97, 26).Select(o => ((char)o).ToString()))
                    .Concat(Enumerable.Range(0, 10).Select(o => o.ToString()))
                    .OrderBy(o => Guid.NewGuid())
                    .Take(11)
                    .ToList().ForEach(o => builder.Append(o));
                string id = builder.ToString();

                var type = "";

                if (c.Tag == null)
                {
                    type = "unknown";
                }
                else
                {
                    type = c.Tag.ToString();
                }

                Point locationOnForm = c.FindForm().PointToClient(c.Parent.PointToScreen(c.Location));

                var location = locationOnForm.ToString();

                var saveItem = new saves
                {
                    id = id,
                    type = type,
                    zone = "screen-right",
                    location = location
                };

                items.Add(saveItem);
            }

            var test = JsonConvert.SerializeObject(items, Formatting.Indented);


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "save files (*.json)|*.json|All files (*.*)|*.*";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);

                System.IO.File.WriteAllText(sfd.FileName, test);
            }
        }

        public class saved
        {
            List<saves> Saved = new List<saves>();
        }

        public class saves
        {
            public string id { get; set; }
            public string type { get; set; }
            public string zone { get; set; }
            public string location { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }


            string text = File.ReadAllText(filePath);
            List<saves> fileJSON = JsonConvert.DeserializeObject<List<saves>>(text);

            foreach (var i in fileJSON)
            {
                var Type = i.type;
                var id = i.id;
                var zone = i.zone;
                var location = i.location;

                if (Type == "azimuth")
                {
                    azimuthCounter();
                    var test = new Button();
                    test.BackgroundImage = Properties.Resources.BC_5_panel_azimuth;
                    test.BackgroundImage.Tag = "screen";
                    test.BackgroundImageLayout = ImageLayout.Stretch;
                    test.Height = 130;
                    test.Tag = "azimuth";
                    test.Width = 150;
                    if (zone == "stern")
                    {
                        panel5.Controls.Add(test);
                        aziSternCounter();
                    }
                    else if (zone == "bow")
                    {
                        panel2.Controls.Add(test);
                        aziBowCounter();
                    }
                    else if (zone == "propulsion")
                    {
                        panel3.Controls.Add(test);
                        aziBowCounter();
                    } else if (zone == "screen-right")
                    {
                        panel6.Controls.Add(test);
                        aziBowCounter();
                    } else if (zone == "screen-left")
                    {
                        panel4.Controls.Add(test);
                        aziBowCounter();
                    }

                    test.DragDrop += panel_DragDrop;
                    test.AllowDrop = true;
                    test.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    test.MouseEnter += delegate
                    {
                        if (test.BackgroundImage.Tag == "screen")
                        {
                            textBox13.Text = "";
                        };

                        placementMax();
                        ControlExtension.Draggable(test, true);

                    };

                }
                else if (Type == "tunnel-single")
                {
                    var btn = new Button();
                    btn.BackgroundImage = Properties.Resources.BC_5_panel_tunnel;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage.Tag = "screen";
                    btn.Height = 130;
                    btn.Width = 160;
                    btn.Tag = "tunnel-single";
                    if (zone == "stern")
                    {
                        panel5.Controls.Add(btn);
                        tunSternCounter();
                        tunnelCounterSINGLE();
                    }
                    else if (zone == "bow")
                    {
                        panel2.Controls.Add(btn);
                        tunBowCounter();
                        tunnelCounterSINGLE();
                    }
                    else if (zone == "propulsion")
                    {
                        panel3.Controls.Add(btn);
                        tunnelCounterSINGLE();
                    }
                    else if (zone == "screen-right")
                    {
                        panel6.Controls.Add(btn);
                        tunnelCounterSINGLE();
                    }
                    else if (zone == "screen-left")
                    {
                        panel4.Controls.Add(btn);
                        tunnelCounterSINGLE();
                    }
                    btn.DragDrop += panel_DragDrop;
                    btn.AllowDrop = true;
                    btn.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    btn.MouseEnter += delegate
                    {
                        if (btn.BackgroundImage.Tag == "screen")
                        {
                            textBox13.Text = "";
                        };

                        placementMax();
                        ControlExtension.Draggable(btn, true);

                    };
                }
                else if (Type == "tunnel-dual-dp")
                {
                    var btn = new Button();
                    btn.BackgroundImage = Properties.Resources.BC_5_panel_two_tunnels_dp;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage.Tag = "screen";
                    btn.Height = 130;
                    btn.Tag = "tunnel-dual-dp";
                    btn.Width = 225;
                    if (zone == "stern")
                    {
                        panel5.Controls.Add(btn);
                        tunSternCounter();
                        tunSternCounter();
                        tunnelCounterDual();
                    }
                    else if (zone == "bow")
                    {
                        panel2.Controls.Add(btn);
                        tunBowCounter();
                        tunBowCounter();
                        tunnelCounterDual();
                    }
                    else if (zone == "propulsion")
                    {
                        panel3.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    else if (zone == "screen-right")
                    {
                        panel6.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    else if (zone == "screen-left")
                    {
                        panel4.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    btn.DragDrop += panel_DragDrop;
                    btn.AllowDrop = true;
                    btn.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    btn.MouseEnter += delegate
                    {
                        ControlExtension.Draggable(btn, true);

                        if (btn.BackgroundImage.Tag == "screen")
                        {
                            textBox13.Text = "";
                        };
 
                        
                    };
                }
                else if (Type == "tunnel-single-wo-monitor")
                {
                    var btn = new Button();
                    btn.BackgroundImage = Properties.Resources.BC_5_panel_tunnel_wo_monitor;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Height = 130;
                    btn.Width = 160;
                    btn.Tag = "tunnel-single-wo-monitor";
                    if (zone == "stern")
                    {
                        panel5.Controls.Add(btn);
                        tunSternCounter();
                        tunnelCounterSINGLE();
                    }
                    else if (zone == "bow")
                    {
                        panel2.Controls.Add(btn);
                        tunBowCounter();
                        tunnelCounterSINGLE();
                    }
                    else if (zone == "propulsion")
                    {
                        panel3.Controls.Add(btn);
                        tunnelCounterSINGLE();
                    }
                    else if (zone == "screen-right")
                    {
                        panel6.Controls.Add(btn);
                        tunnelCounterSINGLE();
                    }
                    else if (zone == "screen-left")
                    {
                        panel4.Controls.Add(btn);
                        tunnelCounterSINGLE(); 
                    }
                    btn.DragDrop += panel_DragDrop;
                    btn.AllowDrop = true;
                    btn.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    btn.MouseEnter += delegate
                    {
                        if (btn.BackgroundImage.Tag == "screen")
                        {
                            textBox13.Text = "";
                        };

                        placementMax();
                        ControlExtension.Draggable(btn, true);

                    };
                } 
                else if(Type == "monitor")
                {
                    var btn = new Button();
                    btn.BackgroundImage = Properties.Resources.BC_5_common_monitor;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage.Tag = "screen";
                    btn.Tag = "monitor";
                    btn.Height = 450;
                    btn.Width = 210;
                    if (zone == "stern")
                    {
                        panel5.Controls.Add(btn);
                    }
                    else if (zone == "bow")
                    {
                        panel2.Controls.Add(btn);
                    }
                    else if (zone == "propulsion")
                    {
                        panel3.Controls.Add(btn);
                    }
                    else if (zone == "screen-right")
                    {
                        panel6.Controls.Add(btn);
                    }
                    else if (zone == "screen-left")
                    {
                        panel4.Controls.Add(btn);
                    }
                    btn.DragDrop += panel_DragDrop;
                    btn.AllowDrop = true;
                    btn.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    btn.MouseEnter += delegate
                    {
                       
                        if (btn.BackgroundImage.Tag == "screen")
                        {
                            textBox13.Text = "";
                        };                       
                        ControlExtension.Draggable(btn, true);
                        
                    };
                }
                else if (Type == "azimuth-propulsion")
                {
                    var btn = new Button();
                    btn.BackgroundImage = Properties.Resources.BC_5_panel_azimuth_propulsion;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage.Tag = "screen";
                    btn.Tag = "azimuth-propulsion";
                    btn.Height = 130;
                    btn.Width = 160;
                    if (zone == "stern")
                    {
                        azimuthPropCounter();
                        panel5.Controls.Add(btn);
                    }
                    else if (zone == "bow")
                    {
                        azimuthPropCounter();
                        panel2.Controls.Add(btn);
                    }
                    else if (zone == "propulsion")
                    {
                        azimuthPropCounter();
                        panel3.Controls.Add(btn);
                    }
                    else if (zone == "screen-right")
                    {
                        azimuthPropCounter();
                        panel6.Controls.Add(btn);
                    }
                    else if (zone == "screen-left")
                    {
                        azimuthPropCounter();
                        panel4.Controls.Add(btn);
                    }
                    btn.DragDrop += panel_DragDrop;
                    btn.AllowDrop = true;
                    btn.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    btn.MouseEnter += delegate
                    {
                        placementMax();
                        if (button14.Controls.Contains(btn))
                        {
                            if (btn.BackgroundImage.Tag == "screen")
                            {
                                textBox13.Text = "";
                            };
                            btn.DoDragDrop(btn, DragDropEffects.Move);
                            panel2.BackColor = Color.DarkRed;
                            panel5.BackColor = Color.DarkRed;
                            panel1.BackColor = Color.DarkRed;
                            panel4.BackColor = Color.DarkRed;
                            panel6.BackColor = Color.DarkRed;

                        }
                        else
                        {
                            panel2.BackColor = Color.Gainsboro;
                            panel5.BackColor = Color.DimGray;
                            panel1.BackColor = Color.LightGray;
                            panel4.BackColor = Color.Silver;
                            panel6.BackColor = Color.Silver;
                            ControlExtension.Draggable(btn, true);

                        }
                    };
                }
                else if (Type == "azimuth-propulsion-wo")
                {
                    var btn = new Button();
                    btn.BackgroundImage = Properties.Resources.BC_5_panel_azimuth_wo_monitor_propulsion;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage.Tag = "screen";
                    btn.Tag = "azimuth-propulsion-wo";
                    btn.Height = 130;
                    btn.Width = 160;
                    if (zone == "stern")
                    {
                        azimuthPropCounter();
                        panel5.Controls.Add(btn);
                    }
                    else if (zone == "bow")
                    {
                        azimuthPropCounter();
                        panel2.Controls.Add(btn);
                    }
                    else if (zone == "propulsion")
                    {
                        azimuthPropCounter();
                        panel3.Controls.Add(btn);
                    }
                    else if (zone == "screen-right")
                    {
                        azimuthPropCounter();
                        panel6.Controls.Add(btn);
                    }
                    else if (zone == "screen-left")
                    {
                        azimuthPropCounter();
                        panel4.Controls.Add(btn);
                    }
                    btn.DragDrop += panel_DragDrop;
                    btn.AllowDrop = true;
                    btn.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    btn.MouseEnter += delegate
                    {
                        placementMax();
                        if (button14.Controls.Contains(btn))
                        {
                            if (btn.BackgroundImage.Tag == "screen")
                            {
                                textBox13.Text = "";
                            };
                            btn.DoDragDrop(btn, DragDropEffects.Move);
                            panel2.BackColor = Color.DarkRed;
                            panel5.BackColor = Color.DarkRed;
                            panel1.BackColor = Color.DarkRed;
                            panel4.BackColor = Color.DarkRed;
                            panel6.BackColor = Color.DarkRed;

                        }
                        else
                        {
                            panel2.BackColor = Color.Gainsboro;
                            panel5.BackColor = Color.DimGray;
                            panel1.BackColor = Color.LightGray;
                            panel4.BackColor = Color.Silver;
                            panel6.BackColor = Color.Silver;
                            ControlExtension.Draggable(btn, true);

                        }
                    };
                }
                else if(Type == "tunnel-dual-wo-monitor")
                {
                    var btn = new Button();
                    btn.BackgroundImage = Properties.Resources.BC_5_panel_two_tunnels_wo_monitor___Copy;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Height = 130;
                    btn.Tag = "tunnel-dual-wo-monitor";
                    btn.Width = 100;
                    if (zone == "stern")
                    {
                        panel5.Controls.Add(btn);
                        tunSternCounter();
                        tunSternCounter();
                        tunnelCounterDual();
                    }
                    else if (zone == "bow")
                    {
                        panel2.Controls.Add(btn);
                        tunBowCounter();
                        tunBowCounter();
                        tunnelCounterDual();
                    }
                    else if (zone == "propulsion")
                    {
                        panel3.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    else if (zone == "screen-right")
                    {
                        panel6.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    else if (zone == "screen-left")
                    {
                        panel4.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    btn.DragDrop += panel_DragDrop;
                    btn.AllowDrop = true;
                    btn.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    btn.MouseEnter += delegate
                    {
                        ControlExtension.Draggable(btn, true);
                    };
                }
                else if (Type == "tunnel-dual")
                {
                    var btn = new Button();
                    btn.BackgroundImage = Properties.Resources.BC_5_panel_two_tunnels;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage.Tag = "screen";
                    btn.Tag = "tunnel-dual";
                    btn.Height = 130;
                    btn.Width = 160;
                    if (zone == "stern")
                    {
                        panel5.Controls.Add(btn);
                        tunSternCounter();
                        tunnelCounterDual();
                        tunnelCounterDual();
                    }
                    else if (zone == "bow")
                    {
                        panel2.Controls.Add(btn);
                        tunBowCounter();
                        tunnelCounterDual();
                        tunnelCounterDual();
                    }
                    else if (zone == "propulsion")
                    {
                        panel3.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    else if (zone == "screen-right")
                    {
                        panel6.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    else if (zone == "screen-left")
                    {
                        panel4.Controls.Add(btn);
                        tunnelCounterDual();
                    }
                    btn.DragDrop += panel_DragDrop;
                    btn.AllowDrop = true;
                    btn.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    btn.MouseEnter += delegate
                    {
                         if (btn.BackgroundImage.Tag == "screen")
                         {
                            textBox13.Text = "";
                         };

                         ControlExtension.Draggable(btn, true);
                    };
                }
                else if (Type == "azimuthWO")
                {
                    azimuthCounter();
                    var test = new Button();
                    test.BackgroundImage = Properties.Resources.BC_5_panel_azimuth_wo_monitor;
                    test.BackgroundImageLayout = ImageLayout.Stretch;
                    test.Height = 130;
                    test.Tag = "azimuth";
                    test.Width = 150;
                    if (zone == "stern")
                    {
                        panel5.Controls.Add(test);
                        aziSternCounter();
                    }
                    else if (zone == "bow")
                    {
                        panel2.Controls.Add(test);
                        aziBowCounter();
                    }
                    else if (zone == "propulsion")
                    {
                        panel3.Controls.Add(test);
                        aziBowCounter();
                    }
                    else if (zone == "screen-right")
                    {
                        panel6.Controls.Add(test);
                        aziBowCounter();
                    }
                    else if (zone == "screen-left")
                    {
                        panel4.Controls.Add(test);
                        aziBowCounter();
                    }

                    test.DragDrop += panel_DragDrop;
                    test.AllowDrop = true;
                    test.MouseLeave += delegate
                    {
                        placementMax();
                        max();
                    };
                    test.MouseEnter += delegate
                    {
                        if (test.BackgroundImage.Tag == "screen")
                        {
                            textBox13.Text = "";
                        };

                        placementMax();
                        ControlExtension.Draggable(test, true);

                    };
                }
            }
        }
    }
}
     