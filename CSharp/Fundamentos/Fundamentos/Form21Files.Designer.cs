namespace Fundamentos
{
    partial class Form21Files
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
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contenido File";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(30, 75);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(162, 151);
            this.txtContenido.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(55, 232);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(96, 32);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(55, 283);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(96, 33);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Write File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(236, 75);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(136, 23);
            this.txtAgregar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(393, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 15;
            this.lstNombres.Items.AddRange(new object[] {
            "lstNombres"});
            this.lstNombres.Location = new System.Drawing.Point(236, 197);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(203, 124);
            this.lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 374);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.label1);
            this.Name = "Form21Files";
            this.Text = "Form21Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private Button btnRead;
        private Button btnWrite;
        private TextBox txtAgregar;
        private Label label2;
        private Button btnAgregar;
        private Label label3;
        private ListBox lstNombres;
    }
}