
namespace ITMO.CSCourse.WFAppLab1._5
{
    partial class EllipseForm
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
            this.CloseMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseMe
            // 
            this.CloseMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseMe.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CloseMe.Location = new System.Drawing.Point(287, 156);
            this.CloseMe.Name = "CloseMe";
            this.CloseMe.Size = new System.Drawing.Size(87, 39);
            this.CloseMe.TabIndex = 0;
            this.CloseMe.Text = "CloseMe";
            this.CloseMe.UseVisualStyleBackColor = false;
            this.CloseMe.Click += new System.EventHandler(this.CloseMe_Click);
            // 
            // EllipseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(662, 353);
            this.Controls.Add(this.CloseMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EllipseForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "EllipseForm";
            this.Load += new System.EventHandler(this.EllipseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseMe;
    }
}

