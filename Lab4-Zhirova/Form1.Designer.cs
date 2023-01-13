namespace Lab4_Zhirova
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_KEYgenerator = new System.Windows.Forms.Button();
            this.button_fileKEYsave = new System.Windows.Forms.Button();
            this.button_fileKEYopen = new System.Windows.Forms.Button();
            this.textBox_fileKEY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.Відкрити = new System.Windows.Forms.ToolTip(this.components);
            this.Зберегти = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fileOUT);
            this.groupBox1.Controls.Add(this.button_fileIN);
            this.groupBox1.Controls.Add(this.textBox_fileOUT);
            this.groupBox1.Controls.Add(this.textBox_fileIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Location = new System.Drawing.Point(401, 62);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(44, 23);
            this.button_fileOUT.TabIndex = 5;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.UseVisualStyleBackColor = true;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // button_fileIN
            // 
            this.button_fileIN.Location = new System.Drawing.Point(401, 33);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(44, 23);
            this.button_fileIN.TabIndex = 4;
            this.button_fileIN.Text = "...";
            this.button_fileIN.UseVisualStyleBackColor = true;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(104, 63);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(279, 20);
            this.textBox_fileOUT.TabIndex = 3;
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(104, 32);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(279, 20);
            this.textBox_fileIN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зберегти у файл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відкрити файл";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_KEYgenerator);
            this.groupBox2.Controls.Add(this.button_fileKEYsave);
            this.groupBox2.Controls.Add(this.button_fileKEYopen);
            this.groupBox2.Controls.Add(this.textBox_fileKEY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // button_KEYgenerator
            // 
            this.button_KEYgenerator.Image = ((System.Drawing.Image)(resources.GetObject("button_KEYgenerator.Image")));
            this.button_KEYgenerator.Location = new System.Drawing.Point(211, 57);
            this.button_KEYgenerator.Name = "button_KEYgenerator";
            this.button_KEYgenerator.Size = new System.Drawing.Size(83, 32);
            this.button_KEYgenerator.TabIndex = 4;
            this.button_KEYgenerator.Text = " ";
            this.button_KEYgenerator.UseVisualStyleBackColor = true;
            this.button_KEYgenerator.Click += new System.EventHandler(this.button_KEYgenerator_Click);
            // 
            // button_fileKEYsave
            // 
            this.button_fileKEYsave.Image = ((System.Drawing.Image)(resources.GetObject("button_fileKEYsave.Image")));
            this.button_fileKEYsave.Location = new System.Drawing.Point(401, 53);
            this.button_fileKEYsave.Name = "button_fileKEYsave";
            this.button_fileKEYsave.Size = new System.Drawing.Size(56, 41);
            this.button_fileKEYsave.TabIndex = 3;
            this.button_fileKEYsave.UseVisualStyleBackColor = true;
            this.button_fileKEYsave.Click += new System.EventHandler(this.button_fileKEYsave_Click);
            // 
            // button_fileKEYopen
            // 
            this.button_fileKEYopen.Image = ((System.Drawing.Image)(resources.GetObject("button_fileKEYopen.Image")));
            this.button_fileKEYopen.Location = new System.Drawing.Point(401, 19);
            this.button_fileKEYopen.Name = "button_fileKEYopen";
            this.button_fileKEYopen.Size = new System.Drawing.Size(56, 32);
            this.button_fileKEYopen.TabIndex = 2;
            this.button_fileKEYopen.Text = " ";
            this.button_fileKEYopen.UseVisualStyleBackColor = true;
            this.button_fileKEYopen.Click += new System.EventHandler(this.button_fileKEYopen_Click);
            // 
            // textBox_fileKEY
            // 
            this.textBox_fileKEY.Location = new System.Drawing.Point(100, 26);
            this.textBox_fileKEY.Name = "textBox_fileKEY";
            this.textBox_fileKEY.Size = new System.Drawing.Size(279, 20);
            this.textBox_fileKEY.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Файл з ключем";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тривалість шифрування (мін:сек.мс):";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(221, 233);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(10, 13);
            this.label_time.TabIndex = 3;
            this.label_time.Text = " ";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(402, 233);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Розмір ключа:";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(114, 250);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(0, 13);
            this.label_size.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 305);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_KEYgenerator;
        private System.Windows.Forms.Button button_fileKEYsave;
        private System.Windows.Forms.Button button_fileKEYopen;
        private System.Windows.Forms.TextBox textBox_fileKEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ToolTip Відкрити;
        private System.Windows.Forms.ToolTip Зберегти;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_size;
    }
}

