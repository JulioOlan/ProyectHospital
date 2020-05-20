namespace ProyectoHospital
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dtgv_Consulta3 = new System.Windows.Forms.DataGridView();
            this.btnActualizar3 = new System.Windows.Forms.Button();
            this.btnEliminar3 = new System.Windows.Forms.Button();
            this.btnInsertar3 = new System.Windows.Forms.Button();
            this.btnConsultar3 = new System.Windows.Forms.Button();
            this.txtEliminarIDinventario = new System.Windows.Forms.TextBox();
            this.txtConsultar_inventario = new System.Windows.Forms.TextBox();
            this.txtid_medicamento = new System.Windows.Forms.TextBox();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.txtunidad_medida = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.txtclasificacion = new System.Windows.Forms.TextBox();
            this.txtnombre_medicamento = new System.Windows.Forms.TextBox();
            this.lblnombre_medicamento = new System.Windows.Forms.Label();
            this.lblestatusinventario = new System.Windows.Forms.Label();
            this.lblunidad = new System.Windows.Forms.Label();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.lblclasificacion = new System.Windows.Forms.Label();
            this.lblidmedicamento = new System.Windows.Forms.Label();
            this.lblEliminarmedicamento = new System.Windows.Forms.Label();
            this.lblID_medicamento = new System.Windows.Forms.Label();
            this.lbltitulotabla3 = new System.Windows.Forms.Label();
            this.ptbLogo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Consulta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Consulta3
            // 
            this.dtgv_Consulta3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_Consulta3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Consulta3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgv_Consulta3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Consulta3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_Consulta3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Consulta3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Consulta3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Consulta3.EnableHeadersVisualStyles = false;
            this.dtgv_Consulta3.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgv_Consulta3.Location = new System.Drawing.Point(165, 45);
            this.dtgv_Consulta3.Name = "dtgv_Consulta3";
            this.dtgv_Consulta3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Consulta3.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_Consulta3.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_Consulta3.Size = new System.Drawing.Size(823, 299);
            this.dtgv_Consulta3.TabIndex = 4;
            // 
            // btnActualizar3
            // 
            this.btnActualizar3.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnActualizar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar3.Location = new System.Drawing.Point(317, 469);
            this.btnActualizar3.Name = "btnActualizar3";
            this.btnActualizar3.Size = new System.Drawing.Size(111, 47);
            this.btnActualizar3.TabIndex = 40;
            this.btnActualizar3.Text = "Actualizar";
            this.btnActualizar3.UseVisualStyleBackColor = false;
            this.btnActualizar3.Click += new System.EventHandler(this.btnActualizar3_Click);
            // 
            // btnEliminar3
            // 
            this.btnEliminar3.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnEliminar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar3.Location = new System.Drawing.Point(12, 456);
            this.btnEliminar3.Name = "btnEliminar3";
            this.btnEliminar3.Size = new System.Drawing.Size(111, 47);
            this.btnEliminar3.TabIndex = 39;
            this.btnEliminar3.Text = "Eliminar";
            this.btnEliminar3.UseVisualStyleBackColor = false;
            this.btnEliminar3.Click += new System.EventHandler(this.btnEliminar3_Click);
            // 
            // btnInsertar3
            // 
            this.btnInsertar3.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnInsertar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar3.Location = new System.Drawing.Point(317, 375);
            this.btnInsertar3.Name = "btnInsertar3";
            this.btnInsertar3.Size = new System.Drawing.Size(111, 47);
            this.btnInsertar3.TabIndex = 38;
            this.btnInsertar3.Text = "Insertar";
            this.btnInsertar3.UseVisualStyleBackColor = false;
            this.btnInsertar3.Click += new System.EventHandler(this.btnInsertar3_Click);
            // 
            // btnConsultar3
            // 
            this.btnConsultar3.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnConsultar3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnConsultar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar3.Location = new System.Drawing.Point(11, 349);
            this.btnConsultar3.Name = "btnConsultar3";
            this.btnConsultar3.Size = new System.Drawing.Size(111, 47);
            this.btnConsultar3.TabIndex = 37;
            this.btnConsultar3.Text = "Consultar";
            this.btnConsultar3.UseVisualStyleBackColor = false;
            this.btnConsultar3.Click += new System.EventHandler(this.btnConsultar3_Click);
            // 
            // txtEliminarIDinventario
            // 
            this.txtEliminarIDinventario.Location = new System.Drawing.Point(138, 509);
            this.txtEliminarIDinventario.Name = "txtEliminarIDinventario";
            this.txtEliminarIDinventario.Size = new System.Drawing.Size(123, 20);
            this.txtEliminarIDinventario.TabIndex = 42;
            // 
            // txtConsultar_inventario
            // 
            this.txtConsultar_inventario.Location = new System.Drawing.Point(138, 402);
            this.txtConsultar_inventario.Name = "txtConsultar_inventario";
            this.txtConsultar_inventario.Size = new System.Drawing.Size(123, 20);
            this.txtConsultar_inventario.TabIndex = 41;
            // 
            // txtid_medicamento
            // 
            this.txtid_medicamento.Location = new System.Drawing.Point(452, 402);
            this.txtid_medicamento.Name = "txtid_medicamento";
            this.txtid_medicamento.Size = new System.Drawing.Size(111, 20);
            this.txtid_medicamento.TabIndex = 54;
            // 
            // txtestatus
            // 
            this.txtestatus.Location = new System.Drawing.Point(686, 496);
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.Size = new System.Drawing.Size(113, 20);
            this.txtestatus.TabIndex = 53;
            // 
            // txtunidad_medida
            // 
            this.txtunidad_medida.Location = new System.Drawing.Point(569, 496);
            this.txtunidad_medida.Name = "txtunidad_medida";
            this.txtunidad_medida.Size = new System.Drawing.Size(111, 20);
            this.txtunidad_medida.TabIndex = 52;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(452, 496);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(111, 20);
            this.txtexistencia.TabIndex = 51;
            // 
            // txtclasificacion
            // 
            this.txtclasificacion.Location = new System.Drawing.Point(686, 402);
            this.txtclasificacion.Name = "txtclasificacion";
            this.txtclasificacion.Size = new System.Drawing.Size(113, 20);
            this.txtclasificacion.TabIndex = 50;
            // 
            // txtnombre_medicamento
            // 
            this.txtnombre_medicamento.Location = new System.Drawing.Point(569, 402);
            this.txtnombre_medicamento.Name = "txtnombre_medicamento";
            this.txtnombre_medicamento.Size = new System.Drawing.Size(111, 20);
            this.txtnombre_medicamento.TabIndex = 49;
            // 
            // lblnombre_medicamento
            // 
            this.lblnombre_medicamento.AutoSize = true;
            this.lblnombre_medicamento.ForeColor = System.Drawing.Color.White;
            this.lblnombre_medicamento.Location = new System.Drawing.Point(566, 386);
            this.lblnombre_medicamento.Name = "lblnombre_medicamento";
            this.lblnombre_medicamento.Size = new System.Drawing.Size(111, 13);
            this.lblnombre_medicamento.TabIndex = 62;
            this.lblnombre_medicamento.Text = "nombre_medicamento";
            // 
            // lblestatusinventario
            // 
            this.lblestatusinventario.AutoSize = true;
            this.lblestatusinventario.ForeColor = System.Drawing.Color.White;
            this.lblestatusinventario.Location = new System.Drawing.Point(683, 480);
            this.lblestatusinventario.Name = "lblestatusinventario";
            this.lblestatusinventario.Size = new System.Drawing.Size(41, 13);
            this.lblestatusinventario.TabIndex = 61;
            this.lblestatusinventario.Text = "estatus";
            // 
            // lblunidad
            // 
            this.lblunidad.AutoSize = true;
            this.lblunidad.ForeColor = System.Drawing.Color.White;
            this.lblunidad.Location = new System.Drawing.Point(566, 480);
            this.lblunidad.Name = "lblunidad";
            this.lblunidad.Size = new System.Drawing.Size(79, 13);
            this.lblunidad.TabIndex = 60;
            this.lblunidad.Text = "unidad_medida";
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.ForeColor = System.Drawing.Color.White;
            this.lblexistencia.Location = new System.Drawing.Point(452, 480);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(54, 13);
            this.lblexistencia.TabIndex = 59;
            this.lblexistencia.Text = "existencia";
            // 
            // lblclasificacion
            // 
            this.lblclasificacion.AutoSize = true;
            this.lblclasificacion.ForeColor = System.Drawing.Color.White;
            this.lblclasificacion.Location = new System.Drawing.Point(683, 386);
            this.lblclasificacion.Name = "lblclasificacion";
            this.lblclasificacion.Size = new System.Drawing.Size(65, 13);
            this.lblclasificacion.TabIndex = 58;
            this.lblclasificacion.Text = "clasificacion";
            // 
            // lblidmedicamento
            // 
            this.lblidmedicamento.AutoSize = true;
            this.lblidmedicamento.ForeColor = System.Drawing.Color.White;
            this.lblidmedicamento.Location = new System.Drawing.Point(452, 386);
            this.lblidmedicamento.Name = "lblidmedicamento";
            this.lblidmedicamento.Size = new System.Drawing.Size(84, 13);
            this.lblidmedicamento.TabIndex = 57;
            this.lblidmedicamento.Text = "id_medicamento";
            // 
            // lblEliminarmedicamento
            // 
            this.lblEliminarmedicamento.AutoSize = true;
            this.lblEliminarmedicamento.ForeColor = System.Drawing.Color.White;
            this.lblEliminarmedicamento.Location = new System.Drawing.Point(129, 493);
            this.lblEliminarmedicamento.Name = "lblEliminarmedicamento";
            this.lblEliminarmedicamento.Size = new System.Drawing.Size(141, 13);
            this.lblEliminarmedicamento.TabIndex = 64;
            this.lblEliminarmedicamento.Text = "Eliminar medicamento por ID";
            // 
            // lblID_medicamento
            // 
            this.lblID_medicamento.AutoSize = true;
            this.lblID_medicamento.ForeColor = System.Drawing.Color.White;
            this.lblID_medicamento.Location = new System.Drawing.Point(128, 386);
            this.lblID_medicamento.Name = "lblID_medicamento";
            this.lblID_medicamento.Size = new System.Drawing.Size(145, 13);
            this.lblID_medicamento.TabIndex = 63;
            this.lblID_medicamento.Text = "ID del medicamento a buscar";
            // 
            // lbltitulotabla3
            // 
            this.lbltitulotabla3.AutoSize = true;
            this.lbltitulotabla3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulotabla3.ForeColor = System.Drawing.Color.White;
            this.lbltitulotabla3.Location = new System.Drawing.Point(162, 25);
            this.lbltitulotabla3.Name = "lbltitulotabla3";
            this.lbltitulotabla3.Size = new System.Drawing.Size(254, 17);
            this.lbltitulotabla3.TabIndex = 66;
            this.lbltitulotabla3.Text = "Tabla de Inventario de Medicamentos";
            // 
            // ptbLogo1
            // 
            this.ptbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo1.Image")));
            this.ptbLogo1.Location = new System.Drawing.Point(1029, 127);
            this.ptbLogo1.Name = "ptbLogo1";
            this.ptbLogo1.Size = new System.Drawing.Size(156, 143);
            this.ptbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo1.TabIndex = 67;
            this.ptbLogo1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1296, 612);
            this.Controls.Add(this.ptbLogo1);
            this.Controls.Add(this.lbltitulotabla3);
            this.Controls.Add(this.lblEliminarmedicamento);
            this.Controls.Add(this.lblID_medicamento);
            this.Controls.Add(this.lblnombre_medicamento);
            this.Controls.Add(this.lblestatusinventario);
            this.Controls.Add(this.lblunidad);
            this.Controls.Add(this.lblexistencia);
            this.Controls.Add(this.lblclasificacion);
            this.Controls.Add(this.lblidmedicamento);
            this.Controls.Add(this.txtid_medicamento);
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.txtunidad_medida);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtclasificacion);
            this.Controls.Add(this.txtnombre_medicamento);
            this.Controls.Add(this.txtEliminarIDinventario);
            this.Controls.Add(this.txtConsultar_inventario);
            this.Controls.Add(this.btnActualizar3);
            this.Controls.Add(this.btnEliminar3);
            this.Controls.Add(this.btnInsertar3);
            this.Controls.Add(this.btnConsultar3);
            this.Controls.Add(this.dtgv_Consulta3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BD ADMINISTRADOR";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Consulta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Consulta3;
        private System.Windows.Forms.Button btnActualizar3;
        private System.Windows.Forms.Button btnEliminar3;
        private System.Windows.Forms.Button btnInsertar3;
        private System.Windows.Forms.Button btnConsultar3;
        private System.Windows.Forms.TextBox txtEliminarIDinventario;
        private System.Windows.Forms.TextBox txtConsultar_inventario;
        private System.Windows.Forms.TextBox txtid_medicamento;
        private System.Windows.Forms.TextBox txtestatus;
        private System.Windows.Forms.TextBox txtunidad_medida;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.TextBox txtclasificacion;
        private System.Windows.Forms.TextBox txtnombre_medicamento;
        private System.Windows.Forms.Label lblnombre_medicamento;
        private System.Windows.Forms.Label lblestatusinventario;
        private System.Windows.Forms.Label lblunidad;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Label lblclasificacion;
        private System.Windows.Forms.Label lblidmedicamento;
        private System.Windows.Forms.Label lblEliminarmedicamento;
        private System.Windows.Forms.Label lblID_medicamento;
        private System.Windows.Forms.Label lbltitulotabla3;
        private System.Windows.Forms.PictureBox ptbLogo1;
    }
}