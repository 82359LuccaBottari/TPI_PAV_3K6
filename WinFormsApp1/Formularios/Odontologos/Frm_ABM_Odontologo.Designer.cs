namespace TPPAV1_Auditoria.Formularios.Odontologos
{
    partial class Frm_ABM_Odontologo
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
            this.Btn_consulta = new System.Windows.Forms.Button();
            this.txt_Matriculas = new System.Windows.Forms.TextBox();
            this.txt_apellido_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Chk_todos = new System.Windows.Forms.CheckBox();
            this.Chk_Apellido = new System.Windows.Forms.CheckBox();
            this.Chk_Nombre = new System.Windows.Forms.CheckBox();
            this.grid_Odontologos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Odontologos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros";
            // 
            // Btn_consulta
            // 
            this.Btn_consulta.Location = new System.Drawing.Point(672, 190);
            this.Btn_consulta.Name = "Btn_consulta";
            this.Btn_consulta.Size = new System.Drawing.Size(112, 34);
            this.Btn_consulta.TabIndex = 5;
            this.Btn_consulta.Text = "Consulta";
            this.Btn_consulta.UseVisualStyleBackColor = true;
            this.Btn_consulta.Click += new System.EventHandler(this.Btn_consulta_Click);
            // 
            // txt_Matriculas
            // 
            this.txt_Matriculas.Location = new System.Drawing.Point(235, 142);
            this.txt_Matriculas.Name = "txt_Matriculas";
            this.txt_Matriculas.Size = new System.Drawing.Size(150, 31);
            this.txt_Matriculas.TabIndex = 3;
            // 
            // txt_apellido_nombre
            // 
            this.txt_apellido_nombre.Location = new System.Drawing.Point(234, 89);
            this.txt_apellido_nombre.Name = "txt_apellido_nombre";
            this.txt_apellido_nombre.Size = new System.Drawing.Size(150, 31);
            this.txt_apellido_nombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido/Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matricula";
            // 
            // Chk_todos
            // 
            this.Chk_todos.AutoSize = true;
            this.Chk_todos.Location = new System.Drawing.Point(237, 190);
            this.Chk_todos.Name = "Chk_todos";
            this.Chk_todos.Size = new System.Drawing.Size(86, 29);
            this.Chk_todos.TabIndex = 4;
            this.Chk_todos.Text = "Todos";
            this.Chk_todos.UseVisualStyleBackColor = true;
            // 
            // Chk_Apellido
            // 
            this.Chk_Apellido.AutoSize = true;
            this.Chk_Apellido.Location = new System.Drawing.Point(417, 95);
            this.Chk_Apellido.Name = "Chk_Apellido";
            this.Chk_Apellido.Size = new System.Drawing.Size(104, 29);
            this.Chk_Apellido.TabIndex = 1;
            this.Chk_Apellido.Text = "Apellido";
            this.Chk_Apellido.UseVisualStyleBackColor = true;
            // 
            // Chk_Nombre
            // 
            this.Chk_Nombre.AutoSize = true;
            this.Chk_Nombre.Location = new System.Drawing.Point(527, 95);
            this.Chk_Nombre.Name = "Chk_Nombre";
            this.Chk_Nombre.Size = new System.Drawing.Size(104, 29);
            this.Chk_Nombre.TabIndex = 2;
            this.Chk_Nombre.Text = "Nombre";
            this.Chk_Nombre.UseVisualStyleBackColor = true;
            // 
            // grid_Odontologos
            // 
            this.grid_Odontologos.AllowUserToAddRows = false;
            this.grid_Odontologos.AllowUserToDeleteRows = false;
            this.grid_Odontologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Odontologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grid_Odontologos.Location = new System.Drawing.Point(77, 242);
            this.grid_Odontologos.Name = "grid_Odontologos";
            this.grid_Odontologos.ReadOnly = true;
            this.grid_Odontologos.RowHeadersWidth = 62;
            this.grid_Odontologos.RowTemplate.Height = 33;
            this.grid_Odontologos.Size = new System.Drawing.Size(785, 292);
            this.grid_Odontologos.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matricula";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(95, 563);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(50, 36);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(178, 563);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(50, 36);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(264, 563);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(50, 36);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(813, 563);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(100, 50);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Frm_ABM_Odontologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(951, 636);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.grid_Odontologos);
            this.Controls.Add(this.Chk_Nombre);
            this.Controls.Add(this.Chk_Apellido);
            this.Controls.Add(this.Chk_todos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_apellido_nombre);
            this.Controls.Add(this.txt_Matriculas);
            this.Controls.Add(this.Btn_consulta);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ABM_Odontologo";
            this.Text = "ABM Odontologos";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.grid_Odontologos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Btn_consulta;
        private TextBox txt_Matriculas;
        private TextBox txt_apellido_nombre;
        private Label label2;
        private Label label3;
        private CheckBox Chk_todos;
        private CheckBox Chk_Apellido;
        private CheckBox Chk_Nombre;
        private DataGridView grid_Odontologos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btn_agregar;
        private Button btn_Modificar;
        private Button btn_Eliminar;
        private Button btn_Salir;
    }
}