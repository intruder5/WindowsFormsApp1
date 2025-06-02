namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneDragForm1 = new SiticoneNetFrameworkUI.SiticoneDragForm();
            this.siticonePictureBox1 = new SiticoneNetFrameworkUI.SiticonePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.siticoneDragForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragForm1
            // 
            this.siticoneDragForm1.AccessibleDescription = "A panel that allows dragging the parent form.";
            this.siticoneDragForm1.AccessibleName = "Drag Form Panel";
            this.siticoneDragForm1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.siticoneDragForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.siticoneDragForm1.Controls.Add(this.siticonePictureBox1);
            this.siticoneDragForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneDragForm1.ForeColor = System.Drawing.Color.Coral;
            this.siticoneDragForm1.Location = new System.Drawing.Point(0, 0);
            this.siticoneDragForm1.Name = "siticoneDragForm1";
            this.siticoneDragForm1.Size = new System.Drawing.Size(800, 50);
            this.siticoneDragForm1.TabIndex = 0;
            this.siticoneDragForm1.TabStop = true;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.BorderColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.BorderWidth = 0;
            this.siticonePictureBox1.Brightness = 1F;
            this.siticonePictureBox1.Contrast = 1F;
            this.siticonePictureBox1.CornerRadius = 0;
            this.siticonePictureBox1.DraggingSpeed = 3.15F;
            this.siticonePictureBox1.EnableAsyncLoading = false;
            this.siticonePictureBox1.EnableCaching = false;
            this.siticonePictureBox1.EnableDragDrop = false;
            this.siticonePictureBox1.EnableExtendedImageSources = false;
            this.siticonePictureBox1.EnableFilters = false;
            this.siticonePictureBox1.EnableFlipping = false;
            this.siticonePictureBox1.EnableGlow = false;
            this.siticonePictureBox1.EnableHighDpiSupport = false;
            this.siticonePictureBox1.EnableMouseInteraction = false;
            this.siticonePictureBox1.EnablePlaceholder = false;
            this.siticonePictureBox1.EnableRotation = false;
            this.siticonePictureBox1.EnableShadow = false;
            this.siticonePictureBox1.EnableSlideshow = false;
            this.siticonePictureBox1.FlipHorizontal = false;
            this.siticonePictureBox1.FlipVertical = false;
            this.siticonePictureBox1.Grayscale = false;
            this.siticonePictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_snap_24;
            this.siticonePictureBox1.ImageOpacity = 1F;
            this.siticonePictureBox1.Images = ((System.Collections.Generic.List<System.Drawing.Image>)(resources.GetObject("siticonePictureBox1.Images")));
            this.siticonePictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.siticonePictureBox1.IsCircular = false;
            this.siticonePictureBox1.Location = new System.Drawing.Point(12, 12);
            this.siticonePictureBox1.MaintainAspectRatio = true;
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.PlaceholderImage = null;
            this.siticonePictureBox1.RotationAngle = 0F;
            this.siticonePictureBox1.Saturation = 1F;
            this.siticonePictureBox1.ShowBorder = false;
            this.siticonePictureBox1.Size = new System.Drawing.Size(27, 26);
            this.siticonePictureBox1.SizeMode = SiticoneNetFrameworkUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.Text = "siticonePictureBox1";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(61, 98);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(667, 286);
            this.webView21.TabIndex = 1;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.siticoneDragForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.siticoneDragForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneDragForm siticoneDragForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private SiticoneNetFrameworkUI.SiticonePictureBox siticonePictureBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

