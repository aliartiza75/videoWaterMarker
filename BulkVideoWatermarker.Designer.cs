namespace YoutubeVideoUploader
{
    partial class BulkVideoWatermarker
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
            this.folder_select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folder_select
            // 
            this.folder_select.Location = new System.Drawing.Point(76, 185);
            this.folder_select.Name = "folder_select";
            this.folder_select.Size = new System.Drawing.Size(114, 23);
            this.folder_select.TabIndex = 0;
            this.folder_select.Text = "Select Folder";
            this.folder_select.UseVisualStyleBackColor = true;
            // 
            // BulkVideoWatermarker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.folder_select);
            this.Name = "BulkVideoWatermarker";
            this.Text = "BulkVideoWatermarker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button folder_select;
    }
}