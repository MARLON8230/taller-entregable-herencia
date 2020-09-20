namespace taller_final
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxoperaciones = new System.Windows.Forms.PictureBox();
            this.pbxconversor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxoperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxconversor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taller Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "conversor de temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operaciones matematicas";
            // 
            // pbxoperaciones
            // 
            this.pbxoperaciones.Image = global::taller_final.Properties.Resources.numero_2;
            this.pbxoperaciones.Location = new System.Drawing.Point(187, 247);
            this.pbxoperaciones.Name = "pbxoperaciones";
            this.pbxoperaciones.Size = new System.Drawing.Size(126, 97);
            this.pbxoperaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxoperaciones.TabIndex = 2;
            this.pbxoperaciones.TabStop = false;
            this.pbxoperaciones.Click += new System.EventHandler(this.pbxoperaciones_Click);
            // 
            // pbxconversor
            // 
            this.pbxconversor.Image = global::taller_final.Properties.Resources.numero_1;
            this.pbxconversor.Location = new System.Drawing.Point(187, 98);
            this.pbxconversor.Name = "pbxconversor";
            this.pbxconversor.Size = new System.Drawing.Size(117, 96);
            this.pbxconversor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxconversor.TabIndex = 1;
            this.pbxconversor.TabStop = false;
            this.pbxconversor.Click += new System.EventHandler(this.pbxconversor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxoperaciones);
            this.Controls.Add(this.pbxconversor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxoperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxconversor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxconversor;
        private System.Windows.Forms.PictureBox pbxoperaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

