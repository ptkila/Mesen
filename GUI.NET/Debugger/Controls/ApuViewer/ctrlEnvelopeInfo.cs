using System.Windows.Forms;

namespace Mesen.GUI.Debugger.Controls.ApuViewer
{
   public partial class ctrlEnvelopeInfo : UserControl
   {
	  public ctrlEnvelopeInfo()
	  {
		 InitializeComponent();
	  }

	  public void ProcessState(ref ApuEnvelopeState state)
	  {
		 chkStart.Checked = state.StartFlag;
		 chkLoop.Checked = state.Loop;
		 chkConstantVolume.Checked = state.ConstantVolume;
		 txtCounter.Text = state.Counter.ToString();
		 txtDivider.Text = state.Divider.ToString();
		 txtVolume.Text = state.Volume.ToString();
	  }
   }
}
