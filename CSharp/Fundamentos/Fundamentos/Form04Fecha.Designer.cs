namespace Fundamentos
{
    partial class Form04Fecha
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.rdbMeses = new System.Windows.Forms.RadioButton();
            this.rdbAños = new System.Windows.Forms.RadioButton();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.txtFA = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(46, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Cambiar formato fecha";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.rdbAños);
            this.groupBox1.Controls.Add(this.rdbMeses);
            this.groupBox1.Controls.Add(this.rdbDias);
            this.groupBox1.Location = new System.Drawing.Point(46, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 220);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iNCREMENTAR FECHA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Location = new System.Drawing.Point(30, 49);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(50, 19);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Dias:";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            this.rdbMeses.AutoSize = true;
            this.rdbMeses.Location = new System.Drawing.Point(30, 74);
            this.rdbMeses.Name = "rdbMeses";
            this.rdbMeses.Size = new System.Drawing.Size(61, 19);
            this.rdbMeses.TabIndex = 1;
            this.rdbMeses.TabStop = true;
            this.rdbMeses.Text = "Meses:";
            this.rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAños
            // 
            this.rdbAños.AutoSize = true;
            this.rdbAños.Location = new System.Drawing.Point(30, 99);
            this.rdbAños.Name = "rdbAños";
            this.rdbAños.Size = new System.Drawing.Size(55, 19);
            this.rdbAños.TabIndex = 2;
            this.rdbAños.TabStop = true;
            this.rdbAños.Text = "Años:";
            this.rdbAños.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(465, 74);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(100, 23);
            this.txtIncremento.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Incremento:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Incrementar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nueva fecha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(53, 404);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(195, 23);
            this.txtNF.TabIndex = 18;
            // 
            // txtFA
            // 
            this.txtFA.Location = new System.Drawing.Point(46, 37);
            this.txtFA.Name = "txtFA";
            this.txtFA.Size = new System.Drawing.Size(224, 23);
            this.txtFA.TabIndex = 19;
            // 
            // Form04Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFA);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form04Fecha";
            this.Text = "Form04Fecha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Button button1;
        private Label label9;
        private TextBox txtIncremento;
        private RadioButton rdbAños;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private Label label3;
        private TextBox txtNF;
        private DateTimePicker txtFA;
    }
}