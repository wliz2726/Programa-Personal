namespace ProyectoPersonal
{
    partial class First_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalEmpresaToolStripMenuItem,
            this.listarRegistrosToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalEmpresaToolStripMenuItem
            // 
            this.personalEmpresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoToolStripMenuItem,
            this.modificacionToolStripMenuItem,
            this.eliminacionToolStripMenuItem});
            this.personalEmpresaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalEmpresaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personalEmpresaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personalEmpresaToolStripMenuItem.Image")));
            this.personalEmpresaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.personalEmpresaToolStripMenuItem.Name = "personalEmpresaToolStripMenuItem";
            this.personalEmpresaToolStripMenuItem.Size = new System.Drawing.Size(173, 25);
            this.personalEmpresaToolStripMenuItem.Text = "Personal Empresa";
            // 
            // agregarNuevoToolStripMenuItem
            // 
            this.agregarNuevoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.agregarNuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregarNuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarNuevoToolStripMenuItem.Image")));
            this.agregarNuevoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            this.agregarNuevoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.agregarNuevoToolStripMenuItem.Text = "Agregar nuevo";
            this.agregarNuevoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoToolStripMenuItem_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.modificacionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modificacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificacionToolStripMenuItem.Image")));
            this.modificacionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.modificacionToolStripMenuItem.Text = "Modificar";
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionToolStripMenuItem_Click);
            // 
            // eliminacionToolStripMenuItem
            // 
            this.eliminacionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.eliminacionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminacionToolStripMenuItem.Image")));
            this.eliminacionToolStripMenuItem.Name = "eliminacionToolStripMenuItem";
            this.eliminacionToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.eliminacionToolStripMenuItem.Text = "Eliminar";
            this.eliminacionToolStripMenuItem.Click += new System.EventHandler(this.eliminacionToolStripMenuItem_Click);
            // 
            // listarRegistrosToolStripMenuItem
            // 
            this.listarRegistrosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarRegistrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listarRegistrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarRegistrosToolStripMenuItem.Image")));
            this.listarRegistrosToolStripMenuItem.Name = "listarRegistrosToolStripMenuItem";
            this.listarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(149, 25);
            this.listarRegistrosToolStripMenuItem.Text = "Listar Registros";
            this.listarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.listarRegistrosToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salirDelSistemaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirDelSistemaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salirDelSistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirDelSistemaToolStripMenuItem.Image")));
            this.salirDelSistemaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salirDelSistemaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(160, 25);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(194, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // First_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(742, 491);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "First_Form";
            this.Text = "Sistema de Personal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

