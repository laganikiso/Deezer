namespace Deezer
{
    partial class Favourites
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
            this.btnDownloaded = new System.Windows.Forms.Button();
            this.btnFavouriteTracks = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnArtists = new System.Windows.Forms.Button();
            this.bsFavourites = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsFavourites)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloaded
            // 
            this.btnDownloaded.Location = new System.Drawing.Point(13, 13);
            this.btnDownloaded.Name = "btnDownloaded";
            this.btnDownloaded.Size = new System.Drawing.Size(200, 80);
            this.btnDownloaded.TabIndex = 0;
            this.btnDownloaded.Text = "Downloaded";
            this.btnDownloaded.UseVisualStyleBackColor = true;
            this.btnDownloaded.Click += new System.EventHandler(this.BtnDownloaded_Click);
            // 
            // btnFavouriteTracks
            // 
            this.btnFavouriteTracks.Location = new System.Drawing.Point(13, 99);
            this.btnFavouriteTracks.Name = "btnFavouriteTracks";
            this.btnFavouriteTracks.Size = new System.Drawing.Size(200, 80);
            this.btnFavouriteTracks.TabIndex = 1;
            this.btnFavouriteTracks.Text = "Favourite tracks";
            this.btnFavouriteTracks.UseVisualStyleBackColor = true;
            this.btnFavouriteTracks.Click += new System.EventHandler(this.BtnFavouriteTracks_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.Location = new System.Drawing.Point(219, 13);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(200, 80);
            this.btnAlbums.TabIndex = 2;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = true;
            this.btnAlbums.Click += new System.EventHandler(this.BtnAlbums_Click);
            // 
            // btnArtists
            // 
            this.btnArtists.Location = new System.Drawing.Point(219, 99);
            this.btnArtists.Name = "btnArtists";
            this.btnArtists.Size = new System.Drawing.Size(200, 80);
            this.btnArtists.TabIndex = 3;
            this.btnArtists.Text = "Artists";
            this.btnArtists.UseVisualStyleBackColor = true;
            this.btnArtists.Click += new System.EventHandler(this.BtnArtists_Click);
            // 
            // Favourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 284);
            this.Controls.Add(this.btnArtists);
            this.Controls.Add(this.btnAlbums);
            this.Controls.Add(this.btnFavouriteTracks);
            this.Controls.Add(this.btnDownloaded);
            this.Name = "Favourites";
            this.Text = "Favourites";
            this.Load += new System.EventHandler(this.Favourites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFavourites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownloaded;
        private System.Windows.Forms.Button btnFavouriteTracks;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnArtists;
        private System.Windows.Forms.BindingSource bsFavourites;
    }
}