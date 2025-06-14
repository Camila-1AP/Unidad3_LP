namespace Ejercicio07
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.listBoxPrimos = new System.Windows.Forms.ListBox();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(151, 172);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(119, 29);
            this.txt2.TabIndex = 0;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(151, 129);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(119, 29);
            this.txt1.TabIndex = 1;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_keyPress);
            // 
            // listBoxPrimos
            // 
            this.listBoxPrimos.BackColor = System.Drawing.Color.Teal;
            this.listBoxPrimos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPrimos.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrimos.ForeColor = System.Drawing.Color.Snow;
            this.listBoxPrimos.FormattingEnabled = true;
            this.listBoxPrimos.ItemHeight = 25;
            this.listBoxPrimos.Location = new System.Drawing.Point(276, 129);
            this.listBoxPrimos.Name = "listBoxPrimos";
            this.listBoxPrimos.Size = new System.Drawing.Size(260, 375);
            this.listBoxPrimos.TabIndex = 2;
            // 
            // btnPrimos
            // 
            this.btnPrimos.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimos.Location = new System.Drawing.Point(151, 211);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(119, 293);
            this.btnPrimos.TabIndex = 3;
            this.btnPrimos.Text = "Primos";
            this.btnPrimos.UseVisualStyleBackColor = true;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 646);
            this.Controls.Add(this.btnPrimos);
            this.Controls.Add(this.listBoxPrimos);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ListBox listBoxPrimos;
        private System.Windows.Forms.Button btnPrimos;
    }
}

