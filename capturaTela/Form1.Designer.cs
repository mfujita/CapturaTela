namespace capturaTela
{
    partial class Form1
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
            this.btnEstrobo = new System.Windows.Forms.Button();
            this.btn_Abortar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstrobo
            // 
            this.btnEstrobo.Location = new System.Drawing.Point(12, 12);
            this.btnEstrobo.Name = "btnEstrobo";
            this.btnEstrobo.Size = new System.Drawing.Size(89, 23);
            this.btnEstrobo.TabIndex = 0;
            this.btnEstrobo.Text = "Estrobo!";
            this.btnEstrobo.UseVisualStyleBackColor = true;
            this.btnEstrobo.Click += new System.EventHandler(this.btnEstrobo_Click);
            // 
            // btn_Abortar
            // 
            this.btn_Abortar.Location = new System.Drawing.Point(12, 92);
            this.btn_Abortar.Name = "btn_Abortar";
            this.btn_Abortar.Size = new System.Drawing.Size(89, 23);
            this.btn_Abortar.TabIndex = 1;
            this.btn_Abortar.Text = "Abortar";
            this.btn_Abortar.UseVisualStyleBackColor = true;
            this.btn_Abortar.Click += new System.EventHandler(this.Btn_Abortar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(164, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 31);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "0";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(12, 52);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(89, 23);
            this.btnConfigurar.TabIndex = 3;
            this.btnConfigurar.Text = "Configuração";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.BtnConfigurar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 127);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btn_Abortar);
            this.Controls.Add(this.btnEstrobo);
            this.Name = "Form1";
            this.Text = "Capturador tela";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstrobo;
        private System.Windows.Forms.Button btn_Abortar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnConfigurar;
    }
}

