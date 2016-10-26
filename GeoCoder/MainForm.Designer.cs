using System;
using System.Windows.Forms;

namespace MultiGeoCoder
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
            this.components = new System.ComponentModel.Container();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.AddressName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MultiAdressLabel = new System.Windows.Forms.Label();
            this.SaveAsTextBox = new System.Windows.Forms.TextBox();
            this.SaveAsPathButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveAsLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.AddressFieldsLabel = new System.Windows.Forms.Label();
            this.AddressMembersDataGridView = new System.Windows.Forms.DataGridView();
            this.AddressMemberCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddressMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ChildSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LocalLabel = new System.Windows.Forms.Label();
            this.LocalComboBox = new System.Windows.Forms.ComboBox();
            this.WorkProgressBar = new System.Windows.Forms.ProgressBar();
            this.AboutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.StopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.DataGridContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddressMembersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChildSplitContainer)).BeginInit();
            this.ChildSplitContainer.Panel1.SuspendLayout();
            this.ChildSplitContainer.Panel2.SuspendLayout();
            this.ChildSplitContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(390, 45);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 20);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddressName});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 16);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.Size = new System.Drawing.Size(427, 199);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_CellMouseClick);
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_KeyDown);
            // 
            // AddressName
            // 
            this.AddressName.ContextMenuStrip = this.DataGridContextMenu;
            this.AddressName.HeaderText = "Address";
            this.AddressName.Name = "AddressName";
            this.AddressName.Width = 70;
            // 
            // DataGridContextMenu
            // 
            this.DataGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.DataGridContextMenu.Name = "DataGridContextMenu";
            this.DataGridContextMenu.Size = new System.Drawing.Size(108, 92);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.CutToolStripMenuItem.Text = "Cut";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // MultiAdressLabel
            // 
            this.MultiAdressLabel.AutoSize = true;
            this.MultiAdressLabel.Location = new System.Drawing.Point(3, 0);
            this.MultiAdressLabel.Name = "MultiAdressLabel";
            this.MultiAdressLabel.Size = new System.Drawing.Size(70, 13);
            this.MultiAdressLabel.TabIndex = 4;
            this.MultiAdressLabel.Text = "Multi Address";
            // 
            // SaveAsTextBox
            // 
            this.SaveAsTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveAsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveAsTextBox.Location = new System.Drawing.Point(3, 16);
            this.SaveAsTextBox.Name = "SaveAsTextBox";
            this.SaveAsTextBox.ReadOnly = true;
            this.SaveAsTextBox.Size = new System.Drawing.Size(396, 20);
            this.SaveAsTextBox.TabIndex = 7;
            this.SaveAsTextBox.TextChanged += new System.EventHandler(this.SaveAsTextBox_TextChanged);
            // 
            // SaveAsPathButton
            // 
            this.SaveAsPathButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveAsPathButton.Location = new System.Drawing.Point(405, 16);
            this.SaveAsPathButton.Name = "SaveAsPathButton";
            this.SaveAsPathButton.Size = new System.Drawing.Size(25, 20);
            this.SaveAsPathButton.TabIndex = 8;
            this.SaveAsPathButton.Text = "...";
            this.SaveAsPathButton.UseVisualStyleBackColor = true;
            this.SaveAsPathButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // SaveAsLabel
            // 
            this.SaveAsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveAsLabel.AutoSize = true;
            this.SaveAsLabel.Location = new System.Drawing.Point(3, 0);
            this.SaveAsLabel.Name = "SaveAsLabel";
            this.SaveAsLabel.Size = new System.Drawing.Size(58, 13);
            this.SaveAsLabel.TabIndex = 9;
            this.SaveAsLabel.Text = "Save as ...";
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Location = new System.Drawing.Point(298, 45);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(40, 20);
            this.RunButton.TabIndex = 10;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // AddressFieldsLabel
            // 
            this.AddressFieldsLabel.AutoSize = true;
            this.AddressFieldsLabel.Location = new System.Drawing.Point(3, 0);
            this.AddressFieldsLabel.Name = "AddressFieldsLabel";
            this.AddressFieldsLabel.Size = new System.Drawing.Size(122, 13);
            this.AddressFieldsLabel.TabIndex = 11;
            this.AddressFieldsLabel.Text = "Saving Addresses Fields";
            // 
            // AddressMembersDataGridView
            // 
            this.AddressMembersDataGridView.AllowUserToAddRows = false;
            this.AddressMembersDataGridView.AllowUserToDeleteRows = false;
            this.AddressMembersDataGridView.AllowUserToResizeColumns = false;
            this.AddressMembersDataGridView.AllowUserToResizeRows = false;
            this.AddressMembersDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AddressMembersDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AddressMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressMembersDataGridView.ColumnHeadersVisible = false;
            this.AddressMembersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddressMemberCheck,
            this.AddressMember});
            this.AddressMembersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressMembersDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.AddressMembersDataGridView.Location = new System.Drawing.Point(3, 16);
            this.AddressMembersDataGridView.Name = "AddressMembersDataGridView";
            this.AddressMembersDataGridView.RowHeadersVisible = false;
            this.AddressMembersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AddressMembersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddressMembersDataGridView.Size = new System.Drawing.Size(427, 206);
            this.AddressMembersDataGridView.TabIndex = 12;
            // 
            // AddressMemberCheck
            // 
            this.AddressMemberCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddressMemberCheck.HeaderText = "AddressMemberCheck";
            this.AddressMemberCheck.Name = "AddressMemberCheck";
            this.AddressMemberCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AddressMemberCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AddressMemberCheck.Width = 5;
            // 
            // AddressMember
            // 
            this.AddressMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.AddressMember.ContextMenuStrip = this.DataGridContextMenu;
            this.AddressMember.HeaderText = "AddressMember";
            this.AddressMember.Name = "AddressMember";
            this.AddressMember.ReadOnly = true;
            this.AddressMember.Width = 5;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplitContainer.IsSplitterFixed = true;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            this.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.ChildSplitContainer);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.LocalLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.LocalComboBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.WorkProgressBar);
            this.MainSplitContainer.Panel2.Controls.Add(this.AboutButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.MainSplitContainer.Panel2.Controls.Add(this.ExitButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.RunButton);
            this.MainSplitContainer.Size = new System.Drawing.Size(433, 528);
            this.MainSplitContainer.SplitterDistance = 447;
            this.MainSplitContainer.TabIndex = 14;
            // 
            // ChildSplitContainer
            // 
            this.ChildSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ChildSplitContainer.Name = "ChildSplitContainer";
            this.ChildSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ChildSplitContainer.Panel1
            // 
            this.ChildSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // ChildSplitContainer.Panel2
            // 
            this.ChildSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.ChildSplitContainer.Size = new System.Drawing.Size(433, 447);
            this.ChildSplitContainer.SplitterDistance = 218;
            this.ChildSplitContainer.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGrid, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MultiAdressLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(433, 218);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.AddressMembersDataGridView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.AddressFieldsLabel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(433, 225);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // LocalLabel
            // 
            this.LocalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalLabel.AutoSize = true;
            this.LocalLabel.Location = new System.Drawing.Point(168, 49);
            this.LocalLabel.Name = "LocalLabel";
            this.LocalLabel.Size = new System.Drawing.Size(58, 13);
            this.LocalLabel.TabIndex = 20;
            this.LocalLabel.Text = "Language:";
            // 
            // LocalComboBox
            // 
            this.LocalComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalComboBox.FormattingEnabled = true;
            this.LocalComboBox.Location = new System.Drawing.Point(232, 44);
            this.LocalComboBox.Name = "LocalComboBox";
            this.LocalComboBox.Size = new System.Drawing.Size(60, 21);
            this.LocalComboBox.TabIndex = 19;
            // 
            // WorkProgressBar
            // 
            this.WorkProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkProgressBar.Location = new System.Drawing.Point(29, 44);
            this.WorkProgressBar.Name = "WorkProgressBar";
            this.WorkProgressBar.Size = new System.Drawing.Size(133, 20);
            this.WorkProgressBar.TabIndex = 18;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(3, 45);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(20, 20);
            this.AboutButton.TabIndex = 17;
            this.AboutButton.Text = "?";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.SaveAsLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.SaveAsPathButton, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.SaveAsTextBox, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(433, 39);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Location = new System.Drawing.Point(344, 496);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(40, 20);
            this.StopButton.TabIndex = 21;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 528);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.MainSplitContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "MainForm";
            this.Text = "Multi GeoCoder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.DataGridContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddressMembersDataGridView)).EndInit();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ChildSplitContainer.Panel1.ResumeLayout(false);
            this.ChildSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChildSplitContainer)).EndInit();
            this.ChildSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label MultiAdressLabel;
        private DataGridViewTextBoxColumn AddressName;
        private ContextMenuStrip DataGridContextMenu;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private ToolStripMenuItem CutToolStripMenuItem;
        private ToolStripMenuItem PasteToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private TextBox SaveAsTextBox;
        private Button SaveAsPathButton;
        private SaveFileDialog saveFileDialog;
        private Label SaveAsLabel;
        private Button RunButton;
        private Label AddressFieldsLabel;
        private DataGridView AddressMembersDataGridView;
        private DataGridViewCheckBoxColumn AddressMemberCheck;
        private DataGridViewTextBoxColumn AddressMember;
        private SplitContainer MainSplitContainer;
        private SplitContainer ChildSplitContainer;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button AboutButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private ProgressBar WorkProgressBar;
        private Label LocalLabel;
        private ComboBox LocalComboBox;
        private Button StopButton;
    }
}

