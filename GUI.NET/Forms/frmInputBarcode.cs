using System;
using System.Windows.Forms;

namespace Mesen.GUI.Forms
{
   public partial class frmInputBarcode : BaseConfigForm
   {
	  public class BarcodeData
	  {
		 public UInt64 Barcode;
	  }

	  public frmInputBarcode()
	  {
		 InitializeComponent();

		 Entity = new BarcodeData();
		 AddBinding("Barcode", txtBarcode, eNumberFormat.Decimal);
	  }

	  protected override void OnFormClosed(FormClosedEventArgs e)
	  {
		 base.OnFormClosed(e);

		 if (DialogResult == DialogResult.OK)
		 {
			InteropEmu.InputBarcode(((BarcodeData)Entity).Barcode, txtBarcode.Text.Length > 8 ? 13 : 8);
		 }
	  }
   }
}
