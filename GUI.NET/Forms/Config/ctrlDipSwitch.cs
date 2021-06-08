using Mesen.GUI.Controls;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mesen.GUI.Forms.Config
{
   public partial class ctrlDipSwitch : BaseControl
   {
	  public ctrlDipSwitch()
	  {
		 InitializeComponent();
	  }

	  [Bindable(true)]
	  [Browsable(true)]
	  [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	  [EditorBrowsable(EditorBrowsableState.Always)]
	  public override string Text
	  {
		 get
		 {
			return lblName.Text;
		 }

		 set
		 {
			lblName.Text = value;
		 }
	  }

	  public ComboBox.ObjectCollection Items
	  {
		 get
		 {
			return cboDipSwitch.Items;
		 }
	  }

	  public int SelectedIndex
	  {
		 get
		 {
			return cboDipSwitch.SelectedIndex;
		 }
		 set
		 {
			cboDipSwitch.SelectedIndex = value;
		 }
	  }
   }
}
