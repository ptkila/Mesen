using Mesen.GUI.Forms;
using System;

namespace Mesen.GUI.Debugger
{
   public partial class frmFadeSpeed : BaseConfigForm
   {
	  public frmFadeSpeed(int initialValue)
	  {
		 InitializeComponent();
		 nudFrameCount.Value = initialValue;
	  }

	  public int FadeSpeed
	  {
		 get { return (int)nudFrameCount.Value; }
	  }

	  protected override void OnShown(EventArgs e)
	  {
		 base.OnShown(e);
		 nudFrameCount.Focus();
	  }
   }
}
