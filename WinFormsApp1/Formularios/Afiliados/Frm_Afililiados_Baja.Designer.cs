namespace TPPAV1_Auditoria.Formularios.Afiliados
{
    partial class Frm_Afililiados_Baja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Afililiados_Baja));
            this.gb_AltaAfiliados = new System.Windows.Forms.GroupBox();
            this.btn_gestionar_baja = new System.Windows.Forms.Button();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_tipo_documento = new WinFormsApp1.Clases.ComboBox01();
            this.txt_nro_documento = new System.Windows.Forms.MaskedTextBox();
            this.txt_nro_afiliado = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_NroAfiliado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_AltaAfiliados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_AltaAfiliados
            // 
            this.gb_AltaAfiliados.Controls.Add(this.btn_gestionar_baja);
            this.gb_AltaAfiliados.Controls.Add(this.txt_apellido);
            this.gb_AltaAfiliados.Controls.Add(this.txt_nombre);
            this.gb_AltaAfiliados.Controls.Add(this.cmb_tipo_documento);
            this.gb_AltaAfiliados.Controls.Add(this.txt_nro_documento);
            this.gb_AltaAfiliados.Controls.Add(this.txt_nro_afiliado);
            this.gb_AltaAfiliados.Controls.Add(this.label4);
            this.gb_AltaAfiliados.Controls.Add(this.label6);
            this.gb_AltaAfiliados.Controls.Add(this.label5);
            this.gb_AltaAfiliados.Controls.Add(this.lb_Nombre);
            this.gb_AltaAfiliados.Controls.Add(this.lb_NroAfiliado);
            this.gb_AltaAfiliados.Controls.Add(this.pictureBox1);
            this.gb_AltaAfiliados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_AltaAfiliados.Location = new System.Drawing.Point(13, 11);
            this.gb_AltaAfiliados.Name = "gb_AltaAfiliados";
            this.gb_AltaAfiliados.Size = new System.Drawing.Size(578, 310);
            this.gb_AltaAfiliados.TabIndex = 5;
            this.gb_AltaAfiliados.TabStop = false;
            this.gb_AltaAfiliados.Text = "Baja de Afiliado";
            // 
            // btn_gestionar_baja
            // 
            this.btn_gestionar_baja.Location = new System.Drawing.Point(458, 234);
            this.btn_gestionar_baja.Name = "btn_gestionar_baja";
            this.btn_gestionar_baja.Size = new System.Drawing.Size(105, 58);
            this.btn_gestionar_baja.TabIndex = 8;
            this.btn_gestionar_baja.Text = "Gestionar \r\nBaja";
            this.btn_gestionar_baja.UseVisualStyleBackColor = true;
            this.btn_gestionar_baja.Click += new System.EventHandler(this.btn_gestionar_baja_Click);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(106, 117);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(123, 27);
            this.txt_apellido.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(106, 83);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(123, 27);
            this.txt_nombre.TabIndex = 2;
            // 
            // cmb_tipo_documento
            // 
            this.cmb_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_documento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_tipo_documento.FormattingEnabled = true;
            this.cmb_tipo_documento.Location = new System.Drawing.Point(106, 151);
            this.cmb_tipo_documento.Name = "cmb_tipo_documento";
            this.cmb_tipo_documento.Pp_descripcion = "Descripcion";
            this.cmb_tipo_documento.Pp_Pk = "CodTipo";
            this.cmb_tipo_documento.Pp_tabla = "TipoDocumentos";
            this.cmb_tipo_documento.Size = new System.Drawing.Size(123, 28);
            this.cmb_tipo_documento.TabIndex = 4;
            this.cmb_tipo_documento.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_documento_SelectedIndexChanged);
            // 
            // txt_nro_documento
            // 
            this.txt_nro_documento.Location = new System.Drawing.Point(106, 184);
            this.txt_nro_documento.Mask = "999999999999999";
            this.txt_nro_documento.Name = "txt_nro_documento";
            this.txt_nro_documento.Size = new System.Drawing.Size(123, 27);
            this.txt_nro_documento.TabIndex = 5;
            // 
            // txt_nro_afiliado
            // 
            this.txt_nro_afiliado.Location = new System.Drawing.Point(106, 50);
            this.txt_nro_afiliado.Mask = "99999";
            this.txt_nro_afiliado.Name = "txt_nro_afiliado";
            this.txt_nro_afiliado.Size = new System.Drawing.Size(50, 27);
            this.txt_nro_afiliado.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Doc.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nro. Doc.:";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(31, 86);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(67, 20);
            this.lb_Nombre.TabIndex = 8;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // lb_NroAfiliado
            // 
            this.lb_NroAfiliado.AutoSize = true;
            this.lb_NroAfiliado.Location = new System.Drawing.Point(6, 53);
            this.lb_NroAfiliado.Name = "lb_NroAfiliado";
            this.lb_NroAfiliado.Size = new System.Drawing.Size(94, 20);
            this.lb_NroAfiliado.TabIndex = 8;
            this.lb_NroAfiliado.Text = "Nro Afiliado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.descarga_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(281, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 182);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Afililiados_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 333);
            this.Controls.Add(this.gb_AltaAfiliados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Afililiados_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Afiliados";
            this.Load += new System.EventHandler(this.Frm_Afililiados_Baja_Load);
            this.gb_AltaAfiliados.ResumeLayout(false);
            this.gb_AltaAfiliados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_AltaAfiliados;
        private Button btn_gestionar_baja;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private WinFormsApp1.Clases.ComboBox01 cmb_tipo_documento;
        private MaskedTextBox txt_nro_documento;
        private MaskedTextBox txt_nro_afiliado;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label lb_Nombre;
        private Label lb_NroAfiliado;
        private PictureBox pictureBox1;
    }
}