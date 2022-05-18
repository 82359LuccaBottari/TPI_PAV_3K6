namespace TPPAV1_Auditoria.Formularios.Expedientes
{
    partial class Frm_ABM_Expedientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Expedientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.msk_Reintegro = new System.Windows.Forms.MaskedTextBox();
            this.msk_nro_Expediente = new System.Windows.Forms.MaskedTextBox();
            this.Chk_Todos = new System.Windows.Forms.CheckBox();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.mkt_fecha_i_Expediente = new System.Windows.Forms.MaskedTextBox();
            this.rb_Reintegro = new System.Windows.Forms.RadioButton();
            this.rb_Fecha_Inicio = new System.Windows.Forms.RadioButton();
            this.rb_nro_Expediente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_Expediente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Expediente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.msk_Reintegro);
            this.groupBox1.Controls.Add(this.msk_nro_Expediente);
            this.groupBox1.Controls.Add(this.Chk_Todos);
            this.groupBox1.Controls.Add(this.Btn_Consultar);
            this.groupBox1.Controls.Add(this.mkt_fecha_i_Expediente);
            this.groupBox1.Controls.Add(this.rb_Reintegro);
            this.groupBox1.Controls.Add(this.rb_Fecha_Inicio);
            this.groupBox1.Controls.Add(this.rb_nro_Expediente);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.btn_Modificar);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Grid_Expediente);
            this.groupBox1.Location = new System.Drawing.Point(44, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 352);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restciicones de calculo";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(542, 75);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(64, 23);
            this.btn_limpiar.TabIndex = 68;
            this.btn_limpiar.Text = "limpiar ";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // msk_Reintegro
            // 
            this.msk_Reintegro.Location = new System.Drawing.Point(443, 100);
            this.msk_Reintegro.Mask = "99999";
            this.msk_Reintegro.Name = "msk_Reintegro";
            this.msk_Reintegro.Size = new System.Drawing.Size(93, 23);
            this.msk_Reintegro.TabIndex = 67;
            this.msk_Reintegro.ValidatingType = typeof(int);
            // 
            // msk_nro_Expediente
            // 
            this.msk_nro_Expediente.Location = new System.Drawing.Point(194, 98);
            this.msk_nro_Expediente.Mask = "99999";
            this.msk_nro_Expediente.Name = "msk_nro_Expediente";
            this.msk_nro_Expediente.Size = new System.Drawing.Size(100, 23);
            this.msk_nro_Expediente.TabIndex = 66;
            this.msk_nro_Expediente.ValidatingType = typeof(int);
            // 
            // Chk_Todos
            // 
            this.Chk_Todos.AutoSize = true;
            this.Chk_Todos.Location = new System.Drawing.Point(549, 103);
            this.Chk_Todos.Name = "Chk_Todos";
            this.Chk_Todos.Size = new System.Drawing.Size(57, 19);
            this.Chk_Todos.TabIndex = 63;
            this.Chk_Todos.Text = "Todos";
            this.Chk_Todos.UseVisualStyleBackColor = true;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(9, 100);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(179, 23);
            this.Btn_Consultar.TabIndex = 62;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // mkt_fecha_i_Expediente
            // 
            this.mkt_fecha_i_Expediente.Location = new System.Drawing.Point(300, 100);
            this.mkt_fecha_i_Expediente.Mask = "00/00/0000";
            this.mkt_fecha_i_Expediente.Name = "mkt_fecha_i_Expediente";
            this.mkt_fecha_i_Expediente.Size = new System.Drawing.Size(137, 23);
            this.mkt_fecha_i_Expediente.TabIndex = 59;
            this.mkt_fecha_i_Expediente.ValidatingType = typeof(System.DateTime);
            // 
            // rb_Reintegro
            // 
            this.rb_Reintegro.AutoSize = true;
            this.rb_Reintegro.Location = new System.Drawing.Point(460, 73);
            this.rb_Reintegro.Name = "rb_Reintegro";
            this.rb_Reintegro.Size = new System.Drawing.Size(76, 19);
            this.rb_Reintegro.TabIndex = 58;
            this.rb_Reintegro.TabStop = true;
            this.rb_Reintegro.Text = "Reintegro";
            this.rb_Reintegro.UseVisualStyleBackColor = true;
            // 
            // rb_Fecha_Inicio
            // 
            this.rb_Fecha_Inicio.AutoSize = true;
            this.rb_Fecha_Inicio.Location = new System.Drawing.Point(337, 73);
            this.rb_Fecha_Inicio.Name = "rb_Fecha_Inicio";
            this.rb_Fecha_Inicio.Size = new System.Drawing.Size(107, 19);
            this.rb_Fecha_Inicio.TabIndex = 57;
            this.rb_Fecha_Inicio.TabStop = true;
            this.rb_Fecha_Inicio.Text = "Fecha de inicio ";
            this.rb_Fecha_Inicio.UseVisualStyleBackColor = true;
            // 
            // rb_nro_Expediente
            // 
            this.rb_nro_Expediente.AutoSize = true;
            this.rb_nro_Expediente.Location = new System.Drawing.Point(185, 73);
            this.rb_nro_Expediente.Name = "rb_nro_Expediente";
            this.rb_nro_Expediente.Size = new System.Drawing.Size(146, 19);
            this.rb_nro_Expediente.TabIndex = 56;
            this.rb_nro_Expediente.TabStop = true;
            this.rb_nro_Expediente.Text = "Numero de expediente";
            this.rb_nro_Expediente.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 168);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_clipart_plus_plus;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(5, 303);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(46, 44);
            this.btn_agregar.TabIndex = 47;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources._269074;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Modificar.Location = new System.Drawing.Point(74, 302);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(46, 44);
            this.btn_Modificar.TabIndex = 49;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.png_transparent_logo_trademark_brand_delete_button_miscellaneous_text_trademark;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Location = new System.Drawing.Point(144, 302);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(44, 44);
            this.btn_Eliminar.TabIndex = 50;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 53;
            this.label1.Text = "Expediente";
            // 
            // Grid_Expediente
            // 
            this.Grid_Expediente.AllowUserToAddRows = false;
            this.Grid_Expediente.AllowUserToDeleteRows = false;
            this.Grid_Expediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Expediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Grid_Expediente.Location = new System.Drawing.Point(194, 130);
            this.Grid_Expediente.Name = "Grid_Expediente";
            this.Grid_Expediente.ReadOnly = true;
            this.Grid_Expediente.RowTemplate.Height = 25;
            this.Grid_Expediente.Size = new System.Drawing.Size(342, 216);
            this.Grid_Expediente.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nro DeExpediente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha de inicio ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Reintegro";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Frm_ABM_Expedientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ABM_Expedientes";
            this.Text = "Frm_ABM_Expedientes";
            this.Load += new System.EventHandler(this.Frm_ABM_Expedientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Expediente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox Chk_Todos;
        private Button Btn_Consultar;
        private MaskedTextBox mkt_fecha_i_Expediente;
        private RadioButton rb_Reintegro;
        private RadioButton rb_Fecha_Inicio;
        private RadioButton rb_nro_Expediente;
        private PictureBox pictureBox1;
        private Button btn_agregar;
        private Button btn_Modificar;
        private Button btn_Eliminar;
        private Label label1;
        private DataGridView Grid_Expediente;
        private TextBox txt_nro_Expediente;
        private TextBox txt__Reintegro;
        private MaskedTextBox msk_nro_Expediente;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private MaskedTextBox msk_Reintegro;
        private Button btn_limpiar;
    }
}