namespace Elempleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.btnCalantiguedad = new System.Windows.Forms.Button();
            this.btnCalprestaciones = new System.Windows.Forms.Button();
            this.textCalcularedadaños = new System.Windows.Forms.TextBox();
            this.textCalcularantiguedadaños = new System.Windows.Forms.TextBox();
            this.textPrestaciones = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.btnCaledad = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCargarimagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textFechanacimiento = new System.Windows.Forms.TextBox();
            this.textFechaingreso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.textCalcularedadmeses = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textCalcularantiguedadmeses = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de Nacimiento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Ingreso:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Calculos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(166, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Salario: $";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textSalario
            // 
            this.textSalario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textSalario.Location = new System.Drawing.Point(231, 259);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(100, 20);
            this.textSalario.TabIndex = 19;
            this.textSalario.TextChanged += new System.EventHandler(this.textSalario_TextChanged);
            this.textSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSalario_KeyPress);
            // 
            // btnCalantiguedad
            // 
            this.btnCalantiguedad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalantiguedad.Location = new System.Drawing.Point(112, 362);
            this.btnCalantiguedad.Name = "btnCalantiguedad";
            this.btnCalantiguedad.Size = new System.Drawing.Size(126, 23);
            this.btnCalantiguedad.TabIndex = 22;
            this.btnCalantiguedad.Text = "Calcular Antiguedad";
            this.btnCalantiguedad.UseVisualStyleBackColor = false;
            this.btnCalantiguedad.Click += new System.EventHandler(this.btnCalantiguedad_Click);
            // 
            // btnCalprestaciones
            // 
            this.btnCalprestaciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalprestaciones.Location = new System.Drawing.Point(112, 404);
            this.btnCalprestaciones.Name = "btnCalprestaciones";
            this.btnCalprestaciones.Size = new System.Drawing.Size(125, 23);
            this.btnCalprestaciones.TabIndex = 23;
            this.btnCalprestaciones.Text = "Calcular Prestaciones";
            this.btnCalprestaciones.UseVisualStyleBackColor = false;
            this.btnCalprestaciones.Click += new System.EventHandler(this.btnCalprestaciones_Click);
            // 
            // textCalcularedadaños
            // 
            this.textCalcularedadaños.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textCalcularedadaños.Location = new System.Drawing.Point(244, 323);
            this.textCalcularedadaños.Name = "textCalcularedadaños";
            this.textCalcularedadaños.Size = new System.Drawing.Size(32, 20);
            this.textCalcularedadaños.TabIndex = 24;
            this.textCalcularedadaños.TextChanged += new System.EventHandler(this.textCalcularedad_TextChanged);
            this.textCalcularedadaños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCalcularedad_KeyPress);
            // 
            // textCalcularantiguedadaños
            // 
            this.textCalcularantiguedadaños.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textCalcularantiguedadaños.Location = new System.Drawing.Point(244, 364);
            this.textCalcularantiguedadaños.Name = "textCalcularantiguedadaños";
            this.textCalcularantiguedadaños.Size = new System.Drawing.Size(32, 20);
            this.textCalcularantiguedadaños.TabIndex = 25;
            this.textCalcularantiguedadaños.TextChanged += new System.EventHandler(this.textCalcularantiguedad_TextChanged);
            this.textCalcularantiguedadaños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCalcularantiguedad_KeyPress);
            // 
            // textPrestaciones
            // 
            this.textPrestaciones.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textPrestaciones.Location = new System.Drawing.Point(245, 404);
            this.textPrestaciones.Name = "textPrestaciones";
            this.textPrestaciones.Size = new System.Drawing.Size(100, 20);
            this.textPrestaciones.TabIndex = 26;
            this.textPrestaciones.TextChanged += new System.EventHandler(this.textPrestaciones_TextChanged);
            this.textPrestaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrestaciones_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Puntos de Extension";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(190, 462);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Opcion 1";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(300, 462);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 29;
            this.button6.Text = "Opcion 2";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textNombre.Location = new System.Drawing.Point(217, 29);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(169, 20);
            this.textNombre.TabIndex = 31;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textApellido.Location = new System.Drawing.Point(217, 61);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(169, 20);
            this.textApellido.TabIndex = 32;
            // 
            // btnCaledad
            // 
            this.btnCaledad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCaledad.Location = new System.Drawing.Point(113, 323);
            this.btnCaledad.Name = "btnCaledad";
            this.btnCaledad.Size = new System.Drawing.Size(125, 23);
            this.btnCaledad.TabIndex = 40;
            this.btnCaledad.Text = "Calcular Edad";
            this.btnCaledad.UseVisualStyleBackColor = false;
            this.btnCaledad.Click += new System.EventHandler(this.btnCaledad_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(408, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 126);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // btnCargarimagen
            // 
            this.btnCargarimagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargarimagen.Location = new System.Drawing.Point(423, 99);
            this.btnCargarimagen.Name = "btnCargarimagen";
            this.btnCargarimagen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarimagen.TabIndex = 43;
            this.btnCargarimagen.Text = "Cargar";
            this.btnCargarimagen.UseVisualStyleBackColor = false;
            this.btnCargarimagen.Click += new System.EventHandler(this.btnCargarimagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textFechanacimiento
            // 
            this.textFechanacimiento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textFechanacimiento.Location = new System.Drawing.Point(217, 124);
            this.textFechanacimiento.Name = "textFechanacimiento";
            this.textFechanacimiento.Size = new System.Drawing.Size(147, 20);
            this.textFechanacimiento.TabIndex = 45;
            this.textFechanacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFechanacimiento_KeyPress);
            // 
            // textFechaingreso
            // 
            this.textFechaingreso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textFechaingreso.Location = new System.Drawing.Point(217, 159);
            this.textFechaingreso.Name = "textFechaingreso";
            this.textFechaingreso.Size = new System.Drawing.Size(147, 20);
            this.textFechaingreso.TabIndex = 46;
            this.textFechaingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFechaingreso_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(419, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Fotografia";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(347, 258);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(280, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 51;
            this.label12.Text = "Años";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(280, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "Años";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Location = new System.Drawing.Point(422, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGenero.Location = new System.Drawing.Point(217, 92);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(48, 20);
            this.txtGenero.TabIndex = 54;
            // 
            // textCalcularedadmeses
            // 
            this.textCalcularedadmeses.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textCalcularedadmeses.Location = new System.Drawing.Point(340, 323);
            this.textCalcularedadmeses.Name = "textCalcularedadmeses";
            this.textCalcularedadmeses.Size = new System.Drawing.Size(32, 20);
            this.textCalcularedadmeses.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(387, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 56;
            this.label14.Text = "Meses";
            // 
            // textCalcularantiguedadmeses
            // 
            this.textCalcularantiguedadmeses.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textCalcularantiguedadmeses.Location = new System.Drawing.Point(340, 364);
            this.textCalcularantiguedadmeses.Name = "textCalcularantiguedadmeses";
            this.textCalcularantiguedadmeses.Size = new System.Drawing.Size(32, 20);
            this.textCalcularantiguedadmeses.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(387, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 58;
            this.label15.Text = "Meses";
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCargo.Location = new System.Drawing.Point(217, 193);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(147, 20);
            this.txtCargo.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 59;
            this.label16.Text = "Cargo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(520, 497);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textCalcularantiguedadmeses);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textCalcularedadmeses);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textFechaingreso);
            this.Controls.Add(this.textFechanacimiento);
            this.Controls.Add(this.btnCargarimagen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCaledad);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textPrestaciones);
            this.Controls.Add(this.textCalcularantiguedadaños);
            this.Controls.Add(this.textCalcularedadaños);
            this.Controls.Add(this.btnCalprestaciones);
            this.Controls.Add(this.btnCalantiguedad);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.Button btnCalantiguedad;
        private System.Windows.Forms.Button btnCalprestaciones;
        private System.Windows.Forms.TextBox textCalcularedadaños;
        private System.Windows.Forms.TextBox textCalcularantiguedadaños;
        private System.Windows.Forms.TextBox textPrestaciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Button btnCaledad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCargarimagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textFechanacimiento;
        private System.Windows.Forms.TextBox textFechaingreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox textCalcularedadmeses;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textCalcularantiguedadmeses;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label16;
    }
}

