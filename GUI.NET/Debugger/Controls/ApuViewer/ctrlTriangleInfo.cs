﻿using System.Windows.Forms;

namespace Mesen.GUI.Debugger.Controls
{
   public partial class ctrlTriangleInfo : UserControl
   {
	  public ctrlTriangleInfo()
	  {
		 InitializeComponent();
	  }

	  public void ProcessState(ref ApuTriangleState state)
	  {
		 chkEnabled.Checked = state.Enabled;
		 txtPeriod.Text = state.Period.ToString();
		 txtTimer.Text = state.Timer.ToString();
		 txtFrequency.Text = ((int)(state.Frequency)).ToString();
		 txtSequencePosition.Text = state.SequencePosition.ToString();
		 txtOutputVolume.Text = state.OutputVolume.ToString();

		 ctrlLengthCounterInfo.ProcessState(ref state.LengthCounter);
	  }
   }
}
