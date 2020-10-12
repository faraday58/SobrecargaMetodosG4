namespace SobrecargaMetodosG4
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
            this.txtbOperan1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbOperan2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado1 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbOperan1
            // 
            this.txtbOperan1.Location = new System.Drawing.Point(47, 92);
            this.txtbOperan1.Name = "txtbOperan1";
            this.txtbOperan1.Size = new System.Drawing.Size(100, 26);
            this.txtbOperan1.TabIndex = 0;
            this.txtbOperan1.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // txtbOperan2
            // 
            this.txtbOperan2.Location = new System.Drawing.Point(247, 92);
            this.txtbOperan2.Name = "txtbOperan2";
            this.txtbOperan2.Size = new System.Drawing.Size(100, 26);
            this.txtbOperan2.TabIndex = 0;
            this.txtbOperan2.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // lbResultado1
            // 
            this.lbResultado1.AutoSize = true;
            this.lbResultado1.Location = new System.Drawing.Point(436, 98);
            this.lbResultado1.Name = "lbResultado1";
            this.lbResultado1.Size = new System.Drawing.Size(27, 20);
            this.lbResultado1.TabIndex = 1;
            this.lbResultado1.Text = "12";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(47, 167);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(105, 38);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 256);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lbResultado1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbOperan2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbOperan1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbOperan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbOperan2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado1;
        private System.Windows.Forms.Button btnSumar;
    }
}

