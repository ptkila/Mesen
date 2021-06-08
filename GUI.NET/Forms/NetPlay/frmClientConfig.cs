using Mesen.GUI.Config;
using System;

namespace Mesen.GUI.Forms.NetPlay
{
   public partial class frmClientConfig : BaseConfigForm
   {
	  public frmClientConfig()
	  {
		 InitializeComponent();

		 Entity = ConfigManager.Config.ClientConnectionInfo;

		 AddBinding("Host", this.txtHost);
		 AddBinding("Password", this.txtPassword);
		 AddBinding("Spectator", chkSpectator);
		 this.txtPort.Text = ConfigManager.Config.ClientConnectionInfo.Port.ToString();
	  }

	  protected override void UpdateConfig()
	  {
		 ((ClientConnectionInfo)Entity).Port = Convert.ToUInt16(this.txtPort.Text);
	  }

	  private void Field_TextChanged(object sender, EventArgs e)
	  {
		 UInt16 port;
		 if (!UInt16.TryParse(this.txtPort.Text, out port))
		 {
			this.btnOK.Enabled = false;
		 }
		 else
		 {
			this.btnOK.Enabled = !string.IsNullOrWhiteSpace(this.txtHost.Text);
		 }
	  }
   }
}
