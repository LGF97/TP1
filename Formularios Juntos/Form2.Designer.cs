
namespace Formularios_Juntos
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ls_agregados = new System.Windows.Forms.ListBox();
            this.ls_pasados = new System.Windows.Forms.ListBox();
            this.btn_pasar = new System.Windows.Forms.Button();
            this.btn_agregarAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.button1.Location = new System.Drawing.Point(398, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(-2, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.Location = new System.Drawing.Point(154, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 47);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // ls_agregados
            // 
            this.ls_agregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.ls_agregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ls_agregados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ls_agregados.FormattingEnabled = true;
            this.ls_agregados.ItemHeight = 24;
            this.ls_agregados.Location = new System.Drawing.Point(5, 202);
            this.ls_agregados.Name = "ls_agregados";
            this.ls_agregados.Size = new System.Drawing.Size(152, 316);
            this.ls_agregados.TabIndex = 3;
            // 
            // ls_pasados
            // 
            this.ls_pasados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.ls_pasados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ls_pasados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ls_pasados.FormattingEnabled = true;
            this.ls_pasados.ItemHeight = 24;
            this.ls_pasados.Location = new System.Drawing.Point(398, 202);
            this.ls_pasados.Name = "ls_pasados";
            this.ls_pasados.Size = new System.Drawing.Size(152, 316);
            this.ls_pasados.TabIndex = 4;
            // 
            // btn_pasar
            // 
            this.btn_pasar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.btn_pasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pasar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.btn_pasar.Location = new System.Drawing.Point(168, 257);
            this.btn_pasar.Name = "btn_pasar";
            this.btn_pasar.Size = new System.Drawing.Size(208, 87);
            this.btn_pasar.TabIndex = 5;
            this.btn_pasar.Text = ">";
            this.btn_pasar.UseVisualStyleBackColor = false;
            this.btn_pasar.Click += new System.EventHandler(this.btn_pasar_Click);
            // 
            // btn_agregarAll
            // 
            this.btn_agregarAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.btn_agregarAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.btn_agregarAll.Location = new System.Drawing.Point(168, 387);
            this.btn_agregarAll.Name = "btn_agregarAll";
            this.btn_agregarAll.Size = new System.Drawing.Size(208, 87);
            this.btn_agregarAll.TabIndex = 6;
            this.btn_agregarAll.Text = ">>";
            this.btn_agregarAll.UseVisualStyleBackColor = false;
            this.btn_agregarAll.Click += new System.EventHandler(this.btn_agregarAll_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(573, 530);
            this.Controls.Add(this.btn_agregarAll);
            this.Controls.Add(this.btn_pasar);
            this.Controls.Add(this.ls_pasados);
            this.Controls.Add(this.ls_agregados);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox ls_agregados;
        private System.Windows.Forms.ListBox ls_pasados;
        private System.Windows.Forms.Button btn_pasar;
        private System.Windows.Forms.Button btn_agregarAll;
    }
}