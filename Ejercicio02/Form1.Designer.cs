namespace Ejercicio02
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
            this.nMinutos = new System.Windows.Forms.NumericUpDown();
            this.nSegundos = new System.Windows.Forms.NumericUpDown();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSegundos)).BeginInit();
            this.SuspendLayout();
            // 
            // nMinutos
            // 
            this.nMinutos.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMinutos.Location = new System.Drawing.Point(172, 151);
            this.nMinutos.Name = "nMinutos";
            this.nMinutos.Size = new System.Drawing.Size(174, 24);
            this.nMinutos.TabIndex = 0;
            // 
            // nSegundos
            // 
            this.nSegundos.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSegundos.Location = new System.Drawing.Point(352, 151);
            this.nSegundos.Name = "nSegundos";
            this.nSegundos.Size = new System.Drawing.Size(163, 24);
            this.nSegundos.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(172, 242);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(343, 42);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Start";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(316, 94);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(0, 25);
            this.labelTiempo.TabIndex = 3;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.BackColor = System.Drawing.Color.Gainsboro;
            this.labelMinutes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelMinutes.Location = new System.Drawing.Point(189, 193);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(95, 27);
            this.labelMinutes.TabIndex = 4;
            this.labelMinutes.Text = "Minutes";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.BackColor = System.Drawing.Color.LightGray;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelSeconds.Location = new System.Drawing.Point(375, 193);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(95, 27);
            this.labelSeconds.TabIndex = 5;
            this.labelSeconds.Text = "Seconds";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(124, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 230);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 440);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.nSegundos);
            this.Controls.Add(this.nMinutos);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSegundos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nMinutos;
        private System.Windows.Forms.NumericUpDown nSegundos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Panel panel1;
    }
}

