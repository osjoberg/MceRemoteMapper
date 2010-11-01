using System;
using System.Windows.Forms;

namespace MceRemoteMapper
{
    /// <summary>
    /// Event handling for main application window.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Remote instance.
        /// </summary>
        private Remote remote;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler for form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad(object sender, EventArgs e)
        {
            // Setup data grid view.
            var idColumn = new DataGridViewTextBoxColumn {HeaderText = "Id", DataPropertyName = "Id", Width = 50};
            var remoteButtonColumn = new DataGridViewTextBoxColumn { HeaderText = "Remote Button", DataPropertyName = "RemoteButton", Width = 150};
            var shiftColumn = new DataGridViewCheckBoxColumn { HeaderText = "Shift", DataPropertyName = "Shift", Width = 50 };
            var controlColumn = new DataGridViewCheckBoxColumn { HeaderText = "Control", DataPropertyName = "Control", Width = 50 };
            var altColumn = new DataGridViewCheckBoxColumn { HeaderText = "Alt", DataPropertyName = "Alt", Width = 50 };
            var windowsColumn = new DataGridViewCheckBoxColumn { HeaderText = "Windows", DataPropertyName = "Windows", Width = 50 };
            var keyCodeColumn = new DataGridViewComboBoxColumn { HeaderText = "Key", DataPropertyName = "ScanCode", DataSource = Enum.GetValues(typeof(ScanCode)), Width = 150};

            remote = new Remote();
            dataGridViewMappings.AutoGenerateColumns = false;
            dataGridViewMappings.Columns.AddRange(idColumn, remoteButtonColumn, shiftColumn, controlColumn, altColumn, windowsColumn, keyCodeColumn);
            dataGridViewMappings.DataSource = remote.Mappings;
        }

        /// <summary>
        /// Handler for exit click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handler for apply click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonApplyClick(object sender, EventArgs e)
        {
            remote.Save();
            MessageBox.Show(this, "Settings was applied to the registry successfully. Please reboot your computer for the settings to take affect.", "Please reboot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
