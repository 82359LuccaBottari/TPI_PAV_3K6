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
            this.rb_todos = new System.Windows.Forms.CheckBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.mkt_edad = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb_todos);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mkt_codigoPrestacion);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.grid_Prestaciones);
            this.groupBox1.Controls.Add(this.mkt_edad);
            this.groupBox1.Location = new System.Drawing.Point(31, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 651);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_todos.Location = new System.Drawing.Point(44, 155);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(130, 24);
            this.rb_todos.TabIndex = 23;
            this.rb_todos.Text = "Busqueda Total";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(44, 244);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(537, 123);
            this.txt_Descripcion.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripcion";
            // 
            // mkt_codigoPrestacion
            // 
            this.mkt_codigoPrestacion.Location = new System.Drawing.Point(255, 57);
            this.mkt_codigoPrestacion.Mask = "99999";
            this.mkt_codigoPrestacion.Name = "mkt_codigoPrestacion";
            this.mkt_codigoPrestacion.Size = new System.Drawing.Size(44, 23);
            this.mkt_codigoPrestacion.TabIndex = 14;
            this.mkt_codigoPrestacion.ValidatingType = typeof(int);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.Location = new System.Drawing.Point(429, 610);
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
            this.btn_eliminar.Location = new System.Drawing.Point(135, 585);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(76, 60);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources._269074;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(217, 585);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(82, 60);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_clipart_plus_plus;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(44, 585);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(85, 60);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPPAV1_Auditoria.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(328, 22);
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
            this.grid_Prestaciones.Location = new System.Drawing.Point(44, 391);
            this.grid_Prestaciones.Name = "grid_Prestaciones";
            this.grid_Prestaciones.ReadOnly = true;
            this.grid_Prestaciones.RowTemplate.Height = 25;
            this.grid_Prestaciones.Size = new System.Drawing.Size(537, 173);
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
            // mkt_edad
            // 
            this.mkt_edad.Location = new System.Drawing.Point(255, 105);
            this.mkt_edad.Mask = "999";
            this.mkt_edad.Name = "mkt_edad";
            this.mkt_edad.Size = new System.Drawing.Size(44, 23);
            this.mkt_edad.TabIndex = 3;
            this.mkt_edad.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Codigo de Prestacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Edad Minima";
            // 
            // Frm_ABM_Prestaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 721);
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
        private MaskedTextBox mkt_edad;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private Button btn_consultar;
        private MaskedTextBox mkt_codigoPrestacion;
        private DataGridViewTextBoxColumn _CodPrestacion;
        private DataGridViewTextBoxColumn _EdadMinima;
        private DataGridViewTextBoxColumn _Descripcion;
        private TextBox txt_Descripcion;
        private Label label2;
        private CheckBox rb_todos;
        private Label label5;
        private Label label4;
    }
}