namespace TPPAV1_Auditoria.Formularios.Prestaciones
{
    partial class Frm_ABM_Prestaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_codigoPrestacion = new System.Windows.Forms.RadioButton();
            this.cb_Edad = new System.Windows.Forms.CheckBox();
            this.mkt_codigoPrestacion = new System.Windows.Forms.MaskedTextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grid_Prestaciones = new System.Windows.Forms.DataGridView();
            this._CodPrestacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EdadMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.mkt_edad = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Prestaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.rb_codigoPrestacion);
            this.groupBox1.Controls.Add(this.cb_Edad);
            this.groupBox1.Controls.Add(this.mkt_codigoPrestacion);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.grid_Prestaciones);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mkt_edad);
            this.groupBox1.Location = new System.Drawing.Point(31, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 522);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(44, 137);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(105, 19);
            this.rb_todos.TabIndex = 20;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Busqueda Total";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // rb_codigoPrestacion
            // 
            this.rb_codigoPrestacion.AutoSize = true;
            this.rb_codigoPrestacion.Location = new System.Drawing.Point(44, 77);
            this.rb_codigoPrestacion.Name = "rb_codigoPrestacion";
            this.rb_codigoPrestacion.Size = new System.Drawing.Size(138, 19);
            this.rb_codigoPrestacion.TabIndex = 19;
            this.rb_codigoPrestacion.TabStop = true;
            this.rb_codigoPrestacion.Text = "Codigo de Prestacion";
            this.rb_codigoPrestacion.UseVisualStyleBackColor = true;
            // 
            // cb_Edad
            // 
            this.cb_Edad.AutoSize = true;
            this.cb_Edad.Location = new System.Drawing.Point(44, 179);
            this.cb_Edad.Name = "cb_Edad";
            this.cb_Edad.Size = new System.Drawing.Size(128, 19);
            this.cb_Edad.TabIndex = 15;
            this.cb_Edad.Text = "Busqueda por edad";
            this.cb_Edad.UseVisualStyleBackColor = true;
            // 
            // mkt_codigoPrestacion
            // 
            this.mkt_codigoPrestacion.Location = new System.Drawing.Point(197, 76);
            this.mkt_codigoPrestacion.Mask = "99999";
            this.mkt_codigoPrestacion.Name = "mkt_codigoPrestacion";
            this.mkt_codigoPrestacion.Size = new System.Drawing.Size(44, 23);
            this.mkt_codigoPrestacion.TabIndex = 14;
            this.mkt_codigoPrestacion.ValidatingType = typeof(int);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.Location = new System.Drawing.Point(429, 451);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(127, 35);
            this.btn_consultar.TabIndex = 12;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_transparent_logo_trademark_brand_delete_button_miscellaneous_text_trademark;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(115, 440);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(76, 60);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources._269074;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(197, 440);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(82, 60);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_clipart_plus_plus;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(24, 440);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(85, 60);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPPAV1_Auditoria.Properties.Resources.nomenclatura_dental_universal;
            this.pictureBox1.Location = new System.Drawing.Point(303, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // grid_Prestaciones
            // 
            this.grid_Prestaciones.AllowUserToAddRows = false;
            this.grid_Prestaciones.AllowUserToDeleteRows = false;
            this.grid_Prestaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Prestaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._CodPrestacion,
            this._EdadMinima,
            this._Descripcion});
            this.grid_Prestaciones.Location = new System.Drawing.Point(24, 249);
            this.grid_Prestaciones.Name = "grid_Prestaciones";
            this.grid_Prestaciones.ReadOnly = true;
            this.grid_Prestaciones.RowTemplate.Height = 25;
            this.grid_Prestaciones.Size = new System.Drawing.Size(532, 173);
            this.grid_Prestaciones.TabIndex = 6;
            // 
            // _CodPrestacion
            // 
            this._CodPrestacion.HeaderText = "Codigo de Prestacion";
            this._CodPrestacion.Name = "_CodPrestacion";
            this._CodPrestacion.ReadOnly = true;
            // 
            // _EdadMinima
            // 
            this._EdadMinima.HeaderText = "Edad Minima";
            this._EdadMinima.Name = "_EdadMinima";
            this._EdadMinima.ReadOnly = true;
            // 
            // _Descripcion
            // 
            this._Descripcion.HeaderText = "Descripcion";
            this._Descripcion.Name = "_Descripcion";
            this._Descripcion.ReadOnly = true;
            this._Descripcion.Width = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Localización de la prestación";
            // 
            // mkt_edad
            // 
            this.mkt_edad.Location = new System.Drawing.Point(197, 177);
            this.mkt_edad.Mask = "999";
            this.mkt_edad.Name = "mkt_edad";
            this.mkt_edad.Size = new System.Drawing.Size(44, 23);
            this.mkt_edad.TabIndex = 3;
            this.mkt_edad.ValidatingType = typeof(int);
            // 
            // Frm_ABM_Prestaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ABM_Prestaciones";
            this.Text = "ABM Prestaciones";
            this.Load += new System.EventHandler(this.Frm_ABM_Prestaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Prestaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private DataGridView grid_Prestaciones;
        private Label label3;
        private MaskedTextBox mkt_edad;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private Button btn_consultar;
        private MaskedTextBox mkt_codigoPrestacion;
        private CheckBox cb_Edad;
        private RadioButton rb_todos;
        private RadioButton rb_codigoPrestacion;
        private DataGridViewTextBoxColumn _CodPrestacion;
        private DataGridViewTextBoxColumn _EdadMinima;
        private DataGridViewTextBoxColumn _Descripcion;
    }
}