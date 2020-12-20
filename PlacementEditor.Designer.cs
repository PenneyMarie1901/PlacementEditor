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
            this.label4 = new System.Windows.Forms.Label();
            this.lblRotation = new System.Windows.Forms.Label();
            this.lblRotZ = new System.Windows.Forms.Label();
            this.lblRotY = new System.Windows.Forms.Label();
            this.lblRotX = new System.Windows.Forms.Label();
            this.txtRotZ = new System.Windows.Forms.TextBox();
            this.txtRotY = new System.Windows.Forms.TextBox();
            this.txtRotX = new System.Windows.Forms.TextBox();
            this.lblScale = new System.Windows.Forms.Label();
            this.lblScaleZ = new System.Windows.Forms.Label();
            this.lblScaleY = new System.Windows.Forms.Label();
            this.lblScaleX = new System.Windows.Forms.Label();
            this.txtScaleZ = new System.Windows.Forms.TextBox();
            this.txtScaleY = new System.Windows.Forms.TextBox();
            this.txtScaleX = new System.Windows.Forms.TextBox();
            this.btnApplyScale = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
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
            this.openSIMPPLATToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openSIMPPLATToolStripMenuItem.Text = "Open SIMP/PLAT...";
            this.openSIMPPLATToolStripMenuItem.Click += new System.EventHandler(this.OpenSIMPPLATToolStripMenuItem_Click);
            // 
            // exitTheSoftwareToolStripMenuItem
            // 
            this.exitTheSoftwareToolStripMenuItem.Name = "exitTheSoftwareToolStripMenuItem";
            this.exitTheSoftwareToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
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
            this.txtPosX.Location = new System.Drawing.Point(67, 143);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(215, 20);
            this.txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(67, 189);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(215, 20);
            this.txtPosY.TabIndex = 3;
            // 
            // txtPosZ
            // 
            this.txtPosZ.Location = new System.Drawing.Point(67, 235);
            this.txtPosZ.Name = "txtPosZ";
            this.txtPosZ.Size = new System.Drawing.Size(214, 20);
            this.txtPosZ.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Position X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Position Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Position Z";
            // 
            // SaveModdedPositions
            // 
            this.SaveModdedPositions.Location = new System.Drawing.Point(12, 372);
            this.SaveModdedPositions.Name = "SaveModdedPositions";
            this.SaveModdedPositions.Size = new System.Drawing.Size(963, 30);
            this.SaveModdedPositions.TabIndex = 8;
            this.SaveModdedPositions.Text = "Save Modified Data";
            this.SaveModdedPositions.UseVisualStyleBackColor = true;
            this.SaveModdedPositions.Click += new System.EventHandler(this.SaveModdedPositions_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Position";
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Location = new System.Drawing.Point(486, 102);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(47, 13);
            this.lblRotation.TabIndex = 16;
            this.lblRotation.Text = "Rotation";
            // 
            // lblRotZ
            // 
            this.lblRotZ.AutoSize = true;
            this.lblRotZ.Location = new System.Drawing.Point(344, 241);
            this.lblRotZ.Name = "lblRotZ";
            this.lblRotZ.Size = new System.Drawing.Size(57, 13);
            this.lblRotZ.TabIndex = 15;
            this.lblRotZ.Text = "Rotation Z";
            // 
            // lblRotY
            // 
            this.lblRotY.AutoSize = true;
            this.lblRotY.Location = new System.Drawing.Point(344, 195);
            this.lblRotY.Name = "lblRotY";
            this.lblRotY.Size = new System.Drawing.Size(57, 13);
            this.lblRotY.TabIndex = 14;
            this.lblRotY.Text = "Rotation Y";
            // 
            // lblRotX
            // 
            this.lblRotX.AutoSize = true;
            this.lblRotX.Location = new System.Drawing.Point(344, 149);
            this.lblRotX.Name = "lblRotX";
            this.lblRotX.Size = new System.Drawing.Size(57, 13);
            this.lblRotX.TabIndex = 13;
            this.lblRotX.Text = "Rotation X";
            // 
            // txtRotZ
            // 
            this.txtRotZ.Location = new System.Drawing.Point(404, 238);
            this.txtRotZ.Name = "txtRotZ";
            this.txtRotZ.Size = new System.Drawing.Size(214, 20);
            this.txtRotZ.TabIndex = 12;
            // 
            // txtRotY
            // 
            this.txtRotY.Location = new System.Drawing.Point(404, 192);
            this.txtRotY.Name = "txtRotY";
            this.txtRotY.Size = new System.Drawing.Size(215, 20);
            this.txtRotY.TabIndex = 11;
            // 
            // txtRotX
            // 
            this.txtRotX.Location = new System.Drawing.Point(404, 146);
            this.txtRotX.Name = "txtRotX";
            this.txtRotX.Size = new System.Drawing.Size(215, 20);
            this.txtRotX.TabIndex = 10;
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(823, 102);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(34, 13);
            this.lblScale.TabIndex = 23;
            this.lblScale.Text = "Scale";
            // 
            // lblScaleZ
            // 
            this.lblScaleZ.AutoSize = true;
            this.lblScaleZ.Location = new System.Drawing.Point(671, 241);
            this.lblScaleZ.Name = "lblScaleZ";
            this.lblScaleZ.Size = new System.Drawing.Size(44, 13);
            this.lblScaleZ.TabIndex = 22;
            this.lblScaleZ.Text = "Scale Z";
            // 
            // lblScaleY
            // 
            this.lblScaleY.AutoSize = true;
            this.lblScaleY.Location = new System.Drawing.Point(671, 195);
            this.lblScaleY.Name = "lblScaleY";
            this.lblScaleY.Size = new System.Drawing.Size(44, 13);
            this.lblScaleY.TabIndex = 21;
            this.lblScaleY.Text = "Scale Y";
            // 
            // lblScaleX
            // 
            this.lblScaleX.AutoSize = true;
            this.lblScaleX.Location = new System.Drawing.Point(671, 149);
            this.lblScaleX.Name = "lblScaleX";
            this.lblScaleX.Size = new System.Drawing.Size(44, 13);
            this.lblScaleX.TabIndex = 20;
            this.lblScaleX.Text = "Scale X";
            // 
            // txtScaleZ
            // 
            this.txtScaleZ.Location = new System.Drawing.Point(731, 238);
            this.txtScaleZ.Name = "txtScaleZ";
            this.txtScaleZ.Size = new System.Drawing.Size(214, 20);
            this.txtScaleZ.TabIndex = 19;
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(731, 192);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(215, 20);
            this.txtScaleY.TabIndex = 18;
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(731, 146);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(215, 20);
            this.txtScaleX.TabIndex = 17;
            // 
            // btnApplyScale
            // 
            this.btnApplyScale.Location = new System.Drawing.Point(779, 264);
            this.btnApplyScale.Name = "btnApplyScale";
            this.btnApplyScale.Size = new System.Drawing.Size(116, 23);
            this.btnApplyScale.TabIndex = 24;
            this.btnApplyScale.Text = "Apply X to all fields";
            this.btnApplyScale.UseVisualStyleBackColor = true;
            this.btnApplyScale.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 414);
            this.Controls.Add(this.btnApplyScale);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.lblScaleZ);
            this.Controls.Add(this.lblScaleY);
            this.Controls.Add(this.lblScaleX);
            this.Controls.Add(this.txtScaleZ);
            this.Controls.Add(this.txtScaleY);
            this.Controls.Add(this.txtScaleX);
            this.Controls.Add(this.lblRotation);
            this.Controls.Add(this.lblRotZ);
            this.Controls.Add(this.lblRotY);
            this.Controls.Add(this.lblRotX);
            this.Controls.Add(this.txtRotZ);
            this.Controls.Add(this.txtRotY);
            this.Controls.Add(this.txtRotX);
            this.Controls.Add(this.label4);
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
            this.Load += new System.EventHandler(this.MainWindow_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.Label lblRotZ;
        private System.Windows.Forms.Label lblRotY;
        private System.Windows.Forms.Label lblRotX;
        private System.Windows.Forms.TextBox txtRotZ;
        private System.Windows.Forms.TextBox txtRotY;
        private System.Windows.Forms.TextBox txtRotX;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label lblScaleZ;
        private System.Windows.Forms.Label lblScaleY;
        private System.Windows.Forms.Label lblScaleX;
        private System.Windows.Forms.TextBox txtScaleZ;
        private System.Windows.Forms.TextBox txtScaleY;
        private System.Windows.Forms.TextBox txtScaleX;
        private System.Windows.Forms.Button btnApplyScale;
    }
}

