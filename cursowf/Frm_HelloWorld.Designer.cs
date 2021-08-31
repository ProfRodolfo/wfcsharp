
namespace cursowf
{
    partial class Frm_HelloWorld
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_ModifcaLabel = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(30, 30);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(255, 24);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .Net Version";
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(250, 265);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(150, 23);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Fechar a aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_ModifcaLabel
            // 
            this.Btn_ModifcaLabel.Location = new System.Drawing.Point(34, 52);
            this.Btn_ModifcaLabel.Name = "Btn_ModifcaLabel";
            this.Btn_ModifcaLabel.Size = new System.Drawing.Size(209, 23);
            this.Btn_ModifcaLabel.TabIndex = 2;
            this.Btn_ModifcaLabel.Text = "Modica Texto do Label";
            this.Btn_ModifcaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModifcaLabel.Click += new System.EventHandler(this.Btn_ModifcaLabel_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(34, 81);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(311, 22);
            this.Txt_ConteudoLabel.TabIndex = 3;
           
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 292);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btn_ModifcaLabel);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_ModifcaLabel;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
    }
}

