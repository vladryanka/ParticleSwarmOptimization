
namespace ParticleSwarmOptimization
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumParticlesInp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxIterationsInp = new System.Windows.Forms.TextBox();
            this.cogCompInp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.socCompInp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lowerBoundInp = new System.Windows.Forms.TextBox();
            this.upperBoundInp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "f(x) = (x-3)^2",
            "f(x,y) = (y-x^2)^2+(1-x)^2",
            "f(x,y,z) = (x-1)^2+(y-3)^2+4(z+5)^2"});
            this.comboBox1.Location = new System.Drawing.Point(27, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Функция";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumParticlesInp
            // 
            this.NumParticlesInp.Location = new System.Drawing.Point(27, 83);
            this.NumParticlesInp.Name = "NumParticlesInp";
            this.NumParticlesInp.Size = new System.Drawing.Size(121, 20);
            this.NumParticlesInp.TabIndex = 2;
            this.NumParticlesInp.TextChanged += new System.EventHandler(this.NumParticlesInp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число частиц";
            // 
            // MaxIterationsInp
            // 
            this.MaxIterationsInp.Location = new System.Drawing.Point(27, 131);
            this.MaxIterationsInp.Name = "MaxIterationsInp";
            this.MaxIterationsInp.Size = new System.Drawing.Size(121, 20);
            this.MaxIterationsInp.TabIndex = 4;
            this.MaxIterationsInp.TextChanged += new System.EventHandler(this.MaxIterationsInp_TextChanged);
            // 
            // cogCompInp
            // 
            this.cogCompInp.Location = new System.Drawing.Point(27, 183);
            this.cogCompInp.Name = "cogCompInp";
            this.cogCompInp.Size = new System.Drawing.Size(121, 20);
            this.cogCompInp.TabIndex = 5;
            this.cogCompInp.TextChanged += new System.EventHandler(this.cogCompInp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Число итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Когнитивная компонента";
            // 
            // socCompInp
            // 
            this.socCompInp.Location = new System.Drawing.Point(27, 232);
            this.socCompInp.Name = "socCompInp";
            this.socCompInp.Size = new System.Drawing.Size(121, 20);
            this.socCompInp.TabIndex = 8;
            this.socCompInp.TextChanged += new System.EventHandler(this.socCompInp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Социальная компонента";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Минимальное значение:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "<>";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lowerBoundInp
            // 
            this.lowerBoundInp.Location = new System.Drawing.Point(27, 283);
            this.lowerBoundInp.Name = "lowerBoundInp";
            this.lowerBoundInp.Size = new System.Drawing.Size(111, 20);
            this.lowerBoundInp.TabIndex = 13;
            this.lowerBoundInp.TextChanged += new System.EventHandler(this.coordinatesInp_TextChanged);
            // 
            // upperBoundInp
            // 
            this.upperBoundInp.Location = new System.Drawing.Point(170, 282);
            this.upperBoundInp.Name = "upperBoundInp";
            this.upperBoundInp.Size = new System.Drawing.Size(100, 20);
            this.upperBoundInp.TabIndex = 14;
            this.upperBoundInp.TextChanged += new System.EventHandler(this.coordinateY_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Нижняя граница";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Верхняя граница";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.upperBoundInp);
            this.Controls.Add(this.lowerBoundInp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.socCompInp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cogCompInp);
            this.Controls.Add(this.MaxIterationsInp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumParticlesInp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumParticlesInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxIterationsInp;
        private System.Windows.Forms.TextBox cogCompInp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox socCompInp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lowerBoundInp;
        private System.Windows.Forms.TextBox upperBoundInp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

