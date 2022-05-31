namespace TPPAV1_Auditoria.Estadística.DocumentoXPrestaciones
{
    partial class Frm_ESTAD_DocXPrest
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
            this.cb_codPrestacion = new WinFormsApp1.Clases.ComboBox01();
            this.cb_codDocumento = new WinFormsApp1.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Todos = new System.Windows.Forms.CheckBox();
            this.grid_Prestaciones = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this._Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._codPrestacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Prestaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_codPrestacion
            // 
            this.cb_codPrestacion.FormattingEnabled = true;
            this.cb_codPrestacion.Location = new System.Drawing.Point(251, 58);
            this.cb_codPrestacion.Name = "cb_codPrestacion";
            this.cb_codPrestacion.Pp_descripcion = "_Descripcion";
            this.cb_codPrestacion.Pp_Pk = "_CodPrestacion";
            this.cb_codPrestacion.Pp_tabla = "Prestaciones";
            this.cb_codPrestacion.Size = new System.Drawing.Size(217, 23);
            this.cb_codPrestacion.TabIndex = 0;
            // 
            // cb_codDocumento
            // 
            this.cb_codDocumento.FormattingEnabled = true;
            this.cb_codDocumento.Location = new System.Drawing.Point(251, 113);
            this.cb_codDocumento.Name = "cb_codDocumento";
            this.cb_codDocumento.Pp_descripcion = "Nombre";
            this.cb_codDocumento.Pp_Pk = "CodDocumentos";
            this.cb_codDocumento.Pp_tabla = "Documentos";
            this.cb_codDocumento.Size = new System.Drawing.Size(217, 23);
            this.cb_codDocumento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de Prestacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo de Documento";
            // 
            // cb_Todos
            // 
            this.cb_Todos.AutoSize = true;
            this.cb_Todos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Todos.Location = new System.Drawing.Point(48, 217);
            this.cb_Todos.Name = "cb_Todos";
            this.cb_Todos.Size = new System.Drawing.Size(69, 25);
            this.cb_Todos.TabIndex = 4;
            this.cb_Todos.Text = "Todos";
            this.cb_Todos.UseVisualStyleBackColor = true;
            // 
            // grid_Prestaciones
            // 
            this.grid_Prestaciones.AllowUserToAddRows = false;
            this.grid_Prestaciones.AllowUserToDeleteRows = false;
            this.grid_Prestaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Prestaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._Id,
            this._codPrestacion,
            this._documento});
            this.grid_Prestaciones.Location = new System.Drawing.Point(48, 272);
            this.grid_Prestaciones.Name = "grid_Prestaciones";
            this.grid_Prestaciones.ReadOnly = true;
            this.grid_Prestaciones.RowTemplate.Height = 25;
            this.grid_Prestaciones.Size = new System.Drawing.Size(420, 173);
            this.grid_Prestaciones.TabIndex = 5;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.Location = new System.Drawing.Point(375, 466);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(93, 34);
            this.btn_consultar.TabIndex = 6;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_clipart_plus_plus;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(48, 466);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(45, 34);
            this.btn_agregar.TabIndex = 7;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources._269074;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(99, 466);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(45, 34);
            this.btn_modificar.TabIndex = 8;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_transparent_logo_trademark_brand_delete_button_miscellaneous_text_trademark;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(150, 466);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(45, 34);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // _Id
            // 
            this._Id.HeaderText = "Id";
            this._Id.Name = "_Id";
            this._Id.ReadOnly = true;
            this._Id.Width = 50;
            // 
            // _codPrestacion
            // 
            this._codPrestacion.HeaderText = "Prestacion";
            this._codPrestacion.Name = "_codPrestacion";
            this._codPrestacion.ReadOnly = true;
            this._codPrestacion.Width = 150;
            // 
            // _documento
            // 
            this._documento.HeaderText = "Documento";
            this._documento.Name = "_documento";
            this._documento.ReadOnly = true;
            this._documento.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numero de Identificacion";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(251, 164);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(217, 23);
            this.txt_id.TabIndex = 11;
            // 
            // Frm_ESTAD_DocXPrest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 534);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.grid_Prestaciones);
            this.Controls.Add(this.cb_Todos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_codDocumento);
            this.Controls.Add(this.cb_codPrestacion);
            this.Name = "Frm_ESTAD_DocXPrest";
            this.Text = "Frm_ESTAD_DocXPrest";
            this.Load += new System.EventHandler(this.Frm_ESTAD_DocXPrest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Prestaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsApp1.Clases.ComboBox01 cb_codPrestacion;
        private WinFormsApp1.Clases.ComboBox01 cb_codDocumento;
        private Label label1;
        private Label label2;
        private CheckBox cb_Todos;
        private DataGridView grid_Prestaciones;
        private Button btn_consultar;
        private Button btn_agregar;
        private Button btn_modificar;
        private Button btn_eliminar;
        private DataGridViewTextBoxColumn _Id;
        private DataGridViewTextBoxColumn _codPrestacion;
        private DataGridViewTextBoxColumn _documento;
        private Label label3;
        private TextBox txt_id;
    }
}