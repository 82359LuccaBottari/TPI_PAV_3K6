namespace TPPAV1_Auditoria.Formularios.Odontologos
{
    partial class Frm_Odontologo_Baja
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
            this.txt_Matricula = new TPPAV1_Auditoria.Clases.textBox01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_baja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(120, 51);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Pp_combo = null;
            this.txt_Matricula.Pp_MensajeError = null;
            this.txt_Matricula.Pp_tabla = null;
            this.txt_Matricula.Pp_validable = false;
            this.txt_Matricula.Size = new System.Drawing.Size(150, 31);
            this.txt_Matricula.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_baja);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Matricula);
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TPPAV1_Auditoria.Properties.Resources.descarga;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(383, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 107);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(55, 115);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(134, 44);
            this.btn_baja.TabIndex = 2;
            this.btn_baja.Text = "Realizar baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // Frm_Odontologo_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 238);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Odontologo_Baja";
            this.Text = "Baja Odontologo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Clases.textBox01 txt_Matricula;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btn_baja;
    }
}