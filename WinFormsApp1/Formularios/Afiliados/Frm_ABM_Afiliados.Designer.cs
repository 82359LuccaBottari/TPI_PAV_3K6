namespace TPPAV1_Auditoria.Formularios.Afiliados
{
    partial class Frm_ABM_Afiliados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Afiliados));
            this.txt_nro_afiliado = new System.Windows.Forms.TextBox();
            this.gb_ConsultaAfiliados = new System.Windows.Forms.GroupBox();
            this.cmb_categorias = new WinFormsApp1.Clases.ComboBox01();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.grid_afiliados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_consulta_afiliados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.lb_nro_afiliado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gb_ConsultaAfiliados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_afiliados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nro_afiliado
            // 
            this.txt_nro_afiliado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nro_afiliado.Location = new System.Drawing.Point(116, 68);
            this.txt_nro_afiliado.Name = "txt_nro_afiliado";
            this.txt_nro_afiliado.Size = new System.Drawing.Size(123, 27);
            this.txt_nro_afiliado.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_nro_afiliado, "Ingresar número de afiliado\r\nque desea buscar\r\n");
            // 
            // gb_ConsultaAfiliados
            // 
            this.gb_ConsultaAfiliados.Controls.Add(this.cmb_categorias);
            this.gb_ConsultaAfiliados.Controls.Add(this.btn_eliminar);
            this.gb_ConsultaAfiliados.Controls.Add(this.btn_modificar);
            this.gb_ConsultaAfiliados.Controls.Add(this.btn_agregar);
            this.gb_ConsultaAfiliados.Controls.Add(this.chk_todos);
            this.gb_ConsultaAfiliados.Controls.Add(this.grid_afiliados);
            this.gb_ConsultaAfiliados.Controls.Add(this.btn_consulta_afiliados);
            this.gb_ConsultaAfiliados.Controls.Add(this.button1);
            this.gb_ConsultaAfiliados.Controls.Add(this.lb_categoria);
            this.gb_ConsultaAfiliados.Controls.Add(this.lb_nro_afiliado);
            this.gb_ConsultaAfiliados.Controls.Add(this.txt_nro_afiliado);
            this.gb_ConsultaAfiliados.Controls.Add(this.pictureBox1);
            this.gb_ConsultaAfiliados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_ConsultaAfiliados.Location = new System.Drawing.Point(12, 12);
            this.gb_ConsultaAfiliados.Name = "gb_ConsultaAfiliados";
            this.gb_ConsultaAfiliados.Size = new System.Drawing.Size(569, 498);
            this.gb_ConsultaAfiliados.TabIndex = 2;
            this.gb_ConsultaAfiliados.TabStop = false;
            this.gb_ConsultaAfiliados.Text = "Consulta Afiliados";
            // 
            // cmb_categorias
            // 
            this.cmb_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categorias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_categorias.FormattingEnabled = true;
            this.cmb_categorias.Location = new System.Drawing.Point(116, 115);
            this.cmb_categorias.Name = "cmb_categorias";
            this.cmb_categorias.Pp_descripcion = "Descripcion";
            this.cmb_categorias.Pp_Pk = "CodCategoria";
            this.cmb_categorias.Pp_tabla = "Categorias";
            this.cmb_categorias.Size = new System.Drawing.Size(123, 28);
            this.cmb_categorias.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmb_categorias, "Ingresar el tipo de categoría \r\nque desea buscar");
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_transparent_logo_trademark_brand_delete_button_miscellaneous_text_trademark;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(108, 430);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(76, 60);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources._269074;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(190, 430);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(82, 60);
            this.btn_modificar.TabIndex = 7;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_clipart_plus_plus;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(17, 430);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(85, 60);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_todos.Location = new System.Drawing.Point(116, 162);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(68, 24);
            this.chk_todos.TabIndex = 3;
            this.chk_todos.Text = "Todos";
            this.toolTip1.SetToolTip(this.chk_todos, "Tildar para buscar todos los afiliados");
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // grid_afiliados
            // 
            this.grid_afiliados.AllowUserToAddRows = false;
            this.grid_afiliados.AllowUserToDeleteRows = false;
            this.grid_afiliados.BackgroundColor = System.Drawing.Color.Lavender;
            this.grid_afiliados.ColumnHeadersHeight = 30;
            this.grid_afiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_afiliados.GridColor = System.Drawing.Color.Lavender;
            this.grid_afiliados.Location = new System.Drawing.Point(17, 192);
            this.grid_afiliados.Name = "grid_afiliados";
            this.grid_afiliados.ReadOnly = true;
            this.grid_afiliados.RowTemplate.Height = 25;
            this.grid_afiliados.Size = new System.Drawing.Size(532, 232);
            this.grid_afiliados.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Número Afiliado";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Código Categoria";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // btn_consulta_afiliados
            // 
            this.btn_consulta_afiliados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consulta_afiliados.Location = new System.Drawing.Point(460, 114);
            this.btn_consulta_afiliados.Name = "btn_consulta_afiliados";
            this.btn_consulta_afiliados.Size = new System.Drawing.Size(89, 28);
            this.btn_consulta_afiliados.TabIndex = 4;
            this.btn_consulta_afiliados.Text = "Consulta";
            this.toolTip1.SetToolTip(this.btn_consulta_afiliados, "Oprimir para recuperar los \r\ndatos deseados en la grilla");
            this.btn_consulta_afiliados.UseVisualStyleBackColor = true;
            this.btn_consulta_afiliados.Click += new System.EventHandler(this.btn_consulta_afiliados_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources._3_puntos;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(256, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 28);
            this.button1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button1, "Oprimir para quitar la\r\nseleción de categorías");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_categoria.Location = new System.Drawing.Point(36, 118);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(74, 20);
            this.lb_categoria.TabIndex = 3;
            this.lb_categoria.Text = "Categoría";
            // 
            // lb_nro_afiliado
            // 
            this.lb_nro_afiliado.AutoSize = true;
            this.lb_nro_afiliado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nro_afiliado.Location = new System.Drawing.Point(17, 71);
            this.lb_nro_afiliado.Name = "lb_nro_afiliado";
            this.lb_nro_afiliado.Size = new System.Drawing.Size(93, 20);
            this.lb_nro_afiliado.TabIndex = 2;
            this.lb_nro_afiliado.Text = "Nro_Afiliado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.descarga_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(281, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 182);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            // 
            // Frm_ABM_Afiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 516);
            this.Controls.Add(this.gb_ConsultaAfiliados);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_ABM_Afiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afiliados";
            this.Load += new System.EventHandler(this.Frm_ABM_Afiliados_Load);
            this.gb_ConsultaAfiliados.ResumeLayout(false);
            this.gb_ConsultaAfiliados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_afiliados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_nro_afiliado;
        private GroupBox gb_ConsultaAfiliados;
        private Label lb_categoria;
        private Label lb_nro_afiliado;
        private Button button1;
        private DataGridView grid_afiliados;
        private CheckBox chk_todos;
        private PictureBox pictureBox1;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private WinFormsApp1.Clases.ComboBox01 cmb_categorias;
        private Button btn_consulta_afiliados;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}