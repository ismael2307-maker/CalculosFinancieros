namespace CalculosFinancieros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            btnCalendarioPago = new Button();
            pnlSubMenuInteres = new Panel();
            btnInteresCompuesto = new Button();
            btnInteresSimple = new Button();
            btnInteres = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            pnlSubMenuInteres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(67, 235, 103);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 38);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1216, 7);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1170, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1216, 7);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += bntMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1263, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.AutoScroll = true;
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(btnCalendarioPago);
            MenuVertical.Controls.Add(pnlSubMenuInteres);
            MenuVertical.Controls.Add(btnInteres);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 38);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 612);
            MenuVertical.TabIndex = 1;
            // 
            // btnCalendarioPago
            // 
            btnCalendarioPago.BackColor = Color.FromArgb(26, 32, 40);
            btnCalendarioPago.Dock = DockStyle.Top;
            btnCalendarioPago.FlatAppearance.BorderSize = 0;
            btnCalendarioPago.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 235, 103);
            btnCalendarioPago.FlatStyle = FlatStyle.Flat;
            btnCalendarioPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalendarioPago.ForeColor = Color.Gainsboro;
            btnCalendarioPago.Location = new Point(0, 213);
            btnCalendarioPago.Name = "btnCalendarioPago";
            btnCalendarioPago.Padding = new Padding(10, 0, 0, 0);
            btnCalendarioPago.Size = new Size(220, 45);
            btnCalendarioPago.TabIndex = 3;
            btnCalendarioPago.Text = "Calendario de Pago";
            btnCalendarioPago.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendarioPago.UseVisualStyleBackColor = false;
            // 
            // pnlSubMenuInteres
            // 
            pnlSubMenuInteres.BackColor = Color.FromArgb(35, 32, 40);
            pnlSubMenuInteres.Controls.Add(btnInteresCompuesto);
            pnlSubMenuInteres.Controls.Add(btnInteresSimple);
            pnlSubMenuInteres.Dock = DockStyle.Top;
            pnlSubMenuInteres.Location = new Point(0, 142);
            pnlSubMenuInteres.Name = "pnlSubMenuInteres";
            pnlSubMenuInteres.Size = new Size(220, 71);
            pnlSubMenuInteres.TabIndex = 2;
            // 
            // btnInteresCompuesto
            // 
            btnInteresCompuesto.Dock = DockStyle.Top;
            btnInteresCompuesto.FlatAppearance.BorderSize = 0;
            btnInteresCompuesto.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 235, 103);
            btnInteresCompuesto.FlatStyle = FlatStyle.Flat;
            btnInteresCompuesto.Font = new Font("Segoe UI", 9.75F);
            btnInteresCompuesto.ForeColor = Color.LightGray;
            btnInteresCompuesto.Location = new Point(0, 33);
            btnInteresCompuesto.Name = "btnInteresCompuesto";
            btnInteresCompuesto.Padding = new Padding(35, 0, 0, 0);
            btnInteresCompuesto.Size = new Size(220, 33);
            btnInteresCompuesto.TabIndex = 1;
            btnInteresCompuesto.Text = "Interes Compuesto";
            btnInteresCompuesto.TextAlign = ContentAlignment.MiddleLeft;
            btnInteresCompuesto.UseVisualStyleBackColor = true;
            btnInteresCompuesto.Click += btnInteresCompuesto_Click;
            // 
            // btnInteresSimple
            // 
            btnInteresSimple.Dock = DockStyle.Top;
            btnInteresSimple.FlatAppearance.BorderSize = 0;
            btnInteresSimple.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 235, 103);
            btnInteresSimple.FlatStyle = FlatStyle.Flat;
            btnInteresSimple.Font = new Font("Segoe UI", 9.75F);
            btnInteresSimple.ForeColor = Color.LightGray;
            btnInteresSimple.Location = new Point(0, 0);
            btnInteresSimple.Name = "btnInteresSimple";
            btnInteresSimple.Padding = new Padding(35, 0, 0, 0);
            btnInteresSimple.Size = new Size(220, 33);
            btnInteresSimple.TabIndex = 0;
            btnInteresSimple.Text = "Interes Simple";
            btnInteresSimple.TextAlign = ContentAlignment.MiddleLeft;
            btnInteresSimple.UseVisualStyleBackColor = true;
            btnInteresSimple.Click += btnInteresSimple_Click;
            // 
            // btnInteres
            // 
            btnInteres.BackColor = Color.FromArgb(26, 32, 40);
            btnInteres.Dock = DockStyle.Top;
            btnInteres.FlatAppearance.BorderSize = 0;
            btnInteres.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 235, 103);
            btnInteres.FlatStyle = FlatStyle.Flat;
            btnInteres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInteres.ForeColor = Color.Gainsboro;
            btnInteres.Location = new Point(0, 97);
            btnInteres.Name = "btnInteres";
            btnInteres.Padding = new Padding(10, 0, 0, 0);
            btnInteres.Size = new Size(220, 45);
            btnInteres.TabIndex = 1;
            btnInteres.Text = "Interes";
            btnInteres.TextAlign = ContentAlignment.MiddleLeft;
            btnInteres.UseVisualStyleBackColor = false;
            btnInteres.Click += btnInteres_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 38);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1080, 612);
            panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            pnlSubMenuInteres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox pictureBox1;
        private Button btnInteres;
        private Panel pnlSubMenuInteres;
        private Button btnInteresCompuesto;
        private Button btnInteresSimple;
        private Button btnCalendarioPago;
    }
}
