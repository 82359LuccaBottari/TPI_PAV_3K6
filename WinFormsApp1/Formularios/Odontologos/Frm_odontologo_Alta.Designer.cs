namespace TPPAV1_Auditoria.Formularios.Odontologos
{
    partial class Frm_odontologo_Alta
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
            this.txt_Nombre = new TPPAV1_Auditoria.Clases.textBox01();
            this.txt_Apellido = new TPPAV1_Auditoria.Clases.textBox01();
            this.txt_Matricula = new TPPAV1_Auditoria.Clases.textBox01();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odontologo Nuevo";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(120, 138);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_combo = null;
            this.txt_Nombre.Pp_MensajeError = "No ingreso un nombre";
            this.txt_Nombre.Pp_tabla = null;
            this.txt_Nombre.Pp_validable = true;
            this.txt_Nombre.Size = new System.Drawing.Size(310, 31);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(120, 201);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Pp_combo = null;
            this.txt_Apellido.Pp_MensajeError = "No ingreso el appellido";
            this.txt_Apellido.Pp_tabla = null;
            this.txt_Apellido.Pp_validable = true;
            this.txt_Apellido.Size = new System.Drawing.Size(310, 31);
            this.txt_Apellido.TabIndex = 1;
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(120, 272);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Pp_combo = null;
            this.txt_Matricula.Pp_MensajeError = "No ingreso la matricula o hay un una existente";
            this.txt_Matricula.Pp_tabla = null;
            this.txt_Matricula.Pp_validable = true;
            this.txt_Matricula.Size = new System.Drawing.Size(310, 31);
            this.txt_Matricula.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricula";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(120, 348);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(112, 34);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(261, 348);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Frm_odontologo_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 414);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_odontologo_Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Clases.textBox01 txt_Nombre;
        private Clases.textBox01 txt_Apellido;
        private Clases.textBox01 txt_Matricula;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
    }
}