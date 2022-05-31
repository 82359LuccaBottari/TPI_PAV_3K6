namespace TPPAV1_Auditoria.Estadística.PrestacionesXElemento
{
    partial class Frm_ESTAD_PrestXElem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Todos = new System.Windows.Forms.CheckBox();
            this.grid_Prestaciones = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Prestacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Elemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DiasGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brn_consultar = new System.Windows.Forms.Button();
            this.brn_agregar = new System.Windows.Forms.Button();
            this.brn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cb_prestacion = new WinFormsApp1.Clases.ComboBox01();
            this.cb_elemento = new WinFormsApp1.Clases.ComboBox01();
            this.cb_diasgarantia = new WinFormsApp1.Clases.ComboBox01();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Prestaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(294, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elemento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias de Garantia";
            // 
            // cb_Todos
            // 
            this.cb_Todos.AutoSize = true;
            this.cb_Todos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Todos.Location = new System.Drawing.Point(41, 180);
            this.cb_Todos.Name = "cb_Todos";
            this.cb_Todos.Size = new System.Drawing.Size(68, 24);
            this.cb_Todos.TabIndex = 6;
            this.cb_Todos.Text = "Todos";
            this.cb_Todos.UseVisualStyleBackColor = true;
            // 
            // grid_Prestaciones
            // 
            this.grid_Prestaciones.AllowUserToAddRows = false;
            this.grid_Prestaciones.AllowUserToDeleteRows = false;
            this.grid_Prestaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Prestaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this._Prestacion,
            this._Elemento,
            this._DiasGarantia});
            this.grid_Prestaciones.Location = new System.Drawing.Point(32, 235);
            this.grid_Prestaciones.Name = "grid_Prestaciones";
            this.grid_Prestaciones.ReadOnly = true;
            this.grid_Prestaciones.RowTemplate.Height = 25;
            this.grid_Prestaciones.Size = new System.Drawing.Size(495, 188);
            this.grid_Prestaciones.TabIndex = 7;
            // 
            // _id
            // 
            this._id.HeaderText = "Id";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Width = 50;
            // 
            // _Prestacion
            // 
            this._Prestacion.HeaderText = "Prestacion";
            this._Prestacion.Name = "_Prestacion";
            this._Prestacion.ReadOnly = true;
            this._Prestacion.Width = 150;
            // 
            // _Elemento
            // 
            this._Elemento.HeaderText = "Elemento";
            this._Elemento.Name = "_Elemento";
            this._Elemento.ReadOnly = true;
            this._Elemento.Width = 150;
            // 
            // _DiasGarantia
            // 
            this._DiasGarantia.HeaderText = "Dias de Garantia";
            this._DiasGarantia.Name = "_DiasGarantia";
            this._DiasGarantia.ReadOnly = true;
            // 
            // brn_consultar
            // 
            this.brn_consultar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brn_consultar.Location = new System.Drawing.Point(443, 458);
            this.brn_consultar.Name = "brn_consultar";
            this.brn_consultar.Size = new System.Drawing.Size(84, 42);
            this.brn_consultar.TabIndex = 8;
            this.brn_consultar.Text = "Consultar";
            this.brn_consultar.UseVisualStyleBackColor = true;
            this.brn_consultar.Click += new System.EventHandler(this.brn_consultar_Click);
            // 
            // brn_agregar
            // 
            this.brn_agregar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_clipart_plus_plus;
            this.brn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brn_agregar.Location = new System.Drawing.Point(32, 450);
            this.brn_agregar.Name = "brn_agregar";
            this.brn_agregar.Size = new System.Drawing.Size(64, 50);
            this.brn_agregar.TabIndex = 9;
            this.brn_agregar.UseVisualStyleBackColor = true;
            this.brn_agregar.Click += new System.EventHandler(this.brn_agregar_Click);
            // 
            // brn_eliminar
            // 
            this.brn_eliminar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_transparent_logo_trademark_brand_delete_button_miscellaneous_text_trademark;
            this.brn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brn_eliminar.Location = new System.Drawing.Point(172, 450);
            this.brn_eliminar.Name = "brn_eliminar";
            this.brn_eliminar.Size = new System.Drawing.Size(64, 50);
            this.brn_eliminar.TabIndex = 10;
            this.brn_eliminar.UseVisualStyleBackColor = true;
            this.brn_eliminar.Click += new System.EventHandler(this.brn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources._269074;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(102, 450);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(64, 50);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(294, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Identificacion";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(399, 131);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(73, 23);
            this.txt_id.TabIndex = 13;
            // 
            // cb_prestacion
            // 
            this.cb_prestacion.FormattingEnabled = true;
            this.cb_prestacion.Location = new System.Drawing.Point(32, 63);
            this.cb_prestacion.Name = "cb_prestacion";
            this.cb_prestacion.Pp_descripcion = "_Descripcion";
            this.cb_prestacion.Pp_Pk = "_CodPrestacion";
            this.cb_prestacion.Pp_tabla = "Prestaciones";
            this.cb_prestacion.Size = new System.Drawing.Size(191, 23);
            this.cb_prestacion.TabIndex = 14;
            this.cb_prestacion.SelectedIndexChanged += new System.EventHandler(this.cb_prestacion_SelectedIndexChanged_1);
            // 
            // cb_elemento
            // 
            this.cb_elemento.FormattingEnabled = true;
            this.cb_elemento.Location = new System.Drawing.Point(294, 63);
            this.cb_elemento.Name = "cb_elemento";
            this.cb_elemento.Pp_descripcion = "Nombre";
            this.cb_elemento.Pp_Pk = "[Nro Elemento]";
            this.cb_elemento.Pp_tabla = "Elemento";
            this.cb_elemento.Size = new System.Drawing.Size(178, 23);
            this.cb_elemento.TabIndex = 15;
            // 
            // cb_diasgarantia
            // 
            this.cb_diasgarantia.FormattingEnabled = true;
            this.cb_diasgarantia.Location = new System.Drawing.Point(157, 122);
            this.cb_diasgarantia.Name = "cb_diasgarantia";
            this.cb_diasgarantia.Pp_descripcion = null;
            this.cb_diasgarantia.Pp_Pk = null;
            this.cb_diasgarantia.Pp_tabla = null;
            this.cb_diasgarantia.Size = new System.Drawing.Size(66, 23);
            this.cb_diasgarantia.TabIndex = 16;
            // 
            // Frm_ESTAD_PrestXElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 518);
            this.Controls.Add(this.cb_diasgarantia);
            this.Controls.Add(this.cb_elemento);
            this.Controls.Add(this.cb_prestacion);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.brn_eliminar);
            this.Controls.Add(this.brn_agregar);
            this.Controls.Add(this.brn_consultar);
            this.Controls.Add(this.grid_Prestaciones);
            this.Controls.Add(this.cb_Todos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ESTAD_PrestXElem";
            this.Text = "Frm_ESTAD_PrestXElem";
            this.Load += new System.EventHandler(this.Frm_ESTAD_PrestXElem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Prestaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cb_Todos;
        private DataGridView grid_Prestaciones;
        private Button brn_consultar;
        private Button brn_agregar;
        private Button brn_eliminar;
        private Button btn_modificar;
        private DataGridViewTextBoxColumn _id;
        private DataGridViewTextBoxColumn _Prestacion;
        private DataGridViewTextBoxColumn _Elemento;
        private DataGridViewTextBoxColumn _DiasGarantia;
        private Label label4;
        private TextBox txt_id;
        private WinFormsApp1.Clases.ComboBox01 cb_prestacion;
        private WinFormsApp1.Clases.ComboBox01 cb_elemento;
        private WinFormsApp1.Clases.ComboBox01 cb_diasgarantia;
    }
}