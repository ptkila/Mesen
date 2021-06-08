using Mesen.GUI.Config;
using System;

namespace Mesen.GUI.Forms.Config
{
   public partial class frmVirtualBoyConfig : BaseInputConfigForm
   {
	  public frmVirtualBoyConfig(ControllerInfo controllerInfo, int portNumber)
	  {
		 InitializeComponent();

		 if (!this.DesignMode)
		 {
			SetMainTab(this.tabMain);

			Entity = controllerInfo;

			ctrlVirtualBoyConfig0.Initialize(controllerInfo.Keys[0]);
			ctrlVirtualBoyConfig1.Initialize(controllerInfo.Keys[1]);
			ctrlVirtualBoyConfig2.Initialize(controllerInfo.Keys[2]);
			ctrlVirtualBoyConfig3.Initialize(controllerInfo.Keys[3]);

			this.Text += ": " + ResourceHelper.GetMessage("PlayerNumber", (portNumber + 1).ToString());
		 }
	  }

	  private void btnClear_Click(object sender, EventArgs e)
	  {
		 ClearCurrentTab();
	  }

	  private void btnSetDefault_Click(object sender, EventArgs e)
	  {
		 GetControllerControl().Initialize(Presets.VirtualBoy);
	  }
   }
}
