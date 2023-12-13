namespace ejercicio5
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
            this.LblNum1 = new System.Windows.Forms.Label();
            this.LblNum2 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.tResultado = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNum1
            // 
            this.LblNum1.AutoSize = true;
            this.LblNum1.Location = new System.Drawing.Point(107, 117);
            this.LblNum1.Name = "LblNum1";
            this.LblNum1.Size = new System.Drawing.Size(53, 13);
            this.LblNum1.TabIndex = 0;
            this.LblNum1.Text = "Número 1";
            this.LblNum1.Click += new System.EventHandler(this.LblNum1_Click);
            // 
            // LblNum2
            // 
            this.LblNum2.AutoSize = true;
            this.LblNum2.Location = new System.Drawing.Point(107, 158);
            this.LblNum2.Name = "LblNum2";
            this.LblNum2.Size = new System.Drawing.Size(53, 13);
            this.LblNum2.TabIndex = 1;
            this.LblNum2.Text = "Número 2";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(105, 200);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(55, 13);
            this.LblResultado.TabIndex = 2;
            this.LblResultado.Text = "Resultado";
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(166, 110);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(100, 20);
            this.tNum1.TabIndex = 3;
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(166, 155);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(100, 20);
            this.tNum2.TabIndex = 4;
            this.tNum2.TextChanged += new System.EventHandler(this.tNum2_TextChanged);
            // 
            // tResultado
            // 
            this.tResultado.Location = new System.Drawing.Point(166, 197);
            this.tResultado.Name = "tResultado";
            this.tResultado.Size = new System.Drawing.Size(100, 20);
            this.tResultado.TabIndex = 5;
            this.tResultado.TextChanged += new System.EventHandler(this.tResultado_TextChanged);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(430, 108);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(144, 50);
            this.btnSumar.TabIndex = 6;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(430, 167);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(144, 50);
            this.btnRestar.TabIndex = 7;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.tResultado);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.tNum1);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblNum2);
            this.Controls.Add(this.LblNum1);
            this.Name = "Form1";
            this.Text = "Ejercicio5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNum1;
        private System.Windows.Forms.Label LblNum2;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.TextBox tResultado;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
    }
}

