namespace RMS_Project
{
    partial class RequirementListForm
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
            this.RequirementListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RequirementListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RequirementListDataGridView
            // 
            this.RequirementListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequirementListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequirementListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.RequirementListDataGridView.Name = "RequirementListDataGridView";
            this.RequirementListDataGridView.RowTemplate.Height = 24;
            this.RequirementListDataGridView.Size = new System.Drawing.Size(519, 363);
            this.RequirementListDataGridView.TabIndex = 0;
            // 
            // RequirementListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 363);
            this.Controls.Add(this.RequirementListDataGridView);
            this.Name = "RequirementListForm";
            this.Text = "RequirementListForm";
            this.Load += new System.EventHandler(this.TestEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequirementListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RequirementListDataGridView;

    }
}