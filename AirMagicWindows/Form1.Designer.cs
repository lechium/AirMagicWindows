namespace AirMagicWindows
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipAddressField = new System.Windows.Forms.Label();
            this.apiVersionField = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iosVersionField = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.textButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // ipAddressField
            // 
            this.ipAddressField.Location = new System.Drawing.Point(80, 300);
            this.ipAddressField.Name = "ipAddressField";
            this.ipAddressField.Size = new System.Drawing.Size(150, 17);
            this.ipAddressField.TabIndex = 12;
            this.ipAddressField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apiVersionField
            // 
            this.apiVersionField.Location = new System.Drawing.Point(80, 320);
            this.apiVersionField.Name = "apiVersionField";
            this.apiVersionField.Size = new System.Drawing.Size(150, 17);
            this.apiVersionField.TabIndex = 14;
            this.apiVersionField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "API Version:";
            // 
            // iosVersionField
            // 
            this.iosVersionField.Location = new System.Drawing.Point(80, 339);
            this.iosVersionField.Name = "iosVersionField";
            this.iosVersionField.Size = new System.Drawing.Size(150, 17);
            this.iosVersionField.TabIndex = 16;
            this.iosVersionField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "iOS Version:";
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackPlay;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(173, 222);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(55, 55);
            this.playButton.TabIndex = 9;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackDownNav;
            this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.downButton.FlatAppearance.BorderSize = 0;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Location = new System.Drawing.Point(92, 222);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(55, 55);
            this.downButton.TabIndex = 8;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackPause;
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Location = new System.Drawing.Point(12, 222);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(55, 55);
            this.pauseButton.TabIndex = 7;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackPlay;
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightButton.FlatAppearance.BorderSize = 0;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Location = new System.Drawing.Point(173, 148);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(55, 55);
            this.rightButton.TabIndex = 6;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackRecord;
            this.selectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectButton.FlatAppearance.BorderSize = 0;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Location = new System.Drawing.Point(92, 148);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(55, 55);
            this.selectButton.TabIndex = 5;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackLeftNav;
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftButton.FlatAppearance.BorderSize = 0;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Location = new System.Drawing.Point(12, 148);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(55, 55);
            this.leftButton.TabIndex = 4;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // textButton
            // 
            this.textButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackText;
            this.textButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.textButton.FlatAppearance.BorderSize = 0;
            this.textButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textButton.Location = new System.Drawing.Point(173, 69);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(55, 55);
            this.textButton.TabIndex = 3;
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // upButton
            // 
            this.upButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackUpNav;
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upButton.FlatAppearance.BorderSize = 0;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Location = new System.Drawing.Point(92, 69);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(55, 55);
            this.upButton.TabIndex = 2;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackgroundImage = global::AirMagicWindows.Properties.Resources.blackList;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Location = new System.Drawing.Point(12, 69);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(55, 55);
            this.menuButton.TabIndex = 1;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 364);
            this.Controls.Add(this.iosVersionField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.apiVersionField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ipAddressField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(256, 402);
            this.MinimumSize = new System.Drawing.Size(256, 402);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirMagic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ipAddressField;
        private System.Windows.Forms.Label apiVersionField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label iosVersionField;
        private System.Windows.Forms.Label label7;
    }
}

