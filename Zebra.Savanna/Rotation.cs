namespace Zebra.Savanna
{
	/// <summary>
	/// Describes barcode image orientation.
	/// </summary>
	public enum Rotation
	{
		/// <summary>
		/// No rotation
		/// </summary>
		Normal = 'N',
		/// <summary>
		/// Clockwise 90 degree rotation
		/// </summary>
		Clockwise = 'R',
		/// <summary>
		/// Inverted 180 degree rotation
		/// </summary>
		Inverted = 'I',
		/// <summary>
		/// Counter-clockwise 90 degree rotation
		/// </summary>
		Counterclockwise = 'L',
	}
}