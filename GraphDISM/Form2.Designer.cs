namespace GraphDISM
{
    partial class FormInfoExt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoExt));
            this.txtOutputExt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOutputExt
            // 
            this.txtOutputExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputExt.Location = new System.Drawing.Point(12, 12);
            this.txtOutputExt.Multiline = true;
            this.txtOutputExt.Name = "txtOutputExt";
            this.txtOutputExt.ReadOnly = true;
            this.txtOutputExt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutputExt.Size = new System.Drawing.Size(529, 602);
            this.txtOutputExt.TabIndex = 0;
            // 
            // FormInfoExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 626);
            this.Controls.Add(this.txtOutputExt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfoExt";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sortie Secondaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtOutputExt;
    }
}