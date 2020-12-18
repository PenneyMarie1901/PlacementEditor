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
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(posX);
                    Array.Reverse(posY);
                    Array.Reverse(posZ);
                }
                posX.CopyTo(x, 0x2C);
                posY.CopyTo(x, 0x30);
                posZ.CopyTo(x, 0x34);



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
                }
                float myFloat = System.BitConverter.ToSingle(PlaceableData, 0x2C); //Read Position X's Float
                float myFloat2 = System.BitConverter.ToSingle(PlaceableData, 0x30); //Read Position Y's Float
                float myFloat3 = System.BitConverter.ToSingle(PlaceableData, 0x34); //Read Position Z's Float
                string z = myFloat.ToString();
                string j = myFloat2.ToString();
                string i = myFloat3.ToString();
                txtPosX.Text = z;
                txtPosY.Text = j;
                txtPosZ.Text = i;
                ofd.Dispose();
                
            }
        }

        private void exitTheSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
