namespace TiendaDeRopa
{
    partial class Form2
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
            label6 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(661, 409);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 28;
            label6.Text = "Cantidad";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(434, 406);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 27;
            // 
            // button2
            // 
            button2.Location = new Point(450, 470);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 26;
            button2.Text = "Agregar Producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(434, 347);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 23);
            comboBox1.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 350);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 24;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(661, 286);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 23;
            label4.Text = "Precio";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(434, 283);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(661, 239);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 21;
            label3.Text = "Talla";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(434, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(661, 176);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 19;
            label2.Text = "Descripcion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(434, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(661, 120);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(48, 47);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 600);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox5;
        private Button button2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}