using Mesen.GUI.Forms;
using System;

namespace Mesen.GUI.Debugger
{
   public partial class frmGoToLine : BaseConfigForm
   {
	  public frmGoToLine(GoToAddress address, int charLimit)
	  {
		 InitializeComponent();

		 Entity = address;
		 AddBinding("Address", txtAddress);

		 txtAddress.MaxLength = charLimit;
	  }

	  protected override void OnShown(EventArgs e)
	  {
		 base.OnShown(e);
		 txtAddress.Focus();
	  }
   }

   public class GoToAddress
   {
	  public UInt32 Address;
   }
}
