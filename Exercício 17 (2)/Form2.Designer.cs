namespace Exercício_17__2_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Registos = new ListBox();
            btnVoltar = new Button();
            btnSair = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // Registos
            // 
            Registos.BorderStyle = BorderStyle.FixedSingle;
            Registos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Registos.FormattingEnabled = true;
            Registos.ItemHeight = 21;
            Registos.Location = new Point(283, 62);
            Registos.Name = "Registos";
            Registos.Size = new Size(236, 275);
            Registos.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.Location = new Point(623, 347);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 52);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(691, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(81, 47);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrar.Location = new Point(349, 347);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(109, 39);
            btnMostrar.TabIndex = 12;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 411);
            Controls.Add(btnMostrar);
            Controls.Add(btnSair);
            Controls.Add(btnVoltar);
            Controls.Add(Registos);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Registos;
        private Button btnVoltar;
        private Button btnSair;
        private Button btnMostrar;
    }
}