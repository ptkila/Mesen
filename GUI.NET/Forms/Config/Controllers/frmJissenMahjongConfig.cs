using Mesen.GUI.Config;
using System;

namespace Mesen.GUI.Forms.Config
{
   public partial class frmJissenMahjongConfig : BaseInputConfigForm
   {
	  public frmJissenMahjongConfig(ControllerInfo controllerInfo)
	  {
		 InitializeComponent();

		 if (!this.DesignMode)
		 {
			SetMainTab(this.tabMain);

			Entity = controllerInfo;

			ctrlJissenMahjongConfig1.Initialize(controllerInfo.Keys[0]);
			ctrlJissenMahjongConfig2.Initialize(controllerInfo.Keys[1]);
			ctrlJissenMahjongConfig3.Initialize(controllerInfo.Keys[2]);
			ctrlJissenMahjongConfig4.Initialize(controllerInfo.Keys[3]);
		 }
	  }

	  private void btnClear_Click(object sender, EventArgs e)
	  {
		 ClearCurrentTab();
	  }

	  private void btnSetDefault_Click(object sender, EventArgs e)
	  {
		 GetControllerControl().Initialize(Presets.JissenMahjong);
	  }
   }
}
