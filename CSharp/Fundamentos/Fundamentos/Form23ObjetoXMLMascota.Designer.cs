namespace Fundamentos
{
    partial class Form23ObjetoXMLMascota
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAños = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(173, 96);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar Dato";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(173, 42);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(100, 37);
            this.btnLeer.TabIndex = 12;
            this.btnLeer.Text = "Leer Dato";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(27, 114);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Raza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // txtAños
            // 
            this.txtAños.Location = new System.Drawing.Point(27, 171);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(100, 23);
            this.txtAños.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Años:";
            // 
            // Form23ObjetoXMLMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form23ObjetoXMLMascota";
            this.Text = "Form23ObjetoXMLMascota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGuardar;
        private Button btnLeer;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private TextBox txtAños;
        private Label label3;
    }
}