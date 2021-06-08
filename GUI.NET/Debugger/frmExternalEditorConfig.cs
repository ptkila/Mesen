using Mesen.GUI.Config;
using Mesen.GUI.Forms;

namespace Mesen.GUI.Debugger
{
   public partial class frmExternalEditorConfig : BaseConfigForm
   {
	  public frmExternalEditorConfig()
	  {
		 InitializeComponent();

		 Entity = ConfigManager.Config.DebugInfo;

		 AddBinding("ExternalEditorPath", txtPath);
		 AddBinding("ExternalEditorArguments", txtArguments);
	  }
   }
}
