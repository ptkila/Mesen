﻿using Mesen.GUI.Config;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mesen.GUI.Forms.Config
{
   public partial class ctrlExcitingBoxingConfig : BaseInputConfigControl
   {
	  private List<Button> _keyIndexes;

	  public ctrlExcitingBoxingConfig()
	  {
		 InitializeComponent();

		 _keyIndexes = new List<Button>() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };
	  }

	  public override void Initialize(KeyMappings mappings)
	  {
		 for (int i = 0; i < _keyIndexes.Count; i++)
		 {
			InitButton(_keyIndexes[i], mappings.ExcitingBoxingButtons[i]);
		 }
	  }

	  public override void UpdateKeyMappings(KeyMappings mappings)
	  {
		 for (int i = 0; i < _keyIndexes.Count; i++)
		 {
			mappings.ExcitingBoxingButtons[i] = (UInt32)_keyIndexes[i].Tag;
		 }
	  }
   }
}
