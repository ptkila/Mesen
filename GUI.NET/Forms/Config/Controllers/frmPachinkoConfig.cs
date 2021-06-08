using Mesen.GUI.Config;
using System;

namespace Mesen.GUI.Forms.Config
{
   public partial class frmPachinkoConfig : BaseInputConfigForm
   {
	  public frmPachinkoConfig(ControllerInfo controllerInfo)
	  {
		 InitializeComponent();

		 if (!this.DesignMode)
		 {
			SetMainTab(this.tabMain);

			Entity = controllerInfo;

			ctrlPachinkoConfig1.Initialize(controllerInfo.Keys[0]);
			ctrlPachinkoConfig2.Initialize(controllerInfo.Keys[1]);
			ctrlPachinkoConfig3.Initialize(controllerInfo.Keys[2]);
			ctrlPachinkoConfig4.Initialize(controllerInfo.Keys[3]);
		 }
	  }

	  private void btnClear_Click(object sender, EventArgs e)
	  {
		 ClearCurrentTab();
	  }

	  private void btnSetDefault_Click(object sender, EventArgs e)
	  {
		 GetControllerControl().Initialize(Presets.Pachinko);
	  }
   }
}
