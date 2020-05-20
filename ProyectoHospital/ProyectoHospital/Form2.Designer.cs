namespace ProyectoHospital
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dtgv_Consulta2 = new System.Windows.Forms.DataGridView();
            this.btnActualizar2 = new System.Windows.Forms.Button();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnInsertar2 = new System.Windows.Forms.Button();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.txtConsultar_doctor = new System.Windows.Forms.TextBox();
            this.lblID_doctor = new System.Windows.Forms.Label();
            this.txtEliminarIDdoctor = new System.Windows.Forms.TextBox();
            this.lblEliminardoctor = new System.Windows.Forms.Label();
            this.txtid_doctor = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtconsultorio = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtespecialidad = new System.Windows.Forms.TextBox();
            this.txtfecha_nac = new System.Windows.Forms.TextBox();
            this.txtnombre_doctor = new System.Windows.Forms.TextBox();
            this.lbliddoctor = new System.Windows.Forms.Label();
            this.lblfechanacimiento = new System.Windows.Forms.Label();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblconsultorio = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblnombredoctor = new System.Windows.Forms.Label();
            this.lbltitulotabla2 = new System.Windows.Forms.Label();
            this.ptbLogo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Consulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Consulta2
            // 
            this.dtgv_Consulta2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_Consulta2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Consulta2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgv_Consulta2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Consulta2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_Consulta2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Consulta2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgv_Consulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Consulta2.EnableHeadersVisualStyles = false;
            this.dtgv_Consulta2.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgv_Consulta2.Location = new System.Drawing.Point(195, 75);
            this.dtgv_Consulta2.Name = "dtgv_Consulta2";
            this.dtgv_Consulta2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Consulta2.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_Consulta2.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgv_Consulta2.Size = new System.Drawing.Size(882, 271);
            this.dtgv_Consulta2.TabIndex = 3;
            // 
            // btnActualizar2
            // 
            this.btnActualizar2.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnActualizar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar2.Location = new System.Drawing.Point(195, 484);
            this.btnActualizar2.Name = "btnActualizar2";
            this.btnActualizar2.Size = new System.Drawing.Size(111, 47);
            this.btnActualizar2.TabIndex = 36;
            this.btnActualizar2.Text = "Actualizar";
            this.btnActualizar2.UseVisualStyleBackColor = true;
            this.btnActualizar2.Click += new System.EventHandler(this.btnActualizar2_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnEliminar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar2.Location = new System.Drawing.Point(12, 248);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(111, 47);
            this.btnEliminar2.TabIndex = 35;
            this.btnEliminar2.Text = "Eliminar";
            this.btnEliminar2.UseVisualStyleBackColor = false;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnInsertar2
            // 
            this.btnInsertar2.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnInsertar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar2.Location = new System.Drawing.Point(195, 406);
            this.btnInsertar2.Name = "btnInsertar2";
            this.btnInsertar2.Size = new System.Drawing.Size(111, 47);
            this.btnInsertar2.TabIndex = 34;
            this.btnInsertar2.Text = "Insertar";
            this.btnInsertar2.UseVisualStyleBackColor = true;
            this.btnInsertar2.Click += new System.EventHandler(this.btnInsertar2_Click);
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnConsultar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnConsultar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar2.Location = new System.Drawing.Point(12, 91);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(111, 47);
            this.btnConsultar2.TabIndex = 33;
            this.btnConsultar2.Text = "Consultar";
            this.btnConsultar2.UseVisualStyleBackColor = false;
            this.btnConsultar2.Click += new System.EventHandler(this.btnConsultar2_Click);
            // 
            // txtConsultar_doctor
            // 
            this.txtConsultar_doctor.Location = new System.Drawing.Point(12, 172);
            this.txtConsultar_doctor.Name = "txtConsultar_doctor";
            this.txtConsultar_doctor.Size = new System.Drawing.Size(123, 20);
            this.txtConsultar_doctor.TabIndex = 37;
            // 
            // lblID_doctor
            // 
            this.lblID_doctor.AutoSize = true;
            this.lblID_doctor.ForeColor = System.Drawing.Color.White;
            this.lblID_doctor.Location = new System.Drawing.Point(9, 156);
            this.lblID_doctor.Name = "lblID_doctor";
            this.lblID_doctor.Size = new System.Drawing.Size(112, 13);
            this.lblID_doctor.TabIndex = 38;
            this.lblID_doctor.Text = "ID del doctor a buscar";
            // 
            // txtEliminarIDdoctor
            // 
            this.txtEliminarIDdoctor.Location = new System.Drawing.Point(12, 326);
            this.txtEliminarIDdoctor.Name = "txtEliminarIDdoctor";
            this.txtEliminarIDdoctor.Size = new System.Drawing.Size(123, 20);
            this.txtEliminarIDdoctor.TabIndex = 39;
            // 
            // lblEliminardoctor
            // 
            this.lblEliminardoctor.AutoSize = true;
            this.lblEliminardoctor.ForeColor = System.Drawing.Color.White;
            this.lblEliminardoctor.Location = new System.Drawing.Point(9, 310);
            this.lblEliminardoctor.Name = "lblEliminardoctor";
            this.lblEliminardoctor.Size = new System.Drawing.Size(108, 13);
            this.lblEliminardoctor.TabIndex = 40;
            this.lblEliminardoctor.Text = "Eliminar doctor por ID";
            // 
            // txtid_doctor
            // 
            this.txtid_doctor.Location = new System.Drawing.Point(328, 434);
            this.txtid_doctor.Name = "txtid_doctor";
            this.txtid_doctor.Size = new System.Drawing.Size(111, 20);
            this.txtid_doctor.TabIndex = 48;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(328, 498);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(111, 20);
            this.txttelefono.TabIndex = 47;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(1032, 434);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(191, 20);
            this.txtcorreo.TabIndex = 46;
            // 
            // txtconsultorio
            // 
            this.txtconsultorio.Location = new System.Drawing.Point(915, 434);
            this.txtconsultorio.Name = "txtconsultorio";
            this.txtconsultorio.Size = new System.Drawing.Size(111, 20);
            this.txtconsultorio.TabIndex = 45;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(798, 434);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(111, 20);
            this.txtcargo.TabIndex = 44;
            // 
            // txtespecialidad
            // 
            this.txtespecialidad.Location = new System.Drawing.Point(681, 434);
            this.txtespecialidad.Name = "txtespecialidad";
            this.txtespecialidad.Size = new System.Drawing.Size(111, 20);
            this.txtespecialidad.TabIndex = 43;
            // 
            // txtfecha_nac
            // 
            this.txtfecha_nac.Location = new System.Drawing.Point(562, 434);
            this.txtfecha_nac.Name = "txtfecha_nac";
            this.txtfecha_nac.Size = new System.Drawing.Size(113, 20);
            this.txtfecha_nac.TabIndex = 42;
            // 
            // txtnombre_doctor
            // 
            this.txtnombre_doctor.Location = new System.Drawing.Point(445, 434);
            this.txtnombre_doctor.Name = "txtnombre_doctor";
            this.txtnombre_doctor.Size = new System.Drawing.Size(111, 20);
            this.txtnombre_doctor.TabIndex = 41;
            // 
            // lbliddoctor
            // 
            this.lbliddoctor.AutoSize = true;
            this.lbliddoctor.ForeColor = System.Drawing.Color.White;
            this.lbliddoctor.Location = new System.Drawing.Point(328, 415);
            this.lbliddoctor.Name = "lbliddoctor";
            this.lbliddoctor.Size = new System.Drawing.Size(51, 13);
            this.lbliddoctor.TabIndex = 49;
            this.lbliddoctor.Text = "id_doctor";
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.ForeColor = System.Drawing.Color.White;
            this.lblfechanacimiento.Location = new System.Drawing.Point(559, 418);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(91, 13);
            this.lblfechanacimiento.TabIndex = 50;
            this.lblfechanacimiento.Text = "fecha_nacimiento";
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.ForeColor = System.Drawing.Color.White;
            this.lblespecialidad.Location = new System.Drawing.Point(678, 418);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(66, 13);
            this.lblespecialidad.TabIndex = 51;
            this.lblespecialidad.Text = "especialidad";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.ForeColor = System.Drawing.Color.White;
            this.lblcargo.Location = new System.Drawing.Point(795, 418);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(34, 13);
            this.lblcargo.TabIndex = 52;
            this.lblcargo.Text = "cargo";
            // 
            // lblconsultorio
            // 
            this.lblconsultorio.AutoSize = true;
            this.lblconsultorio.ForeColor = System.Drawing.Color.White;
            this.lblconsultorio.Location = new System.Drawing.Point(912, 418);
            this.lblconsultorio.Name = "lblconsultorio";
            this.lblconsultorio.Size = new System.Drawing.Size(58, 13);
            this.lblconsultorio.TabIndex = 53;
            this.lblconsultorio.Text = "consultorio";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.ForeColor = System.Drawing.Color.White;
            this.lblcorreo.Location = new System.Drawing.Point(1029, 418);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(37, 13);
            this.lblcorreo.TabIndex = 54;
            this.lblcorreo.Text = "correo";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.ForeColor = System.Drawing.Color.White;
            this.lbltelefono.Location = new System.Drawing.Point(328, 482);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(45, 13);
            this.lbltelefono.TabIndex = 55;
            this.lbltelefono.Text = "telefono";
            // 
            // lblnombredoctor
            // 
            this.lblnombredoctor.AutoSize = true;
            this.lblnombredoctor.ForeColor = System.Drawing.Color.White;
            this.lblnombredoctor.Location = new System.Drawing.Point(442, 418);
            this.lblnombredoctor.Name = "lblnombredoctor";
            this.lblnombredoctor.Size = new System.Drawing.Size(78, 13);
            this.lblnombredoctor.TabIndex = 56;
            this.lblnombredoctor.Text = "nombre_doctor";
            // 
            // lbltitulotabla2
            // 
            this.lbltitulotabla2.AutoSize = true;
            this.lbltitulotabla2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulotabla2.ForeColor = System.Drawing.Color.White;
            this.lbltitulotabla2.Location = new System.Drawing.Point(192, 55);
            this.lbltitulotabla2.Name = "lbltitulotabla2";
            this.lbltitulotabla2.Size = new System.Drawing.Size(126, 17);
            this.lbltitulotabla2.TabIndex = 57;
            this.lbltitulotabla2.Text = "Tabla de Doctores";
            // 
            // ptbLogo1
            // 
            this.ptbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo1.Image")));
            this.ptbLogo1.Location = new System.Drawing.Point(1105, 136);
            this.ptbLogo1.Name = "ptbLogo1";
            this.ptbLogo1.Size = new System.Drawing.Size(156, 143);
            this.ptbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo1.TabIndex = 60;
            this.ptbLogo1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1296, 612);
            this.Controls.Add(this.ptbLogo1);
            this.Controls.Add(this.lbltitulotabla2);
            this.Controls.Add(this.lblnombredoctor);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lblconsultorio);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblespecialidad);
            this.Controls.Add(this.lblfechanacimiento);
            this.Controls.Add(this.lbliddoctor);
            this.Controls.Add(this.txtid_doctor);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtconsultorio);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtespecialidad);
            this.Controls.Add(this.txtfecha_nac);
            this.Controls.Add(this.txtnombre_doctor);
            this.Controls.Add(this.lblEliminardoctor);
            this.Controls.Add(this.txtEliminarIDdoctor);
            this.Controls.Add(this.lblID_doctor);
            this.Controls.Add(this.txtConsultar_doctor);
            this.Controls.Add(this.btnActualizar2);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnInsertar2);
            this.Controls.Add(this.btnConsultar2);
            this.Controls.Add(this.dtgv_Consulta2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BD ADMINISTRADOR";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Consulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Consulta2;
        private System.Windows.Forms.Button btnActualizar2;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnInsertar2;
        private System.Windows.Forms.Button btnConsultar2;
        private System.Windows.Forms.TextBox txtConsultar_doctor;
        private System.Windows.Forms.Label lblID_doctor;
        private System.Windows.Forms.TextBox txtEliminarIDdoctor;
        private System.Windows.Forms.Label lblEliminardoctor;
        private System.Windows.Forms.TextBox txtid_doctor;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtconsultorio;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.TextBox txtfecha_nac;
        private System.Windows.Forms.TextBox txtnombre_doctor;
        private System.Windows.Forms.Label lbliddoctor;
        private System.Windows.Forms.Label lblfechanacimiento;
        private System.Windows.Forms.Label lblespecialidad;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblconsultorio;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblnombredoctor;
        private System.Windows.Forms.Label lbltitulotabla2;
        private System.Windows.Forms.PictureBox ptbLogo1;
    }
}