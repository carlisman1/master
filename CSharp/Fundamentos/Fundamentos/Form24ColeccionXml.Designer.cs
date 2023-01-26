namespace Fundamentos
{
    partial class Form24ColeccionXml
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAños = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Años:";
            // 
            // txtAños
            // 
            this.txtAños.Location = new System.Drawing.Point(12, 164);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(100, 23);
            this.txtAños.TabIndex = 22;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(155, 147);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar Dato";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(155, 93);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(100, 37);
            this.btnLeer.TabIndex = 20;
            this.btnLeer.Text = "Leer Dato";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(12, 107);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Raza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(155, 31);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(100, 41);
            this.btnNueva.TabIndex = 24;
            this.btnNueva.Text = "Nueva Mascota";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Items.AddRange(new object[] {
            "lstMascotas"});
            this.lstMascotas.Location = new System.Drawing.Point(12, 243);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(243, 184);
            this.lstMascotas.TabIndex = 26;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(339, 314);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(101, 40);
            this.btnExaminar.TabIndex = 28;
            this.btnExaminar.Text = "button1";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // Form24ColeccionXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form24ColeccionXml";
            this.Text = "Form24ColeccionXml";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox txtAños;
        private Button btnGuardar;
        private Button btnLeer;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Button btnNueva;
        private Label label4;
        private ListBox lstMascotas;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}