namespace Deezer
{
    partial class FrmDeezerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeezerHome));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.lbDeezerHome = new System.Windows.Forms.ListBox();
            this.bsDeezer = new System.Windows.Forms.BindingSource(this.components);
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnMakeFavourite = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeezer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(90, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(400, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(10, 250);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(290, 23);
            this.btnMusic.TabIndex = 1;
            this.btnMusic.Text = "Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // btnFavourites
            // 
            this.btnFavourites.Location = new System.Drawing.Point(300, 250);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(275, 23);
            this.btnFavourites.TabIndex = 2;
            this.btnFavourites.Text = "Favourites";
            this.btnFavourites.UseVisualStyleBackColor = true;
            this.btnFavourites.Click += new System.EventHandler(this.BtnFavourites_Click);
            // 
            // lbDeezerHome
            // 
            this.lbDeezerHome.FormattingEnabled = true;
            this.lbDeezerHome.Location = new System.Drawing.Point(90, 37);
            this.lbDeezerHome.Name = "lbDeezerHome";
            this.lbDeezerHome.Size = new System.Drawing.Size(400, 212);
            this.lbDeezerHome.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(497, 95);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // btnMakeFavourite
            // 
            this.btnMakeFavourite.Location = new System.Drawing.Point(496, 124);
            this.btnMakeFavourite.Name = "btnMakeFavourite";
            this.btnMakeFavourite.Size = new System.Drawing.Size(75, 37);
            this.btnMakeFavourite.TabIndex = 5;
            this.btnMakeFavourite.Text = "Add to Favourite";
            this.btnMakeFavourite.UseVisualStyleBackColor = true;
            this.btnMakeFavourite.Click += new System.EventHandler(this.BtnMakeFavourite_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(497, 196);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnSerialize.TabIndex = 6;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.BtnSerialize_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(496, 37);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(496, 66);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // FrmDeezerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 284);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnMakeFavourite);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lbDeezerHome);
            this.Controls.Add(this.btnFavourites);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.tbSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDeezerHome";
            this.Text = "Deezer";
            this.Load += new System.EventHandler(this.FrmDeezerHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDeezer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.ListBox lbDeezerHome;
        private System.Windows.Forms.BindingSource bsDeezer;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnMakeFavourite;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
    }
}

