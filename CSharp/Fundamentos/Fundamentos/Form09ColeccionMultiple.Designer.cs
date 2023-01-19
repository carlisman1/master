namespace Fundamentos
{
    partial class Form09ColeccionMultiple
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
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNuevoElemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 15;
            this.lstElementos.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstElementos.Location = new System.Drawing.Point(62, 67);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(141, 154);
            this.lstElementos.TabIndex = 18;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lblItem.Location = new System.Drawing.Point(62, 315);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(44, 15);
            this.lblItem.TabIndex = 17;
            this.lblItem.Text = "lblItem";
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(62, 271);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(52, 15);
            this.lblIndice.TabIndex = 16;
            this.lblIndice.Text = "lblIndice";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(259, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Borrar Todo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(259, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNuevoElemento
            // 
            this.txtNuevoElemento.Location = new System.Drawing.Point(259, 82);
            this.txtNuevoElemento.Name = "txtNuevoElemento";
            this.txtNuevoElemento.Size = new System.Drawing.Size(100, 23);
            this.txtNuevoElemento.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nuevo Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(259, 198);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(100, 31);
            this.btnSeleccionados.TabIndex = 19;
            this.btnSeleccionados.Text = "Sleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // Form09ColeccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 388);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNuevoElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form09ColeccionMultiple";
            this.Text = "Form09ColeccionMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstElementos;
        private Label lblItem;
        private Label lblIndice;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtNuevoElemento;
        private Label label2;
        private Label label1;
        private Button btnSeleccionados;
    }
}