namespace LastLab
{
    partial class Form2
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
            this.tbPrincipal = new System.Windows.Forms.TextBox();
            this.btPeliculas = new System.Windows.Forms.Button();
            this.btActores = new System.Windows.Forms.Button();
            this.btDirectores = new System.Windows.Forms.Button();
            this.btProductores = new System.Windows.Forms.Button();
            this.btEstudio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Location = new System.Drawing.Point(108, 107);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.Size = new System.Drawing.Size(549, 20);
            this.tbPrincipal.TabIndex = 0;
            // 
            // btPeliculas
            // 
            this.btPeliculas.Location = new System.Drawing.Point(109, 146);
            this.btPeliculas.Name = "btPeliculas";
            this.btPeliculas.Size = new System.Drawing.Size(102, 28);
            this.btPeliculas.TabIndex = 1;
            this.btPeliculas.Text = "Peliculas";
            this.btPeliculas.UseVisualStyleBackColor = true;
            // 
            // btActores
            // 
            this.btActores.Location = new System.Drawing.Point(228, 145);
            this.btActores.Name = "btActores";
            this.btActores.Size = new System.Drawing.Size(84, 28);
            this.btActores.TabIndex = 2;
            this.btActores.Text = "Actores";
            this.btActores.UseVisualStyleBackColor = true;
            // 
            // btDirectores
            // 
            this.btDirectores.Location = new System.Drawing.Point(338, 145);
            this.btDirectores.Name = "btDirectores";
            this.btDirectores.Size = new System.Drawing.Size(85, 28);
            this.btDirectores.TabIndex = 3;
            this.btDirectores.Text = "Directores";
            this.btDirectores.UseVisualStyleBackColor = true;
            // 
            // btProductores
            // 
            this.btProductores.Location = new System.Drawing.Point(449, 145);
            this.btProductores.Name = "btProductores";
            this.btProductores.Size = new System.Drawing.Size(95, 28);
            this.btProductores.TabIndex = 4;
            this.btProductores.Text = "Productores";
            this.btProductores.UseVisualStyleBackColor = true;
            // 
            // btEstudio
            // 
            this.btEstudio.Location = new System.Drawing.Point(571, 149);
            this.btEstudio.Name = "btEstudio";
            this.btEstudio.Size = new System.Drawing.Size(85, 24);
            this.btEstudio.TabIndex = 5;
            this.btEstudio.Text = "Estudio";
            this.btEstudio.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEstudio);
            this.Controls.Add(this.btProductores);
            this.Controls.Add(this.btDirectores);
            this.Controls.Add(this.btActores);
            this.Controls.Add(this.btPeliculas);
            this.Controls.Add(this.tbPrincipal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrincipal;
        private System.Windows.Forms.Button btPeliculas;
        private System.Windows.Forms.Button btActores;
        private System.Windows.Forms.Button btDirectores;
        private System.Windows.Forms.Button btProductores;
        private System.Windows.Forms.Button btEstudio;
    }
}