using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace PlacementEditor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveModifiedAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        byte[] posX;
        byte[] posY;
        byte[] posZ;

        byte[] rotX;
        byte[] rotY;
        byte[] rotZ;

        byte[] scaleX;
        byte[] scaleY;
        byte[] scaleZ;
        public void SaveModdedPositions_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                float parsePosX = float.Parse(txtPosX.Text);
                float parsePosY = float.Parse(txtPosY.Text);
                float parsePosZ = float.Parse(txtPosZ.Text);
                float s = parsePosX;
                float i = parsePosY;
                float p = parsePosZ;
                float all1 = float.Parse(s.ToString());
                float all2 = float.Parse(i.ToString());
                float all3 = float.Parse(p.ToString());
                posX = BitConverter.GetBytes(all1);
                posY = BitConverter.GetBytes(all2);
                posZ = BitConverter.GetBytes(all3);

                float parseRotX = float.Parse(txtRotX.Text);
                float parseRotY = float.Parse(txtRotY.Text);
                float parseRotZ = float.Parse(txtRotZ.Text);
                float q = parseRotX;
                float w = parseRotY;
                float r = parseRotZ;
                float all4 = float.Parse(q.ToString());
                float all5 = float.Parse(w.ToString());
                float all6 = float.Parse(r.ToString());
                rotX = BitConverter.GetBytes(all4);
                rotY = BitConverter.GetBytes(all5);
                rotZ = BitConverter.GetBytes(all6);

                float parseScaleX = float.Parse(txtScaleX.Text);
                float parseScaleY = float.Parse(txtScaleY.Text);
                float parseScaleZ = float.Parse(txtScaleZ.Text);
                float a = parseScaleX;
                float l = parseScaleY;
                float d = parseScaleZ;
                float all7 = float.Parse(a.ToString());
                float all8 = float.Parse(l.ToString());
                float all9 = float.Parse(d.ToString());
                scaleX = BitConverter.GetBytes(all7);
                scaleY = BitConverter.GetBytes(all8);
                scaleZ = BitConverter.GetBytes(all9);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(posX);
                    Array.Reverse(posY);
                    Array.Reverse(posZ);

                    Array.Reverse(rotX);
                    Array.Reverse(rotY);
                    Array.Reverse(rotZ);

                    Array.Reverse(scaleX);
                    Array.Reverse(scaleY);
                    Array.Reverse(scaleZ);
                }
                posX.CopyTo(x, 0x2C);
                posY.CopyTo(x, 0x30);
                posZ.CopyTo(x, 0x34);

                rotX.CopyTo(x, 0x20);
                rotY.CopyTo(x, 0x24);
                rotZ.CopyTo(x, 0x28);

                scaleX.CopyTo(x, 0x38);
                scaleY.CopyTo(x, 0x3C);
                scaleZ.CopyTo(x, 0x40);



                File.WriteAllBytes(sfd.FileName, x);
                sfd.Dispose();
            }
        }
        byte[] x;
        public void OpenSIMPPLATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                x = File.ReadAllBytes(ofd.FileName);
                byte[] PlaceableData = x;
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(x, 0x2C, 4);
                    Array.Reverse(x, 0x30, 4);
                    Array.Reverse(x, 0x34, 4);

                    Array.Reverse(x, 0x20, 4);
                    Array.Reverse(x, 0x24, 4);
                    Array.Reverse(x, 0x28, 4);

                    Array.Reverse(x, 0x38, 4);
                    Array.Reverse(x, 0x3C, 4);
                    Array.Reverse(x, 0x40, 4);

                }
                float myFloat = System.BitConverter.ToSingle(PlaceableData, 0x2C); //Read Position X's Float
                float myFloat2 = System.BitConverter.ToSingle(PlaceableData, 0x30); //Read Position Y's Float
                float myFloat3 = System.BitConverter.ToSingle(PlaceableData, 0x34); //Read Position Z's Float

                float myFloat4 = System.BitConverter.ToSingle(PlaceableData, 0x20); //Read Roation X's Float
                float myFloat5 = System.BitConverter.ToSingle(PlaceableData, 0x24); //Read Rotation Y's Float
                float myFloat6 = System.BitConverter.ToSingle(PlaceableData, 0x28); //Read Rotation Z's Float

                float myFloat7 = System.BitConverter.ToSingle(PlaceableData, 0x38); //Read Scale X's Float
                float myFloat8 = System.BitConverter.ToSingle(PlaceableData, 0x3C); //Read Scale Y's Float
                float myFloat9 = System.BitConverter.ToSingle(PlaceableData, 0x40); //ReadScale Z's Float
                string z = myFloat.ToString();
                string j = myFloat2.ToString();
                string i = myFloat3.ToString();

                string q = myFloat4.ToString();
                string w = myFloat5.ToString();
                string r = myFloat6.ToString();

                string t = myFloat7.ToString();
                string y = myFloat8.ToString();
                string o = myFloat9.ToString();

                txtPosX.Text = z;
                txtPosY.Text = j;
                txtPosZ.Text = i;

                txtRotX.Text = q;
                txtRotY.Text = w;
                txtRotZ.Text = r;

                txtScaleX.Text = t;
                txtScaleY.Text = y;
                txtScaleZ.Text = o;


                ofd.Dispose();
                
            }
        }

        private void exitTheSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = txtScaleX.Text;

            txtScaleY.Text = input1;
            txtScaleZ.Text = input1;
        }
    }
}
