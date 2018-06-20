namespace ProyectoPersonal
{
    partial class Delete_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.textb_edad = new System.Windows.Forms.TextBox();
            this.textb_direc = new System.Windows.Forms.TextBox();
            this.textb_nom = new System.Windows.Forms.TextBox();
            this.textb_id = new System.Windows.Forms.TextBox();
            this.label_edad = new System.Windows.Forms.Label();
            this.label_direc = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.textb_edad);
            this.groupBox1.Controls.Add(this.textb_direc);
            this.groupBox1.Controls.Add(this.textb_nom);
            this.groupBox1.Controls.Add(this.textb_id);
            this.groupBox1.Controls.Add(this.label_edad);
            this.groupBox1.Controls.Add(this.label_direc);
            this.groupBox1.Controls.Add(this.label_nom);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(170, 19);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(83, 23);
            this.button_buscar.TabIndex = 2;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // textb_edad
            // 
            this.textb_edad.Location = new System.Drawing.Point(108, 120);
            this.textb_edad.Name = "textb_edad";
            this.textb_edad.Size = new System.Drawing.Size(56, 20);
            this.textb_edad.TabIndex = 8;
            this.textb_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_edad_KeyPress);
            // 
            // textb_direc
            // 
            this.textb_direc.Location = new System.Drawing.Point(108, 86);
            this.textb_direc.Name = "textb_direc";
            this.textb_direc.Size = new System.Drawing.Size(314, 20);
            this.textb_direc.TabIndex = 6;
            this.textb_direc.TextChanged += new System.EventHandler(this.textb_direc_TextChanged);
            this.textb_direc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_direc_KeyPress);
            // 
            // textb_nom
            // 
            this.textb_nom.Location = new System.Drawing.Point(108, 52);
            this.textb_nom.Name = "textb_nom";
            this.textb_nom.Size = new System.Drawing.Size(314, 20);
            this.textb_nom.TabIndex = 4;
            this.textb_nom.TextChanged += new System.EventHandler(this.textb_nom_TextChanged);
            this.textb_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_nom_KeyPress);
            // 
            // textb_id
            // 
            this.textb_id.Location = new System.Drawing.Point(108, 19);
            this.textb_id.Name = "textb_id";
            this.textb_id.Size = new System.Drawing.Size(56, 20);
            this.textb_id.TabIndex = 1;
            this.textb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_id_KeyPress);
            // 
            // label_edad
            // 
            this.label_edad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_edad.Location = new System.Drawing.Point(13, 120);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(44, 19);
            this.label_edad.TabIndex = 7;
            this.label_edad.Text = "EDAD";
            // 
            // label_direc
            // 
            this.label_direc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_direc.Location = new System.Drawing.Point(13, 86);
            this.label_direc.Name = "label_direc";
            this.label_direc.Size = new System.Drawing.Size(70, 19);
            this.label_direc.TabIndex = 5;
            this.label_direc.Text = "DIRECION";
            // 
            // label_nom
            // 
            this.label_nom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_nom.Location = new System.Drawing.Point(13, 52);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(70, 19);
            this.label_nom.TabIndex = 3;
            this.label_nom.Text = "NOMBRE";
            // 
            // label_id
            // 
            this.label_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_id.Location = new System.Drawing.Point(13, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(44, 19);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_guardar);
            this.groupBox2.Controls.Add(this.button_cancel);
            this.groupBox2.Location = new System.Drawing.Point(23, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(227, 10);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(83, 33);
            this.button_guardar.TabIndex = 9;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(340, 10);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(82, 33);
            this.button_cancel.TabIndex = 11;
            this.button_cancel.Text = "Salir";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click_1);
            // 
            // Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 265);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Delete_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletion of system records";
            this.Load += new System.EventHandler(this.Delete_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.Label label_direc;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox textb_edad;
        private System.Windows.Forms.TextBox textb_direc;
        private System.Windows.Forms.TextBox textb_nom;
        private System.Windows.Forms.TextBox textb_id;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cancel;
    }
}