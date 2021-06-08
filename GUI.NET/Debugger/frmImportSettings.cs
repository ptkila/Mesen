using Mesen.GUI.Config;
using Mesen.GUI.Forms;

namespace Mesen.GUI.Debugger
{
   public partial class frmImportSettings : BaseConfigForm
   {
	  public frmImportSettings()
	  {
		 InitializeComponent();

		 Entity = ConfigManager.Config.DebugInfo.ImportConfig;

		 AddBinding("ResetLabelsOnImport", chkResetLabelsOnImport);

		 AddBinding("DbgImportRamLabels", chkDbgImportRamLabels);
		 AddBinding("DbgImportPrgRomLabels", chkDbgImportPrgRomLabels);
		 AddBinding("DbgImportWorkRamLabels", chkDbgImportWorkRamLabels);
		 AddBinding("DbgImportSaveRamLabels", chkDbgImportSaveRamLabels);
		 AddBinding("DbgImportComments", chkDbgImportComments);

		 AddBinding("MlbImportInternalRamLabels", chkMlbImportInternalRamLabels);
		 AddBinding("MlbImportWorkRamLabels", chkMlbImportWorkRamLabels);
		 AddBinding("MlbImportSaveRamLabels", chkMlbImportSaveRamLabels);
		 AddBinding("MlbImportRegisterLabels", chkDbgImportRegisterLabels);
		 AddBinding("MlbImportPrgRomLabels", chkMlbImportPrgRomLabels);
		 AddBinding("MlbImportComments", chkMlbImportComments);
	  }
   }
}
