namespace TPPAV1_Auditoria.Formularios.Atenciones
{
    partial class Frm_ABM_Atenciones
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.mkt_numeroAfiliado = new System.Windows.Forms.MaskedTextBox();
            this.mkt_codigoCategoria = new System.Windows.Forms.MaskedTextBox();
            this.mkt_fechaAtencion = new System.Windows.Forms.MaskedTextBox();
            this.grid_Atenciones = new System.Windows.Forms.DataGridView();
            this.cb_codigoPrestacion = new WinFormsApp1.Clases.ComboBox01();
            this.cb_numeroElemento = new WinFormsApp1.Clases.ComboBox01();
            this.cb_codigoTipo = new WinFormsApp1.Clases.ComboBox01();
            this.cb_matricula = new WinFormsApp1.Clases.ComboBox01();
            this.cb_numeroExped = new WinFormsApp1.Clases.ComboBox01();
            this.mkt_id = new System.Windows.Forms.MaskedTextBox();
            this.rb_nroAfiliado = new System.Windows.Forms.RadioButton();
            this.rb_codigoCategoria = new System.Windows.Forms.RadioButton();
            this.rb_codigoPrestacion = new System.Windows.Forms.RadioButton();
            this.rb_nroElemento = new System.Windows.Forms.RadioButton();
            this.rb_fechaAtención = new System.Windows.Forms.RadioButton();
            this.rb_matricula = new System.Windows.Forms.RadioButton();
            this.rb_codigoDocumento = new System.Windows.Forms.RadioButton();
            this.rb_numeroExpediente = new System.Windows.Forms.RadioButton();
            this.cb_id = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPrestacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroElemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Atenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atenciones";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_clipart_plus_plus;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(12, 587);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 50);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_transparent_logo_trademark_brand_delete_button_miscellaneous_text_trademark;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(93, 587);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 50);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources._269074;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(174, 587);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 50);
            this.btn_modificar.TabIndex = 4;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.Location = new System.Drawing.Point(553, 600);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(109, 37);
            this.btn_consultar.TabIndex = 5;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // mkt_numeroAfiliado
            // 
            this.mkt_numeroAfiliado.Location = new System.Drawing.Point(174, 72);
            this.mkt_numeroAfiliado.Mask = "99999";
            this.mkt_numeroAfiliado.Name = "mkt_numeroAfiliado";
            this.mkt_numeroAfiliado.Size = new System.Drawing.Size(121, 23);
            this.mkt_numeroAfiliado.TabIndex = 6;
            this.mkt_numeroAfiliado.ValidatingType = typeof(int);
            // 
            // mkt_codigoCategoria
            // 
            this.mkt_codigoCategoria.Location = new System.Drawing.Point(174, 115);
            this.mkt_codigoCategoria.Mask = "99999";
            this.mkt_codigoCategoria.Name = "mkt_codigoCategoria";
            this.mkt_codigoCategoria.Size = new System.Drawing.Size(121, 23);
            this.mkt_codigoCategoria.TabIndex = 7;
            this.mkt_codigoCategoria.ValidatingType = typeof(int);
            // 
            // mkt_fechaAtencion
            // 
            this.mkt_fechaAtencion.Location = new System.Drawing.Point(174, 207);
            this.mkt_fechaAtencion.Mask = "00/00/0000";
            this.mkt_fechaAtencion.Name = "mkt_fechaAtencion";
            this.mkt_fechaAtencion.Size = new System.Drawing.Size(121, 23);
            this.mkt_fechaAtencion.TabIndex = 17;
            this.mkt_fechaAtencion.ValidatingType = typeof(System.DateTime);
            // 
            // grid_Atenciones
            // 
            this.grid_Atenciones.AllowUserToAddRows = false;
            this.grid_Atenciones.AllowUserToDeleteRows = false;
            this.grid_Atenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Atenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this.NroAfiliado,
            this.CodigoCategoria,
            this.CodigoPrestacion,
            this.FechaAtencion,
            this.NumeroElemento,
            this.CodigoDocumento,
            this.Matricula,
            this.NumeroExpediente});
            this.grid_Atenciones.Location = new System.Drawing.Point(12, 305);
            this.grid_Atenciones.Name = "grid_Atenciones";
            this.grid_Atenciones.ReadOnly = true;
            this.grid_Atenciones.RowTemplate.Height = 25;
            this.grid_Atenciones.Size = new System.Drawing.Size(650, 264);
            this.grid_Atenciones.TabIndex = 21;
            // 
            // cb_codigoPrestacion
            // 
            this.cb_codigoPrestacion.FormattingEnabled = true;
            this.cb_codigoPrestacion.Location = new System.Drawing.Point(174, 162);
            this.cb_codigoPrestacion.Name = "cb_codigoPrestacion";
            this.cb_codigoPrestacion.Pp_descripcion = "_Descripcion";
            this.cb_codigoPrestacion.Pp_Pk = "_CodPrestacion";
            this.cb_codigoPrestacion.Pp_tabla = "Prestaciones";
            this.cb_codigoPrestacion.Size = new System.Drawing.Size(121, 23);
            this.cb_codigoPrestacion.TabIndex = 38;
            // 
            // cb_numeroElemento
            // 
            this.cb_numeroElemento.FormattingEnabled = true;
            this.cb_numeroElemento.Location = new System.Drawing.Point(535, 68);
            this.cb_numeroElemento.Name = "cb_numeroElemento";
            this.cb_numeroElemento.Pp_descripcion = "Nombre";
            this.cb_numeroElemento.Pp_Pk = "NroElemento";
            this.cb_numeroElemento.Pp_tabla = "Elementos";
            this.cb_numeroElemento.Size = new System.Drawing.Size(118, 23);
            this.cb_numeroElemento.TabIndex = 39;
            // 
            // cb_codigoTipo
            // 
            this.cb_codigoTipo.FormattingEnabled = true;
            this.cb_codigoTipo.Location = new System.Drawing.Point(535, 113);
            this.cb_codigoTipo.Name = "cb_codigoTipo";
            this.cb_codigoTipo.Pp_descripcion = "Descripcion";
            this.cb_codigoTipo.Pp_Pk = "CodTipo";
            this.cb_codigoTipo.Pp_tabla = "TipoDocumentos";
            this.cb_codigoTipo.Size = new System.Drawing.Size(118, 23);
            this.cb_codigoTipo.TabIndex = 40;
            // 
            // cb_matricula
            // 
            this.cb_matricula.FormattingEnabled = true;
            this.cb_matricula.Location = new System.Drawing.Point(535, 160);
            this.cb_matricula.Name = "cb_matricula";
            this.cb_matricula.Pp_descripcion = "Nombre, Apellido";
            this.cb_matricula.Pp_Pk = "Matricula";
            this.cb_matricula.Pp_tabla = "Odontologos";
            this.cb_matricula.Size = new System.Drawing.Size(118, 23);
            this.cb_matricula.TabIndex = 41;
            // 
            // cb_numeroExped
            // 
            this.cb_numeroExped.FormattingEnabled = true;
            this.cb_numeroExped.Location = new System.Drawing.Point(535, 207);
            this.cb_numeroExped.Name = "cb_numeroExped";
            this.cb_numeroExped.Pp_descripcion = "FechaInicio";
            this.cb_numeroExped.Pp_Pk = "NroExpe";
            this.cb_numeroExped.Pp_tabla = "Expedientes";
            this.cb_numeroExped.Size = new System.Drawing.Size(118, 23);
            this.cb_numeroExped.TabIndex = 42;
            // 
            // mkt_id
            // 
            this.mkt_id.Location = new System.Drawing.Point(174, 247);
            this.mkt_id.Mask = "99999";
            this.mkt_id.Name = "mkt_id";
            this.mkt_id.Size = new System.Drawing.Size(35, 23);
            this.mkt_id.TabIndex = 44;
            this.mkt_id.ValidatingType = typeof(int);
            // 
            // rb_nroAfiliado
            // 
            this.rb_nroAfiliado.AutoSize = true;
            this.rb_nroAfiliado.Location = new System.Drawing.Point(12, 69);
            this.rb_nroAfiliado.Name = "rb_nroAfiliado";
            this.rb_nroAfiliado.Size = new System.Drawing.Size(113, 19);
            this.rb_nroAfiliado.TabIndex = 45;
            this.rb_nroAfiliado.TabStop = true;
            this.rb_nroAfiliado.Text = "Numero Afiliado";
            this.rb_nroAfiliado.UseVisualStyleBackColor = true;
            // 
            // rb_codigoCategoria
            // 
            this.rb_codigoCategoria.AutoSize = true;
            this.rb_codigoCategoria.Location = new System.Drawing.Point(12, 119);
            this.rb_codigoCategoria.Name = "rb_codigoCategoria";
            this.rb_codigoCategoria.Size = new System.Drawing.Size(134, 19);
            this.rb_codigoCategoria.TabIndex = 46;
            this.rb_codigoCategoria.TabStop = true;
            this.rb_codigoCategoria.Text = "Codigo de Categoria";
            this.rb_codigoCategoria.UseVisualStyleBackColor = true;
            // 
            // rb_codigoPrestacion
            // 
            this.rb_codigoPrestacion.AutoSize = true;
            this.rb_codigoPrestacion.Location = new System.Drawing.Point(12, 166);
            this.rb_codigoPrestacion.Name = "rb_codigoPrestacion";
            this.rb_codigoPrestacion.Size = new System.Drawing.Size(138, 19);
            this.rb_codigoPrestacion.TabIndex = 47;
            this.rb_codigoPrestacion.TabStop = true;
            this.rb_codigoPrestacion.Text = "Codigo de Prestacion";
            this.rb_codigoPrestacion.UseVisualStyleBackColor = true;
            // 
            // rb_nroElemento
            // 
            this.rb_nroElemento.AutoSize = true;
            this.rb_nroElemento.Location = new System.Drawing.Point(357, 72);
            this.rb_nroElemento.Name = "rb_nroElemento";
            this.rb_nroElemento.Size = new System.Drawing.Size(138, 19);
            this.rb_nroElemento.TabIndex = 48;
            this.rb_nroElemento.TabStop = true;
            this.rb_nroElemento.Text = "Numero de Elemento";
            this.rb_nroElemento.UseVisualStyleBackColor = true;
            // 
            // rb_fechaAtención
            // 
            this.rb_fechaAtención.AutoSize = true;
            this.rb_fechaAtención.Location = new System.Drawing.Point(12, 211);
            this.rb_fechaAtención.Name = "rb_fechaAtención";
            this.rb_fechaAtención.Size = new System.Drawing.Size(123, 19);
            this.rb_fechaAtención.TabIndex = 49;
            this.rb_fechaAtención.TabStop = true;
            this.rb_fechaAtención.Text = "Fecha de Atencion";
            this.rb_fechaAtención.UseVisualStyleBackColor = true;
            // 
            // rb_matricula
            // 
            this.rb_matricula.AutoSize = true;
            this.rb_matricula.Location = new System.Drawing.Point(357, 166);
            this.rb_matricula.Name = "rb_matricula";
            this.rb_matricula.Size = new System.Drawing.Size(75, 19);
            this.rb_matricula.TabIndex = 50;
            this.rb_matricula.TabStop = true;
            this.rb_matricula.Text = "Matricula";
            this.rb_matricula.UseVisualStyleBackColor = true;
            // 
            // rb_codigoDocumento
            // 
            this.rb_codigoDocumento.AutoSize = true;
            this.rb_codigoDocumento.Location = new System.Drawing.Point(357, 119);
            this.rb_codigoDocumento.Name = "rb_codigoDocumento";
            this.rb_codigoDocumento.Size = new System.Drawing.Size(146, 19);
            this.rb_codigoDocumento.TabIndex = 51;
            this.rb_codigoDocumento.TabStop = true;
            this.rb_codigoDocumento.Text = "Codigo de Documento";
            this.rb_codigoDocumento.UseVisualStyleBackColor = true;
            // 
            // rb_numeroExpediente
            // 
            this.rb_numeroExpediente.AutoSize = true;
            this.rb_numeroExpediente.Location = new System.Drawing.Point(357, 211);
            this.rb_numeroExpediente.Name = "rb_numeroExpediente";
            this.rb_numeroExpediente.Size = new System.Drawing.Size(146, 19);
            this.rb_numeroExpediente.TabIndex = 52;
            this.rb_numeroExpediente.TabStop = true;
            this.rb_numeroExpediente.Text = "Numero de Expediente";
            this.rb_numeroExpediente.UseVisualStyleBackColor = true;
            // 
            // cb_id
            // 
            this.cb_id.AutoSize = true;
            this.cb_id.Location = new System.Drawing.Point(12, 251);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(35, 19);
            this.cb_id.TabIndex = 53;
            this.cb_id.TabStop = true;
            this.cb_id.Text = "Id";
            this.cb_id.UseVisualStyleBackColor = true;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(357, 251);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(62, 19);
            this.rb_todos.TabIndex = 54;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "TODOS";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(580, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 37);
            this.button1.TabIndex = 55;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _id
            // 
            this._id.HeaderText = "Id";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            // 
            // NroAfiliado
            // 
            this.NroAfiliado.HeaderText = "Numero de Afiliado";
            this.NroAfiliado.Name = "NroAfiliado";
            this.NroAfiliado.ReadOnly = true;
            // 
            // CodigoCategoria
            // 
            this.CodigoCategoria.HeaderText = "Codigo de Categoria";
            this.CodigoCategoria.Name = "CodigoCategoria";
            this.CodigoCategoria.ReadOnly = true;
            // 
            // CodigoPrestacion
            // 
            this.CodigoPrestacion.HeaderText = "Codigo de Prestación";
            this.CodigoPrestacion.Name = "CodigoPrestacion";
            this.CodigoPrestacion.ReadOnly = true;
            // 
            // FechaAtencion
            // 
            this.FechaAtencion.HeaderText = "Fecha de Atención";
            this.FechaAtencion.Name = "FechaAtencion";
            this.FechaAtencion.ReadOnly = true;
            // 
            // NumeroElemento
            // 
            this.NumeroElemento.HeaderText = "Número de Elemento";
            this.NumeroElemento.Name = "NumeroElemento";
            this.NumeroElemento.ReadOnly = true;
            // 
            // CodigoDocumento
            // 
            this.CodigoDocumento.HeaderText = "Codigo de Documento";
            this.CodigoDocumento.Name = "CodigoDocumento";
            this.CodigoDocumento.ReadOnly = true;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // NumeroExpediente
            // 
            this.NumeroExpediente.HeaderText = "Número de Expediente";
            this.NumeroExpediente.Name = "NumeroExpediente";
            this.NumeroExpediente.ReadOnly = true;
            // 
            // Frm_ABM_Atenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.cb_id);
            this.Controls.Add(this.rb_numeroExpediente);
            this.Controls.Add(this.rb_codigoDocumento);
            this.Controls.Add(this.rb_matricula);
            this.Controls.Add(this.rb_fechaAtención);
            this.Controls.Add(this.rb_nroElemento);
            this.Controls.Add(this.rb_codigoPrestacion);
            this.Controls.Add(this.rb_codigoCategoria);
            this.Controls.Add(this.rb_nroAfiliado);
            this.Controls.Add(this.mkt_id);
            this.Controls.Add(this.cb_numeroExped);
            this.Controls.Add(this.cb_matricula);
            this.Controls.Add(this.cb_codigoTipo);
            this.Controls.Add(this.cb_numeroElemento);
            this.Controls.Add(this.cb_codigoPrestacion);
            this.Controls.Add(this.grid_Atenciones);
            this.Controls.Add(this.mkt_fechaAtencion);
            this.Controls.Add(this.mkt_codigoCategoria);
            this.Controls.Add(this.mkt_numeroAfiliado);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ABM_Atenciones";
            this.Text = "ABM Atenciones";
            this.Load += new System.EventHandler(this.Frm_ABM_Atenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Atenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_agregar;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_consultar;
        private MaskedTextBox mkt_numeroAfiliado;
        private MaskedTextBox mkt_codigoCategoria;
        private MaskedTextBox mkt_fechaAtencion;
        private DataGridView grid_Atenciones;
        private WinFormsApp1.Clases.ComboBox01 cb_codigoPrestacion;
        private WinFormsApp1.Clases.ComboBox01 cb_numeroElemento;
        private WinFormsApp1.Clases.ComboBox01 cb_codigoTipo;
        private WinFormsApp1.Clases.ComboBox01 cb_matricula;
        private WinFormsApp1.Clases.ComboBox01 cb_numeroExped;
        private MaskedTextBox mkt_id;
        private RadioButton rb_nroAfiliado;
        private RadioButton rb_codigoCategoria;
        private RadioButton rb_codigoPrestacion;
        private RadioButton rb_nroElemento;
        private RadioButton rb_fechaAtención;
        private RadioButton rb_matricula;
        private RadioButton rb_codigoDocumento;
        private RadioButton rb_numeroExpediente;
        private RadioButton cb_id;
        private RadioButton rb_todos;
        private Button button1;
        private DataGridViewTextBoxColumn _id;
        private DataGridViewTextBoxColumn NroAfiliado;
        private DataGridViewTextBoxColumn CodigoCategoria;
        private DataGridViewTextBoxColumn CodigoPrestacion;
        private DataGridViewTextBoxColumn FechaAtencion;
        private DataGridViewTextBoxColumn NumeroElemento;
        private DataGridViewTextBoxColumn CodigoDocumento;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn NumeroExpediente;
    }
}