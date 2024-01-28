namespace Shop.Design
{
    partial class Workcs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridss1 = new Shop.Design.dataGridss();
            this.SuspendLayout();
            // 
            // dataGridss1
            // 
            this.dataGridss1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridss1.Location = new System.Drawing.Point(157, 43);
            this.dataGridss1.Name = "dataGridss1";
            this.dataGridss1.Size = new System.Drawing.Size(1946, 1106);
            this.dataGridss1.TabIndex = 0;
            // 
            // Workcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridss1);
            this.Name = "Workcs";
            this.Size = new System.Drawing.Size(1627, 875);
            this.Load += new System.EventHandler(this.Workcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private dataGridss dataGridss1;
    }
}
