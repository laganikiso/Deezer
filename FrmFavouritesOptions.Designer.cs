namespace Deezer
{
    partial class FrmFavouritesOptions
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbFavouriteOptions = new System.Windows.Forms.ListBox();
            this.bsFavouritesOptions = new System.Windows.Forms.BindingSource(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsFavouritesOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lbFavouriteOptions
            // 
            this.lbFavouriteOptions.FormattingEnabled = true;
            this.lbFavouriteOptions.Location = new System.Drawing.Point(13, 39);
            this.lbFavouriteOptions.Name = "lbFavouriteOptions";
            this.lbFavouriteOptions.Size = new System.Drawing.Size(200, 238);
            this.lbFavouriteOptions.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(219, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(219, 68);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmFavouritesOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 284);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lbFavouriteOptions);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmFavouritesOptions";
            this.Text = "FrmFavouritesOptions";
            this.Load += new System.EventHandler(this.FrmFavouritesOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFavouritesOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbFavouriteOptions;
        private System.Windows.Forms.BindingSource bsFavouritesOptions;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBack;
    }
}