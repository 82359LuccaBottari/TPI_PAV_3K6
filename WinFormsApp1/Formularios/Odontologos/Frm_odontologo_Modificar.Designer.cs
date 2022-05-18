namespace TPPAV1_Auditoria.Formularios.Odontologos
{
    partial class Frm_odontologo_Modificar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_gestionar_modificacion = new System.Windows.Forms.Button();
            this.txt_Matricula = new TPPAV1_Auditoria.Clases.textBox01();
            this.txt_Apellido = new TPPAV1_Auditoria.Clases.textBox01();
            this.txt_Nombre = new TPPAV1_Auditoria.Clases.textBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancelar);
            this.groupBox1.Controls.Add(this.btn_gestionar_modificacion);
            this.groupBox1.Controls.Add(this.txt_Matricula);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(312, 185);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_gestionar_modificacion
            // 
            this.btn_gestionar_modificacion.Location = new System.Drawing.Point(450, 159);
            this.btn_gestionar_modificacion.Name = "btn_gestionar_modificacion";
            this.btn_gestionar_modificacion.Size = new System.Drawing.Size(141, 60);
            this.btn_gestionar_modificacion.TabIndex = 6;
            this.btn_gestionar_modificacion.Text = "Gestionar Modificación";
            this.btn_gestionar_modificacion.UseVisualStyleBackColor = true;
            this.btn_gestionar_modificacion.Click += new System.EventHandler(this.btn_gestionar_modificacion_Click);
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(114, 159);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Pp_combo = null;
            this.txt_Matricula.Pp_MensajeError = null;
            this.txt_Matricula.Pp_tabla = null;
            this.txt_Matricula.Pp_validable = false;
            this.txt_Matricula.Size = new System.Drawing.Size(150, 31);
            this.txt_Matricula.TabIndex = 5;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(114, 113);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Pp_combo = null;
            this.txt_Apellido.Pp_MensajeError = null;
            this.txt_Apellido.Pp_tabla = null;
            this.txt_Apellido.Pp_validable = false;
            this.txt_Apellido.Size = new System.Drawing.Size(150, 31);
            this.txt_Apellido.TabIndex = 4;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(114, 58);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_combo = null;
            this.txt_Nombre.Pp_MensajeError = null;
            this.txt_Nombre.Pp_tabla = null;
            this.txt_Nombre.Pp_validable = false;
            this.txt_Nombre.Size = new System.Drawing.Size(150, 31);
            this.txt_Nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Frm_odontologo_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 295);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_odontologo_Modificar";
            this.Text = "Frm_odontologo_Modificar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_gestionar_modificacion;
        private Clases.textBox01 txt_Matricula;
        private Clases.textBox01 txt_Apellido;
        private Clases.textBox01 txt_Nombre;
        private Button btn_Cancelar;
    }
}