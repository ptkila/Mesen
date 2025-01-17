﻿using System;
using System.ComponentModel;

namespace Mesen.GUI.Controls
{
   public partial class ctrlHorizontalTrackbar : BaseControl
   {
	  public event EventHandler ValueChanged
	  {
		 add { trackBar.ValueChanged += value; }
		 remove { trackBar.ValueChanged -= value; }
	  }

	  public ctrlHorizontalTrackbar()
	  {
		 InitializeComponent();

		 if (!Program.IsMono)
		 {
			this.trackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
		 }
	  }

	  public int Maximum
	  {
		 get { return trackBar.Maximum; }
		 set { trackBar.Maximum = value; }
	  }

	  public int Minimum
	  {
		 get { return trackBar.Minimum; }
		 set { trackBar.Minimum = value; }
	  }

	  [Bindable(true)]
	  [Browsable(true)]
	  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	  [EditorBrowsable(EditorBrowsableState.Always)]
	  public override string Text
	  {
		 get { return lblText.Text; }
		 set { lblText.Text = value; }
	  }

	  public int Value
	  {
		 get { return trackBar.Value; }
		 set
		 {
			trackBar.Value = Math.Max(trackBar.Minimum, Math.Min(value, trackBar.Maximum));
			lblValue.Text = trackBar.Value.ToString();
		 }
	  }

	  private void trackBar_ValueChanged(object sender, EventArgs e)
	  {
		 lblValue.Text = trackBar.Value.ToString();
	  }
   }
}
