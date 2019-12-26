using System;
using System.Diagnostics;
using System.Windows.Forms;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using MijoSoftware.AssemblyInformation;

namespace EXO_DB
{
	public partial class InfoForm : KryptonForm
	{
		public InfoForm() => InitializeComponent();

		private void ClearStatusbar() => toolStripStatusLabel.Text = string.Empty;

		private void InfoForm_Load(object sender, EventArgs e)
		{
			Text = $"Info über {AssemblyInfo.AssemblyTitle}";
			kryptonLabelProductName.Text = AssemblyInfo.AssemblyProduct;
			kryptonLabelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			kryptonLabelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			kryptonLabelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			kryptonRichTextBoxDescription.Text = AssemblyInfo.AssemblyDescription;
			ClearStatusbar();
		}

		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				toolStripStatusLabel.Text = control.AccessibleDescription;
			}
			else if (sender is ToolStripButton toolStripButton)
			{
				toolStripStatusLabel.Text = toolStripButton.AccessibleDescription;
			}
			else if (sender is ToolStripMenuItem toolStripMenuItem)
			{
				toolStripStatusLabel.Text = toolStripMenuItem.AccessibleDescription;
			}
			else if (sender is ToolStripLabel toolStripLabel)
			{
				toolStripStatusLabel.Text = toolStripLabel.AccessibleDescription;
			}
			else if (sender is ToolStripComboBox toolStripComboBox)
			{
				toolStripStatusLabel.Text = toolStripComboBox.AccessibleDescription;
			}
			else if (sender is ToolStripDropDown toolStripDropDown)
			{
				toolStripStatusLabel.Text = toolStripDropDown.AccessibleDescription;
			}
			else if (sender is ToolStripDropDownButton toolStripDropDownButton)
			{
				toolStripStatusLabel.Text = toolStripDropDownButton.AccessibleDescription;
			}
			else if (sender is ToolStripDropDownItem toolStripDropDownItem)
			{
				toolStripStatusLabel.Text = toolStripDropDownItem.AccessibleDescription;
			}
			else if (sender is ToolStripDropDownMenu toolStripDropDownMenu)
			{
				toolStripStatusLabel.Text = toolStripDropDownMenu.AccessibleDescription;
			}
			else if (sender is ToolStripProgressBar toolStripProgressBar)
			{
				toolStripStatusLabel.Text = toolStripProgressBar.AccessibleDescription;
			}
			else if (sender is ToolStripSplitButton toolStripSplitButton)
			{
				toolStripStatusLabel.Text = toolStripSplitButton.AccessibleDescription;
			}
			else if (sender is ToolStripSeparator toolStripSeparator)
			{
				toolStripStatusLabel.Text = toolStripSeparator.AccessibleDescription;
			}
			else if (sender is ToolStripStatusLabel toolStripStatusLabel2)
			{
				toolStripStatusLabel.Text = toolStripStatusLabel2.AccessibleDescription;
			}
			else if (sender is ToolStripTextBox toolStripTextBox)
			{
				toolStripStatusLabel.Text = toolStripTextBox.AccessibleDescription;
			}
			else if (sender is KryptonButton kryptonButton)
			{
				toolStripStatusLabel.Text = kryptonButton.AccessibleDescription;
			}
			else if (sender is KryptonPage kryptonPage)
			{
				toolStripStatusLabel.Text = kryptonPage.AccessibleDescription;
			}
			else if (sender is KryptonLabel kryptonLabel)
			{
				toolStripStatusLabel.Text = kryptonLabel.AccessibleDescription;
			}
			else if (sender is KryptonLinkLabel kryptonLinkLabel)
			{
				toolStripStatusLabel.Text = kryptonLinkLabel.AccessibleDescription;
			}
			else if (sender is KryptonRichTextBox kryptonRichTextBox)
			{
				toolStripStatusLabel.Text = kryptonRichTextBox.AccessibleDescription;
			}
		}

		private void ClearStatusbar_Leave(object sender, EventArgs e) => ClearStatusbar();

		private void KryptonLinkLabelWebsite_LinkClicked(object sender, EventArgs e) => Process.Start(fileName: "https://exo-db.de");

		private void KryptonLinkLabelGithub_LinkClicked(object sender, EventArgs e) => Process.Start(fileName: "https://github.com/mjohne/EXO-DB");

		private void KryptonLinkLabelMail_LinkClicked(object sender, EventArgs e) => Process.Start(fileName: "mailto:info@exo-db.de");
	}
}
