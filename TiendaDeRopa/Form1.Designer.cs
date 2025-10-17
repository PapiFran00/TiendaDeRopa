namespace TiendaDeRopa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 191);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 0;
            button1.Text = "Nuevo Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 94);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 10;
            label1.Text = "BIENVENIDO";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 247);
            button2.Name = "button2";
            button2.Size = new Size(166, 23);
            button2.TabIndex = 11;
            button2.Text = "Ver  Productos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(327, 191);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 12;
            button3.Text = "Nuevo Cliente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(327, 245);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 13;
            button4.Text = "Modificar Cliente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(518, 191);
            button5.Name = "button5";
            button5.Size = new Size(98, 23);
            button5.TabIndex = 14;
            button5.Text = "Nueva Venta";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(102, 352);
            button6.Name = "button6";
            button6.Size = new Size(203, 23);
            button6.TabIndex = 15;
            button6.Text = "Productos con pocos stock";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(102, 301);
            button7.Name = "button7";
            button7.Size = new Size(166, 23);
            button7.TabIndex = 16;
            button7.Text = "Lista  Productos";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(518, 245);
            button8.Name = "button8";
            button8.Size = new Size(136, 23);
            button8.TabIndex = 17;
            button8.Text = "Ventas realizadas";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 577);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
