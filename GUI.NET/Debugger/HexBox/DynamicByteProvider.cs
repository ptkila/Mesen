using System;
using System.Collections.Generic;

namespace Be.Windows.Forms
{
   /// <summary>
   /// Byte provider for a small amount of data.
   /// </summary>
   public class DynamicByteProvider : IByteProvider
   {
	  /// <summary>
	  /// Contains information about changes.
	  /// </summary>
	  bool _hasChanges;
	  /// <summary>
	  /// Contains a byte collection.
	  /// </summary>
	  List<byte> _bytes;

	  /// <summary>
	  /// Initializes a new instance of the DynamicByteProvider class.
	  /// </summary>
	  /// <param name="data"></param>
	  public DynamicByteProvider(byte[] data) : this(new List<Byte>(data))
	  {
	  }

	  /// <summary>
	  /// Initializes a new instance of the DynamicByteProvider class.
	  /// </summary>
	  /// <param name="bytes"></param>
	  public DynamicByteProvider(List<Byte> bytes)
	  {
		 _bytes = bytes;
	  }

	  public void SetData(byte[] data)
	  {
		 _bytes = new List<byte>(data);
	  }

	  /// <summary>
	  /// Raises the Changed event.
	  /// </summary>
	  void OnChanged(EventArgs e)
	  {
		 _hasChanges = true;

		 if (Changed != null)
			Changed(this, e);
	  }

	  /// <summary>
	  /// Raises the LengthChanged event.
	  /// </summary>
	  void OnLengthChanged(EventArgs e)
	  {
		 if (LengthChanged != null)
			LengthChanged(this, e);
	  }

	  /// <summary>
	  /// Gets the byte collection.
	  /// </summary>
	  public List<Byte> Bytes
	  {
		 get { return _bytes; }
	  }

	  #region IByteProvider Members
	  /// <summary>
	  /// True, when changes are done.
	  /// </summary>
	  public bool HasChanges()
	  {
		 return _hasChanges;
	  }

	  /// <summary>
	  /// Applies changes.
	  /// </summary>
	  public void ApplyChanges()
	  {
		 _hasChanges = false;
	  }

	  /// <summary>
	  /// Occurs, when the write buffer contains new changes.
	  /// </summary>
	  public event EventHandler Changed;

	  /// <summary>
	  /// Occurs, when InsertBytes or DeleteBytes method is called.
	  /// </summary>
	  public event EventHandler LengthChanged;

	  public delegate void ByteChangedHandler(int byteIndex, byte newValue, byte oldValue);
	  public event ByteChangedHandler ByteChanged;

	  public delegate void BytesChangedHandler(int byteIndex, byte[] values);
	  public event BytesChangedHandler BytesChanged;

	  /// <summary>
	  /// Reads a byte from the byte collection.
	  /// </summary>
	  /// <param name="index">the index of the byte to read</param>
	  /// <returns>the byte</returns>
	  public byte ReadByte(long index)
	  {
		 if (_partialPos == index)
		 {
			return _partialValue;
		 }
		 else
		 {
			return _bytes[(int)index];
		 }
	  }

	  /// <summary>
	  /// Write a byte into the byte collection.
	  /// </summary>
	  /// <param name="index">the index of the byte to write.</param>
	  /// <param name="value">the byte</param>
	  public void WriteByte(long index, byte value)
	  {
		 if (index == _partialPos)
		 {
			_partialPos = -1;
		 }

		 if (_bytes[(int)index] != value)
		 {
			ByteChanged?.Invoke((int)index, value, _bytes[(int)index]);
			_bytes[(int)index] = value;
			OnChanged(EventArgs.Empty);
		 }
	  }

	  public void WriteBytes(long index, byte[] values)
	  {
		 _partialPos = -1;
		 BytesChanged?.Invoke((int)index, values);
		 for (int i = 0; i < values.Length && index + i < _bytes.Count; i++)
		 {
			_bytes[(int)index + i] = values[i];
		 }
	  }

	  long _partialPos = -1;
	  byte _partialValue = 0;
	  public void PartialWriteByte(long index, byte value)
	  {
		 //Wait for a full byte to be written
		 _partialPos = index;
		 _partialValue = value;
	  }

	  public void CommitWriteByte()
	  {
		 if (_partialPos >= 0)
		 {
			WriteByte(_partialPos, _partialValue);
			_partialPos = -1;
		 }
	  }

	  /// <summary>
	  /// Deletes bytes from the byte collection.
	  /// </summary>
	  /// <param name="index">the start index of the bytes to delete.</param>
	  /// <param name="length">the length of bytes to delete.</param>
	  public void DeleteBytes(long index, long length)
	  {
		 int internal_index = (int)Math.Max(0, index);
		 int internal_length = (int)Math.Min((int)Length, length);
		 _bytes.RemoveRange(internal_index, internal_length);

		 OnLengthChanged(EventArgs.Empty);
		 OnChanged(EventArgs.Empty);
	  }

	  /// <summary>
	  /// Inserts byte into the byte collection.
	  /// </summary>
	  /// <param name="index">the start index of the bytes in the byte collection</param>
	  /// <param name="bs">the byte array to insert</param>
	  public void InsertBytes(long index, byte[] bs)
	  {
		 _bytes.InsertRange((int)index, bs);

		 OnLengthChanged(EventArgs.Empty);
		 OnChanged(EventArgs.Empty);
	  }

	  /// <summary>
	  /// Gets the length of the bytes in the byte collection.
	  /// </summary>
	  public long Length
	  {
		 get
		 {
			return _bytes.Count;
		 }
	  }

	  /// <summary>
	  /// Returns true
	  /// </summary>
	  public virtual bool SupportsWriteByte()
	  {
		 return true;
	  }

	  /// <summary>
	  /// Returns true
	  /// </summary>
	  public virtual bool SupportsInsertBytes()
	  {
		 return true;
	  }

	  /// <summary>
	  /// Returns true
	  /// </summary>
	  public virtual bool SupportsDeleteBytes()
	  {
		 return true;
	  }
	  #endregion

   }
}
