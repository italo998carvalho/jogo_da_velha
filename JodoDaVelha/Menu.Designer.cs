namespace JodoDaVelha
{
    partial class Menu
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
            this.btnP1 = new System.Windows.Forms.Button();
            this.btnP2 = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnP1
            // 
            this.btnP1.Location = new System.Drawing.Point(59, 82);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(166, 42);
            this.btnP1.TabIndex = 0;
            this.btnP1.Text = "1 Jogador";
            this.btnP1.UseVisualStyleBackColor = true;
            this.btnP1.Click += new System.EventHandler(this.btnP1_Click);
            // 
            // btnP2
            // 
            this.btnP2.Location = new System.Drawing.Point(59, 144);
            this.btnP2.Name = "btnP2";
            this.btnP2.Size = new System.Drawing.Size(166, 42);
            this.btnP2.TabIndex = 1;
            this.btnP2.Text = "2 Jogadores";
            this.btnP2.UseVisualStyleBackColor = true;
            this.btnP2.Click += new System.EventHandler(this.btnP2_Click);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gb1.Enabled = false;
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb1.Location = new System.Drawing.Point(28, 23);
            this.gb1.Name = "gb1";
            this.gb1.ReadOnly = true;
            this.gb1.Size = new System.Drawing.Size(230, 37);
            this.gb1.TabIndex = 22;
            this.gb1.Text = "         Jogo da velha";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(59, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 42);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnP2);
            this.Controls.Add(this.btnP1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.Button btnP2;
        private System.Windows.Forms.RichTextBox gb1;
        private System.Windows.Forms.Button btnClose;
    }
}