using Mesen.GUI.Config;
using Mesen.GUI.Forms;
using System;
using System.Windows.Forms;

namespace Mesen.GUI.Debugger
{
   public partial class frmSetScriptTimeout : BaseConfigForm
   {
	  public frmSetScriptTimeout()
	  {
		 InitializeComponent();

		 nudTimeout.Value = ConfigManager.Config.DebugInfo.ScriptTimeout;
	  }

	  protected override void OnShown(EventArgs e)
	  {
		 base.OnShown(e);
		 nudTimeout.Focus();
	  }

	  protected override void OnFormClosed(FormClosedEventArgs e)
	  {
		 base.OnFormClosed(e);
		 if (this.DialogResult == DialogResult.OK)
		 {
			UInt32 count = (UInt32)nudTimeout.Value;
			ConfigManager.Config.DebugInfo.ScriptTimeout = count;
			ConfigManager.ApplyChanges();
			DebugInfo.ApplyConfig();
		 }
	  }
   }
}
