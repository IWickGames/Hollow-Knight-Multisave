
namespace HK_Multisave
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BackupSavesBox = new System.Windows.Forms.ListBox();
            this.RefreshSavesBtn = new System.Windows.Forms.Button();
            this.LoadedSavesBox = new System.Windows.Forms.ListBox();
            this.SlotTitleLabel = new System.Windows.Forms.Label();
            this.CreatedAtLabel = new System.Windows.Forms.Label();
            this.LastUpdateLabel = new System.Windows.Forms.Label();
            this.DeleteSaveBtn = new System.Windows.Forms.Button();
            this.BackupSaveBtn = new System.Windows.Forms.Button();
            this.SaveBackupNameBox = new System.Windows.Forms.TextBox();
            this.DeleteBackupBtn = new System.Windows.Forms.Button();
            this.SlotNumberSelect = new System.Windows.Forms.NumericUpDown();
            this.LoadBackupBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SlotNumberSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // BackupSavesBox
            // 
            this.BackupSavesBox.FormattingEnabled = true;
            this.BackupSavesBox.Location = new System.Drawing.Point(253, 13);
            this.BackupSavesBox.Name = "BackupSavesBox";
            this.BackupSavesBox.Size = new System.Drawing.Size(423, 355);
            this.BackupSavesBox.TabIndex = 0;
            // 
            // RefreshSavesBtn
            // 
            this.RefreshSavesBtn.Location = new System.Drawing.Point(12, 373);
            this.RefreshSavesBtn.Name = "RefreshSavesBtn";
            this.RefreshSavesBtn.Size = new System.Drawing.Size(664, 23);
            this.RefreshSavesBtn.TabIndex = 1;
            this.RefreshSavesBtn.Text = "Refresh Saves";
            this.RefreshSavesBtn.UseVisualStyleBackColor = true;
            this.RefreshSavesBtn.Click += new System.EventHandler(this.RefreshSavesBtn_Click);
            // 
            // LoadedSavesBox
            // 
            this.LoadedSavesBox.FormattingEnabled = true;
            this.LoadedSavesBox.Location = new System.Drawing.Point(13, 13);
            this.LoadedSavesBox.Name = "LoadedSavesBox";
            this.LoadedSavesBox.Size = new System.Drawing.Size(234, 160);
            this.LoadedSavesBox.TabIndex = 2;
            this.LoadedSavesBox.SelectedIndexChanged += new System.EventHandler(this.LoadedSavesBox_SelectedIndexChanged);
            // 
            // SlotTitleLabel
            // 
            this.SlotTitleLabel.AutoSize = true;
            this.SlotTitleLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotTitleLabel.Location = new System.Drawing.Point(12, 176);
            this.SlotTitleLabel.Name = "SlotTitleLabel";
            this.SlotTitleLabel.Size = new System.Drawing.Size(145, 24);
            this.SlotTitleLabel.TabIndex = 3;
            this.SlotTitleLabel.Text = "Select a save";
            // 
            // CreatedAtLabel
            // 
            this.CreatedAtLabel.AutoSize = true;
            this.CreatedAtLabel.Location = new System.Drawing.Point(16, 204);
            this.CreatedAtLabel.Name = "CreatedAtLabel";
            this.CreatedAtLabel.Size = new System.Drawing.Size(80, 13);
            this.CreatedAtLabel.TabIndex = 4;
            this.CreatedAtLabel.Text = "Created at      : ";
            // 
            // LastUpdateLabel
            // 
            this.LastUpdateLabel.AutoSize = true;
            this.LastUpdateLabel.Location = new System.Drawing.Point(16, 218);
            this.LastUpdateLabel.Name = "LastUpdateLabel";
            this.LastUpdateLabel.Size = new System.Drawing.Size(80, 13);
            this.LastUpdateLabel.TabIndex = 5;
            this.LastUpdateLabel.Text = "Last Updated : ";
            // 
            // DeleteSaveBtn
            // 
            this.DeleteSaveBtn.Location = new System.Drawing.Point(16, 235);
            this.DeleteSaveBtn.Name = "DeleteSaveBtn";
            this.DeleteSaveBtn.Size = new System.Drawing.Size(116, 23);
            this.DeleteSaveBtn.TabIndex = 6;
            this.DeleteSaveBtn.Text = "Delete";
            this.DeleteSaveBtn.UseVisualStyleBackColor = true;
            this.DeleteSaveBtn.Click += new System.EventHandler(this.DeleteSaveBtn_Click);
            // 
            // BackupSaveBtn
            // 
            this.BackupSaveBtn.Location = new System.Drawing.Point(139, 235);
            this.BackupSaveBtn.Name = "BackupSaveBtn";
            this.BackupSaveBtn.Size = new System.Drawing.Size(108, 23);
            this.BackupSaveBtn.TabIndex = 7;
            this.BackupSaveBtn.Text = "Backup";
            this.BackupSaveBtn.UseVisualStyleBackColor = true;
            this.BackupSaveBtn.Click += new System.EventHandler(this.BackupSaveBtn_Click);
            // 
            // SaveBackupNameBox
            // 
            this.SaveBackupNameBox.Location = new System.Drawing.Point(16, 263);
            this.SaveBackupNameBox.Name = "SaveBackupNameBox";
            this.SaveBackupNameBox.Size = new System.Drawing.Size(231, 20);
            this.SaveBackupNameBox.TabIndex = 8;
            this.SaveBackupNameBox.Text = "Backup Name";
            // 
            // DeleteBackupBtn
            // 
            this.DeleteBackupBtn.Location = new System.Drawing.Point(16, 290);
            this.DeleteBackupBtn.Name = "DeleteBackupBtn";
            this.DeleteBackupBtn.Size = new System.Drawing.Size(231, 23);
            this.DeleteBackupBtn.TabIndex = 9;
            this.DeleteBackupBtn.Text = "Delete Backup";
            this.DeleteBackupBtn.UseVisualStyleBackColor = true;
            this.DeleteBackupBtn.Click += new System.EventHandler(this.DeleteBackupBtn_Click);
            // 
            // SlotNumberSelect
            // 
            this.SlotNumberSelect.Location = new System.Drawing.Point(187, 347);
            this.SlotNumberSelect.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SlotNumberSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SlotNumberSelect.Name = "SlotNumberSelect";
            this.SlotNumberSelect.Size = new System.Drawing.Size(60, 20);
            this.SlotNumberSelect.TabIndex = 10;
            this.SlotNumberSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LoadBackupBtn
            // 
            this.LoadBackupBtn.Location = new System.Drawing.Point(16, 346);
            this.LoadBackupBtn.Name = "LoadBackupBtn";
            this.LoadBackupBtn.Size = new System.Drawing.Size(165, 22);
            this.LoadBackupBtn.TabIndex = 11;
            this.LoadBackupBtn.Text = "Load Backup";
            this.LoadBackupBtn.UseVisualStyleBackColor = true;
            this.LoadBackupBtn.Click += new System.EventHandler(this.LoadBackupBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 402);
            this.Controls.Add(this.LoadBackupBtn);
            this.Controls.Add(this.SlotNumberSelect);
            this.Controls.Add(this.DeleteBackupBtn);
            this.Controls.Add(this.SaveBackupNameBox);
            this.Controls.Add(this.BackupSaveBtn);
            this.Controls.Add(this.DeleteSaveBtn);
            this.Controls.Add(this.LastUpdateLabel);
            this.Controls.Add(this.CreatedAtLabel);
            this.Controls.Add(this.SlotTitleLabel);
            this.Controls.Add(this.LoadedSavesBox);
            this.Controls.Add(this.RefreshSavesBtn);
            this.Controls.Add(this.BackupSavesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Hollow Knight Multisave";
            ((System.ComponentModel.ISupportInitialize)(this.SlotNumberSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BackupSavesBox;
        private System.Windows.Forms.Button RefreshSavesBtn;
        private System.Windows.Forms.ListBox LoadedSavesBox;
        private System.Windows.Forms.Label SlotTitleLabel;
        private System.Windows.Forms.Label CreatedAtLabel;
        private System.Windows.Forms.Label LastUpdateLabel;
        private System.Windows.Forms.Button DeleteSaveBtn;
        private System.Windows.Forms.Button BackupSaveBtn;
        private System.Windows.Forms.TextBox SaveBackupNameBox;
        private System.Windows.Forms.Button DeleteBackupBtn;
        private System.Windows.Forms.NumericUpDown SlotNumberSelect;
        private System.Windows.Forms.Button LoadBackupBtn;
    }
}

