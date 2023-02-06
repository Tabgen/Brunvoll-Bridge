using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Brunvoll_utplasseringsprosjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.AllowDrop = true;
            button1.AllowDrop = true;

            panel1.DragEnter += panel_DragEnter;
            button1.DragEnter += panel_DragEnter;

            panel1.DragDrop += panel_DragDrop;
            button1.DragDrop += panel_DragDrop;

            button1.MouseDown += button1_MouseDown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = new Button();
            test.BackgroundImage = Properties.Resources.BC_5_panel_azimuth;
            test.BackgroundImageLayout = ImageLayout.Stretch;
            test.Height = 130;
            test.Width = 150;
            this.button1.Controls.Add(test);

            test.DragDrop += panel_DragDrop;
            test.AllowDrop = true;
            test.MouseDown += delegate
            {
                if (button1.Controls.Contains(test))
                {
                    test.DoDragDrop(test, DragDropEffects.Move);
                }
                else
                {
                    ControlExtension.Draggable(test, true);
                }
            };

            
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //button1.DoDragDrop(button1, DragDropEffects.Move);
        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (Panel)sender;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
 