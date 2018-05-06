namespace ResourceMigration
{
    partial class MainForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Assembly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromResx = new System.Windows.Forms.Button();
            this.fromDatabase = new System.Windows.Forms.Button();
            this.toDatabase = new System.Windows.Forms.Button();
            this.totalRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assembly,
            this.ResourceType,
            this.ResourceName,
            this.EN,
            this.ES,
            this.FR,
            this.PT});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(813, 386);
            this.dataGridView.TabIndex = 0;
            // 
            // Assembly
            // 
            this.Assembly.Frozen = true;
            this.Assembly.HeaderText = "Assembly";
            this.Assembly.Name = "Assembly";
            this.Assembly.ReadOnly = true;
            this.Assembly.Width = 76;
            // 
            // ResourceType
            // 
            this.ResourceType.Frozen = true;
            this.ResourceType.HeaderText = "Resource Type";
            this.ResourceType.Name = "ResourceType";
            this.ResourceType.ReadOnly = true;
            this.ResourceType.Width = 96;
            // 
            // ResourceName
            // 
            this.ResourceName.Frozen = true;
            this.ResourceName.HeaderText = "Resource Name";
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.ReadOnly = true;
            // 
            // EN
            // 
            this.EN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EN.HeaderText = "EN-GB";
            this.EN.Name = "EN";
            // 
            // ES
            // 
            this.ES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ES.HeaderText = "ES";
            this.ES.Name = "ES";
            // 
            // FR
            // 
            this.FR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FR.HeaderText = "FR";
            this.FR.Name = "FR";
            // 
            // PT
            // 
            this.PT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PT.HeaderText = "PT";
            this.PT.Name = "PT";
            // 
            // fromResx
            // 
            this.fromResx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fromResx.Location = new System.Drawing.Point(50, 440);
            this.fromResx.Name = "fromResx";
            this.fromResx.Size = new System.Drawing.Size(100, 23);
            this.fromResx.TabIndex = 1;
            this.fromResx.Text = "From ResX";
            this.fromResx.UseVisualStyleBackColor = true;
            this.fromResx.Click += new System.EventHandler(this.fromResx_Click);
            // 
            // fromDatabase
            // 
            this.fromDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fromDatabase.Location = new System.Drawing.Point(334, 440);
            this.fromDatabase.Name = "fromDatabase";
            this.fromDatabase.Size = new System.Drawing.Size(100, 23);
            this.fromDatabase.TabIndex = 2;
            this.fromDatabase.Text = "From Database";
            this.fromDatabase.UseVisualStyleBackColor = true;
            this.fromDatabase.Click += new System.EventHandler(this.fromDatabase_Click);
            // 
            // toDatabase
            // 
            this.toDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toDatabase.Location = new System.Drawing.Point(662, 440);
            this.toDatabase.Name = "toDatabase";
            this.toDatabase.Size = new System.Drawing.Size(100, 23);
            this.toDatabase.TabIndex = 3;
            this.toDatabase.Text = "To Database";
            this.toDatabase.UseVisualStyleBackColor = true;
            this.toDatabase.Click += new System.EventHandler(this.toDatabase_Click);
            // 
            // totalRows
            // 
            this.totalRows.AutoSize = true;
            this.totalRows.Location = new System.Drawing.Point(13, 393);
            this.totalRows.Name = "totalRows";
            this.totalRows.Size = new System.Drawing.Size(35, 13);
            this.totalRows.TabIndex = 4;
            this.totalRows.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 483);
            this.Controls.Add(this.totalRows);
            this.Controls.Add(this.toDatabase);
            this.Controls.Add(this.fromDatabase);
            this.Controls.Add(this.fromResx);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button fromResx;
        private System.Windows.Forms.Button fromDatabase;
        private System.Windows.Forms.Button toDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assembly;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ES;
        private System.Windows.Forms.DataGridViewTextBoxColumn FR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PT;
        private System.Windows.Forms.Label totalRows;
    }
}

