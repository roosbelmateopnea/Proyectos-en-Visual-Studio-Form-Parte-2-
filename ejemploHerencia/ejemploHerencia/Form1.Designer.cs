namespace ejemploHerencia
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuadradoLado = new System.Windows.Forms.TextBox();
            this.txtCuadradoSLado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCirculoRadio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcularCuadrado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultadoCuadrado = new System.Windows.Forms.Label();
            this.lblResultadoCirculo = new System.Windows.Forms.Label();
            this.btnCalcularCirculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Calcular Area del Cuadrado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(122, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Digite el Primer Lado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(122, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Digite el Segundo Lado:";
            // 
            // txtCuadradoLado
            // 
            this.txtCuadradoLado.Location = new System.Drawing.Point(391, 93);
            this.txtCuadradoLado.Name = "txtCuadradoLado";
            this.txtCuadradoLado.Size = new System.Drawing.Size(100, 20);
            this.txtCuadradoLado.TabIndex = 70;
            // 
            // txtCuadradoSLado
            // 
            this.txtCuadradoSLado.Location = new System.Drawing.Point(391, 132);
            this.txtCuadradoSLado.Name = "txtCuadradoSLado";
            this.txtCuadradoSLado.Size = new System.Drawing.Size(100, 20);
            this.txtCuadradoSLado.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Calcular Area del Circulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(126, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Digita el Radio:";
            // 
            // txtCirculoRadio
            // 
            this.txtCirculoRadio.Location = new System.Drawing.Point(395, 284);
            this.txtCirculoRadio.Name = "txtCirculoRadio";
            this.txtCirculoRadio.Size = new System.Drawing.Size(100, 20);
            this.txtCirculoRadio.TabIndex = 74;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(513, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 34);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCalcularCuadrado
            // 
            this.btnCalcularCuadrado.Location = new System.Drawing.Point(577, 103);
            this.btnCalcularCuadrado.Name = "btnCalcularCuadrado";
            this.btnCalcularCuadrado.Size = new System.Drawing.Size(129, 34);
            this.btnCalcularCuadrado.TabIndex = 76;
            this.btnCalcularCuadrado.Text = "Calcular";
            this.btnCalcularCuadrado.UseVisualStyleBackColor = true;
            this.btnCalcularCuadrado.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 77;
            this.label6.Text = "Resultado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(58, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Resultado:";
            // 
            // lblResultadoCuadrado
            // 
            this.lblResultadoCuadrado.AutoSize = true;
            this.lblResultadoCuadrado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResultadoCuadrado.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoCuadrado.Location = new System.Drawing.Point(142, 181);
            this.lblResultadoCuadrado.Name = "lblResultadoCuadrado";
            this.lblResultadoCuadrado.Size = new System.Drawing.Size(31, 16);
            this.lblResultadoCuadrado.TabIndex = 80;
            this.lblResultadoCuadrado.Text = "--.--";
            // 
            // lblResultadoCirculo
            // 
            this.lblResultadoCirculo.AutoSize = true;
            this.lblResultadoCirculo.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResultadoCirculo.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoCirculo.Location = new System.Drawing.Point(142, 330);
            this.lblResultadoCirculo.Name = "lblResultadoCirculo";
            this.lblResultadoCirculo.Size = new System.Drawing.Size(31, 16);
            this.lblResultadoCirculo.TabIndex = 81;
            this.lblResultadoCirculo.Text = "--.--";
            // 
            // btnCalcularCirculo
            // 
            this.btnCalcularCirculo.Location = new System.Drawing.Point(577, 256);
            this.btnCalcularCirculo.Name = "btnCalcularCirculo";
            this.btnCalcularCirculo.Size = new System.Drawing.Size(129, 34);
            this.btnCalcularCirculo.TabIndex = 82;
            this.btnCalcularCirculo.Text = "Calcular";
            this.btnCalcularCirculo.UseVisualStyleBackColor = true;
            this.btnCalcularCirculo.Click += new System.EventHandler(this.btnCalcularCirculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularCirculo);
            this.Controls.Add(this.lblResultadoCirculo);
            this.Controls.Add(this.lblResultadoCuadrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcularCuadrado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCirculoRadio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCuadradoSLado);
            this.Controls.Add(this.txtCuadradoLado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuadradoLado;
        private System.Windows.Forms.TextBox txtCuadradoSLado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCirculoRadio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcularCuadrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResultadoCuadrado;
        private System.Windows.Forms.Label lblResultadoCirculo;
        private System.Windows.Forms.Button btnCalcularCirculo;
    }
}

