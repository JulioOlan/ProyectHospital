namespace ProyectoHospital
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtgv_Consulta = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultar_paciente = new System.Windows.Forms.TextBox();
            this.lblID_paciente = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtnombre_paciente = new System.Windows.Forms.TextBox();
            this.txtapellidos_paciente = new System.Windows.Forms.TextBox();
            this.txtcurp = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtfecha_nacimiento = new System.Windows.Forms.TextBox();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.lblnombrepaciente = new System.Windows.Forms.Label();
            this.lblapellidospaciente = new System.Windows.Forms.Label();
            this.lblcurp = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblfechanacimiento = new System.Windows.Forms.Label();
            this.lblestatus = new System.Windows.Forms.Label();
            this.txtlugar_nacimiento = new System.Windows.Forms.TextBox();
            this.lbllugarnacimiento = new System.Windows.Forms.Label();
            this.txtid_paciente = new System.Windows.Forms.TextBox();
            this.lblidpaciente = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarID = new System.Windows.Forms.TextBox();
            this.lblEliminarpaciente = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablaDoctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaInventariomedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaCitaspacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaRecetasmedicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbltitulotabla1 = new System.Windows.Forms.Label();
            this.ptbLogo1 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Consulta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Consulta
            // 
            this.dtgv_Consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_Consulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Consulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgv_Consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Consulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_Consulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Consulta.EnableHeadersVisualStyles = false;
            this.dtgv_Consulta.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgv_Consulta.Location = new System.Drawing.Point(43, 59);
            this.dtgv_Consulta.Name = "dtgv_Consulta";
            this.dtgv_Consulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Consulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_Consulta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_Consulta.Size = new System.Drawing.Size(1039, 325);
            this.dtgv_Consulta.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 407);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 47);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsultar_paciente
            // 
            this.txtConsultar_paciente.Location = new System.Drawing.Point(12, 494);
            this.txtConsultar_paciente.Name = "txtConsultar_paciente";
            this.txtConsultar_paciente.Size = new System.Drawing.Size(123, 20);
            this.txtConsultar_paciente.TabIndex = 4;
            // 
            // lblID_paciente
            // 
            this.lblID_paciente.AutoSize = true;
            this.lblID_paciente.ForeColor = System.Drawing.Color.White;
            this.lblID_paciente.Location = new System.Drawing.Point(12, 475);
            this.lblID_paciente.Name = "lblID_paciente";
            this.lblID_paciente.Size = new System.Drawing.Size(123, 13);
            this.lblID_paciente.TabIndex = 5;
            this.lblID_paciente.Text = "ID del paciente a buscar";
            // 
            // btnInsertar
            // 
            this.btnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(213, 409);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(111, 47);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtnombre_paciente
            // 
            this.txtnombre_paciente.Location = new System.Drawing.Point(466, 423);
            this.txtnombre_paciente.Name = "txtnombre_paciente";
            this.txtnombre_paciente.Size = new System.Drawing.Size(111, 20);
            this.txtnombre_paciente.TabIndex = 8;
            // 
            // txtapellidos_paciente
            // 
            this.txtapellidos_paciente.Location = new System.Drawing.Point(583, 423);
            this.txtapellidos_paciente.Name = "txtapellidos_paciente";
            this.txtapellidos_paciente.Size = new System.Drawing.Size(152, 20);
            this.txtapellidos_paciente.TabIndex = 9;
            // 
            // txtcurp
            // 
            this.txtcurp.Location = new System.Drawing.Point(743, 423);
            this.txtcurp.Name = "txtcurp";
            this.txtcurp.Size = new System.Drawing.Size(111, 20);
            this.txtcurp.TabIndex = 10;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(860, 423);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(111, 20);
            this.txtedad.TabIndex = 11;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(977, 423);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(105, 20);
            this.txtsexo.TabIndex = 12;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(349, 494);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(111, 20);
            this.txttelefono.TabIndex = 13;
            // 
            // txtfecha_nacimiento
            // 
            this.txtfecha_nacimiento.Location = new System.Drawing.Point(468, 494);
            this.txtfecha_nacimiento.Name = "txtfecha_nacimiento";
            this.txtfecha_nacimiento.Size = new System.Drawing.Size(111, 20);
            this.txtfecha_nacimiento.TabIndex = 14;
            // 
            // txtestatus
            // 
            this.txtestatus.Location = new System.Drawing.Point(585, 494);
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.Size = new System.Drawing.Size(111, 20);
            this.txtestatus.TabIndex = 15;
            // 
            // lblnombrepaciente
            // 
            this.lblnombrepaciente.AutoSize = true;
            this.lblnombrepaciente.ForeColor = System.Drawing.Color.White;
            this.lblnombrepaciente.Location = new System.Drawing.Point(463, 407);
            this.lblnombrepaciente.Name = "lblnombrepaciente";
            this.lblnombrepaciente.Size = new System.Drawing.Size(89, 13);
            this.lblnombrepaciente.TabIndex = 16;
            this.lblnombrepaciente.Text = "nombre_paciente";
            // 
            // lblapellidospaciente
            // 
            this.lblapellidospaciente.AutoSize = true;
            this.lblapellidospaciente.ForeColor = System.Drawing.Color.White;
            this.lblapellidospaciente.Location = new System.Drawing.Point(580, 407);
            this.lblapellidospaciente.Name = "lblapellidospaciente";
            this.lblapellidospaciente.Size = new System.Drawing.Size(95, 13);
            this.lblapellidospaciente.TabIndex = 17;
            this.lblapellidospaciente.Text = "apellidos_paciente";
            // 
            // lblcurp
            // 
            this.lblcurp.AutoSize = true;
            this.lblcurp.ForeColor = System.Drawing.Color.White;
            this.lblcurp.Location = new System.Drawing.Point(740, 407);
            this.lblcurp.Name = "lblcurp";
            this.lblcurp.Size = new System.Drawing.Size(28, 13);
            this.lblcurp.TabIndex = 18;
            this.lblcurp.Text = "curp";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.ForeColor = System.Drawing.Color.White;
            this.lbledad.Location = new System.Drawing.Point(857, 407);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(31, 13);
            this.lbledad.TabIndex = 19;
            this.lbledad.Text = "edad";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.ForeColor = System.Drawing.Color.White;
            this.lblsexo.Location = new System.Drawing.Point(974, 407);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(29, 13);
            this.lblsexo.TabIndex = 20;
            this.lblsexo.Text = "sexo";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.ForeColor = System.Drawing.Color.White;
            this.lbltelefono.Location = new System.Drawing.Point(346, 478);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(45, 13);
            this.lbltelefono.TabIndex = 21;
            this.lbltelefono.Text = "telefono";
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.ForeColor = System.Drawing.Color.White;
            this.lblfechanacimiento.Location = new System.Drawing.Point(465, 478);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(91, 13);
            this.lblfechanacimiento.TabIndex = 22;
            this.lblfechanacimiento.Text = "fecha_nacimiento";
            // 
            // lblestatus
            // 
            this.lblestatus.AutoSize = true;
            this.lblestatus.ForeColor = System.Drawing.Color.White;
            this.lblestatus.Location = new System.Drawing.Point(582, 478);
            this.lblestatus.Name = "lblestatus";
            this.lblestatus.Size = new System.Drawing.Size(41, 13);
            this.lblestatus.TabIndex = 23;
            this.lblestatus.Text = "estatus";
            // 
            // txtlugar_nacimiento
            // 
            this.txtlugar_nacimiento.Location = new System.Drawing.Point(702, 494);
            this.txtlugar_nacimiento.Name = "txtlugar_nacimiento";
            this.txtlugar_nacimiento.Size = new System.Drawing.Size(111, 20);
            this.txtlugar_nacimiento.TabIndex = 25;
            // 
            // lbllugarnacimiento
            // 
            this.lbllugarnacimiento.AutoSize = true;
            this.lbllugarnacimiento.ForeColor = System.Drawing.Color.White;
            this.lbllugarnacimiento.Location = new System.Drawing.Point(699, 478);
            this.lbllugarnacimiento.Name = "lbllugarnacimiento";
            this.lbllugarnacimiento.Size = new System.Drawing.Size(87, 13);
            this.lbllugarnacimiento.TabIndex = 26;
            this.lbllugarnacimiento.Text = "lugar_nacimiento";
            // 
            // txtid_paciente
            // 
            this.txtid_paciente.Location = new System.Drawing.Point(349, 423);
            this.txtid_paciente.Name = "txtid_paciente";
            this.txtid_paciente.Size = new System.Drawing.Size(111, 20);
            this.txtid_paciente.TabIndex = 27;
            // 
            // lblidpaciente
            // 
            this.lblidpaciente.AutoSize = true;
            this.lblidpaciente.ForeColor = System.Drawing.Color.White;
            this.lblidpaciente.Location = new System.Drawing.Point(346, 407);
            this.lblidpaciente.Name = "lblidpaciente";
            this.lblidpaciente.Size = new System.Drawing.Size(62, 13);
            this.lblidpaciente.TabIndex = 28;
            this.lblidpaciente.Text = "id_paciente";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(213, 555);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 47);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminarID
            // 
            this.txtEliminarID.Location = new System.Drawing.Point(346, 580);
            this.txtEliminarID.Name = "txtEliminarID";
            this.txtEliminarID.Size = new System.Drawing.Size(123, 20);
            this.txtEliminarID.TabIndex = 30;
            // 
            // lblEliminarpaciente
            // 
            this.lblEliminarpaciente.AutoSize = true;
            this.lblEliminarpaciente.ForeColor = System.Drawing.Color.White;
            this.lblEliminarpaciente.Location = new System.Drawing.Point(346, 564);
            this.lblEliminarpaciente.Name = "lblEliminarpaciente";
            this.lblEliminarpaciente.Size = new System.Drawing.Size(119, 13);
            this.lblEliminarpaciente.TabIndex = 31;
            this.lblEliminarpaciente.Text = "Eliminar paciente por ID";
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(213, 487);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 47);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaDoctoresToolStripMenuItem,
            this.tablaInventariomedicamentosToolStripMenuItem,
            this.tablaCitaspacientesToolStripMenuItem,
            this.tablaRecetasmedicasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1296, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablaDoctoresToolStripMenuItem
            // 
            this.tablaDoctoresToolStripMenuItem.Name = "tablaDoctoresToolStripMenuItem";
            this.tablaDoctoresToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.tablaDoctoresToolStripMenuItem.Text = "Tabla doctores";
            this.tablaDoctoresToolStripMenuItem.Click += new System.EventHandler(this.tablaDoctoresToolStripMenuItem_Click);
            // 
            // tablaInventariomedicamentosToolStripMenuItem
            // 
            this.tablaInventariomedicamentosToolStripMenuItem.Name = "tablaInventariomedicamentosToolStripMenuItem";
            this.tablaInventariomedicamentosToolStripMenuItem.Size = new System.Drawing.Size(187, 20);
            this.tablaInventariomedicamentosToolStripMenuItem.Text = "Tabla inventario_medicamentos";
            this.tablaInventariomedicamentosToolStripMenuItem.Click += new System.EventHandler(this.tablaInventariomedicamentosToolStripMenuItem_Click);
            // 
            // tablaCitaspacientesToolStripMenuItem
            // 
            this.tablaCitaspacientesToolStripMenuItem.Name = "tablaCitaspacientesToolStripMenuItem";
            this.tablaCitaspacientesToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.tablaCitaspacientesToolStripMenuItem.Text = "Tabla citas_pacientes";
            this.tablaCitaspacientesToolStripMenuItem.Click += new System.EventHandler(this.tablaCitaspacientesToolStripMenuItem_Click);
            // 
            // tablaRecetasmedicasToolStripMenuItem
            // 
            this.tablaRecetasmedicasToolStripMenuItem.Name = "tablaRecetasmedicasToolStripMenuItem";
            this.tablaRecetasmedicasToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.tablaRecetasmedicasToolStripMenuItem.Text = "Tabla recetas_medicas";
            // 
            // lbltitulotabla1
            // 
            this.lbltitulotabla1.AutoSize = true;
            this.lbltitulotabla1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulotabla1.ForeColor = System.Drawing.Color.White;
            this.lbltitulotabla1.Location = new System.Drawing.Point(40, 39);
            this.lbltitulotabla1.Name = "lbltitulotabla1";
            this.lbltitulotabla1.Size = new System.Drawing.Size(130, 17);
            this.lbltitulotabla1.TabIndex = 58;
            this.lbltitulotabla1.Text = "Tabla de Pacientes";
            // 
            // ptbLogo1
            // 
            this.ptbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo1.Image")));
            this.ptbLogo1.Location = new System.Drawing.Point(1113, 153);
            this.ptbLogo1.Name = "ptbLogo1";
            this.ptbLogo1.Size = new System.Drawing.Size(156, 143);
            this.ptbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo1.TabIndex = 59;
            this.ptbLogo1.TabStop = false;
            // 
            // ptb1
            // 
            this.ptb1.BackColor = System.Drawing.Color.White;
            this.ptb1.Image = ((System.Drawing.Image)(resources.GetObject("ptb1.Image")));
            this.ptb1.Location = new System.Drawing.Point(1276, 0);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(20, 24);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb1.TabIndex = 60;
            this.ptb1.TabStop = false;
            this.ptb1.Click += new System.EventHandler(this.ptb1_Click);
            // 
            // ptb2
            // 
            this.ptb2.BackColor = System.Drawing.Color.White;
            this.ptb2.Image = ((System.Drawing.Image)(resources.GetObject("ptb2.Image")));
            this.ptb2.Location = new System.Drawing.Point(1250, 0);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(20, 24);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb2.TabIndex = 61;
            this.ptb2.TabStop = false;
            this.ptb2.Click += new System.EventHandler(this.ptb2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1296, 612);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.ptbLogo1);
            this.Controls.Add(this.lbltitulotabla1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblEliminarpaciente);
            this.Controls.Add(this.txtEliminarID);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblidpaciente);
            this.Controls.Add(this.txtid_paciente);
            this.Controls.Add(this.lbllugarnacimiento);
            this.Controls.Add(this.txtlugar_nacimiento);
            this.Controls.Add(this.lblestatus);
            this.Controls.Add(this.lblfechanacimiento);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblcurp);
            this.Controls.Add(this.lblapellidospaciente);
            this.Controls.Add(this.lblnombrepaciente);
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.txtfecha_nacimiento);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtcurp);
            this.Controls.Add(this.txtapellidos_paciente);
            this.Controls.Add(this.txtnombre_paciente);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblID_paciente);
            this.Controls.Add(this.txtConsultar_paciente);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtgv_Consulta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BD ADMINISTRADOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Consulta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_Consulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultar_paciente;
        private System.Windows.Forms.Label lblID_paciente;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtnombre_paciente;
        private System.Windows.Forms.TextBox txtapellidos_paciente;
        private System.Windows.Forms.TextBox txtcurp;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtfecha_nacimiento;
        private System.Windows.Forms.TextBox txtestatus;
        private System.Windows.Forms.Label lblnombrepaciente;
        private System.Windows.Forms.Label lblapellidospaciente;
        private System.Windows.Forms.Label lblcurp;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblfechanacimiento;
        private System.Windows.Forms.Label lblestatus;
        private System.Windows.Forms.TextBox txtlugar_nacimiento;
        private System.Windows.Forms.Label lbllugarnacimiento;
        private System.Windows.Forms.TextBox txtid_paciente;
        private System.Windows.Forms.Label lblidpaciente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminarID;
        private System.Windows.Forms.Label lblEliminarpaciente;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablaDoctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaInventariomedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaCitaspacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaRecetasmedicasToolStripMenuItem;
        private System.Windows.Forms.Label lbltitulotabla1;
        private System.Windows.Forms.PictureBox ptbLogo1;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.PictureBox ptb2;
    }
}

