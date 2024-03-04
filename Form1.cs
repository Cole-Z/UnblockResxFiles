using System;
using System.Drawing;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Diagnostics;

namespace UnblockResxFiles
{
	public partial class Form1 : Form
	{
		private Timer timer;
		private int progressBarMaxValue = 100;
		private int progressBarIncrement = 10; 
		private int timerInterval = 300; // 3 seconds
		private string directoryPath;

		public Form1()
		{
			InitializeComponent();
			InitializeTimer();
		}

		private void InitializeTimer()
		{
			timer = new Timer();
			timer.Interval = timerInterval;
			timer.Tick += Timer_Tick;
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			using (var folderBrowserDialog = new FolderBrowserDialog())
			{
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					directoryPath = folderBrowserDialog.SelectedPath;
					directoryTextBox.Text = directoryPath;
				}
			}
		}

		private void UnblockResxFiles(string directoryPath)
		{
			string[] resxFiles = Directory.GetFiles(directoryPath, "*.resx", SearchOption.AllDirectories);

			foreach (string resxFile in resxFiles)
			{
				UnblockFile(resxFile);
			}
		}

		// unblock the path to the folder containg the .resx file with pwrshell
		private void UnblockFile(string filePath)
		{
			try
			{
				ProcessStartInfo psi = new ProcessStartInfo("powershell.exe")
				{
					Arguments = $"-Command \"Unblock-File '{filePath}'\"",
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true
				};

				Process process = Process.Start(psi);
				process.WaitForExit();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error unblocking file {filePath}: {ex.Message}");
				btnProgressLbl.Text = "Failed";
				btnProgressLbl.BackColor = Color.Salmon;
			}
		}


		private void unblockButton_Click_1(object sender, EventArgs e)
		{
			string directoryPath = directoryTextBox.Text;

			if (string.IsNullOrEmpty(directoryPath) || !Directory.Exists(directoryPath))
			{
				MessageBox.Show("Please select a valid directory.");
				return;
			}

			// check if directory contains .resx files
			string[] resxFiles = Directory.GetFiles(directoryPath, "*.resx", SearchOption.AllDirectories);
			if (resxFiles.Length == 0)
			{
				btnProgressLbl.ForeColor= Color.Salmon;
				btnProgressLbl.Text = "Incorrect Folder";
				MessageBox.Show("The selected directory does not contain any .resx files.");
				return;
			}
			progressBar1.Value = 0; 
			timer.Start();
		}


		private void progressBar1_Click(object sender, EventArgs e)
		{
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			btnProgressLbl.Text = "Searching Files";
			progressBar1.BackColor = Color.Blue;

			if (progressBar1.Value < progressBarMaxValue)
			{
				progressBar1.Value += progressBarIncrement;
			}
			else
			{
				timer.Stop();

				UnblockResxFiles(directoryPath);
				MessageBox.Show("Unblocking complete.");
				btnProgressLbl.Text = "Complete";
				btnProgressLbl.ForeColor = Color.Lime;
			}
		}

		private void directoryTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
