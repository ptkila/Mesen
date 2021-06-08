using Mesen.GUI.Config;

namespace Mesen.GUI.Forms.NetPlay
{
   public partial class frmPlayerProfile : BaseConfigForm
   {
	  public frmPlayerProfile()
	  {
		 InitializeComponent();

		 this.txtPlayerName.Text = ConfigManager.Config.Profile.PlayerName;
	  }

	  protected override void UpdateConfig()
	  {
		 PlayerProfile profile = new PlayerProfile();
		 profile.PlayerName = this.txtPlayerName.Text;
		 ConfigManager.Config.Profile = profile;
	  }
   }
}
