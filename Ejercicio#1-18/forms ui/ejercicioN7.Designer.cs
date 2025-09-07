namespace Ejercicio_1_18.Interface
{
    partial class ejercicioN7
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
            this.label4 = new System.Windows.Forms.Label();
            this.HL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 73);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de horas laboradas en el mes";
            // 
            // HL
            // 
            this.HL.Location = new System.Drawing.Point(398, 43);
            this.HL.Margin = new System.Windows.Forms.Padding(2);
            this.HL.Name = "HL";
            this.HL.Size = new System.Drawing.Size(99, 20);
            this.HL.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tarifa por horas";
            // 
            // TH
            // 
            this.TH.Location = new System.Drawing.Point(398, 165);
            this.TH.Margin = new System.Windows.Forms.Padding(2);
            this.TH.Name = "TH";
            this.TH.Size = new System.Drawing.Size(99, 20);
            this.TH.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 85);
            this.label3.TabIndex = 10;
            this.label3.Text = "La planilla a pagar es de:";
            // 
            // P
            // 
            this.P.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.P.BackColor = System.Drawing.SystemColors.HotTrack;
            this.P.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.P.Location = new System.Drawing.Point(398, 314);
            this.P.Margin = new System.Windows.Forms.Padding(2);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(99, 20);
            this.P.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 235);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 49);
            this.button2.TabIndex = 12;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 368);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 49);
            this.button3.TabIndex = 14;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ejercicioN7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HL);
            this.Controls.Add(this.label4);
            this.Name = "ejercicioN7";
            this.Text = "ejercicioN7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox P;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}