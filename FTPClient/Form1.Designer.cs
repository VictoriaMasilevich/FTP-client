namespace FTPClient
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
            this.addressBarTE = new System.Windows.Forms.TextBox();
            this.userTE = new System.Windows.Forms.TextBox();
            this.pasTE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contentLB = new System.Windows.Forms.ListBox();
            this.uploadB = new System.Windows.Forms.Button();
            this.directoryB = new System.Windows.Forms.Button();
            this.uploadTB = new System.Windows.Forms.TextBox();
            this.downloadTB = new System.Windows.Forms.TextBox();
            this.makedirectoryTB = new System.Windows.Forms.TextBox();
            this.moveB = new System.Windows.Forms.Button();
            this.destinationTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.downloadB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressBarTE
            // 
            this.addressBarTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressBarTE.Location = new System.Drawing.Point(360, 46);
            this.addressBarTE.Name = "addressBarTE";
            this.addressBarTE.Size = new System.Drawing.Size(183, 22);
            this.addressBarTE.TabIndex = 1;
            this.addressBarTE.Text = "172.20.10.2";
            // 
            // userTE
            // 
            this.userTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTE.Location = new System.Drawing.Point(174, 36);
            this.userTE.Name = "userTE";
            this.userTE.Size = new System.Drawing.Size(100, 22);
            this.userTE.TabIndex = 2;
            this.userTE.Text = "ftp_user_1";
            // 
            // pasTE
            // 
            this.pasTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasTE.Location = new System.Drawing.Point(174, 70);
            this.pasTE.Name = "pasTE";
            this.pasTE.Size = new System.Drawing.Size(100, 22);
            this.pasTE.TabIndex = 3;
            this.pasTE.Text = "123456";
            this.pasTE.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(321, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "ftp://";
            // 
            // contentLB
            // 
            this.contentLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contentLB.FormattingEnabled = true;
            this.contentLB.ItemHeight = 16;
            this.contentLB.Location = new System.Drawing.Point(20, 57);
            this.contentLB.Name = "contentLB";
            this.contentLB.Size = new System.Drawing.Size(175, 180);
            this.contentLB.TabIndex = 10;
            // 
            // uploadB
            // 
            this.uploadB.BackgroundImage = global::FTPClient.Properties.Resources.Plus_96;
            this.uploadB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadB.ForeColor = System.Drawing.Color.Crimson;
            this.uploadB.Location = new System.Drawing.Point(487, 110);
            this.uploadB.Name = "uploadB";
            this.uploadB.Size = new System.Drawing.Size(63, 61);
            this.uploadB.TabIndex = 13;
            this.uploadB.UseVisualStyleBackColor = true;
            this.uploadB.Click += new System.EventHandler(this.uploadB_Click);
            // 
            // directoryB
            // 
            this.directoryB.BackgroundImage = global::FTPClient.Properties.Resources.Upload_To_Ftp_96;
            this.directoryB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.directoryB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directoryB.ForeColor = System.Drawing.Color.Crimson;
            this.directoryB.Location = new System.Drawing.Point(487, 195);
            this.directoryB.Name = "directoryB";
            this.directoryB.Size = new System.Drawing.Size(63, 61);
            this.directoryB.TabIndex = 14;
            this.directoryB.UseVisualStyleBackColor = true;
            this.directoryB.Click += new System.EventHandler(this.directoryB_Click);
            // 
            // uploadTB
            // 
            this.uploadTB.Location = new System.Drawing.Point(258, 151);
            this.uploadTB.Name = "uploadTB";
            this.uploadTB.Size = new System.Drawing.Size(223, 20);
            this.uploadTB.TabIndex = 15;
            this.uploadTB.Text = "E://ftptest/2.txt";
            // 
            // downloadTB
            // 
            this.downloadTB.Location = new System.Drawing.Point(258, 57);
            this.downloadTB.Name = "downloadTB";
            this.downloadTB.Size = new System.Drawing.Size(223, 20);
            this.downloadTB.TabIndex = 16;
            this.downloadTB.Text = "E://ftptest/";
            // 
            // makedirectoryTB
            // 
            this.makedirectoryTB.Location = new System.Drawing.Point(258, 218);
            this.makedirectoryTB.Name = "makedirectoryTB";
            this.makedirectoryTB.Size = new System.Drawing.Size(223, 20);
            this.makedirectoryTB.TabIndex = 17;
            this.makedirectoryTB.Text = "MyDir";
            // 
            // moveB
            // 
            this.moveB.BackgroundImage = global::FTPClient.Properties.Resources.Synchronize_96;
            this.moveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveB.ForeColor = System.Drawing.Color.Crimson;
            this.moveB.Location = new System.Drawing.Point(487, 272);
            this.moveB.Name = "moveB";
            this.moveB.Size = new System.Drawing.Size(63, 61);
            this.moveB.TabIndex = 18;
            this.moveB.UseVisualStyleBackColor = true;
            this.moveB.Click += new System.EventHandler(this.moveB_Click);
            // 
            // destinationTB
            // 
            this.destinationTB.Location = new System.Drawing.Point(258, 313);
            this.destinationTB.Name = "destinationTB";
            this.destinationTB.Size = new System.Drawing.Size(223, 20);
            this.destinationTB.TabIndex = 19;
            this.destinationTB.Text = "MyDir";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.addressBarTE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userTE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pasTE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.displayB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(51, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP подключение";
            // 
            // displayB
            // 
            this.displayB.Image = global::FTPClient.Properties.Resources.folder;
            this.displayB.Location = new System.Drawing.Point(572, 17);
            this.displayB.Name = "displayB";
            this.displayB.Size = new System.Drawing.Size(156, 77);
            this.displayB.TabIndex = 0;
            this.displayB.UseVisualStyleBackColor = true;
            this.displayB.Click += new System.EventHandler(this.displayB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.deleteB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.downloadTB);
            this.groupBox2.Controls.Add(this.downloadB);
            this.groupBox2.Controls.Add(this.contentLB);
            this.groupBox2.Controls.Add(this.moveB);
            this.groupBox2.Controls.Add(this.destinationTB);
            this.groupBox2.Controls.Add(this.uploadTB);
            this.groupBox2.Controls.Add(this.uploadB);
            this.groupBox2.Controls.Add(this.directoryB);
            this.groupBox2.Controls.Add(this.makedirectoryTB);
            this.groupBox2.Location = new System.Drawing.Point(51, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 365);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // deleteB
            // 
            this.deleteB.BackgroundImage = global::FTPClient.Properties.Resources.Delete_96;
            this.deleteB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteB.ForeColor = System.Drawing.Color.Crimson;
            this.deleteB.Location = new System.Drawing.Point(54, 258);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(100, 75);
            this.deleteB.TabIndex = 25;
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(254, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Переместить в";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(254, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Создать папку";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(254, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Загрузить из";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(254, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Сохранить в";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(55, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Каталог";
            // 
            // downloadB
            // 
            this.downloadB.BackgroundImage = global::FTPClient.Properties.Resources.down;
            this.downloadB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloadB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadB.ForeColor = System.Drawing.Color.Crimson;
            this.downloadB.Location = new System.Drawing.Point(487, 33);
            this.downloadB.Name = "downloadB";
            this.downloadB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.downloadB.Size = new System.Drawing.Size(63, 61);
            this.downloadB.TabIndex = 11;
            this.downloadB.UseVisualStyleBackColor = true;
            this.downloadB.Click += new System.EventHandler(this.downloadB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::FTPClient.Properties.Resources.poligon_2560x1600_4k_hd_cvetnoy_zeleniy_fon_225;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(861, 536);
            this.MinimumSize = new System.Drawing.Size(861, 536);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP-Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayB;
        private System.Windows.Forms.TextBox addressBarTE;
        private System.Windows.Forms.TextBox userTE;
        private System.Windows.Forms.TextBox pasTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox contentLB;
        private System.Windows.Forms.Button downloadB;
        private System.Windows.Forms.Button uploadB;
        private System.Windows.Forms.Button directoryB;
        private System.Windows.Forms.TextBox uploadTB;
        private System.Windows.Forms.TextBox downloadTB;
        private System.Windows.Forms.TextBox makedirectoryTB;
        private System.Windows.Forms.Button moveB;
        private System.Windows.Forms.TextBox destinationTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteB;
    }
}

