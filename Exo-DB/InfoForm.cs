using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace EXO_DB
{
	public partial class InfoForm : KryptonForm
	{
		#region Assemblyattributaccessoren

		public string AssemblyTitle
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
				if (attributes.Length > 0)
				{
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title != "")
					{
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

		public string AssemblyDescription
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		public string AssemblyProduct
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		public string AssemblyCopyright
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		public string AssemblyCompany
		{
			get
			{
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
				if (attributes.Length == 0)
				{
					return "";
				}
				return ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}
		#endregion

		public InfoForm()
		{
			InitializeComponent();
			Text = $"Info über {AssemblyTitle}";
			kryptonLabelProductName.Text = AssemblyProduct;
			kryptonLabelVersion.Text = $"Version {AssemblyVersion}";
			kryptonLabelCopyright.Text = AssemblyCopyright;
			kryptonLabelCompanyName.Text = AssemblyCompany;
			kryptonRichTextBoxDescription.Text = AssemblyDescription;
		}

		private void SetStatusbar(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				toolStripStatusLabel.Text = ((TextBox)sender).AccessibleDescription;
			}
			else if (sender is Button)
			{
				toolStripStatusLabel.Text = ((Button)sender).AccessibleDescription;
			}
			else if (sender is RadioButton)
			{
				toolStripStatusLabel.Text = ((RadioButton)sender).AccessibleDescription;
			}
			else if (sender is DateTimePicker)
			{
				toolStripStatusLabel.Text = ((DateTimePicker)sender).AccessibleDescription;
			}
			else if (sender is Label)
			{
				toolStripStatusLabel.Text = ((Label)sender).AccessibleDescription;
			}
			else if (sender is PictureBox)
			{
				toolStripStatusLabel.Text = ((PictureBox)sender).AccessibleDescription;
			}
			else if (sender is ToolStripButton)
			{
				toolStripStatusLabel.Text = ((ToolStripButton)sender).AccessibleDescription;
			}
			else if (sender is ToolStripMenuItem)
			{
				toolStripStatusLabel.Text = ((ToolStripMenuItem)sender).AccessibleDescription;
			}
			else if (sender is ToolStripLabel)
			{
				toolStripStatusLabel.Text = ((ToolStripLabel)sender).AccessibleDescription;
			}
			else if (sender is ToolStripComboBox)
			{
				toolStripStatusLabel.Text = ((ToolStripComboBox)sender).AccessibleDescription;
			}
			else if (sender is ToolStripDropDown)
			{
				toolStripStatusLabel.Text = ((ToolStripDropDown)sender).AccessibleDescription;
			}
			else if (sender is ToolStripDropDownButton)
			{
				toolStripStatusLabel.Text = ((ToolStripDropDownButton)sender).AccessibleDescription;
			}
			else if (sender is ToolStripDropDownItem)
			{
				toolStripStatusLabel.Text = ((ToolStripDropDownItem)sender).AccessibleDescription;
			}
			else if (sender is ToolStripDropDownMenu)
			{
				toolStripStatusLabel.Text = ((ToolStripDropDownMenu)sender).AccessibleDescription;
			}
			else if (sender is ToolStripProgressBar)
			{
				toolStripStatusLabel.Text = ((ToolStripProgressBar)sender).AccessibleDescription;
			}
			else if (sender is ToolStripSplitButton)
			{
				toolStripStatusLabel.Text = ((ToolStripSplitButton)sender).AccessibleDescription;
			}
			else if (sender is ToolStripSeparator)
			{
				toolStripStatusLabel.Text = ((ToolStripSeparator)sender).AccessibleDescription;
			}
			else if (sender is ToolStripStatusLabel)
			{
				toolStripStatusLabel.Text = ((ToolStripStatusLabel)sender).AccessibleDescription;
			}
			else if (sender is ToolStripTextBox)
			{
				toolStripStatusLabel.Text = ((ToolStripTextBox)sender).AccessibleDescription;
			}
			else if (sender is KryptonButton)
			{
				toolStripStatusLabel.Text = ((KryptonButton)sender).AccessibleDescription;
			}
			else if (sender is KryptonPage)
			{
				toolStripStatusLabel.Text = ((KryptonButton)sender).AccessibleDescription;
			}
			else if (sender is KryptonLabel)
			{
				toolStripStatusLabel.Text = ((KryptonLabel)sender).AccessibleDescription;
			}
			else if (sender is KryptonLinkLabel)
			{
				toolStripStatusLabel.Text = ((KryptonLinkLabel)sender).AccessibleDescription;
			}
			else if (sender is KryptonRichTextBox)
			{
				toolStripStatusLabel.Text = ((KryptonRichTextBox)sender).AccessibleDescription;
			}
		}

		private void ClearStatusbar()
		{
			toolStripStatusLabel.Text = string.Empty;
		}

		private void InfoForm_Load(object sender, System.EventArgs e)
		{
			ClearStatusbar();
		}

		#region Enter-Eventhandlers

		private void KryptonLabelProductName_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLabelVersion_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLabelCopyright_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLabelCompanyName_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonRichTextBoxDescription_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLinkLabelWebsite_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLinkLabelGithub_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLinkLabelMail_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonOkay_Enter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region MouseEnter-Eventhandlers

		private void PictureBoxLogo_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLabelProductName_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLabelVersion_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLabelCopyright_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLabelCompanyName_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonRichTextBoxDescription_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLinkLabelWebsite_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLinkLabelGithub_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonLinkLabelMail_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		private void KryptonButtonOkay_MouseEnter(object sender, EventArgs e)
		{
			SetStatusbar(sender: sender, e: e);
		}

		#endregion

		#region Leave-Eventhandlers

		private void KryptonLabelProductName_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLabelVersion_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLabelCopyright_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLabelCompanyName_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonRichTextBoxDescription_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLinkLabelWebsite_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLinkLabelGithub_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLinkLabelMail_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonOkay_Leave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		#endregion

		#region MouseLeave-Eventhandlers

		private void PictureBoxLogo_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLabelProductName_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLabelVersion_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLabelCopyright_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLabelCompanyName_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonRichTextBoxDescription_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLinkLabelWebsite_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLinkLabelGithub_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLinkLabelMail_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonButtonOkay_MouseLeave(object sender, EventArgs e)
		{
			ClearStatusbar();
		}

		private void KryptonLinkLabelWebsite_LinkClicked(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(fileName: "https://exo-db.de");
		}

		private void KryptonLinkLabelGithub_LinkClicked(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(fileName: "https://github.com/mjohne/EXO-DB");
		}

		private void KryptonLinkLabelMail_LinkClicked(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(fileName: "mailto:info@exo-db.de");
		}

		#endregion
	}
}
