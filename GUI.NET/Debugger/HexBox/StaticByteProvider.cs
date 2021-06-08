namespace Be.Windows.Forms
{
   public class StaticByteProvider : DynamicByteProvider
   {
	  public StaticByteProvider(byte[] data) : base(data)
	  {
	  }

	  public override bool SupportsInsertBytes()
	  {
		 return false;
	  }

	  public override bool SupportsDeleteBytes()
	  {
		 return false;
	  }
   }
}
