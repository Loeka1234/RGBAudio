namespace ArduinoAudio
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pnlAudio = new System.Windows.Forms.Panel();
            this.audioTimer = new System.Windows.Forms.Timer(this.components);
            this.btnColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAudio = new System.Windows.Forms.Label();
            this.lblHardness = new System.Windows.Forms.Label();
            this.tbHardness = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblConnection = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRedNumber = new System.Windows.Forms.Label();
            this.lblGreenNumber = new System.Windows.Forms.Label();
            this.lblBlueNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChangePins = new System.Windows.Forms.Button();
            this.txtRedInput = new System.Windows.Forms.TextBox();
            this.txtGreenInput = new System.Windows.Forms.TextBox();
            this.txtBlueInput = new System.Windows.Forms.TextBox();
            this.visualAudioTimer = new System.Windows.Forms.Timer(this.components);
            this.pbSubmitBlue = new System.Windows.Forms.PictureBox();
            this.pbSubmitGreen = new System.Windows.Forms.PictureBox();
            this.pbSubmitRed = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHardness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmitBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmitGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmitRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAudio
            // 
            this.pnlAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.pnlAudio.Location = new System.Drawing.Point(56, 182);
            this.pnlAudio.Name = "pnlAudio";
            this.pnlAudio.Size = new System.Drawing.Size(55, 187);
            this.pnlAudio.TabIndex = 1;
            // 
            // audioTimer
            // 
            this.audioTimer.Enabled = true;
            this.audioTimer.Interval = 10;
            this.audioTimer.Tick += new System.EventHandler(this.audioTimer_Tick);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.btnColor.FlatAppearance.BorderSize = 2;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.btnColor.Location = new System.Drawing.Point(32, 126);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(50, 50);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(189)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.lblAudio);
            this.panel2.Controls.Add(this.lblHardness);
            this.panel2.Controls.Add(this.pnlAudio);
            this.panel2.Controls.Add(this.tbHardness);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.cbMode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbDevices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 400);
            this.panel2.TabIndex = 6;
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblAudio.Location = new System.Drawing.Point(75, 372);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(17, 19);
            this.lblAudio.TabIndex = 29;
            this.lblAudio.Text = "0";
            this.lblAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHardness
            // 
            this.lblHardness.AutoSize = true;
            this.lblHardness.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblHardness.Location = new System.Drawing.Point(6, 372);
            this.lblHardness.Name = "lblHardness";
            this.lblHardness.Size = new System.Drawing.Size(44, 19);
            this.lblHardness.TabIndex = 28;
            this.lblHardness.Text = "100%";
            // 
            // tbHardness
            // 
            this.tbHardness.Location = new System.Drawing.Point(7, 182);
            this.tbHardness.Maximum = 150;
            this.tbHardness.Minimum = 50;
            this.tbHardness.Name = "tbHardness";
            this.tbHardness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbHardness.Size = new System.Drawing.Size(56, 193);
            this.tbHardness.TabIndex = 27;
            this.tbHardness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbHardness.Value = 100;
            this.tbHardness.Scroll += new System.EventHandler(this.tbHardness_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Colors:";
            // 
            // cbMode
            // 
            this.cbMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(178)))), ((int)(((byte)(134)))));
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Light",
            "Comming soon..."});
            this.cbMode.Location = new System.Drawing.Point(5, 76);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(110, 25);
            this.cbMode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Audio device:";
            // 
            // cbDevices
            // 
            this.cbDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(178)))), ((int)(((byte)(134)))));
            this.cbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(5, 27);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(110, 25);
            this.cbDevices.TabIndex = 2;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(126, 18);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(205, 19);
            this.lblConnection.TabIndex = 9;
            this.lblConnection.Text = "The arduino was not found...";
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetry.FlatAppearance.BorderSize = 2;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Location = new System.Drawing.Point(328, 12);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(62, 29);
            this.btnRetry.TabIndex = 10;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Red:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Green:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Blue:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ground:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(188)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(154, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pins:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRedNumber
            // 
            this.lblRedNumber.AutoSize = true;
            this.lblRedNumber.Location = new System.Drawing.Point(198, 71);
            this.lblRedNumber.Name = "lblRedNumber";
            this.lblRedNumber.Size = new System.Drawing.Size(17, 19);
            this.lblRedNumber.TabIndex = 16;
            this.lblRedNumber.Text = "6";
            // 
            // lblGreenNumber
            // 
            this.lblGreenNumber.AutoSize = true;
            this.lblGreenNumber.Location = new System.Drawing.Point(198, 90);
            this.lblGreenNumber.Name = "lblGreenNumber";
            this.lblGreenNumber.Size = new System.Drawing.Size(17, 19);
            this.lblGreenNumber.TabIndex = 17;
            this.lblGreenNumber.Text = "5";
            // 
            // lblBlueNumber
            // 
            this.lblBlueNumber.AutoSize = true;
            this.lblBlueNumber.Location = new System.Drawing.Point(198, 109);
            this.lblBlueNumber.Name = "lblBlueNumber";
            this.lblBlueNumber.Size = new System.Drawing.Size(17, 19);
            this.lblBlueNumber.TabIndex = 18;
            this.lblBlueNumber.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Choose one on your arduino";
            // 
            // btnChangePins
            // 
            this.btnChangePins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.btnChangePins.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangePins.FlatAppearance.BorderSize = 2;
            this.btnChangePins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePins.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePins.ForeColor = System.Drawing.Color.White;
            this.btnChangePins.Location = new System.Drawing.Point(202, 151);
            this.btnChangePins.Name = "btnChangePins";
            this.btnChangePins.Size = new System.Drawing.Size(107, 35);
            this.btnChangePins.TabIndex = 20;
            this.btnChangePins.Text = "Change Pins";
            this.btnChangePins.UseVisualStyleBackColor = false;
            this.btnChangePins.Click += new System.EventHandler(this.btnChangePins_Click);
            // 
            // txtRedInput
            // 
            this.txtRedInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txtRedInput.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.txtRedInput.Location = new System.Drawing.Point(198, 70);
            this.txtRedInput.Multiline = true;
            this.txtRedInput.Name = "txtRedInput";
            this.txtRedInput.Size = new System.Drawing.Size(40, 21);
            this.txtRedInput.TabIndex = 21;
            this.txtRedInput.Text = "6";
            this.txtRedInput.Visible = false;
            this.txtRedInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtRedInput_PreviewKeyDown);
            // 
            // txtGreenInput
            // 
            this.txtGreenInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txtGreenInput.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreenInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.txtGreenInput.Location = new System.Drawing.Point(198, 89);
            this.txtGreenInput.Multiline = true;
            this.txtGreenInput.Name = "txtGreenInput";
            this.txtGreenInput.Size = new System.Drawing.Size(40, 21);
            this.txtGreenInput.TabIndex = 22;
            this.txtGreenInput.Text = "5";
            this.txtGreenInput.Visible = false;
            this.txtGreenInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtGreenInput_PreviewKeyDown);
            // 
            // txtBlueInput
            // 
            this.txtBlueInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.txtBlueInput.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlueInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.txtBlueInput.Location = new System.Drawing.Point(198, 109);
            this.txtBlueInput.Multiline = true;
            this.txtBlueInput.Name = "txtBlueInput";
            this.txtBlueInput.Size = new System.Drawing.Size(40, 21);
            this.txtBlueInput.TabIndex = 23;
            this.txtBlueInput.Text = "3";
            this.txtBlueInput.Visible = false;
            this.txtBlueInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBlueInput_PreviewKeyDown);
            // 
            // visualAudioTimer
            // 
            this.visualAudioTimer.Enabled = true;
            this.visualAudioTimer.Interval = 50;
            this.visualAudioTimer.Tick += new System.EventHandler(this.visualAudioTimer_Tick);
            // 
            // pbSubmitBlue
            // 
            this.pbSubmitBlue.BackgroundImage = global::ArduinoAudio.Properties.Resources.submit;
            this.pbSubmitBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSubmitBlue.Location = new System.Drawing.Point(244, 109);
            this.pbSubmitBlue.Name = "pbSubmitBlue";
            this.pbSubmitBlue.Size = new System.Drawing.Size(21, 21);
            this.pbSubmitBlue.TabIndex = 26;
            this.pbSubmitBlue.TabStop = false;
            this.pbSubmitBlue.Visible = false;
            this.pbSubmitBlue.Click += new System.EventHandler(this.pbSubmitBlue_Click);
            // 
            // pbSubmitGreen
            // 
            this.pbSubmitGreen.BackgroundImage = global::ArduinoAudio.Properties.Resources.submit;
            this.pbSubmitGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSubmitGreen.Location = new System.Drawing.Point(244, 90);
            this.pbSubmitGreen.Name = "pbSubmitGreen";
            this.pbSubmitGreen.Size = new System.Drawing.Size(21, 21);
            this.pbSubmitGreen.TabIndex = 25;
            this.pbSubmitGreen.TabStop = false;
            this.pbSubmitGreen.Visible = false;
            this.pbSubmitGreen.Click += new System.EventHandler(this.pbSubmitGreen_Click);
            // 
            // pbSubmitRed
            // 
            this.pbSubmitRed.BackgroundImage = global::ArduinoAudio.Properties.Resources.submit;
            this.pbSubmitRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSubmitRed.Location = new System.Drawing.Point(244, 70);
            this.pbSubmitRed.Name = "pbSubmitRed";
            this.pbSubmitRed.Size = new System.Drawing.Size(21, 21);
            this.pbSubmitRed.TabIndex = 24;
            this.pbSubmitRed.TabStop = false;
            this.pbSubmitRed.Visible = false;
            this.pbSubmitRed.Click += new System.EventHandler(this.pbSubmitRed_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ArduinoAudio.Properties.Resources.minimize;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(528, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ArduinoAudio.Properties.Resources.close;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(562, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pbSubmitBlue);
            this.Controls.Add(this.pbSubmitGreen);
            this.Controls.Add(this.pbSubmitRed);
            this.Controls.Add(this.txtBlueInput);
            this.Controls.Add(this.txtGreenInput);
            this.Controls.Add(this.txtRedInput);
            this.Controls.Add(this.btnChangePins);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBlueNumber);
            this.Controls.Add(this.lblGreenNumber);
            this.Controls.Add(this.lblRedNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(167)))), ((int)(((byte)(190)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHardness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmitBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmitGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmitRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlAudio;
        private System.Windows.Forms.Timer audioTimer;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRedNumber;
        private System.Windows.Forms.Label lblGreenNumber;
        private System.Windows.Forms.Label lblBlueNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnChangePins;
        private System.Windows.Forms.TextBox txtRedInput;
        private System.Windows.Forms.TextBox txtGreenInput;
        private System.Windows.Forms.TextBox txtBlueInput;
        private System.Windows.Forms.PictureBox pbSubmitRed;
        private System.Windows.Forms.PictureBox pbSubmitGreen;
        private System.Windows.Forms.PictureBox pbSubmitBlue;
        private System.Windows.Forms.TrackBar tbHardness;
        private System.Windows.Forms.Label lblHardness;
        private System.Windows.Forms.Label lblAudio;
        private System.Windows.Forms.Timer visualAudioTimer;
    }
}

