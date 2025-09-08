namespace Ejercicio_1_18.Interface
{
    partial class ejercicioN12
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
            this.TXTAN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTE1 = new System.Windows.Forms.TextBox();
            this.TXTE2 = new System.Windows.Forms.TextBox();
            this.TXT_DIF = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTAN
            // 
            this.TXTAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAN.Location = new System.Drawing.Point(11, 56);
            this.TXTAN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TXTAN.Name = "TXTAN";
            this.TXTAN.Size = new System.Drawing.Size(340, 41);
            this.TXTAN.TabIndex = 15;
            this.TXTAN.Text = "Edad del primer hermano";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Edad del segundo hermano";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "Diferencia de edades";
            // 
            // TXTE1
            // 
            this.TXTE1.Location = new System.Drawing.Point(479, 67);
            this.TXTE1.Margin = new System.Windows.Forms.Padding(2);
            this.TXTE1.Name = "TXTE1";
            this.TXTE1.Size = new System.Drawing.Size(99, 20);
            this.TXTE1.TabIndex = 25;
            this.TXTE1.TextChanged += new System.EventHandler(this.TXE1_TextChanged);
            // 
            // TXTE2
            // 
            this.TXTE2.Location = new System.Drawing.Point(479, 152);
            this.TXTE2.Margin = new System.Windows.Forms.Padding(2);
            this.TXTE2.Name = "TXTE2";
            this.TXTE2.Size = new System.Drawing.Size(99, 20);
            this.TXTE2.TabIndex = 26;
            this.TXTE2.TextChanged += new System.EventHandler(this.TXTE2_TextChanged);
            // 
            // TXT_DIF
            // 
            this.TXT_DIF.Location = new System.Drawing.Point(429, 278);
            this.TXT_DIF.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_DIF.Name = "TXT_DIF";
            this.TXT_DIF.Size = new System.Drawing.Size(258, 20);
            this.TXT_DIF.TabIndex = 27;
            this.TXT_DIF.TextChanged += new System.EventHandler(this.TXT_DIF_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 28;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 49);
            this.button1.TabIndex = 29;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 353);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 49);
            this.button3.TabIndex = 30;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ejercicioN12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXT_DIF);
            this.Controls.Add(this.TXTE2);
            this.Controls.Add(this.TXTE1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTAN);
            this.Name = "ejercicioN12";
            this.Text = "ejercicioN12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TXTAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTE1;
        private System.Windows.Forms.TextBox TXTE2;
        private System.Windows.Forms.TextBox TXT_DIF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}