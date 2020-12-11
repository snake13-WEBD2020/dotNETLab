namespace FormsApp
{
    partial class PointForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSortbtnSort = new System.Windows.Forms.Button();
            this.btnSerialize1 = new System.Windows.Forms.Button();
            this.btnDeserialize1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(28, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(599, 225);
            this.listBox.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(31, 275);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 48);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // btnSortbtnSort
            // 
            this.btnSortbtnSort.Location = new System.Drawing.Point(193, 275);
            this.btnSortbtnSort.Name = "btnSortbtnSort";
            this.btnSortbtnSort.Size = new System.Drawing.Size(111, 48);
            this.btnSortbtnSort.TabIndex = 2;
            this.btnSortbtnSort.Text = "Sort";
            this.btnSortbtnSort.UseVisualStyleBackColor = true;
            this.btnSortbtnSort.Click += new System.EventHandler(this.btnSortbtnSort_Click);
            // 
            // btnSerialize1
            // 
            this.btnSerialize1.Location = new System.Drawing.Point(358, 275);
            this.btnSerialize1.Name = "btnSerialize1";
            this.btnSerialize1.Size = new System.Drawing.Size(107, 48);
            this.btnSerialize1.TabIndex = 3;
            this.btnSerialize1.Text = "Serialize";
            this.btnSerialize1.UseVisualStyleBackColor = true;
            this.btnSerialize1.Click += new System.EventHandler(this.btnSerialize1_Click_1);
            // 
            // btnDeserialize1
            // 
            this.btnDeserialize1.Location = new System.Drawing.Point(519, 275);
            this.btnDeserialize1.Name = "btnDeserialize1";
            this.btnDeserialize1.Size = new System.Drawing.Size(107, 48);
            this.btnDeserialize1.TabIndex = 4;
            this.btnDeserialize1.Text = "Deserialize";
            this.btnDeserialize1.UseVisualStyleBackColor = true;
            this.btnDeserialize1.Click += new System.EventHandler(this.btnDeserialize1_Click);
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 381);
            this.Controls.Add(this.btnDeserialize1);
            this.Controls.Add(this.btnSerialize1);
            this.Controls.Add(this.btnSortbtnSort);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.listBox);
            this.Name = "PointForm";
            this.Text = "PointForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSortbtnSort;
        private System.Windows.Forms.Button btnSerialize1;
        private System.Windows.Forms.Button btnDeserialize1;
    }
}