using Mesen.GUI.Config;
using System;

namespace Mesen.GUI.Forms.Config
{
   public partial class frmSuborKeyboardConfig : BaseInputConfigForm
   {
	  public frmSuborKeyboardConfig(ControllerInfo controllerInfo)
	  {
		 InitializeComponent();

		 if (!this.DesignMode)
		 {
			SetMainTab(this.tabMain);

			Entity = controllerInfo;

			ctrlSuborKeyboardConfig1.Initialize(controllerInfo.Keys[0]);
			ctrlSuborKeyboardConfig2.Initialize(controllerInfo.Keys[1]);
			ctrlSuborKeyboardConfig3.Initialize(controllerInfo.Keys[2]);
			ctrlSuborKeyboardConfig4.Initialize(controllerInfo.Keys[3]);
		 }
	  }

	  private void btnClear_Click(object sender, EventArgs e)
	  {
		 ClearCurrentTab();
	  }

	  private void btnSetDefault_Click(object sender, EventArgs e)
	  {
		 GetControllerControl().Initialize(Presets.SuborKeyboard);
	  }
   }
}
