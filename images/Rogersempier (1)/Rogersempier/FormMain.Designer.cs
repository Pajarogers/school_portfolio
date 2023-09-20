namespace Rogersempier
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Search = new System.Windows.Forms.Button();
            this.textboxUrl = new System.Windows.Forms.TextBox();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            this.timerChangeImage = new System.Windows.Forms.Timer(this.components);
            this.imageListWorkofArt = new System.Windows.Forms.ImageList(this.components);
            this.webBrowserControl = new System.Windows.Forms.WebBrowser();
            this.tabControlNotePad = new System.Windows.Forms.TabControl();
            this.tabNotePad = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPageMe = new System.Windows.Forms.TabPage();
            this.textBoxMe = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.pictureBoxWife = new System.Windows.Forms.PictureBox();
            this.pictureBoxPower = new System.Windows.Forms.PictureBox();
            this.pictureBoxFamily = new System.Windows.Forms.PictureBox();
            this.pictureBoxJob = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerMother = new System.Windows.Forms.Timer(this.components);
            this.imageListMother = new System.Windows.Forms.ImageList(this.components);
            this.timerWife = new System.Windows.Forms.Timer(this.components);
            this.imageListWife = new System.Windows.Forms.ImageList(this.components);
            this.timerCareer = new System.Windows.Forms.Timer(this.components);
            this.imageListCareer = new System.Windows.Forms.ImageList(this.components);
            this.timerstrength = new System.Windows.Forms.Timer(this.components);
            this.imageListStrength = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            this.tabControlNotePad.SuspendLayout();
            this.tabNotePad.SuspendLayout();
            this.tabPageMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.AllowDrop = true;
            this.Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Search.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Search.Location = new System.Drawing.Point(311, 1);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(117, 35);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.goButton_Click);
            // 
            // textboxUrl
            // 
            this.textboxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUrl.Location = new System.Drawing.Point(434, 6);
            this.textboxUrl.Name = "textboxUrl";
            this.textboxUrl.Size = new System.Drawing.Size(629, 26);
            this.textboxUrl.TabIndex = 1;
            this.textboxUrl.TextChanged += new System.EventHandler(this.textboxUrl_TextChanged);
            // 
            // pictureBoxArt
            // 
            this.pictureBoxArt.Location = new System.Drawing.Point(569, 38);
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.Size = new System.Drawing.Size(263, 140);
            this.pictureBoxArt.TabIndex = 10;
            this.pictureBoxArt.TabStop = false;
            this.pictureBoxArt.Click += new System.EventHandler(this.pictureBoxArt_Click);
            // 
            // timerChangeImage
            // 
            this.timerChangeImage.Enabled = true;
            this.timerChangeImage.Interval = 800;
            this.timerChangeImage.Tick += new System.EventHandler(this.timerChangeImage_Tick);
            // 
            // imageListWorkofArt
            // 
            this.imageListWorkofArt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListWorkofArt.ImageStream")));
            this.imageListWorkofArt.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListWorkofArt.Images.SetKeyName(0, "color w2.jpg");
            this.imageListWorkofArt.Images.SetKeyName(1, "color w3.jpg");
            this.imageListWorkofArt.Images.SetKeyName(2, "colorw5.jpg");
            this.imageListWorkofArt.Images.SetKeyName(3, "colorw6.jpg");
            this.imageListWorkofArt.Images.SetKeyName(4, "colorw7.jpg");
            this.imageListWorkofArt.Images.SetKeyName(5, "colorw9.jpg");
            // 
            // webBrowserControl
            // 
            this.webBrowserControl.Location = new System.Drawing.Point(218, 219);
            this.webBrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserControl.Name = "webBrowserControl";
            this.webBrowserControl.Size = new System.Drawing.Size(956, 546);
            this.webBrowserControl.TabIndex = 2;
            this.webBrowserControl.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserControl_DocumentCompleted);
            // 
            // tabControlNotePad
            // 
            this.tabControlNotePad.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlNotePad.Controls.Add(this.tabNotePad);
            this.tabControlNotePad.Controls.Add(this.tabPageMe);
            this.tabControlNotePad.Location = new System.Drawing.Point(1069, 12);
            this.tabControlNotePad.Multiline = true;
            this.tabControlNotePad.Name = "tabControlNotePad";
            this.tabControlNotePad.SelectedIndex = 0;
            this.tabControlNotePad.Size = new System.Drawing.Size(324, 205);
            this.tabControlNotePad.TabIndex = 11;
            // 
            // tabNotePad
            // 
            this.tabNotePad.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabNotePad.Controls.Add(this.textBox2);
            this.tabNotePad.Location = new System.Drawing.Point(23, 4);
            this.tabNotePad.Name = "tabNotePad";
            this.tabNotePad.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotePad.Size = new System.Drawing.Size(297, 197);
            this.tabNotePad.TabIndex = 1;
            this.tabNotePad.Text = "Notepad";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 185);
            this.textBox2.TabIndex = 1;
            // 
            // tabPageMe
            // 
            this.tabPageMe.Controls.Add(this.textBoxMe);
            this.tabPageMe.Controls.Add(this.textBoxMessage);
            this.tabPageMe.Controls.Add(this.pictureBoxWife);
            this.tabPageMe.Controls.Add(this.pictureBoxPower);
            this.tabPageMe.Controls.Add(this.pictureBoxFamily);
            this.tabPageMe.Controls.Add(this.pictureBoxJob);
            this.tabPageMe.Location = new System.Drawing.Point(23, 4);
            this.tabPageMe.Name = "tabPageMe";
            this.tabPageMe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMe.Size = new System.Drawing.Size(297, 197);
            this.tabPageMe.TabIndex = 0;
            this.tabPageMe.Text = "Who Am I";
            this.tabPageMe.UseVisualStyleBackColor = true;
            // 
            // textBoxMe
            // 
            this.textBoxMe.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMe.Location = new System.Drawing.Point(91, 176);
            this.textBoxMe.Name = "textBoxMe";
            this.textBoxMe.Size = new System.Drawing.Size(203, 24);
            this.textBoxMe.TabIndex = 9;
            this.textBoxMe.Text = "Mother, Wife, Provider,Leader";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(17, 177);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(65, 20);
            this.textBoxMessage.TabIndex = 4;
            this.textBoxMessage.Text = "Who Am I ?";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // pictureBoxWife
            // 
            this.pictureBoxWife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWife.Location = new System.Drawing.Point(149, 0);
            this.pictureBoxWife.Name = "pictureBoxWife";
            this.pictureBoxWife.Size = new System.Drawing.Size(140, 85);
            this.pictureBoxWife.TabIndex = 7;
            this.pictureBoxWife.TabStop = false;
            // 
            // pictureBoxPower
            // 
            this.pictureBoxPower.Location = new System.Drawing.Point(149, 85);
            this.pictureBoxPower.Name = "pictureBoxPower";
            this.pictureBoxPower.Size = new System.Drawing.Size(140, 85);
            this.pictureBoxPower.TabIndex = 8;
            this.pictureBoxPower.TabStop = false;
            // 
            // pictureBoxFamily
            // 
            this.pictureBoxFamily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFamily.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxFamily.Name = "pictureBoxFamily";
            this.pictureBoxFamily.Size = new System.Drawing.Size(140, 85);
            this.pictureBoxFamily.TabIndex = 5;
            this.pictureBoxFamily.TabStop = false;
            this.pictureBoxFamily.Click += new System.EventHandler(this.pictureBoxFamily_Click);
            // 
            // pictureBoxJob
            // 
            this.pictureBoxJob.Location = new System.Drawing.Point(0, 85);
            this.pictureBoxJob.Name = "pictureBoxJob";
            this.pictureBoxJob.Size = new System.Drawing.Size(140, 85);
            this.pictureBoxJob.TabIndex = 6;
            this.pictureBoxJob.TabStop = false;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 469);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1180, 307);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 469);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // timerMother
            // 
            this.timerMother.Enabled = true;
            this.timerMother.Interval = 1500;
            this.timerMother.Tick += new System.EventHandler(this.timerMother_Tick);
            // 
            // imageListMother
            // 
            this.imageListMother.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMother.ImageStream")));
            this.imageListMother.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMother.Images.SetKeyName(0, "mother and kids.png");
            this.imageListMother.Images.SetKeyName(1, "brother and sister.png");
            this.imageListMother.Images.SetKeyName(2, "kids22.png");
            // 
            // timerWife
            // 
            this.timerWife.Enabled = true;
            this.timerWife.Interval = 1500;
            this.timerWife.Tick += new System.EventHandler(this.timerWife_Tick);
            // 
            // imageListWife
            // 
            this.imageListWife.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListWife.ImageStream")));
            this.imageListWife.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListWife.Images.SetKeyName(0, "wife.png");
            this.imageListWife.Images.SetKeyName(1, "wife2.jpg");
            this.imageListWife.Images.SetKeyName(2, "me and andrew1.jpg");
            // 
            // timerCareer
            // 
            this.timerCareer.Enabled = true;
            this.timerCareer.Interval = 1500;
            this.timerCareer.Tick += new System.EventHandler(this.timerCareer_Tick);
            // 
            // imageListCareer
            // 
            this.imageListCareer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCareer.ImageStream")));
            this.imageListCareer.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCareer.Images.SetKeyName(0, "work.jpg");
            this.imageListCareer.Images.SetKeyName(1, "work2.png");
            this.imageListCareer.Images.SetKeyName(2, "WORKDIL1.jpg");
            // 
            // timerstrength
            // 
            this.timerstrength.Enabled = true;
            this.timerstrength.Interval = 1500;
            this.timerstrength.Tick += new System.EventHandler(this.timerstrength_Tick);
            // 
            // imageListStrength
            // 
            this.imageListStrength.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStrength.ImageStream")));
            this.imageListStrength.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStrength.Images.SetKeyName(0, "strong1.jpg");
            this.imageListStrength.Images.SetKeyName(1, "woman2.jpg");
            this.imageListStrength.Images.SetKeyName(2, "0.jpg");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 767);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.tabControlNotePad);
            this.Controls.Add(this.pictureBoxArt);
            this.Controls.Add(this.webBrowserControl);
            this.Controls.Add(this.textboxUrl);
            this.Controls.Add(this.Search);
            this.Name = "FormMain";
            this.Text = "Pajaempire";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            this.tabControlNotePad.ResumeLayout(false);
            this.tabNotePad.ResumeLayout(false);
            this.tabNotePad.PerformLayout();
            this.tabPageMe.ResumeLayout(false);
            this.tabPageMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textboxUrl;
        private System.Windows.Forms.WebBrowser webBrowserControl;
        private System.Windows.Forms.PictureBox pictureBoxArt;
        private System.Windows.Forms.Timer timerChangeImage;
        private System.Windows.Forms.ImageList imageListWorkofArt;
        private System.Windows.Forms.TabControl tabControlNotePad;
        private System.Windows.Forms.TabPage tabNotePad;
        private System.Windows.Forms.TabPage tabPageMe;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.PictureBox pictureBoxWife;
        private System.Windows.Forms.PictureBox pictureBoxPower;
        private System.Windows.Forms.PictureBox pictureBoxFamily;
        private System.Windows.Forms.PictureBox pictureBoxJob;
        private System.Windows.Forms.Timer timerMother;
        private System.Windows.Forms.ImageList imageListMother;
        private System.Windows.Forms.Timer timerWife;
        private System.Windows.Forms.ImageList imageListWife;
        private System.Windows.Forms.Timer timerCareer;
        private System.Windows.Forms.ImageList imageListCareer;
        private System.Windows.Forms.Timer timerstrength;
        private System.Windows.Forms.ImageList imageListStrength;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxMe;
    }
}

