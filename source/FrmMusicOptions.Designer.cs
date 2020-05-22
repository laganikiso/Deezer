namespace Deezer
{
    partial class FrmMusicOptions
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
            this.components = new System.ComponentModel.Container();
            this.lbMusicOptions = new System.Windows.Forms.ListBox();
            this.tbSearchMusic = new System.Windows.Forms.TextBox();
            this.bsMusicOptions = new System.Windows.Forms.BindingSource(this.components);
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnFavourite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsMusicOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMusicOptions
            // 
            this.lbMusicOptions.FormattingEnabled = true;
            this.lbMusicOptions.Location = new System.Drawing.Point(12, 34);
            this.lbMusicOptions.Name = "lbMusicOptions";
            this.lbMusicOptions.Size = new System.Drawing.Size(200, 238);
            this.lbMusicOptions.TabIndex = 0;
            // 
            // tbSearchMusic
            // 
            this.tbSearchMusic.Location = new System.Drawing.Point(13, 8);
            this.tbSearchMusic.Name = "tbSearchMusic";
            this.tbSearchMusic.Size = new System.Drawing.Size(200, 20);
            this.tbSearchMusic.TabIndex = 1;
            this.tbSearchMusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchMusic.TextChanged += new System.EventHandler(this.TbSearchMusic_TextChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(219, 34);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // btnFavourite
            // 
            this.btnFavourite.Location = new System.Drawing.Point(219, 64);
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.Size = new System.Drawing.Size(75, 35);
            this.btnFavourite.TabIndex = 3;
            this.btnFavourite.Text = "Add Favourite";
            this.btnFavourite.UseVisualStyleBackColor = true;
            this.btnFavourite.Click += new System.EventHandler(this.BtnFavourite_Click);
            // 
            // FrmMusicOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 284);
            this.Controls.Add(this.btnFavourite);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.tbSearchMusic);
            this.Controls.Add(this.lbMusicOptions);
            this.Name = "FrmMusicOptions";
            this.Text = "FrmMusicOptions";
            this.Load += new System.EventHandler(this.FrmMusicOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMusicOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMusicOptions;
        private System.Windows.Forms.TextBox tbSearchMusic;
        private System.Windows.Forms.BindingSource bsMusicOptions;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnFavourite;
    }
}