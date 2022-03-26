
namespace Formularios_Juntos
{
    partial class Form4
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_masc = new System.Windows.Forms.RadioButton();
            this.rbtn_fem = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_Soltero = new System.Windows.Forms.RadioButton();
            this.rbtn_Casado = new System.Windows.Forms.RadioButton();
            this.lbl_elem = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.chkdlb = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 156);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.groupBox1.Controls.Add(this.rbtn_masc);
            this.groupBox1.Controls.Add(this.rbtn_fem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(3, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtn_masc
            // 
            this.rbtn_masc.AutoSize = true;
            this.rbtn_masc.Location = new System.Drawing.Point(49, 58);
            this.rbtn_masc.Name = "rbtn_masc";
            this.rbtn_masc.Size = new System.Drawing.Size(98, 24);
            this.rbtn_masc.TabIndex = 1;
            this.rbtn_masc.TabStop = true;
            this.rbtn_masc.Text = "Masculino";
            this.rbtn_masc.UseVisualStyleBackColor = true;
            // 
            // rbtn_fem
            // 
            this.rbtn_fem.AutoSize = true;
            this.rbtn_fem.Checked = true;
            this.rbtn_fem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.rbtn_fem.Location = new System.Drawing.Point(49, 19);
            this.rbtn_fem.Name = "rbtn_fem";
            this.rbtn_fem.Size = new System.Drawing.Size(98, 24);
            this.rbtn_fem.TabIndex = 0;
            this.rbtn_fem.TabStop = true;
            this.rbtn_fem.Text = "Femenino";
            this.rbtn_fem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.groupBox2.Controls.Add(this.rbtn_Soltero);
            this.groupBox2.Controls.Add(this.rbtn_Casado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.groupBox2.Location = new System.Drawing.Point(385, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // rbtn_Soltero
            // 
            this.rbtn_Soltero.AutoSize = true;
            this.rbtn_Soltero.Location = new System.Drawing.Point(49, 58);
            this.rbtn_Soltero.Name = "rbtn_Soltero";
            this.rbtn_Soltero.Size = new System.Drawing.Size(78, 24);
            this.rbtn_Soltero.TabIndex = 1;
            this.rbtn_Soltero.TabStop = true;
            this.rbtn_Soltero.Text = "Soltero";
            this.rbtn_Soltero.UseVisualStyleBackColor = true;
            // 
            // rbtn_Casado
            // 
            this.rbtn_Casado.AutoSize = true;
            this.rbtn_Casado.Checked = true;
            this.rbtn_Casado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.rbtn_Casado.Location = new System.Drawing.Point(49, 19);
            this.rbtn_Casado.Name = "rbtn_Casado";
            this.rbtn_Casado.Size = new System.Drawing.Size(82, 24);
            this.rbtn_Casado.TabIndex = 0;
            this.rbtn_Casado.TabStop = true;
            this.rbtn_Casado.Text = "Casado";
            this.rbtn_Casado.UseVisualStyleBackColor = true;
            // 
            // lbl_elem
            // 
            this.lbl_elem.AutoSize = true;
            this.lbl_elem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_elem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lbl_elem.Location = new System.Drawing.Point(102, 357);
            this.lbl_elem.Name = "lbl_elem";
            this.lbl_elem.Size = new System.Drawing.Size(0, 18);
            this.lbl_elem.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.btn_Agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.btn_Agregar.Location = new System.Drawing.Point(107, 148);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(312, 47);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Mostrar lo que selecciono";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkdlb
            // 
            this.chkdlb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.chkdlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkdlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.chkdlb.FormattingEnabled = true;
            this.chkdlb.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.chkdlb.Location = new System.Drawing.Point(107, 3);
            this.chkdlb.Name = "chkdlb";
            this.chkdlb.Size = new System.Drawing.Size(312, 139);
            this.chkdlb.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82269F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.17731F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.chkdlb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Agregar, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 156);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(573, 198);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(573, 530);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_elem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_masc;
        private System.Windows.Forms.RadioButton rbtn_fem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_Soltero;
        private System.Windows.Forms.RadioButton rbtn_Casado;
        private System.Windows.Forms.Label lbl_elem;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.CheckedListBox chkdlb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}