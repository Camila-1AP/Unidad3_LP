namespace Ejercicio08
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(35, 193);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(410, 22);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.Plum;
            this.btnContar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContar.Location = new System.Drawing.Point(451, 193);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(147, 305);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Palabras";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label label1;
    }
}

