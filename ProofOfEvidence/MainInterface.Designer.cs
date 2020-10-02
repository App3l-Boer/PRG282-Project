namespace ProofOfEvidence
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.lblUserDisplay = new System.Windows.Forms.Label();
            this.btnAddObs = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cbxEnemy = new System.Windows.Forms.ComboBox();
            this.cbxPlanes = new System.Windows.Forms.ComboBox();
            this.btnAddPlane = new System.Windows.Forms.Button();
            this.pbxPlane = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.prbHit = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.prbSpeed = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.prbAltidude = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.prbLoad = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.prbFuel = new System.Windows.Forms.ProgressBar();
            this.pbxEnemy3 = new System.Windows.Forms.PictureBox();
            this.pbxEnemy6 = new System.Windows.Forms.PictureBox();
            this.pbxEnemy1 = new System.Windows.Forms.PictureBox();
            this.pbxEnemy4 = new System.Windows.Forms.PictureBox();
            this.pbxEnemy2 = new System.Windows.Forms.PictureBox();
            this.pbxEnemy5 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserDisplay
            // 
            this.lblUserDisplay.AutoSize = true;
            this.lblUserDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUserDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDisplay.Location = new System.Drawing.Point(981, 0);
            this.lblUserDisplay.Name = "lblUserDisplay";
            this.lblUserDisplay.Size = new System.Drawing.Size(109, 39);
            this.lblUserDisplay.TabIndex = 0;
            this.lblUserDisplay.Text = "label1";
            // 
            // btnAddObs
            // 
            this.btnAddObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObs.Location = new System.Drawing.Point(401, 373);
            this.btnAddObs.Name = "btnAddObs";
            this.btnAddObs.Size = new System.Drawing.Size(139, 65);
            this.btnAddObs.TabIndex = 5;
            this.btnAddObs.Text = "Add Enemy Object";
            this.btnAddObs.UseVisualStyleBackColor = true;
            this.btnAddObs.Click += new System.EventHandler(this.btnAddObs_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(923, 126);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 48);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cbxEnemy
            // 
            this.cbxEnemy.FormattingEnabled = true;
            this.cbxEnemy.Location = new System.Drawing.Point(401, 346);
            this.cbxEnemy.Name = "cbxEnemy";
            this.cbxEnemy.Size = new System.Drawing.Size(139, 21);
            this.cbxEnemy.TabIndex = 7;
            this.cbxEnemy.Text = "Select Enemie Object";
            // 
            // cbxPlanes
            // 
            this.cbxPlanes.FormattingEnabled = true;
            this.cbxPlanes.Location = new System.Drawing.Point(602, 346);
            this.cbxPlanes.Name = "cbxPlanes";
            this.cbxPlanes.Size = new System.Drawing.Size(121, 21);
            this.cbxPlanes.TabIndex = 8;
            this.cbxPlanes.Text = "Select Plane";
            // 
            // btnAddPlane
            // 
            this.btnAddPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlane.Location = new System.Drawing.Point(604, 374);
            this.btnAddPlane.Name = "btnAddPlane";
            this.btnAddPlane.Size = new System.Drawing.Size(119, 64);
            this.btnAddPlane.TabIndex = 10;
            this.btnAddPlane.Text = "Add Plane";
            this.btnAddPlane.UseVisualStyleBackColor = true;
            this.btnAddPlane.Click += new System.EventHandler(this.btnAddPlane_Click);
            // 
            // pbxPlane
            // 
            this.pbxPlane.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbxPlane.Location = new System.Drawing.Point(40, 182);
            this.pbxPlane.Name = "pbxPlane";
            this.pbxPlane.Size = new System.Drawing.Size(13, 12);
            this.pbxPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlane.TabIndex = 9;
            this.pbxPlane.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProofOfEvidence.Properties.Resources.WarMap;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prbHit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.prbSpeed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.prbAltidude);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prbLoad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.prbFuel);
            this.panel1.Location = new System.Drawing.Point(401, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 340);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "HIT RATE";
            // 
            // prbHit
            // 
            this.prbHit.ForeColor = System.Drawing.Color.Lime;
            this.prbHit.Location = new System.Drawing.Point(99, 227);
            this.prbHit.Name = "prbHit";
            this.prbHit.Size = new System.Drawing.Size(155, 23);
            this.prbHit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "SPEED";
            // 
            // prbSpeed
            // 
            this.prbSpeed.ForeColor = System.Drawing.Color.Lime;
            this.prbSpeed.Location = new System.Drawing.Point(99, 182);
            this.prbSpeed.Name = "prbSpeed";
            this.prbSpeed.Size = new System.Drawing.Size(155, 23);
            this.prbSpeed.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ALTITUDE";
            // 
            // prbAltidude
            // 
            this.prbAltidude.ForeColor = System.Drawing.Color.Lime;
            this.prbAltidude.Location = new System.Drawing.Point(99, 135);
            this.prbAltidude.Name = "prbAltidude";
            this.prbAltidude.Size = new System.Drawing.Size(155, 23);
            this.prbAltidude.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOAD";
            // 
            // prbLoad
            // 
            this.prbLoad.ForeColor = System.Drawing.Color.Lime;
            this.prbLoad.Location = new System.Drawing.Point(99, 86);
            this.prbLoad.Name = "prbLoad";
            this.prbLoad.Size = new System.Drawing.Size(155, 23);
            this.prbLoad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FUEL";
            // 
            // prbFuel
            // 
            this.prbFuel.ForeColor = System.Drawing.Color.Lime;
            this.prbFuel.Location = new System.Drawing.Point(99, 33);
            this.prbFuel.Name = "prbFuel";
            this.prbFuel.Size = new System.Drawing.Size(155, 23);
            this.prbFuel.TabIndex = 0;
            // 
            // pbxEnemy3
            // 
            this.pbxEnemy3.Location = new System.Drawing.Point(266, 250);
            this.pbxEnemy3.Name = "pbxEnemy3";
            this.pbxEnemy3.Size = new System.Drawing.Size(20, 23);
            this.pbxEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemy3.TabIndex = 12;
            this.pbxEnemy3.TabStop = false;
            // 
            // pbxEnemy6
            // 
            this.pbxEnemy6.Location = new System.Drawing.Point(356, 405);
            this.pbxEnemy6.Name = "pbxEnemy6";
            this.pbxEnemy6.Size = new System.Drawing.Size(20, 19);
            this.pbxEnemy6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemy6.TabIndex = 13;
            this.pbxEnemy6.TabStop = false;
            // 
            // pbxEnemy1
            // 
            this.pbxEnemy1.Location = new System.Drawing.Point(185, 303);
            this.pbxEnemy1.Name = "pbxEnemy1";
            this.pbxEnemy1.Size = new System.Drawing.Size(17, 16);
            this.pbxEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemy1.TabIndex = 14;
            this.pbxEnemy1.TabStop = false;
            // 
            // pbxEnemy4
            // 
            this.pbxEnemy4.Location = new System.Drawing.Point(241, 298);
            this.pbxEnemy4.Name = "pbxEnemy4";
            this.pbxEnemy4.Size = new System.Drawing.Size(22, 21);
            this.pbxEnemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemy4.TabIndex = 15;
            this.pbxEnemy4.TabStop = false;
            // 
            // pbxEnemy2
            // 
            this.pbxEnemy2.Location = new System.Drawing.Point(212, 270);
            this.pbxEnemy2.Name = "pbxEnemy2";
            this.pbxEnemy2.Size = new System.Drawing.Size(16, 15);
            this.pbxEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemy2.TabIndex = 16;
            this.pbxEnemy2.TabStop = false;
            // 
            // pbxEnemy5
            // 
            this.pbxEnemy5.Location = new System.Drawing.Point(223, 390);
            this.pbxEnemy5.Name = "pbxEnemy5";
            this.pbxEnemy5.Size = new System.Drawing.Size(16, 18);
            this.pbxEnemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnemy5.TabIndex = 17;
            this.pbxEnemy5.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(546, 346);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(763, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(315, 64);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Run Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pbxEnemy5);
            this.Controls.Add(this.pbxEnemy2);
            this.Controls.Add(this.pbxEnemy4);
            this.Controls.Add(this.pbxEnemy1);
            this.Controls.Add(this.pbxEnemy6);
            this.Controls.Add(this.pbxEnemy3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddPlane);
            this.Controls.Add(this.pbxPlane);
            this.Controls.Add(this.cbxPlanes);
            this.Controls.Add(this.cbxEnemy);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddObs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUserDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainInterface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainInterface_FormClosed);
            this.Load += new System.EventHandler(this.MainInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddObs;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbxEnemy;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.Button btnAddPlane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar prbHit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prbSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prbAltidude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar prbLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prbFuel;
        private System.Windows.Forms.PictureBox pbxEnemy3;
        private System.Windows.Forms.PictureBox pbxEnemy6;
        private System.Windows.Forms.PictureBox pbxEnemy1;
        private System.Windows.Forms.PictureBox pbxEnemy4;
        private System.Windows.Forms.PictureBox pbxEnemy2;
        private System.Windows.Forms.PictureBox pbxEnemy5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pbxPlane;
        private System.Windows.Forms.Button btnStart;
    }
}