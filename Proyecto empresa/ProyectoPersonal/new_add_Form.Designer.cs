namespace ProyectoPersonal
{
    partial class new_add_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.textb_edad = new System.Windows.Forms.TextBox();
            this.textb_direc = new System.Windows.Forms.TextBox();
            this.textb_nom = new System.Windows.Forms.TextBox();
            this.label_edad = new System.Windows.Forms.Label();
            this.label_direc = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.textb_id = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textb_edad);
            this.groupBox1.Controls.Add(this.textb_direc);
            this.groupBox1.Controls.Add(this.textb_nom);
            this.groupBox1.Controls.Add(this.label_edad);
            this.groupBox1.Controls.Add(this.label_direc);
            this.groupBox1.Controls.Add(this.label_nom);
            this.groupBox1.Controls.Add(this.textb_id);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textb_edad
            // 
            this.textb_edad.Location = new System.Drawing.Point(99, 126);
            this.textb_edad.Name = "textb_edad";
            this.textb_edad.Size = new System.Drawing.Size(61, 20);
            this.textb_edad.TabIndex = 10;
            this.textb_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_edad_KeyPress);
            this.textb_edad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textb_edad_KeyUp);
            // 
            // textb_direc
            // 
            this.textb_direc.Location = new System.Drawing.Point(99, 90);
            this.textb_direc.Name = "textb_direc";
            this.textb_direc.Size = new System.Drawing.Size(323, 20);
            this.textb_direc.TabIndex = 8;
            this.textb_direc.TextChanged += new System.EventHandler(this.textb_direc_TextChanged);
            this.textb_direc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_direc_KeyPress);
            // 
            // textb_nom
            // 
            this.textb_nom.Location = new System.Drawing.Point(99, 58);
            this.textb_nom.Name = "textb_nom";
            this.textb_nom.Size = new System.Drawing.Size(323, 20);
            this.textb_nom.TabIndex = 6;
            this.textb_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_nom_KeyPress);
            // 
            // label_edad
            // 
            this.label_edad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_edad.Location = new System.Drawing.Point(17, 126);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(43, 20);
            this.label_edad.TabIndex = 9;
            this.label_edad.Text = "EDAD";
            // 
            // label_direc
            // 
            this.label_direc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_direc.Location = new System.Drawing.Point(17, 92);
            this.label_direc.Name = "label_direc";
            this.label_direc.Size = new System.Drawing.Size(76, 20);
            this.label_direc.TabIndex = 7;
            this.label_direc.Text = "DIRECCION";
            // 
            // label_nom
            // 
            this.label_nom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_nom.Location = new System.Drawing.Point(17, 60);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(76, 20);
            this.label_nom.TabIndex = 5;
            this.label_nom.Text = "NOMBRE";
            // 
            // textb_id
            // 
            this.textb_id.AcceptsTab = true;
            this.textb_id.Location = new System.Drawing.Point(99, 27);
            this.textb_id.Name = "textb_id";
            this.textb_id.Size = new System.Drawing.Size(61, 20);
            this.textb_id.TabIndex = 3;
            this.textb_id.TextChanged += new System.EventHandler(this.textb_id_TextChanged);
            this.textb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_id_KeyPress);
            // 
            // label_id
            // 
            this.label_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_id.Location = new System.Drawing.Point(17, 29);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(43, 20);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_guardar);
            this.groupBox2.Controls.Add(this.button_cancel);
            this.groupBox2.Location = new System.Drawing.Point(17, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(233, 14);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(86, 36);
            this.button_guardar.TabIndex = 11;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(339, 14);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(83, 36);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancelar";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click_1);
            // 
            // new_add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 261);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "new_add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new registry";
            this.Load += new System.EventHandler(this.new_add_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textb_edad;
        private System.Windows.Forms.TextBox textb_direc;
        private System.Windows.Forms.TextBox textb_nom;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.Label label_direc;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox textb_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_cancel;
    }
}