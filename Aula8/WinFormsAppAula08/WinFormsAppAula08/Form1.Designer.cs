namespace WinFormsAppAula08
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
            panel1 = new Panel();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            Vendas = new Button();
            Produtos = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 50);
            panel1.TabIndex = 0;
            panel1.MouseMove += panel1_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(790, 9);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(37, 32);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.White;
            btnMaximizar.FlatStyle = FlatStyle.Popup;
            btnMaximizar.ForeColor = SystemColors.ControlText;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(833, 9);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(37, 32);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 432);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("RomanC", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(284, 4);
            label1.Name = "label1";
            label1.Size = new Size(319, 37);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Contas";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(876, 9);
            button1.Name = "button1";
            button1.Size = new Size(37, 32);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.TopRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(Vendas);
            panel3.Controls.Add(Produtos);
            panel3.Controls.Add(button2);
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 429);
            panel3.TabIndex = 1;
            // 
            // Vendas
            // 
            Vendas.FlatAppearance.BorderColor = Color.White;
            Vendas.FlatAppearance.MouseDownBackColor = Color.White;
            Vendas.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            Vendas.FlatStyle = FlatStyle.Flat;
            Vendas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Vendas.Image = (Image)resources.GetObject("Vendas.Image");
            Vendas.ImageAlign = ContentAlignment.MiddleLeft;
            Vendas.Location = new Point(8, 38);
            Vendas.Name = "Vendas";
            Vendas.Size = new Size(134, 26);
            Vendas.TabIndex = 2;
            Vendas.Text = "Vendas";
            Vendas.UseVisualStyleBackColor = true;
            Vendas.Click += Vendas_Click;
            // 
            // Produtos
            // 
            Produtos.FlatAppearance.BorderColor = Color.White;
            Produtos.FlatAppearance.MouseDownBackColor = Color.White;
            Produtos.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            Produtos.FlatStyle = FlatStyle.Flat;
            Produtos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Produtos.Image = (Image)resources.GetObject("Produtos.Image");
            Produtos.ImageAlign = ContentAlignment.MiddleLeft;
            Produtos.Location = new Point(8, 70);
            Produtos.Name = "Produtos";
            Produtos.Size = new Size(134, 26);
            Produtos.TabIndex = 1;
            Produtos.Text = "Produtos";
            Produtos.UseVisualStyleBackColor = true;
            Produtos.Click += Produtos_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(8, 6);
            button2.Name = "button2";
            button2.Size = new Size(134, 26);
            button2.TabIndex = 0;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 480);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button btnRestaurar;
        private Button btnMaximizar;
        private Button Vendas;
        private Button Produtos;
    }
}
