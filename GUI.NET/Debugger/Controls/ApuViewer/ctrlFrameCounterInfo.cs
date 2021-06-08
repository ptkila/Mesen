using System.Windows.Forms;

namespace Mesen.GUI.Debugger.Controls
{
   public partial class ctrlFrameCounterInfo : UserControl
   {
	  public ctrlFrameCounterInfo()
	  {
		 InitializeComponent();
	  }

	  public void ProcessState(ref ApuFrameCounterState state)
	  {
		 chkFiveStepMode.Checked = state.FiveStepMode;
		 chkIrqEnabled.Checked = state.IrqEnabled;
		 txtCurrentStep.Text = state.SequencePosition.ToString();
	  }
   }
}
