using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HK_Multisave
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            RefreshSaves();
        }

        private void RefreshSaves()
        {
            if (!Directory.Exists(Settings.SavesPath))
            {
                MessageBox.Show("Missing Hollow Knight saves path, is the game installed?");
                return;
            }

            LoadedSavesBox.Items.Clear();
            BackupSavesBox.Items.Clear();

            foreach (string save in HKSaves.ListLoadedSaves())
            {
                LoadedSavesBox.Items.Add(save);
            }

            if (!Directory.Exists(Settings.BackupSavesPath))
            {
                Directory.CreateDirectory(Settings.BackupSavesPath);
                return;
            }

            foreach (string save in HKSaves.ListBackupSaves())
            {
                BackupSavesBox.Items.Add(save.Split('\\').Last().Split('.')[0]);
            }
        }

        private void RefreshSavesBtn_Click(object sender, EventArgs e)
        {
            RefreshSaves(); 
        }

        private void LoadedSavesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadedSavesBox.SelectedItem == null) { return; }

            string SelectedSave = LoadedSavesBox.SelectedItem.ToString();
            string saveFilePath = HKSaves.SlotToFile(SelectedSave);

            SlotTitleLabel.Text = SelectedSave;
            CreatedAtLabel.Text = $"Created at      : {File.GetCreationTime(saveFilePath)}";
            LastUpdateLabel.Text = $"Last Updated : {File.GetLastWriteTime(saveFilePath)}";
        }

        private void DeleteSaveBtn_Click(object sender, EventArgs e)
        {
            if (LoadedSavesBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "No save slot selected to delete",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "You are about to wipe the selected save slot. This operation cannot be reversed, are you sure?", 
                "Wipe Save?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result.ToString() != "Yes") { return; }

            string SelectedSave = LoadedSavesBox.SelectedItem.ToString();
            string saveFilePath = HKSaves.SlotToFile(SelectedSave);

            File.Delete(saveFilePath);

            RefreshSaves();
        }

        private void BackupSaveBtn_Click(object sender, EventArgs e)
        {
            if (LoadedSavesBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "No save slot selected to backup",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string SelectedSave = LoadedSavesBox.SelectedItem.ToString();
            string saveFilePath = HKSaves.SlotToFile(SelectedSave);

            if (!HKSaves.ValidateString(SaveBackupNameBox.Text))
            {
                MessageBox.Show(
                    "Invalid backup name\nFilename cannot contain / \\ : * ? \" < > |",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            File.Copy(saveFilePath, Settings.BackupSavesPath + "/" + SaveBackupNameBox.Text + ".dat");

            RefreshSaves();
        }

        private void DeleteBackupBtn_Click(object sender, EventArgs e)
        {
            if (BackupSavesBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "No backup selected to delete",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "You are about to delete the selected backup. This operation cannot be reversed, are you sure?",
                "Delete backup?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result.ToString() != "Yes") { return; }

            File.Delete(Settings.BackupSavesPath + "/" + BackupSavesBox.SelectedItem + ".dat");

            RefreshSaves();
        }

        private void LoadBackupBtn_Click(object sender, EventArgs e)
        {
            if (BackupSavesBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "No backup selected to load",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                $"This will destroy the current save in Slot {SlotNumberSelect.Value} and replace it with the selected backup.\n" +
                $"This action cannot be reversed, it is suggested to make sure you have a backup of the current save state before loading a backup\n" +
                $"Are you sure you want to load the selected backup?",
                "Load backup?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result.ToString() != "Yes") { return; }

            File.Copy(
                Settings.BackupSavesPath + "/" + BackupSavesBox.SelectedItem + ".dat", 
                HKSaves.SlotToFile($"Slot {SlotNumberSelect.Value}"),
                true
            );

            RefreshSaves();
        }
    }
}
