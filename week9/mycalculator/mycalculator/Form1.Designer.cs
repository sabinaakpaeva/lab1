namespace mycalculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 43);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "MC";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "MR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "MS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(159, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "M+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(204, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "M-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(204, 98);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(39, 30);
            this.button29.TabIndex = 33;
            this.button29.Text = "√";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.root);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(159, 98);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(39, 30);
            this.button30.TabIndex = 32;
            this.button30.Text = "±";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.sign);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(114, 98);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(39, 30);
            this.button31.TabIndex = 31;
            this.button31.Text = "C";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.C);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(69, 98);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(39, 30);
            this.button32.TabIndex = 30;
            this.button32.Text = "CE";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.CE);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(22, 98);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(39, 30);
            this.button33.TabIndex = 29;
            this.button33.Text = " ←";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.nazad);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(204, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 30);
            this.button9.TabIndex = 38;
            this.button9.Text = "%";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.percent);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(159, 134);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(39, 30);
            this.button10.TabIndex = 37;
            this.button10.Text = "/";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.divide);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(114, 134);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(39, 30);
            this.button11.TabIndex = 36;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.number_click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(69, 134);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 30);
            this.button12.TabIndex = 35;
            this.button12.Text = "8";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.number_click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(22, 134);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(39, 30);
            this.button13.TabIndex = 34;
            this.button13.Text = "7";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.number_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(204, 170);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(39, 30);
            this.button14.TabIndex = 43;
            this.button14.Text = "1/x";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.inverse_divide);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(159, 170);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(39, 30);
            this.button15.TabIndex = 42;
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.multiply);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(114, 170);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(39, 30);
            this.button16.TabIndex = 41;
            this.button16.Text = "6";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.number_click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(69, 170);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(39, 30);
            this.button17.TabIndex = 40;
            this.button17.Text = "5";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.number_click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(22, 170);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(39, 30);
            this.button18.TabIndex = 39;
            this.button18.Text = "4";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.number_click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(204, 206);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(39, 66);
            this.button19.TabIndex = 48;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.equal);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(159, 206);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(39, 30);
            this.button20.TabIndex = 47;
            this.button20.Text = "-";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.minus);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(114, 206);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(39, 30);
            this.button21.TabIndex = 46;
            this.button21.Text = "3";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.number_click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(69, 206);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(39, 30);
            this.button22.TabIndex = 45;
            this.button22.Text = "2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.number_click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(22, 206);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(39, 30);
            this.button23.TabIndex = 44;
            this.button23.Text = "1";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.number_click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(159, 242);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(39, 30);
            this.button25.TabIndex = 52;
            this.button25.Text = "+";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.plus);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(114, 242);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(39, 30);
            this.button26.TabIndex = 51;
            this.button26.Text = ",";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.comma);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(22, 242);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(86, 30);
            this.button28.TabIndex = 49;
            this.button28.Text = "0";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.number_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 290);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button28;
    }
}

