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
            this.label2 = new System.Windows.Forms.Label();
            this.refreshA = new System.Windows.Forms.Button();
            this.searchA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SPPtable = new System.Windows.Forms.DataGridView();
            this.AStable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SPPtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AStable)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPPtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SPPtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SPPtable.DefaultCellStyle = dataGridViewCellStyle2;
            this.SPPtable.Location = new System.Drawing.Point(1880, 24);
            this.SPPtable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SPPtable.MultiSelect = false;
            this.SPPtable.Name = "SPPtable";
            this.SPPtable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPPtable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SPPtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SPPtable.Size = new System.Drawing.Size(10, 10);
            this.SPPtable.TabIndex = 82;
            // 
            // AStable
            // 
            this.AStable.AllowUserToAddRows = false;
            this.AStable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.AStable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AStable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AStable.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.AStable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AStable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AStable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AStable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AStable.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AStable.DefaultCellStyle = dataGridViewCellStyle6;
            this.AStable.EnableHeadersVisualStyles = false;
            this.AStable.GridColor = System.Drawing.Color.WhiteSmoke;
            this.AStable.Location = new System.Drawing.Point(0, 110);
            this.AStable.Name = "AStable";
            this.AStable.RowTemplate.DividerHeight = 3;
            this.AStable.RowTemplate.Height = 30;
            this.AStable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AStable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AStable.Size = new System.Drawing.Size(1482, 616);
            this.AStable.TabIndex = 113;
            this.AStable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AStable);
            this.Controls.Add(this.SPPtable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshA);
            this.Controls.Add(this.searchA);
            this.Name = "ProductSale";
            this.Size = new System.Drawing.Size(1946, 1106);
            this.Load += new System.EventHandler(this.ProductSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPPtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AStable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshA;
        private System.Windows.Forms.TextBox searchA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SPPtable;
        private System.Windows.Forms.DataGridView AStable;
    }
}
