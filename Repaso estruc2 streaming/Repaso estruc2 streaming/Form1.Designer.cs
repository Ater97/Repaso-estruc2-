namespace Repaso_estruc2_streaming
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
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Create_Song = new System.Windows.Forms.Button();
            this.Create_Playlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(12, 12);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(91, 23);
            this.Uploadbtn.TabIndex = 0;
            this.Uploadbtn.Text = "Cargar Canciones";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            // 
            // Create_Song
            // 
            this.Create_Song.Location = new System.Drawing.Point(12, 41);
            this.Create_Song.Name = "Create_Song";
            this.Create_Song.Size = new System.Drawing.Size(91, 23);
            this.Create_Song.TabIndex = 1;
            this.Create_Song.Text = "Cargar cancion";
            this.Create_Song.UseVisualStyleBackColor = true;
            // 
            // Create_Playlist
            // 
            this.Create_Playlist.Location = new System.Drawing.Point(12, 70);
            this.Create_Playlist.Name = "Create_Playlist";
            this.Create_Playlist.Size = new System.Drawing.Size(91, 23);
            this.Create_Playlist.TabIndex = 2;
            this.Create_Playlist.Text = "Crear Playlist";
            this.Create_Playlist.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Create_Playlist);
            this.Controls.Add(this.Create_Song);
            this.Controls.Add(this.Uploadbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.Button Create_Song;
        private System.Windows.Forms.Button Create_Playlist;
    }
}

