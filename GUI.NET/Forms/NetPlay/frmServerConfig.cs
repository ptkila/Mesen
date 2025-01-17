﻿using Mesen.GUI.Config;
using System;

namespace Mesen.GUI.Forms.NetPlay
{
   public partial class frmServerConfig : BaseConfigForm
   {
	  public frmServerConfig()
	  {
		 InitializeComponent();

		 this.txtServerName.Text = ConfigManager.Config.ServerInfo.Name;
		 this.txtPort.Text = ConfigManager.Config.ServerInfo.Port.ToString();
		 this.txtPassword.Text = string.Empty;
	  }

	  protected override void UpdateConfig()
	  {
		 ConfigManager.Config.ServerInfo = new ServerInfo()
		 {
			Name = this.txtServerName.Text,
			Port = Convert.ToUInt16(this.txtPort.Text),
			Password = this.txtPassword.Text
		 };
	  }

	  private void Field_ValueChanged(object sender, EventArgs e)
	  {
		 UInt16 port;
		 if (!UInt16.TryParse(this.txtPort.Text, out port))
		 {
			this.btnOK.Enabled = false;
		 }
		 else
		 {
			this.btnOK.Enabled = !string.IsNullOrWhiteSpace(this.txtServerName.Text);
		 }
	  }
   }
}
