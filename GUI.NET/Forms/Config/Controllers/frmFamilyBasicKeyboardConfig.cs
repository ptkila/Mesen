using Mesen.GUI.Config;
using System;

namespace Mesen.GUI.Forms.Config
{
   public partial class frmFamilyBasicKeyboardConfig : BaseInputConfigForm
   {
	  public frmFamilyBasicKeyboardConfig(ControllerInfo controllerInfo)
	  {
		 InitializeComponent();

		 if (!this.DesignMode)
		 {
			SetMainTab(this.tabMain);

			Entity = controllerInfo;

			ctrlFamilyBasicKeyboardConfig1.Initialize(controllerInfo.Keys[0]);
			ctrlFamilyBasicKeyboardConfig2.Initialize(controllerInfo.Keys[1]);
			ctrlFamilyBasicKeyboardConfig3.Initialize(controllerInfo.Keys[2]);
			ctrlFamilyBasicKeyboardConfig4.Initialize(controllerInfo.Keys[3]);
		 }
	  }

	  private void btnClear_Click(object sender, EventArgs e)
	  {
		 ClearCurrentTab();
	  }

	  private void btnSetDefault_Click(object sender, EventArgs e)
	  {
		 GetControllerControl().Initialize(Presets.FamilyBasic);
	  }
   }
}
