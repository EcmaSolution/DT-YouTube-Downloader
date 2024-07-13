﻿namespace MyApplication;

partial class MainForm
{
	private System.ComponentModel.IContainer components = null;

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
		downloadButton = new Button();
		targetPathTextBox = new TextBox();
		youTubeVideoIdTextBox = new TextBox();
		targetPathLabel = new Label();
		youTubeVideoIdLabel = new Label();
		detectButton = new Button();
		ffmpegPathNameLabel = new Label();
		ffmpegPathNameTextBox = new TextBox();
		headerPanel = new Panel();
		myMenuStrip = new MenuStrip();
		detailsPanel = new Panel();
		footerPanel = new Panel();
		videoTitleTextBox = new TextBox();
		gridViewPanel = new Panel();
		myDataGridView = new DataGridView();
		downloadVideoCheckBox = new CheckBox();
		downloadCaptionCheckBox = new CheckBox();
		headerPanel.SuspendLayout();
		footerPanel.SuspendLayout();
		gridViewPanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)myDataGridView).BeginInit();
		SuspendLayout();
		// 
		// downloadButton
		// 
		downloadButton.Location = new Point(177, 6);
		downloadButton.Name = "downloadButton";
		downloadButton.Size = new Size(151, 29);
		downloadButton.TabIndex = 2;
		downloadButton.Text = "&2 - Download";
		downloadButton.UseVisualStyleBackColor = true;
		downloadButton.Click += DownloadButton_Click;
		// 
		// targetPathTextBox
		// 
		targetPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		targetPathTextBox.Location = new Point(147, 3);
		targetPathTextBox.Name = "targetPathTextBox";
		targetPathTextBox.Size = new Size(1157, 27);
		targetPathTextBox.TabIndex = 1;
		targetPathTextBox.Text = "D:\\YouTubeDownloads";
		// 
		// youTubeVideoIdTextBox
		// 
		youTubeVideoIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		youTubeVideoIdTextBox.Location = new Point(147, 69);
		youTubeVideoIdTextBox.Name = "youTubeVideoIdTextBox";
		youTubeVideoIdTextBox.Size = new Size(1157, 27);
		youTubeVideoIdTextBox.TabIndex = 5;
		youTubeVideoIdTextBox.TextChanged += YouTubeVideoIdTextBox_TextChanged;
		youTubeVideoIdTextBox.DoubleClick += YouTubeVideoIdTextBox_DoubleClick;
		youTubeVideoIdTextBox.Enter += YouTubeVideoIdTextBox_Enter;
		// 
		// targetPathLabel
		// 
		targetPathLabel.AutoSize = true;
		targetPathLabel.Location = new Point(3, 6);
		targetPathLabel.Name = "targetPathLabel";
		targetPathLabel.Size = new Size(82, 20);
		targetPathLabel.TabIndex = 0;
		targetPathLabel.Text = "&Target Path";
		// 
		// youTubeVideoIdLabel
		// 
		youTubeVideoIdLabel.AutoSize = true;
		youTubeVideoIdLabel.Location = new Point(3, 72);
		youTubeVideoIdLabel.Name = "youTubeVideoIdLabel";
		youTubeVideoIdLabel.Size = new Size(128, 20);
		youTubeVideoIdLabel.TabIndex = 4;
		youTubeVideoIdLabel.Text = "&YouTube Video ID";
		// 
		// detectButton
		// 
		detectButton.Location = new Point(147, 102);
		detectButton.Name = "detectButton";
		detectButton.Size = new Size(151, 29);
		detectButton.TabIndex = 6;
		detectButton.Text = "&1 - Detect";
		detectButton.UseVisualStyleBackColor = true;
		detectButton.Click += DetectButton_Click;
		// 
		// ffmpegPathNameLabel
		// 
		ffmpegPathNameLabel.AutoSize = true;
		ffmpegPathNameLabel.Location = new Point(3, 39);
		ffmpegPathNameLabel.Name = "ffmpegPathNameLabel";
		ffmpegPathNameLabel.Size = new Size(138, 20);
		ffmpegPathNameLabel.TabIndex = 2;
		ffmpegPathNameLabel.Text = "&FFMpeg Path Name";
		// 
		// ffmpegPathNameTextBox
		// 
		ffmpegPathNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		ffmpegPathNameTextBox.Location = new Point(147, 36);
		ffmpegPathNameTextBox.Name = "ffmpegPathNameTextBox";
		ffmpegPathNameTextBox.Size = new Size(1157, 27);
		ffmpegPathNameTextBox.TabIndex = 3;
		ffmpegPathNameTextBox.Text = "D:\\Download\\FFMpeg\\ffmpeg-windows-x64\\ffmpeg.exe";
		// 
		// headerPanel
		// 
		headerPanel.Controls.Add(targetPathTextBox);
		headerPanel.Controls.Add(ffmpegPathNameTextBox);
		headerPanel.Controls.Add(ffmpegPathNameLabel);
		headerPanel.Controls.Add(youTubeVideoIdTextBox);
		headerPanel.Controls.Add(targetPathLabel);
		headerPanel.Controls.Add(detectButton);
		headerPanel.Controls.Add(youTubeVideoIdLabel);
		headerPanel.Dock = DockStyle.Top;
		headerPanel.Location = new Point(0, 24);
		headerPanel.Name = "headerPanel";
		headerPanel.Size = new Size(1307, 138);
		headerPanel.TabIndex = 1;
		// 
		// myMenuStrip
		// 
		myMenuStrip.ImageScalingSize = new Size(20, 20);
		myMenuStrip.Location = new Point(0, 0);
		myMenuStrip.Name = "myMenuStrip";
		myMenuStrip.Size = new Size(1307, 24);
		myMenuStrip.TabIndex = 0;
		myMenuStrip.Text = "menuStrip1";
		// 
		// detailsPanel
		// 
		detailsPanel.Dock = DockStyle.Top;
		detailsPanel.Location = new Point(0, 162);
		detailsPanel.Name = "detailsPanel";
		detailsPanel.Size = new Size(1307, 13);
		detailsPanel.TabIndex = 2;
		// 
		// footerPanel
		// 
		footerPanel.Controls.Add(downloadCaptionCheckBox);
		footerPanel.Controls.Add(downloadVideoCheckBox);
		footerPanel.Controls.Add(videoTitleTextBox);
		footerPanel.Controls.Add(downloadButton);
		footerPanel.Dock = DockStyle.Bottom;
		footerPanel.Location = new Point(0, 669);
		footerPanel.Name = "footerPanel";
		footerPanel.Size = new Size(1307, 41);
		footerPanel.TabIndex = 3;
		// 
		// videoTitleTextBox
		// 
		videoTitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		videoTitleTextBox.Location = new Point(334, 6);
		videoTitleTextBox.Name = "videoTitleTextBox";
		videoTitleTextBox.ReadOnly = true;
		videoTitleTextBox.Size = new Size(961, 27);
		videoTitleTextBox.TabIndex = 3;
		videoTitleTextBox.Visible = false;
		// 
		// gridViewPanel
		// 
		gridViewPanel.Controls.Add(myDataGridView);
		gridViewPanel.Dock = DockStyle.Fill;
		gridViewPanel.Location = new Point(0, 175);
		gridViewPanel.Name = "gridViewPanel";
		gridViewPanel.Size = new Size(1307, 494);
		gridViewPanel.TabIndex = 13;
		// 
		// myDataGridView
		// 
		myDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		myDataGridView.Dock = DockStyle.Fill;
		myDataGridView.Location = new Point(0, 0);
		myDataGridView.Name = "myDataGridView";
		myDataGridView.RowHeadersWidth = 51;
		myDataGridView.Size = new Size(1307, 494);
		myDataGridView.TabIndex = 0;
		// 
		// downloadVideoCheckBox
		// 
		downloadVideoCheckBox.AutoSize = true;
		downloadVideoCheckBox.Checked = true;
		downloadVideoCheckBox.CheckState = CheckState.Checked;
		downloadVideoCheckBox.Location = new Point(12, 8);
		downloadVideoCheckBox.Name = "downloadVideoCheckBox";
		downloadVideoCheckBox.Size = new Size(70, 24);
		downloadVideoCheckBox.TabIndex = 0;
		downloadVideoCheckBox.Text = "Video";
		downloadVideoCheckBox.UseVisualStyleBackColor = true;
		// 
		// downloadCaptionCheckBox
		// 
		downloadCaptionCheckBox.AutoSize = true;
		downloadCaptionCheckBox.Checked = true;
		downloadCaptionCheckBox.CheckState = CheckState.Checked;
		downloadCaptionCheckBox.Location = new Point(88, 8);
		downloadCaptionCheckBox.Name = "downloadCaptionCheckBox";
		downloadCaptionCheckBox.Size = new Size(83, 24);
		downloadCaptionCheckBox.TabIndex = 1;
		downloadCaptionCheckBox.Text = "Caption";
		downloadCaptionCheckBox.UseVisualStyleBackColor = true;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(8F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1307, 710);
		Controls.Add(gridViewPanel);
		Controls.Add(footerPanel);
		Controls.Add(detailsPanel);
		Controls.Add(headerPanel);
		Controls.Add(myMenuStrip);
		MainMenuStrip = myMenuStrip;
		Name = "MainForm";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "DT YouTube Downloader! - Version 2.2";
		Load += Form_Load;
		headerPanel.ResumeLayout(false);
		headerPanel.PerformLayout();
		footerPanel.ResumeLayout(false);
		footerPanel.PerformLayout();
		gridViewPanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)myDataGridView).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button downloadButton;
	private TextBox targetPathTextBox;
	private TextBox youTubeVideoIdTextBox;
	private Label targetPathLabel;
	private Label youTubeVideoIdLabel;
	private Button detectButton;
	private Label ffmpegPathNameLabel;
	private TextBox ffmpegPathNameTextBox;
	private Panel headerPanel;
	private MenuStrip myMenuStrip;
	private Panel detailsPanel;
	private Panel footerPanel;
	private Panel gridViewPanel;
	private DataGridView myDataGridView;
	private TextBox videoTitleTextBox;
	private CheckBox downloadCaptionCheckBox;
	private CheckBox downloadVideoCheckBox;
}
