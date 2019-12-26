using ComponentFactory.Krypton.Toolkit;

namespace EXO_DB
{
	partial class InfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
			this.kryptonLinkLabelWebsite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
			this.kryptonLinkLabelGithub = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
			this.kryptonLinkLabelMail = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
			this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.kryptonSplitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			this.kryptonButtonOkay = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonLabelProductName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonRichTextBoxDescription = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
			this.kryptonLabelCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelCopyright = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer.Panel1)).BeginInit();
			this.kryptonSplitContainer.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer.Panel2)).BeginInit();
			this.kryptonSplitContainer.Panel2.SuspendLayout();
			this.kryptonSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// kryptonLinkLabelWebsite
			// 
			this.kryptonLinkLabelWebsite.AccessibleDescription = "Öffnet die Webseite der Anwendung";
			this.kryptonLinkLabelWebsite.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.kryptonLinkLabelWebsite.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
			this.kryptonLinkLabelWebsite.Location = new System.Drawing.Point(12, 199);
			this.kryptonLinkLabelWebsite.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonLinkLabelWebsite.Name = "kryptonLinkLabelWebsite";
			this.kryptonLinkLabelWebsite.Size = new System.Drawing.Size(123, 20);
			this.kryptonLinkLabelWebsite.TabIndex = 5;
			this.toolTip.SetToolTip(this.kryptonLinkLabelWebsite, "Webseite der Anwendung");
			this.kryptonLinkLabelWebsite.Values.Image = global::EXO_DB.Properties.Resources.www_page;
			this.kryptonLinkLabelWebsite.Values.Text = "https://exo-db.de";
			this.kryptonLinkLabelWebsite.LinkClicked += new System.EventHandler(this.KryptonLinkLabelWebsite_LinkClicked);
			this.kryptonLinkLabelWebsite.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLinkLabelWebsite.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLinkLabelWebsite.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLinkLabelWebsite.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLinkLabelGithub
			// 
			this.kryptonLinkLabelGithub.AccessibleDescription = "Öffnet die Entwicklerseite der Anwendung";
			this.kryptonLinkLabelGithub.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.kryptonLinkLabelGithub.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
			this.kryptonLinkLabelGithub.Location = new System.Drawing.Point(12, 221);
			this.kryptonLinkLabelGithub.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonLinkLabelGithub.Name = "kryptonLinkLabelGithub";
			this.kryptonLinkLabelGithub.Size = new System.Drawing.Size(224, 20);
			this.kryptonLinkLabelGithub.TabIndex = 6;
			this.toolTip.SetToolTip(this.kryptonLinkLabelGithub, "Entwicklerseite der Anwendung");
			this.kryptonLinkLabelGithub.Values.Image = global::EXO_DB.Properties.Resources.tag;
			this.kryptonLinkLabelGithub.Values.Text = "https://github.com/mjohne/EXO-DB";
			this.kryptonLinkLabelGithub.LinkClicked += new System.EventHandler(this.KryptonLinkLabelGithub_LinkClicked);
			this.kryptonLinkLabelGithub.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLinkLabelGithub.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLinkLabelGithub.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLinkLabelGithub.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLinkLabelMail
			// 
			this.kryptonLinkLabelMail.AccessibleDescription = "Öffnet eine neue Mail für die Mailadresse der Anwendung";
			this.kryptonLinkLabelMail.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
			this.kryptonLinkLabelMail.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
			this.kryptonLinkLabelMail.Location = new System.Drawing.Point(12, 243);
			this.kryptonLinkLabelMail.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonLinkLabelMail.Name = "kryptonLinkLabelMail";
			this.kryptonLinkLabelMail.Size = new System.Drawing.Size(116, 20);
			this.kryptonLinkLabelMail.TabIndex = 7;
			this.toolTip.SetToolTip(this.kryptonLinkLabelMail, "Mailadresse der Anwendung");
			this.kryptonLinkLabelMail.Values.Image = global::EXO_DB.Properties.Resources.email;
			this.kryptonLinkLabelMail.Values.Text = "info@exo-db.de";
			this.kryptonLinkLabelMail.LinkClicked += new System.EventHandler(this.KryptonLinkLabelMail_LinkClicked);
			this.kryptonLinkLabelMail.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLinkLabelMail.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLinkLabelMail.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLinkLabelMail.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.kryptonPanel.Controls.Add(this.kryptonSplitContainer);
			this.kryptonPanel.Controls.Add(this.statusStrip);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(597, 321);
			this.kryptonPanel.TabIndex = 10;
			// 
			// kryptonSplitContainer
			// 
			this.kryptonSplitContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.kryptonSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
			this.kryptonSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.kryptonSplitContainer.Name = "kryptonSplitContainer";
			// 
			// kryptonSplitContainer.Panel1
			// 
			this.kryptonSplitContainer.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.kryptonSplitContainer.Panel1.Controls.Add(this.pictureBoxLogo);
			// 
			// kryptonSplitContainer.Panel2
			// 
			this.kryptonSplitContainer.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonButtonOkay);
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonLabelProductName);
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonRichTextBoxDescription);
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonLinkLabelGithub);
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonLabelCompanyName);
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonLinkLabelWebsite);
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonLabelCopyright);
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonLinkLabelMail);
			this.kryptonSplitContainer.Panel2.Controls.Add(this.kryptonLabelVersion);
			this.kryptonSplitContainer.Size = new System.Drawing.Size(597, 299);
			this.kryptonSplitContainer.SplitterDistance = 284;
			this.kryptonSplitContainer.TabIndex = 0;
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.AccessibleDescription = "Zeigt das Logo der Anwendung an";
			this.pictureBoxLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxLogo.Image = global::EXO_DB.Properties.Resources.logo_256;
			this.pictureBoxLogo.Location = new System.Drawing.Point(15, 7);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(256, 256);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxLogo.TabIndex = 0;
			this.pictureBoxLogo.TabStop = false;
			this.pictureBoxLogo.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.pictureBoxLogo.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonButtonOkay
			// 
			this.kryptonButtonOkay.AccessibleDescription = "Schließt die Anwendung";
			this.kryptonButtonOkay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.kryptonButtonOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.kryptonButtonOkay.Location = new System.Drawing.Point(215, 271);
			this.kryptonButtonOkay.Name = "kryptonButtonOkay";
			this.kryptonButtonOkay.Size = new System.Drawing.Size(90, 25);
			this.kryptonButtonOkay.TabIndex = 8;
			this.toolTip.SetToolTip(this.kryptonButtonOkay, "Okay");
			this.kryptonButtonOkay.Values.Image = global::EXO_DB.Properties.Resources.accept_button;
			this.kryptonButtonOkay.Values.Text = "&Okay";
			this.kryptonButtonOkay.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonOkay.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonButtonOkay.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonButtonOkay.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelProductName
			// 
			this.kryptonLabelProductName.AccessibleDescription = "Zeigt den Produktname an";
			this.kryptonLabelProductName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelProductName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
			this.kryptonLabelProductName.Location = new System.Drawing.Point(12, 7);
			this.kryptonLabelProductName.Name = "kryptonLabelProductName";
			this.kryptonLabelProductName.Size = new System.Drawing.Size(138, 29);
			this.kryptonLabelProductName.TabIndex = 0;
			this.toolTip.SetToolTip(this.kryptonLabelProductName, "Produktname der Anwendung");
			this.kryptonLabelProductName.Values.Text = "Product Name";
			this.kryptonLabelProductName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelProductName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelProductName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelProductName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonRichTextBoxDescription
			// 
			this.kryptonRichTextBoxDescription.AccessibleDescription = "Zeigt die Beschreibung der Anwendung an";
			this.kryptonRichTextBoxDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.kryptonRichTextBoxDescription.AllowButtonSpecToolTips = true;
			this.kryptonRichTextBoxDescription.Location = new System.Drawing.Point(12, 123);
			this.kryptonRichTextBoxDescription.Name = "kryptonRichTextBoxDescription";
			this.kryptonRichTextBoxDescription.ReadOnly = true;
			this.kryptonRichTextBoxDescription.Size = new System.Drawing.Size(287, 73);
			this.kryptonRichTextBoxDescription.TabIndex = 4;
			this.kryptonRichTextBoxDescription.Text = "Description";
			this.toolTip.SetToolTip(this.kryptonRichTextBoxDescription, "Beschreibung der Anwendung");
			this.kryptonRichTextBoxDescription.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonRichTextBoxDescription.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonRichTextBoxDescription.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonRichTextBoxDescription.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelCompanyName
			// 
			this.kryptonLabelCompanyName.AccessibleDescription = "Zeit den Namen des Herstellers an";
			this.kryptonLabelCompanyName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelCompanyName.Location = new System.Drawing.Point(12, 97);
			this.kryptonLabelCompanyName.Name = "kryptonLabelCompanyName";
			this.kryptonLabelCompanyName.Size = new System.Drawing.Size(99, 20);
			this.kryptonLabelCompanyName.TabIndex = 3;
			this.toolTip.SetToolTip(this.kryptonLabelCompanyName, "Name des Herstellers der Anwendung");
			this.kryptonLabelCompanyName.Values.Text = "Company Name";
			this.kryptonLabelCompanyName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelCompanyName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelCompanyName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelCompanyName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelCopyright
			// 
			this.kryptonLabelCopyright.AccessibleDescription = "Zeigt den Copyrightvermerk an";
			this.kryptonLabelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelCopyright.Location = new System.Drawing.Point(12, 70);
			this.kryptonLabelCopyright.Name = "kryptonLabelCopyright";
			this.kryptonLabelCopyright.Size = new System.Drawing.Size(64, 20);
			this.kryptonLabelCopyright.TabIndex = 2;
			this.toolTip.SetToolTip(this.kryptonLabelCopyright, "Copyrightvermerk der Anwendung");
			this.kryptonLabelCopyright.Values.Text = "Copyright";
			this.kryptonLabelCopyright.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelCopyright.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelCopyright.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelCopyright.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// kryptonLabelVersion
			// 
			this.kryptonLabelVersion.AccessibleDescription = "Zeit die Versionsnummer an";
			this.kryptonLabelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.kryptonLabelVersion.Location = new System.Drawing.Point(12, 43);
			this.kryptonLabelVersion.Name = "kryptonLabelVersion";
			this.kryptonLabelVersion.Size = new System.Drawing.Size(51, 20);
			this.kryptonLabelVersion.TabIndex = 1;
			this.toolTip.SetToolTip(this.kryptonLabelVersion, "Versionsnummer der Anwendung");
			this.kryptonLabelVersion.Values.Text = "Version";
			this.kryptonLabelVersion.Enter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelVersion.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
			this.kryptonLabelVersion.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
			this.kryptonLabelVersion.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 299);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(597, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AccessibleDescription = "Hier stehen einige Hilfstexte.";
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.AutoToolTip = true;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(158, 17);
			this.toolStripStatusLabel.Text = "Hier stehen einige Hilfstexte.";
			this.toolStripStatusLabel.ToolTipText = "What da fuck?!";
			// 
			// InfoForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AllowButtonSpecToolTips = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 321);
			this.Controls.Add(this.kryptonPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InfoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Information";
			this.TextExtra = "";
			this.Load += new System.EventHandler(this.InfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			this.kryptonPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer.Panel1)).EndInit();
			this.kryptonSplitContainer.Panel1.ResumeLayout(false);
			this.kryptonSplitContainer.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer.Panel2)).EndInit();
			this.kryptonSplitContainer.Panel2.ResumeLayout(false);
			this.kryptonSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer)).EndInit();
			this.kryptonSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private KryptonLinkLabel kryptonLinkLabelWebsite;
		private KryptonLinkLabel kryptonLinkLabelGithub;
		private KryptonLinkLabel kryptonLinkLabelMail;
		private KryptonPanel kryptonPanel;
		private System.Windows.Forms.StatusStrip statusStrip;
		private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxDescription;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCompanyName;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCopyright;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelVersion;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelProductName;
		private System.Windows.Forms.ToolTip toolTip;
		private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonOkay;
	}
}