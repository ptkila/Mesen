using Mesen.GUI.Config;
using Mesen.GUI.Forms;
using System;
using System.Windows.Forms;

namespace Mesen.GUI.Debugger
{
   public partial class frmBreakOn : BaseConfigForm
   {
	  public frmBreakOn()
	  {
		 InitializeComponent();

		 nudCount.Value = ConfigManager.Config.DebugInfo.BreakOnValue;
	  }

	  protected override void OnShown(EventArgs e)
	  {
		 base.OnShown(e);
		 nudCount.Focus();
	  }

	  protected override void OnFormClosed(FormClosedEventArgs e)
	  {
		 base.OnFormClosed(e);
		 if (this.DialogResult == DialogResult.OK)
		 {
			int count = (int)nudCount.Value;
			ConfigManager.Config.DebugInfo.BreakOnValue = count;
			InteropEmu.DebugRun();
			InteropEmu.DebugBreakOnScanline(count);
			ConfigManager.ApplyChanges();
		 }
	  }
   }
}
