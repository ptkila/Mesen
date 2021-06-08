using System.Windows.Forms;

namespace Mesen.GUI.Debugger.Controls.ApuViewer
{
   public partial class ctrlLengthCounterInfo : UserControl
   {
	  public ctrlLengthCounterInfo()
	  {
		 InitializeComponent();
	  }

	  public void ProcessState(ref ApuLengthCounterState state)
	  {
		 chkHalt.Checked = state.Halt;
		 txtCounter.Text = state.Counter.ToString();
		 txtReloadValue.Text = state.ReloadValue.ToString();
	  }
   }
}
