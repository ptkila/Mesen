using Mesen.GUI.Config;
using System.Windows.Forms;

namespace Mesen.GUI.Forms.Config
{
   public partial class frmZapperConfig : BaseConfigForm
   {
	  public frmZapperConfig(ZapperInfo zapperInfo)
	  {
		 InitializeComponent();

		 Entity = zapperInfo;
		 AddBinding("DetectionRadius", trkRadius);
	  }

	  protected override void OnFormClosed(FormClosedEventArgs e)
	  {
		 //Do not save anything, the parent input form will handle the changes
		 if (this.DialogResult == DialogResult.OK)
		 {
			UpdateObject();
		 }
		 base.OnFormClosed(e);
	  }
   }
}
