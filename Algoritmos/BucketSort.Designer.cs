namespace Algoritmos
{
    partial class BucketSort
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
            btnBucketSort = new Button();
            txtOrder = new TextBox();
            lstvOrder = new ListView();
            lstvBucket = new ListView();
            btnBucketSortClose = new Button();
            SuspendLayout();
            // 
            // btnBucketSort
            // 
            btnBucketSort.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBucketSort.Location = new Point(126, 259);
            btnBucketSort.Margin = new Padding(3, 4, 3, 4);
            btnBucketSort.Name = "btnBucketSort";
            btnBucketSort.Size = new Size(139, 43);
            btnBucketSort.TabIndex = 0;
            btnBucketSort.Text = "Bucket Sort ";
            btnBucketSort.UseVisualStyleBackColor = true;
            btnBucketSort.Click += btnBucketSort_Click;
            // 
            // txtOrder
            // 
            txtOrder.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrder.Location = new Point(31, 176);
            txtOrder.Margin = new Padding(3, 4, 3, 4);
            txtOrder.Multiline = true;
            txtOrder.Name = "txtOrder";
            txtOrder.ReadOnly = true;
            txtOrder.ScrollBars = ScrollBars.Vertical;
            txtOrder.Size = new Size(337, 73);
            txtOrder.TabIndex = 1;
            // 
            // lstvOrder
            // 
            lstvOrder.Location = new Point(393, 236);
            lstvOrder.Margin = new Padding(3, 4, 3, 4);
            lstvOrder.Name = "lstvOrder";
            lstvOrder.Size = new Size(359, 300);
            lstvOrder.TabIndex = 2;
            lstvOrder.UseCompatibleStateImageBehavior = false;
            // 
            // lstvBucket
            // 
            lstvBucket.Location = new Point(427, 16);
            lstvBucket.Margin = new Padding(3, 4, 3, 4);
            lstvBucket.Name = "lstvBucket";
            lstvBucket.Size = new Size(291, 211);
            lstvBucket.TabIndex = 3;
            lstvBucket.UseCompatibleStateImageBehavior = false;
            // 
            // btnBucketSortClose
            // 
            btnBucketSortClose.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBucketSortClose.Location = new Point(126, 324);
            btnBucketSortClose.Margin = new Padding(3, 4, 3, 4);
            btnBucketSortClose.Name = "btnBucketSortClose";
            btnBucketSortClose.Size = new Size(139, 43);
            btnBucketSortClose.TabIndex = 4;
            btnBucketSortClose.Text = "Close";
            btnBucketSortClose.UseVisualStyleBackColor = true;
            btnBucketSortClose.Click += btnBucketSortClose_Click;
            // 
            // BucketSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 605);
            Controls.Add(btnBucketSortClose);
            Controls.Add(lstvBucket);
            Controls.Add(lstvOrder);
            Controls.Add(txtOrder);
            Controls.Add(btnBucketSort);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BucketSort";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBucketSort;
        private TextBox txtOrder;
        private ListView lstvOrder;
        private ListView lstvBucket;
        private Button btnBucketSortClose;
    }
}