namespace AdoNet
{
    partial class Form02BuscadorEmpleados
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstSalarios = new System.Windows.Forms.ListBox();
            this.lstOficio = new System.Windows.Forms.ListBox();
            this.btnBuscarOficio = new System.Windows.Forms.Button();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(30, 62);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 23);
            this.txtSalario.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(30, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 45);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar empleados";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstSalarios
            // 
            this.lstSalarios.FormattingEnabled = true;
            this.lstSalarios.ItemHeight = 15;
            this.lstSalarios.Location = new System.Drawing.Point(30, 167);
            this.lstSalarios.Name = "lstSalarios";
            this.lstSalarios.Size = new System.Drawing.Size(139, 169);
            this.lstSalarios.TabIndex = 3;
            // 
            // lstOficio
            // 
            this.lstOficio.FormattingEnabled = true;
            this.lstOficio.ItemHeight = 15;
            this.lstOficio.Location = new System.Drawing.Point(271, 167);
            this.lstOficio.Name = "lstOficio";
            this.lstOficio.Size = new System.Drawing.Size(139, 169);
            this.lstOficio.TabIndex = 7;
            // 
            // btnBuscarOficio
            // 
            this.btnBuscarOficio.Location = new System.Drawing.Point(271, 100);
            this.btnBuscarOficio.Name = "btnBuscarOficio";
            this.btnBuscarOficio.Size = new System.Drawing.Size(107, 45);
            this.btnBuscarOficio.TabIndex = 6;
            this.btnBuscarOficio.Text = "Buscar empleados";
            this.btnBuscarOficio.UseVisualStyleBackColor = true;
            this.btnBuscarOficio.Click += new System.EventHandler(this.btnBuscarOficio_Click);
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(271, 62);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(100, 23);
            this.txtOficio.TabIndex = 5;
            this.txtOficio.TextChanged += new System.EventHandler(this.txtOficio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oficio";
            // 
            // Form02BuscadorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 348);
            this.Controls.Add(this.lstOficio);
            this.Controls.Add(this.btnBuscarOficio);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSalarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Name = "Form02BuscadorEmpleados";
            this.Text = "Form02BuscadorEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSalario;
        private Button btnBuscar;
        private ListBox lstSalarios;
        private ListBox lstOficio;
        private Button btnBuscarOficio;
        private TextBox txtOficio;
        private Label label2;
    }
}