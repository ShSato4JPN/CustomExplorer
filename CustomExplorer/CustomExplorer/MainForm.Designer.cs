
namespace CustomExplorer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SubButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExplorerList = new System.Windows.Forms.DataGridView();
            this.ExpImageCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExpNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerList)).BeginInit();
            this.SuspendLayout();
            // 
            // SubButton
            // 
            this.SubButton.Location = new System.Drawing.Point(226, 12);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(40, 40);
            this.SubButton.TabIndex = 1;
            this.SubButton.Text = "ー";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(272, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(40, 40);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "＋";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExplorerList
            // 
            this.ExplorerList.AllowUserToAddRows = false;
            this.ExplorerList.AllowUserToResizeColumns = false;
            this.ExplorerList.AllowUserToResizeRows = false;
            this.ExplorerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExplorerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExplorerList.ColumnHeadersVisible = false;
            this.ExplorerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpImageCol,
            this.ExpNameCol,
            this.ExpTypeCol});
            this.ExplorerList.Location = new System.Drawing.Point(12, 58);
            this.ExplorerList.MultiSelect = false;
            this.ExplorerList.Name = "ExplorerList";
            this.ExplorerList.RowHeadersVisible = false;
            this.ExplorerList.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ExplorerList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ExplorerList.RowTemplate.Height = 20;
            this.ExplorerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExplorerList.Size = new System.Drawing.Size(300, 733);
            this.ExplorerList.TabIndex = 4;
            this.ExplorerList.TabStop = false;
            this.ExplorerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerList_CellClick);
            this.ExplorerList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.ExplorerList_RowPrePaint);
            this.ExplorerList.SelectionChanged += new System.EventHandler(this.ExplorerList_SelectionChanged);
            this.ExplorerList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExplorerList_KeyDown);
            // 
            // ExpImageCol
            // 
            this.ExpImageCol.HeaderText = "image";
            this.ExpImageCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ExpImageCol.MinimumWidth = 50;
            this.ExpImageCol.Name = "ExpImageCol";
            this.ExpImageCol.ReadOnly = true;
            this.ExpImageCol.Width = 50;
            // 
            // ExpNameCol
            // 
            this.ExpNameCol.HeaderText = "name";
            this.ExpNameCol.MinimumWidth = 6;
            this.ExpNameCol.Name = "ExpNameCol";
            this.ExpNameCol.ReadOnly = true;
            this.ExpNameCol.Width = 250;
            // 
            // ExpTypeCol
            // 
            this.ExpTypeCol.HeaderText = "type";
            this.ExpTypeCol.MinimumWidth = 6;
            this.ExpTypeCol.Name = "ExpTypeCol";
            this.ExpTypeCol.ReadOnly = true;
            this.ExpTypeCol.Visible = false;
            this.ExpTypeCol.Width = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 803);
            this.Controls.Add(this.ExplorerList);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView ExplorerList;
        private System.Windows.Forms.DataGridViewImageColumn ExpImageCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpTypeCol;
    }
}

