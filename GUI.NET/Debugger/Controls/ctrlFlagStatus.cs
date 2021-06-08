using Mesen.GUI.Controls;
using System.Drawing;

namespace Mesen.GUI.Debugger.Controls
{
   public partial class ctrlFlagStatus : BaseControl
   {
	  public ctrlFlagStatus()
	  {
		 InitializeComponent();
		 if (Program.IsMono)
		 {
			lblLetter.Location = new Point(-1, -1);
		 }
	  }

	  public bool Active
	  {
		 set
		 {
			panelBorder.BackColor = value ? Color.Red : Color.LightGray;
			panelBg.BackColor = value ? Color.White : Color.DarkGray;
			lblLetter.ForeColor = Color.Black;
		 }
	  }

	  public string Letter
	  {
		 set
		 {
			lblLetter.Text = value;
		 }
	  }
   }
}
