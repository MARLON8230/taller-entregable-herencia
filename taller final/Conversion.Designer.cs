namespace taller_final
{
    partial class Conversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmiligramos = new System.Windows.Forms.Button();
            this.btngramos = new System.Windows.Forms.Button();
            this.btndecagramos = new System.Windows.Forms.Button();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.pbxsalir = new System.Windows.Forms.PictureBox();
            this.lblresultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Temperatura ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "escriba  el peso que desea convertir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convertir A :";
            // 
            // btnmiligramos
            // 
            this.btnmiligramos.Location = new System.Drawing.Point(226, 201);
            this.btnmiligramos.Name = "btnmiligramos";
            this.btnmiligramos.Size = new System.Drawing.Size(92, 23);
            this.btnmiligramos.TabIndex = 3;
            this.btnmiligramos.Text = "Miligramos";
            this.btnmiligramos.UseVisualStyleBackColor = true;
            this.btnmiligramos.Click += new System.EventHandler(this.btnmiligramos_Click);
            // 
            // btngramos
            // 
            this.btngramos.Location = new System.Drawing.Point(395, 201);
            this.btngramos.Name = "btngramos";
            this.btngramos.Size = new System.Drawing.Size(75, 23);
            this.btngramos.TabIndex = 4;
            this.btngramos.Text = "Gramos";
            this.btngramos.UseVisualStyleBackColor = true;
            this.btngramos.Click += new System.EventHandler(this.btngramos_Click);
            // 
            // btndecagramos
            // 
            this.btndecagramos.Location = new System.Drawing.Point(527, 201);
            this.btndecagramos.Name = "btndecagramos";
            this.btndecagramos.Size = new System.Drawing.Size(101, 23);
            this.btndecagramos.TabIndex = 5;
            this.btndecagramos.Text = "decagramos";
            this.btndecagramos.UseVisualStyleBackColor = true;
            this.btndecagramos.Click += new System.EventHandler(this.btndecagramos_Click);
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(643, 97);
            this.txtpeso.Multiline = true;
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(145, 73);
            this.txtpeso.TabIndex = 6;
            // 
            // pbxsalir
            // 
            this.pbxsalir.Image = global::taller_final.Properties.Resources.exit;
            this.pbxsalir.Location = new System.Drawing.Point(643, 340);
            this.pbxsalir.Name = "pbxsalir";
            this.pbxsalir.Size = new System.Drawing.Size(100, 77);
            this.pbxsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxsalir.TabIndex = 7;
            this.pbxsalir.TabStop = false;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(223, 312);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(164, 38);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.pbxsalir);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.btndecagramos);
            this.Controls.Add(this.btngramos);
            this.Controls.Add(this.btnmiligramos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Conversion";
            this.Text = "conversion";
            ((System.ComponentModel.ISupportInitialize)(this.pbxsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmiligramos;
        private System.Windows.Forms.Button btngramos;
        private System.Windows.Forms.Button btndecagramos;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.PictureBox pbxsalir;
        private System.Windows.Forms.Label lblresultado;
    }
}