namespace Aula9
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
            btnSalvar = new Button();
            txtNome = new TextBox();
            Listar = new Button();
            listUsuarios = new ListBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(326, 154);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(117, 45);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(232, 228);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(303, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // Listar
            // 
            Listar.Location = new Point(338, 72);
            Listar.Name = "Listar";
            Listar.Size = new Size(104, 64);
            Listar.TabIndex = 2;
            Listar.Text = "Listar";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += Listar_Click;
            // 
            // listUsuarios
            // 
            listUsuarios.FormattingEnabled = true;
            listUsuarios.ItemHeight = 15;
            listUsuarios.Location = new Point(290, 260);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(234, 79);
            listUsuarios.TabIndex = 3;
            listUsuarios.SelectedIndexChanged += listUsuarios_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listUsuarios);
            Controls.Add(Listar);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNome;
        private Button Listar;
        private ListBox listUsuarios;
    }
}
