namespace Ejercicio01
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
            this.btnTabla = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.listBoxTabla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTabla
            // 
            this.btnTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabla.Location = new System.Drawing.Point(449, 118);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(106, 374);
            this.btnTabla.TabIndex = 0;
            this.btnTabla.Text = "Tabla";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            this.btnTabla.MouseHover += new System.EventHandler(this.btnTabla_MouseHover);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(214, 118);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(229, 24);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // listBoxTabla
            // 
            this.listBoxTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTabla.FormattingEnabled = true;
            this.listBoxTabla.ItemHeight = 22;
            this.listBoxTabla.Location = new System.Drawing.Point(214, 150);
            this.listBoxTabla.Name = "listBoxTabla";
            this.listBoxTabla.Size = new System.Drawing.Size(229, 356);
            this.listBoxTabla.TabIndex = 2;
            this.listBoxTabla.SelectedIndexChanged += new System.EventHandler(this.listBoxTabla_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 643);
            this.Controls.Add(this.listBoxTabla);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ListBox listBoxTabla;
    }
}

