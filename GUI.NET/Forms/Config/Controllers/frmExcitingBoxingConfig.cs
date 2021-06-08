using Mesen.GUI.Config;
using System;

namespace Mesen.GUI.Forms.Config
{
   public partial class frmExcitingBoxingConfig : BaseInputConfigForm
   {
	  public frmExcitingBoxingConfig(ControllerInfo controllerInfo)
	  {
		 InitializeComponent();

		 if (!this.DesignMode)
		 {
			SetMainTab(this.tabMain);

			Entity = controllerInfo;

			ctrlExcitingBoxingConfig0.Initialize(controllerInfo.Keys[0]);
			ctrlExcitingBoxingConfig1.Initialize(controllerInfo.Keys[1]);
			ctrlExcitingBoxingConfig2.Initialize(controllerInfo.Keys[2]);
			ctrlExcitingBoxingConfig3.Initialize(controllerInfo.Keys[3]);
		 }
	  }

	  private void btnClear_Click(object sender, EventArgs e)
	  {
		 ClearCurrentTab();
	  }

	  private void btnSetDefault_Click(object sender, EventArgs e)
	  {
		 GetControllerControl().Initialize(Presets.ExcitingBoxing);
	  }
   }
}
