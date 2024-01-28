namespace Shop.Design
{
    partial class ProductSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AStable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshA = new System.Windows.Forms.Button();
            this.searchA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SPPtable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AStable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPPtable)).BeginInit();
            this.SuspendLayout();
            // 
            // AStable
            // 
            this.AStable.AllowUserToAddRows = false;
            this.AStable.AllowUserToDeleteRows = false;
            this.AStable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AStable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AStable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.AStable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AStable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AStable.ColumnHeadersHeight = 15;
            this.AStable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AStable.DefaultCellStyle = dataGridViewCellStyle2;
            this.AStable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AStable.Location = new System.Drawing.Point(0, 113);
            this.AStable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AStable.MultiSelect = false;
            this.AStable.Name = "AStable";
            this.AStable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AStable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AStable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AStable.Size = new System.Drawing.Size(1847, 993);
            this.AStable.TabIndex = 28;
            this.AStable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AStable_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 45);
            this.label2.TabIndex = 30;
            this.label2.Text = "Product sold";
            // 
            // refreshA
            // 
            this.refreshA.BackColor = System.Drawing.Color.FloralWhite;
            this.refreshA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshA.ForeColor = System.Drawing.Color.Red;
            this.refreshA.Location = new System.Drawing.Point(1174, 41);
            this.refreshA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshA.Name = "refreshA";
            this.refreshA.Size = new System.Drawing.Size(120, 46);
            this.refreshA.TabIndex = 29;
            this.refreshA.Text = "Refresh";
            this.refreshA.UseVisualStyleBackColor = false;
            this.refreshA.Click += new System.EventHandler(this.refreshA_Click_1);
            // 
            // searchA
            // 
            this.searchA.BackColor = System.Drawing.Color.LightGray;
            this.searchA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchA.Location = new System.Drawing.Point(825, 54);
            this.searchA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchA.Name = "searchA";
            this.searchA.Size = new System.Drawing.Size(289, 33);
            this.searchA.TabIndex = 27;
            this.searchA.TextChanged += new System.EventHandler(this.searchA_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(676, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Search";
            // 
            // SPPtable
            // 
            this.SPPtable.AllowUserToAddRows = false;
            this.SPPtable.AllowUserToDeleteRows = false;
            this.SPPtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SPPtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SPPtable.BackgroundColor = System.Drawing.Color.White;
            this.SPPtable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SPPtable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPPtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SPPtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SPPtable.DefaultCellStyle = dataGridViewCellStyle5;
            this.SPPtable.Location = new System.Drawing.Point(1880, 24);
            this.SPPtable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SPPtable.MultiSelect = false;
            this.SPPtable.Name = "SPPtable";
            this.SPPtable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPPtable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.SPPtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SPPtable.Size = new System.Drawing.Size(10, 10);
            this.SPPtable.TabIndex = 82;
            // 
            // ProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SPPtable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AStable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshA);
            this.Controls.Add(this.searchA);
            this.Name = "ProductSale";
            this.Size = new System.Drawing.Size(1946, 1106);
            this.Load += new System.EventHandler(this.ProductSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AStable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPPtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AStable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshA;
        private System.Windows.Forms.TextBox searchA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SPPtable;
    }
}
