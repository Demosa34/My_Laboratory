namespace CNCHelper
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
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txBoxToolName = new System.Windows.Forms.TextBox();
            this.txBoxNumberDivisions = new System.Windows.Forms.TextBox();
            this.txBoxInitialCorner = new System.Windows.Forms.TextBox();
            this.txBoxEventualCorner = new System.Windows.Forms.TextBox();
            this.txBoxRadiusCircle = new System.Windows.Forms.TextBox();
            this.txBoxStartPointX = new System.Windows.Forms.TextBox();
            this.txBoxStartPointZ = new System.Windows.Forms.TextBox();
            this.txBoxSpeedShpindle = new System.Windows.Forms.TextBox();
            this.btonTotal = new System.Windows.Forms.Button();
            this.listBoxTotal = new System.Windows.Forms.ListBox();
            this.comboBoxSetTool = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txBoxToolRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(60, 19);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(100, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Имя инструмента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во делений окружности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начальный угол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Конечный угол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Требуемый радиус:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Начальная точка ось х:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Начальная точка ось z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Коррекция инструмента:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Скорость шпинделя:";
            // 
            // txBoxToolName
            // 
            this.txBoxToolName.Location = new System.Drawing.Point(172, 16);
            this.txBoxToolName.Name = "txBoxToolName";
            this.txBoxToolName.Size = new System.Drawing.Size(132, 20);
            this.txBoxToolName.TabIndex = 9;
            // 
            // txBoxNumberDivisions
            // 
            this.txBoxNumberDivisions.Location = new System.Drawing.Point(172, 114);
            this.txBoxNumberDivisions.Name = "txBoxNumberDivisions";
            this.txBoxNumberDivisions.Size = new System.Drawing.Size(132, 20);
            this.txBoxNumberDivisions.TabIndex = 10;
            this.txBoxNumberDivisions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxNumberDivisions_KeyPress);
            // 
            // txBoxInitialCorner
            // 
            this.txBoxInitialCorner.Location = new System.Drawing.Point(172, 152);
            this.txBoxInitialCorner.Name = "txBoxInitialCorner";
            this.txBoxInitialCorner.Size = new System.Drawing.Size(132, 20);
            this.txBoxInitialCorner.TabIndex = 11;
            this.txBoxInitialCorner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxInitialCorner_KeyPress);
            // 
            // txBoxEventualCorner
            // 
            this.txBoxEventualCorner.Location = new System.Drawing.Point(172, 185);
            this.txBoxEventualCorner.Name = "txBoxEventualCorner";
            this.txBoxEventualCorner.Size = new System.Drawing.Size(132, 20);
            this.txBoxEventualCorner.TabIndex = 12;
            this.txBoxEventualCorner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxEventualCorner_KeyPress);
            // 
            // txBoxRadiusCircle
            // 
            this.txBoxRadiusCircle.Location = new System.Drawing.Point(172, 216);
            this.txBoxRadiusCircle.Name = "txBoxRadiusCircle";
            this.txBoxRadiusCircle.Size = new System.Drawing.Size(132, 20);
            this.txBoxRadiusCircle.TabIndex = 13;
            this.txBoxRadiusCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxRadiusCircle_KeyPress);
            // 
            // txBoxStartPointX
            // 
            this.txBoxStartPointX.Location = new System.Drawing.Point(172, 248);
            this.txBoxStartPointX.Name = "txBoxStartPointX";
            this.txBoxStartPointX.Size = new System.Drawing.Size(132, 20);
            this.txBoxStartPointX.TabIndex = 14;
            this.txBoxStartPointX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxStartPointX_KeyPress);
            // 
            // txBoxStartPointZ
            // 
            this.txBoxStartPointZ.Location = new System.Drawing.Point(172, 283);
            this.txBoxStartPointZ.Name = "txBoxStartPointZ";
            this.txBoxStartPointZ.Size = new System.Drawing.Size(132, 20);
            this.txBoxStartPointZ.TabIndex = 15;
            this.txBoxStartPointZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxStartPointZ_KeyPress);
            // 
            // txBoxSpeedShpindle
            // 
            this.txBoxSpeedShpindle.Location = new System.Drawing.Point(172, 316);
            this.txBoxSpeedShpindle.Name = "txBoxSpeedShpindle";
            this.txBoxSpeedShpindle.Size = new System.Drawing.Size(132, 20);
            this.txBoxSpeedShpindle.TabIndex = 17;
            this.txBoxSpeedShpindle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxSpeedShpindle_KeyPress);
            // 
            // btonTotal
            // 
            this.btonTotal.Location = new System.Drawing.Point(536, 349);
            this.btonTotal.Name = "btonTotal";
            this.btonTotal.Size = new System.Drawing.Size(128, 23);
            this.btonTotal.TabIndex = 18;
            this.btonTotal.Text = "Создать программу";
            this.btonTotal.UseVisualStyleBackColor = true;
            this.btonTotal.Click += new System.EventHandler(this.btonTotal_Click);
            // 
            // listBoxTotal
            // 
            this.listBoxTotal.FormattingEnabled = true;
            this.listBoxTotal.Location = new System.Drawing.Point(431, 16);
            this.listBoxTotal.Name = "listBoxTotal";
            this.listBoxTotal.Size = new System.Drawing.Size(345, 303);
            this.listBoxTotal.TabIndex = 19;
            // 
            // comboBoxSetTool
            // 
            this.comboBoxSetTool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetTool.Items.AddRange(new object[] {
            "Слева от детали(G41)",
            "Справа от детали(G42)",
            "Без коррекции(G40) "});
            this.comboBoxSetTool.Location = new System.Drawing.Point(172, 80);
            this.comboBoxSetTool.Name = "comboBoxSetTool";
            this.comboBoxSetTool.Size = new System.Drawing.Size(132, 21);
            this.comboBoxSetTool.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Радиус инструмента:";
            // 
            // txBoxToolRadius
            // 
            this.txBoxToolRadius.Location = new System.Drawing.Point(172, 48);
            this.txBoxToolRadius.Name = "txBoxToolRadius";
            this.txBoxToolRadius.Size = new System.Drawing.Size(132, 20);
            this.txBoxToolRadius.TabIndex = 22;
            this.txBoxToolRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxToolRadius_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 398);
            this.Controls.Add(this.txBoxToolRadius);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxSetTool);
            this.Controls.Add(this.listBoxTotal);
            this.Controls.Add(this.btonTotal);
            this.Controls.Add(this.txBoxSpeedShpindle);
            this.Controls.Add(this.txBoxStartPointZ);
            this.Controls.Add(this.txBoxStartPointX);
            this.Controls.Add(this.txBoxRadiusCircle);
            this.Controls.Add(this.txBoxEventualCorner);
            this.Controls.Add(this.txBoxInitialCorner);
            this.Controls.Add(this.txBoxNumberDivisions);
            this.Controls.Add(this.txBoxToolName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txBoxToolName;
        private System.Windows.Forms.TextBox txBoxNumberDivisions;
        private System.Windows.Forms.TextBox txBoxInitialCorner;
        private System.Windows.Forms.TextBox txBoxEventualCorner;
        private System.Windows.Forms.TextBox txBoxRadiusCircle;
        private System.Windows.Forms.TextBox txBoxStartPointX;
        private System.Windows.Forms.TextBox txBoxStartPointZ;
        private System.Windows.Forms.TextBox txBoxSpeedShpindle;
        private System.Windows.Forms.Button btonTotal;
        private System.Windows.Forms.ListBox listBoxTotal;
        private System.Windows.Forms.ComboBox comboBoxSetTool;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txBoxToolRadius;
    }
}

