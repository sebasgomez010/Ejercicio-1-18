namespace Ejercicio_1_18.Interface
{
    partial class ejercicioN11
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
            this.TXTAA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXAN = new System.Windows.Forms.TextBox();
            this.TXAA = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TXTSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTAN
            // 
            this.TXTAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAN.Location = new System.Drawing.Point(21, 37);
            this.TXTAN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TXTAN.Name = "TXTAN";
            this.TXTAN.Size = new System.Drawing.Size(340, 41);
            this.TXTAN.TabIndex = 14;
            this.TXTAN.Text = "Ingrese año de nacimiento";
            // 
            // TXTAA
            // 
            this.TXTAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAA.Location = new System.Drawing.Point(21, 108);
            this.TXTAA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TXTAA.Name = "TXTAA";
            this.TXTAA.Size = new System.Drawing.Size(316, 41);
            this.TXTAA.TabIndex = 15;
            this.TXTAA.Text = "Año actual";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 41);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mensaje";
            // 
            // TXAN
            // 
            this.TXAN.Location = new System.Drawing.Point(427, 48);
            this.TXAN.Margin = new System.Windows.Forms.Padding(2);
            this.TXAN.Name = "TXAN";
            this.TXAN.Size = new System.Drawing.Size(99, 20);
            this.TXAN.TabIndex = 24;
            // 
            // TXAA
            // 
            this.TXAA.Location = new System.Drawing.Point(427, 108);
            this.TXAA.Margin = new System.Windows.Forms.Padding(2);
            this.TXAA.Name = "TXAA";
            this.TXAA.Size = new System.Drawing.Size(99, 20);
            this.TXAA.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXTSalida
            // 
            this.TXTSalida.Location = new System.Drawing.Point(234, 263);
            this.TXTSalida.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSalida.Name = "TXTSalida";
            this.TXTSalida.Size = new System.Drawing.Size(292, 20);
            this.TXTSalida.TabIndex = 27;
            // 
            // ejercicioN11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTSalida);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXAA);
            this.Controls.Add(this.TXAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTAA);
            this.Controls.Add(this.TXTAN);
            this.Name = "ejercicioN11";
            this.Text = "ejercicioN11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TXTAN;
        private System.Windows.Forms.Label TXTAA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXAN;
        private System.Windows.Forms.TextBox TXAA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXTSalida;
    }
}