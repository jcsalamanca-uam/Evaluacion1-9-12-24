namespace Evaluacion._2
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
            this.BtnGeneral = new System.Windows.Forms.Button();
            this.LbNotas = new System.Windows.Forms.ListBox();
            this.LbPromedio = new System.Windows.Forms.ListBox();
            this.LbPrimeros3 = new System.Windows.Forms.ListBox();
            this.TbNotas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGeneral
            // 
            this.BtnGeneral.Location = new System.Drawing.Point(12, 12);
            this.BtnGeneral.Name = "BtnGeneral";
            this.BtnGeneral.Size = new System.Drawing.Size(253, 31);
            this.BtnGeneral.TabIndex = 0;
            this.BtnGeneral.Text = "Agregar Notas";
            this.BtnGeneral.UseVisualStyleBackColor = true;
            this.BtnGeneral.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbNotas
            // 
            this.LbNotas.FormattingEnabled = true;
            this.LbNotas.ItemHeight = 20;
            this.LbNotas.Location = new System.Drawing.Point(80, 97);
            this.LbNotas.Name = "LbNotas";
            this.LbNotas.Size = new System.Drawing.Size(159, 224);
            this.LbNotas.TabIndex = 1;
            this.LbNotas.SelectedIndexChanged += new System.EventHandler(this.LbNotas_SelectedIndexChanged);
            // 
            // LbPromedio
            // 
            this.LbPromedio.FormattingEnabled = true;
            this.LbPromedio.ItemHeight = 20;
            this.LbPromedio.Location = new System.Drawing.Point(306, 97);
            this.LbPromedio.Name = "LbPromedio";
            this.LbPromedio.Size = new System.Drawing.Size(163, 224);
            this.LbPromedio.TabIndex = 2;
            // 
            // LbPrimeros3
            // 
            this.LbPrimeros3.FormattingEnabled = true;
            this.LbPrimeros3.ItemHeight = 20;
            this.LbPrimeros3.Location = new System.Drawing.Point(509, 97);
            this.LbPrimeros3.Name = "LbPrimeros3";
            this.LbPrimeros3.Size = new System.Drawing.Size(169, 224);
            this.LbPrimeros3.TabIndex = 3;
            // 
            // TbNotas
            // 
            this.TbNotas.Location = new System.Drawing.Point(306, 17);
            this.TbNotas.Name = "TbNotas";
            this.TbNotas.Size = new System.Drawing.Size(100, 26);
            this.TbNotas.TabIndex = 4;
            this.TbNotas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primeros3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNotas);
            this.Controls.Add(this.LbPrimeros3);
            this.Controls.Add(this.LbPromedio);
            this.Controls.Add(this.LbNotas);
            this.Controls.Add(this.BtnGeneral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeneral;
        private System.Windows.Forms.ListBox LbNotas;
        private System.Windows.Forms.ListBox LbPromedio;
        private System.Windows.Forms.ListBox LbPrimeros3;
        private System.Windows.Forms.TextBox TbNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

