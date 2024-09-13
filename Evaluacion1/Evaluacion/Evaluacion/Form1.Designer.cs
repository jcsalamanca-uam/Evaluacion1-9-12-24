namespace Evaluacion
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.ListBox();
            this.LbApellido = new System.Windows.Forms.ListBox();
            this.LbFechaNac = new System.Windows.Forms.ListBox();
            this.TbFechaNac = new System.Windows.Forms.TextBox();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.BtnAgregarNombre = new System.Windows.Forms.Button();
            this.BtnAgregarApellido = new System.Windows.Forms.Button();
            this.BtnAgregarFechaNac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // LbNombre
            // 
            this.LbNombre.FormattingEnabled = true;
            this.LbNombre.ItemHeight = 20;
            this.LbNombre.Location = new System.Drawing.Point(12, 190);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(143, 204);
            this.LbNombre.TabIndex = 4;
            // 
            // LbApellido
            // 
            this.LbApellido.FormattingEnabled = true;
            this.LbApellido.ItemHeight = 20;
            this.LbApellido.Location = new System.Drawing.Point(192, 190);
            this.LbApellido.Name = "LbApellido";
            this.LbApellido.Size = new System.Drawing.Size(134, 204);
            this.LbApellido.TabIndex = 5;
            // 
            // LbFechaNac
            // 
            this.LbFechaNac.FormattingEnabled = true;
            this.LbFechaNac.ItemHeight = 20;
            this.LbFechaNac.Location = new System.Drawing.Point(380, 190);
            this.LbFechaNac.Name = "LbFechaNac";
            this.LbFechaNac.Size = new System.Drawing.Size(120, 204);
            this.LbFechaNac.TabIndex = 6;
            // 
            // TbFechaNac
            // 
            this.TbFechaNac.Location = new System.Drawing.Point(380, 94);
            this.TbFechaNac.Name = "TbFechaNac";
            this.TbFechaNac.Size = new System.Drawing.Size(100, 26);
            this.TbFechaNac.TabIndex = 9;
            this.TbFechaNac.TextChanged += new System.EventHandler(this.TbFechaNac_TextChanged);
            // 
            // TbApellido
            // 
            this.TbApellido.Location = new System.Drawing.Point(192, 94);
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(100, 26);
            this.TbApellido.TabIndex = 10;
            this.TbApellido.TextChanged += new System.EventHandler(this.TbApellido_TextChanged);
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(12, 94);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(100, 26);
            this.TbNombre.TabIndex = 11;
            this.TbNombre.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // BtnAgregarNombre
            // 
            this.BtnAgregarNombre.Location = new System.Drawing.Point(12, 143);
            this.BtnAgregarNombre.Name = "BtnAgregarNombre";
            this.BtnAgregarNombre.Size = new System.Drawing.Size(100, 41);
            this.BtnAgregarNombre.TabIndex = 12;
            this.BtnAgregarNombre.Text = "Agregar";
            this.BtnAgregarNombre.UseVisualStyleBackColor = true;
            this.BtnAgregarNombre.Click += new System.EventHandler(this.BtnAgregarNombre_Click);
            // 
            // BtnAgregarApellido
            // 
            this.BtnAgregarApellido.Location = new System.Drawing.Point(192, 143);
            this.BtnAgregarApellido.Name = "BtnAgregarApellido";
            this.BtnAgregarApellido.Size = new System.Drawing.Size(100, 41);
            this.BtnAgregarApellido.TabIndex = 13;
            this.BtnAgregarApellido.Text = "Agregar";
            this.BtnAgregarApellido.UseVisualStyleBackColor = true;
            this.BtnAgregarApellido.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAgregarFechaNac
            // 
            this.BtnAgregarFechaNac.Location = new System.Drawing.Point(380, 143);
            this.BtnAgregarFechaNac.Name = "BtnAgregarFechaNac";
            this.BtnAgregarFechaNac.Size = new System.Drawing.Size(100, 41);
            this.BtnAgregarFechaNac.TabIndex = 14;
            this.BtnAgregarFechaNac.Text = "Agregar";
            this.BtnAgregarFechaNac.UseVisualStyleBackColor = true;
            this.BtnAgregarFechaNac.Click += new System.EventHandler(this.BtnAgregarFechaNac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAgregarFechaNac);
            this.Controls.Add(this.BtnAgregarApellido);
            this.Controls.Add(this.BtnAgregarNombre);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.TbApellido);
            this.Controls.Add(this.TbFechaNac);
            this.Controls.Add(this.LbFechaNac);
            this.Controls.Add(this.LbApellido);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbNombre;
        private System.Windows.Forms.ListBox LbApellido;
        private System.Windows.Forms.ListBox LbFechaNac;
        private System.Windows.Forms.TextBox TbFechaNac;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Button BtnAgregarNombre;
        private System.Windows.Forms.Button BtnAgregarApellido;
        private System.Windows.Forms.Button BtnAgregarFechaNac;
    }
}

