namespace Actividad_Oreden_de_Carpetas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlayfiles = new System.Windows.Forms.Button();
            this.btnSortfiles = new System.Windows.Forms.Button();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.vlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayfiles
            // 
            this.btnPlayfiles.Location = new System.Drawing.Point(0, 0);
            this.btnPlayfiles.Name = "btnPlayfiles";
            this.btnPlayfiles.Size = new System.Drawing.Size(75, 23);
            this.btnPlayfiles.TabIndex = 0;
            this.btnPlayfiles.Text = "Play Files";
            this.btnPlayfiles.UseVisualStyleBackColor = true;
            this.btnPlayfiles.Click += new System.EventHandler(this.btnPlayfiles_Click);
            // 
            // btnSortfiles
            // 
            this.btnSortfiles.Location = new System.Drawing.Point(81, 0);
            this.btnSortfiles.Name = "btnSortfiles";
            this.btnSortfiles.Size = new System.Drawing.Size(75, 23);
            this.btnSortfiles.TabIndex = 1;
            this.btnSortfiles.Text = "Sort Files";
            this.btnSortfiles.UseVisualStyleBackColor = true;
            this.btnSortfiles.Click += new System.EventHandler(this.btnSortfiles_Click);
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(0, 29);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(802, 285);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 2;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(0, 320);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(75, 23);
            this.btnReproducir.TabIndex = 3;
            this.btnReproducir.Text = "Play";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.button1_Click);
            // 
            // vlcControl
            // 
            this.vlcControl.BackColor = System.Drawing.Color.Black;
            this.vlcControl.Location = new System.Drawing.Point(0, 0);
            this.vlcControl.Name = "vlcControl";
            this.vlcControl.Size = new System.Drawing.Size(0, 0);
            this.vlcControl.Spu = -1;
            this.vlcControl.TabIndex = 5;
            this.vlcControl.VlcLibDirectory = null;
            this.vlcControl.VlcMediaplayerOptions = null;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(81, 320);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(157, 45);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.btnSortfiles);
            this.Controls.Add(this.btnPlayfiles);
            this.Controls.Add(this.vlcControl);
            this.Name = "Form1";
            this.Text = "Form1";
          
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayfiles;
        private System.Windows.Forms.Button btnSortfiles;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btnReproducir;
        private Vlc.DotNet.Forms.VlcControl vlcControl;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

