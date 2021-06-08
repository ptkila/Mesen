using System;

namespace Mesen.GUI.Forms
{
   public partial class frmLogWindow : BaseForm
   {
	  private string _currentLog;
	  public frmLogWindow()
	  {
		 InitializeComponent();
	  }

	  protected override void OnLoad(EventArgs e)
	  {
		 base.OnLoad(e);
	  }

	  protected override void OnShown(EventArgs e)
	  {
		 base.OnShown(e);
		 UpdateLog(InteropEmu.GetLog());
	  }

	  private void UpdateLog(string log)
	  {
		 _currentLog = log;
		 txtLog.Text = _currentLog;
		 txtLog.SelectionLength = 0;
		 txtLog.SelectionStart = txtLog.Text.Length;
		 txtLog.ScrollToCaret();
	  }

	  private void btnClose_Click(object sender, EventArgs e)
	  {
		 this.Close();
	  }

	  private void tmrRefresh_Tick(object sender, EventArgs e)
	  {
		 string newLog = InteropEmu.GetLog();
		 if (_currentLog != newLog)
		 {
			UpdateLog(newLog);
		 }
	  }
   }
}
