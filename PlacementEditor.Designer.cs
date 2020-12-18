namespace PlacementEditor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSIMPPLATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTheSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtPosZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveModdedPositions = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSIMPPLATToolStripMenuItem,
            this.exitTheSoftwareToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSIMPPLATToolStripMenuItem
            // 
            this.openSIMPPLATToolStripMenuItem.Name = "openSIMPPLATToolStripMenuItem";
            this.openSIMPPLATToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSIMPPLATToolStripMenuItem.Text = "Open SIMP/PLAT...";
            this.openSIMPPLATToolStripMenuItem.Click += new System.EventHandler(this.OpenSIMPPLATToolStripMenuItem_Click);
            // 
            // exitTheSoftwareToolStripMenuItem
            // 
            this.exitTheSoftwareToolStripMenuItem.Name = "exitTheSoftwareToolStripMenuItem";
            this.exitTheSoftwareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitTheSoftwareToolStripMenuItem.Text = "Exit The Software";
            this.exitTheSoftwareToolStripMenuItem.Click += new System.EventHandler(this.exitTheSoftwareToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(12, 55);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(481, 20);
            this.txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(12, 101);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(481, 20);
            this.txtPosY.TabIndex = 3;
            // 
            // txtPosZ
            // 
            this.txtPosZ.Location = new System.Drawing.Point(12, 147);
            this.txtPosZ.Name = "txtPosZ";
            this.txtPosZ.Size = new System.Drawing.Size(480, 20);
            this.txtPosZ.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Position X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Position Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Position Z";
            // 
            // SaveModdedPositions
            // 
            this.SaveModdedPositions.Location = new System.Drawing.Point(12, 187);
            this.SaveModdedPositions.Name = "SaveModdedPositions";
            this.SaveModdedPositions.Size = new System.Drawing.Size(480, 88);
            this.SaveModdedPositions.TabIndex = 8;
            this.SaveModdedPositions.Text = "Save Modified Positions";
            this.SaveModdedPositions.UseVisualStyleBackColor = true;
            this.SaveModdedPositions.Click += new System.EventHandler(this.SaveModdedPositions_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 287);
            this.Controls.Add(this.SaveModdedPositions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosZ);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Placement Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSIMPPLATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTheSoftwareToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveModdedPositions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

