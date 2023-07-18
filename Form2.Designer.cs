
namespace Aula06Streaming
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imgFundo = new System.Windows.Forms.PictureBox();
            this.wvVideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(72, 179);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 19);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label2";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(72, 299);
            this.lblDescricao.MaximumSize = new System.Drawing.Size(710, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(154, 20);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "descrição longa aqui";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Assistir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgFundo
            // 
            this.imgFundo.Location = new System.Drawing.Point(-5, -4);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(810, 463);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFundo.TabIndex = 3;
            this.imgFundo.TabStop = false;
            // 
            // wvVideo
            // 
            this.wvVideo.AllowExternalDrop = true;
            this.wvVideo.CreationProperties = null;
            this.wvVideo.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvVideo.Location = new System.Drawing.Point(-5, -4);
            this.wvVideo.Name = "wvVideo";
            this.wvVideo.Size = new System.Drawing.Size(810, 463);
            this.wvVideo.TabIndex = 4;
            this.wvVideo.Visible = false;
            this.wvVideo.ZoomFactor = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wvVideo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgFundo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgFundo;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvVideo;
    }
}