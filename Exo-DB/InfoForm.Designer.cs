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
			this.kryptonRichTextBoxDescription = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
			this.kryptonLabelCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelCopyright = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.kryptonLabelProductName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
			this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
			this.kryptonPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
			this.kryptonSplitContainer1.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
			this.kryptonSplitContainer1.Panel2.SuspendLayout();
			this.kryptonSplitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// kryptonLinkLabelWebsite
			// 
			this.kryptonLinkLabelWebsite.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
			this.kryptonLinkLabelWebsite.Location = new System.Drawing.Point(12, 199);
			this.kryptonLinkLabelWebsite.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonLinkLabelWebsite.Name = "kryptonLinkLabelWebsite";
			this.kryptonLinkLabelWebsite.Size = new System.Drawing.Size(123, 20);
			this.kryptonLinkLabelWebsite.TabIndex = 7;
			this.kryptonLinkLabelWebsite.Values.Image = global::EXO_DB.Properties.Resources.www_page;
			this.kryptonLinkLabelWebsite.Values.Text = "https://exo-db.de";
			// 
			// kryptonLinkLabelGithub
			// 
			this.kryptonLinkLabelGithub.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
			this.kryptonLinkLabelGithub.Location = new System.Drawing.Point(12, 221);
			this.kryptonLinkLabelGithub.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonLinkLabelGithub.Name = "kryptonLinkLabelGithub";
			this.kryptonLinkLabelGithub.Size = new System.Drawing.Size(221, 20);
			this.kryptonLinkLabelGithub.TabIndex = 8;
			this.kryptonLinkLabelGithub.Values.Image = global::EXO_DB.Properties.Resources.tag;
			this.kryptonLinkLabelGithub.Values.Text = "https://github.com/mjohne/Exo-DB";
			// 
			// kryptonLinkLabelMail
			// 
			this.kryptonLinkLabelMail.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
			this.kryptonLinkLabelMail.Location = new System.Drawing.Point(12, 243);
			this.kryptonLinkLabelMail.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonLinkLabelMail.Name = "kryptonLinkLabelMail";
			this.kryptonLinkLabelMail.Size = new System.Drawing.Size(116, 20);
			this.kryptonLinkLabelMail.TabIndex = 9;
			this.kryptonLinkLabelMail.Values.Image = global::EXO_DB.Properties.Resources.email;
			this.kryptonLinkLabelMail.Values.Text = "info@exo-db.de";
			// 
			// kryptonPanel
			// 
			this.kryptonPanel.Controls.Add(this.kryptonSplitContainer1);
			this.kryptonPanel.Controls.Add(this.statusStrip);
			this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel.Name = "kryptonPanel";
			this.kryptonPanel.Size = new System.Drawing.Size(597, 295);
			this.kryptonPanel.TabIndex = 10;
			// 
			// kryptonRichTextBoxDescription
			// 
			this.kryptonRichTextBoxDescription.AllowButtonSpecToolTips = true;
			this.kryptonRichTextBoxDescription.Location = new System.Drawing.Point(12, 123);
			this.kryptonRichTextBoxDescription.Name = "kryptonRichTextBoxDescription";
			this.kryptonRichTextBoxDescription.ReadOnly = true;
			this.kryptonRichTextBoxDescription.Size = new System.Drawing.Size(287, 73);
			this.kryptonRichTextBoxDescription.TabIndex = 15;
			this.kryptonRichTextBoxDescription.Text = "Description";
			// 
			// kryptonLabelCompanyName
			// 
			this.kryptonLabelCompanyName.Location = new System.Drawing.Point(12, 97);
			this.kryptonLabelCompanyName.Name = "kryptonLabelCompanyName";
			this.kryptonLabelCompanyName.Size = new System.Drawing.Size(99, 20);
			this.kryptonLabelCompanyName.TabIndex = 14;
			this.kryptonLabelCompanyName.Values.Text = "Company Name";
			// 
			// kryptonLabelCopyright
			// 
			this.kryptonLabelCopyright.Location = new System.Drawing.Point(12, 70);
			this.kryptonLabelCopyright.Name = "kryptonLabelCopyright";
			this.kryptonLabelCopyright.Size = new System.Drawing.Size(64, 20);
			this.kryptonLabelCopyright.TabIndex = 13;
			this.kryptonLabelCopyright.Values.Text = "Copyright";
			// 
			// kryptonLabelVersion
			// 
			this.kryptonLabelVersion.Location = new System.Drawing.Point(12, 43);
			this.kryptonLabelVersion.Name = "kryptonLabelVersion";
			this.kryptonLabelVersion.Size = new System.Drawing.Size(51, 20);
			this.kryptonLabelVersion.TabIndex = 12;
			this.kryptonLabelVersion.Values.Text = "Version";
			// 
			// kryptonLabelProductName
			// 
			this.kryptonLabelProductName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
			this.kryptonLabelProductName.Location = new System.Drawing.Point(12, 7);
			this.kryptonLabelProductName.Name = "kryptonLabelProductName";
			this.kryptonLabelProductName.Size = new System.Drawing.Size(138, 29);
			this.kryptonLabelProductName.TabIndex = 11;
			this.kryptonLabelProductName.Values.Text = "Product Name";
			// 
			// statusStrip
			// 
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusStrip.Location = new System.Drawing.Point(0, 273);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(597, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 10;
			this.statusStrip.Text = "statusStrip";
			// 
			// kryptonSplitContainer1
			// 
			this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
			// 
			// kryptonSplitContainer1.Panel1
			// 
			this.kryptonSplitContainer1.Panel1.Controls.Add(this.pictureBoxLogo);
			// 
			// kryptonSplitContainer1.Panel2
			// 
			this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLabelProductName);
			this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonRichTextBoxDescription);
			this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLinkLabelGithub);
			this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLabelCompanyName);
			this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLinkLabelWebsite);
			this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLabelCopyright);
			this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLinkLabelMail);
			this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLabelVersion);
			this.kryptonSplitContainer1.Size = new System.Drawing.Size(597, 273);
			this.kryptonSplitContainer1.SplitterDistance = 284;
			this.kryptonSplitContainer1.TabIndex = 16;
			// 
			// pictureBoxLogo
			// 
			this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxLogo.Image = global::EXO_DB.Properties.Resources.logo_256;
			this.pictureBoxLogo.Location = new System.Drawing.Point(15, 7);
			this.pictureBoxLogo.Name = "pictureBoxLogo";
			this.pictureBoxLogo.Size = new System.Drawing.Size(256, 256);
			this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxLogo.TabIndex = 0;
			this.pictureBoxLogo.TabStop = false;
			// 
			// InfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 295);
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
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
			this.kryptonPanel.ResumeLayout(false);
			this.kryptonPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
			this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
			this.kryptonSplitContainer1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
			this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
			this.kryptonSplitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
			this.kryptonSplitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabelWebsite;
		private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabelGithub;
		private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabelMail;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
		private System.Windows.Forms.StatusStrip statusStrip;
		private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBoxDescription;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCompanyName;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelCopyright;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelVersion;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabelProductName;
		private System.Windows.Forms.ToolTip toolTip;
		private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
	}
}