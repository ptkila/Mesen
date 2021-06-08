using Mesen.GUI.Config;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mesen.GUI.Forms.Config
{
   public partial class ctrlPachinkoConfig : BaseInputConfigControl
   {
	  private List<Button> _keyIndexes;

	  public ctrlPachinkoConfig()
	  {
		 InitializeComponent();

		 _keyIndexes = new List<Button>() {
				btn1, btn2
			};
	  }

	  public override void Initialize(KeyMappings mappings)
	  {
		 for (int i = 0; i < _keyIndexes.Count; i++)
		 {
			InitButton(_keyIndexes[i], mappings.PachinkoButtons[i]);
		 }
	  }

	  public override void UpdateKeyMappings(KeyMappings mappings)
	  {
		 for (int i = 0; i < _keyIndexes.Count; i++)
		 {
			mappings.PachinkoButtons[i] = (UInt32)_keyIndexes[i].Tag;
		 }
	  }
   }
}
