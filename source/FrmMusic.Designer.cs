namespace Deezer
{
    partial class FrmMusic
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
            this.btnRap = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnJazz = new System.Windows.Forms.Button();
            this.btnElectronic = new System.Windows.Forms.Button();
            this.btnRnB = new System.Windows.Forms.Button();
            this.btnClassic = new System.Windows.Forms.Button();
            this.btnMetal = new System.Windows.Forms.Button();
            this.btnBlues = new System.Windows.Forms.Button();
            this.bsMusic = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRap
            // 
            this.btnRap.Location = new System.Drawing.Point(13, 13);
            this.btnRap.Name = "btnRap";
            this.btnRap.Size = new System.Drawing.Size(179, 78);
            this.btnRap.TabIndex = 0;
            this.btnRap.Text = "Rap";
            this.btnRap.UseVisualStyleBackColor = true;
            this.btnRap.Click += new System.EventHandler(this.BtnRap_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(13, 97);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(179, 80);
            this.btnPop.TabIndex = 1;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.BtnPop_Click);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(198, 97);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(180, 80);
            this.btnRock.TabIndex = 2;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.BtnRock_Click);
            // 
            // btnJazz
            // 
            this.btnJazz.Location = new System.Drawing.Point(198, 13);
            this.btnJazz.Name = "btnJazz";
            this.btnJazz.Size = new System.Drawing.Size(180, 78);
            this.btnJazz.TabIndex = 3;
            this.btnJazz.Text = "Jazz";
            this.btnJazz.UseVisualStyleBackColor = true;
            this.btnJazz.Click += new System.EventHandler(this.BtnJazz_Click);
            // 
            // btnElectronic
            // 
            this.btnElectronic.Location = new System.Drawing.Point(384, 13);
            this.btnElectronic.Name = "btnElectronic";
            this.btnElectronic.Size = new System.Drawing.Size(180, 78);
            this.btnElectronic.TabIndex = 4;
            this.btnElectronic.Text = "Electronic";
            this.btnElectronic.UseVisualStyleBackColor = true;
            this.btnElectronic.Click += new System.EventHandler(this.BtnElectronic_Click);
            // 
            // btnRnB
            // 
            this.btnRnB.Location = new System.Drawing.Point(384, 97);
            this.btnRnB.Name = "btnRnB";
            this.btnRnB.Size = new System.Drawing.Size(180, 80);
            this.btnRnB.TabIndex = 5;
            this.btnRnB.Text = "RnB";
            this.btnRnB.UseVisualStyleBackColor = true;
            this.btnRnB.Click += new System.EventHandler(this.BtnRnB_Click);
            // 
            // btnClassic
            // 
            this.btnClassic.Location = new System.Drawing.Point(13, 183);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(179, 80);
            this.btnClassic.TabIndex = 6;
            this.btnClassic.Text = "Classic";
            this.btnClassic.UseVisualStyleBackColor = true;
            this.btnClassic.Click += new System.EventHandler(this.BtnClassic_Click);
            // 
            // btnMetal
            // 
            this.btnMetal.Location = new System.Drawing.Point(199, 184);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(179, 80);
            this.btnMetal.TabIndex = 7;
            this.btnMetal.Text = "Metal";
            this.btnMetal.UseVisualStyleBackColor = true;
            this.btnMetal.Click += new System.EventHandler(this.BtnMetal_Click);
            // 
            // btnBlues
            // 
            this.btnBlues.Location = new System.Drawing.Point(384, 184);
            this.btnBlues.Name = "btnBlues";
            this.btnBlues.Size = new System.Drawing.Size(180, 80);
            this.btnBlues.TabIndex = 8;
            this.btnBlues.Text = "Blues";
            this.btnBlues.UseVisualStyleBackColor = true;
            this.btnBlues.Click += new System.EventHandler(this.BtnBlues_Click);
            // 
            // FrmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 284);
            this.Controls.Add(this.btnBlues);
            this.Controls.Add(this.btnMetal);
            this.Controls.Add(this.btnClassic);
            this.Controls.Add(this.btnRnB);
            this.Controls.Add(this.btnElectronic);
            this.Controls.Add(this.btnJazz);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnRap);
            this.Name = "FrmMusic";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.FrmMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRap;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnJazz;
        private System.Windows.Forms.Button btnElectronic;
        private System.Windows.Forms.Button btnRnB;
        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.Button btnMetal;
        private System.Windows.Forms.Button btnBlues;
        private System.Windows.Forms.BindingSource bsMusic;
    }
}