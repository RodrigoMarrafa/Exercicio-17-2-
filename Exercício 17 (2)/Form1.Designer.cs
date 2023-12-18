namespace Exercício_17__2_
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnRegistar = new Button();
            labelNome = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            cbMostrar = new CheckBox();
            btnSair = new Button();
            btnVerRegistos = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(259, 95);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(289, 29);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(259, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 29);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(259, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(289, 29);
            txtPassword.TabIndex = 2;
            // 
            // btnRegistar
            // 
            btnRegistar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistar.Location = new Point(342, 256);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(118, 39);
            btnRegistar.TabIndex = 3;
            btnRegistar.Text = "Registar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = Color.White;
            labelNome.Location = new Point(199, 99);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(57, 21);
            labelNome.TabIndex = 4;
            labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(203, 155);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(53, 21);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(174, 210);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(82, 21);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // cbMostrar
            // 
            cbMostrar.AutoSize = true;
            cbMostrar.BackColor = Color.Transparent;
            cbMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbMostrar.ForeColor = Color.White;
            cbMostrar.Location = new Point(551, 208);
            cbMostrar.Name = "cbMostrar";
            cbMostrar.Size = new Size(88, 25);
            cbMostrar.TabIndex = 7;
            cbMostrar.Text = "Mostrar";
            cbMostrar.UseVisualStyleBackColor = false;
            cbMostrar.CheckedChanged += cbMostrar_CheckedChanged;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(691, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(81, 47);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnVerRegistos
            // 
            btnVerRegistos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerRegistos.Location = new Point(623, 347);
            btnVerRegistos.Name = "btnVerRegistos";
            btnVerRegistos.Size = new Size(149, 52);
            btnVerRegistos.TabIndex = 9;
            btnVerRegistos.Text = "Ver Registos";
            btnVerRegistos.UseVisualStyleBackColor = true;
            btnVerRegistos.Click += btnVerRegistos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 411);
            Controls.Add(btnVerRegistos);
            Controls.Add(btnSair);
            Controls.Add(cbMostrar);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(btnRegistar);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnRegistar;
        private Label labelNome;
        private Label labelEmail;
        private Label labelPassword;
        private CheckBox cbMostrar;
        private Button btnSair;
        private Button btnVerRegistos;
    }
}