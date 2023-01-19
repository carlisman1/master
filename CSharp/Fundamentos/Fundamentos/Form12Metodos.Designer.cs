namespace Fundamentos
{
    partial class Form12Metodos
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
            this.lblRes = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnDoble = new System.Windows.Forms.Button();
            this.btnDobleReferencia = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMouse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(85, 242);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(38, 15);
            this.lblRes.TabIndex = 1;
            this.lblRes.Text = "label2";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(54, 55);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDoble
            // 
            this.btnDoble.Location = new System.Drawing.Point(66, 84);
            this.btnDoble.Name = "btnDoble";
            this.btnDoble.Size = new System.Drawing.Size(88, 32);
            this.btnDoble.TabIndex = 3;
            this.btnDoble.Text = "Doble()";
            this.btnDoble.UseVisualStyleBackColor = true;
            this.btnDoble.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDobleReferencia
            // 
            this.btnDobleReferencia.Location = new System.Drawing.Point(66, 132);
            this.btnDobleReferencia.Name = "btnDobleReferencia";
            this.btnDobleReferencia.Size = new System.Drawing.Size(88, 43);
            this.btnDobleReferencia.TabIndex = 4;
            this.btnDobleReferencia.Text = "Doble Referencia()";
            this.btnDobleReferencia.UseVisualStyleBackColor = true;
            this.btnDobleReferencia.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(66, 185);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(88, 38);
            this.btnRef.TabIndex = 5;
            this.btnRef.Text = "Objeto Referencia";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solo numeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Solo letras";
            // 
            // lblMouse
            // 
            this.lblMouse.BackColor = System.Drawing.Color.Lime;
            this.lblMouse.Location = new System.Drawing.Point(215, 146);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(157, 125);
            this.lblMouse.TabIndex = 8;
            this.lblMouse.Text = "lblMouse";
            this.lblMouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 411);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnDobleReferencia);
            this.Controls.Add(this.btnDoble);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label1);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblRes;
        private TextBox txtNumero;
        private Button btnDoble;
        private Button btnDobleReferencia;
        private Button btnRef;
        private Label label2;
        private Label label3;
        private Label lblMouse;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}