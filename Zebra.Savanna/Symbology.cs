namespace Zebra.Savanna
{
	/// <summary>
	/// Describes barcode type.
	/// </summary>
	public enum Symbology
	{
		/// <summary>
		/// AusPost 4 State Customer Code
		/// </summary>
		auspost,
		/// <summary>
		/// Aztec Code
		/// </summary>
		azteccode,
		/// <summary>
		/// Compact Aztec Code
		/// </summary>
		azteccodecompact,
		/// <summary>
		/// Aztec Runes
		/// </summary>
		aztecrune,
		/// <summary>
		/// BC412
		/// </summary>
		bc412,
		/// <summary>
		/// Channel Code
		/// </summary>
		channelcode,
		/// <summary>
		/// Codablock F
		/// </summary>
		codablockf,
		/// <summary>
		/// Code 11
		/// </summary>
		code11,
		/// <summary>
		/// Code 128
		/// </summary>
		code128,
		/// <summary>
		/// Code 16K
		/// </summary>
		code16k,
		/// <summary>
		/// Code 25
		/// </summary>
		code2of5,
		/// <summary>
		/// Italian Pharmacode
		/// </summary>
		code32,
		/// <summary>
		/// Code 39
		/// </summary>
		code39,
		/// <summary>
		/// Code 39 Extended
		/// </summary>
		code39ext,
		/// <summary>
		/// Code 49
		/// </summary>
		code49,
		/// <summary>
		/// Code 93
		/// </summary>
		code93,
		/// <summary>
		/// Code 93 Extended
		/// </summary>
		code93ext,
		/// <summary>
		/// Code One
		/// </summary>
		codeone,
		/// <summary>
		/// COOP 2 of 5
		/// </summary>
		coop2of5,
		/// <summary>
		/// Custom 4 state symbology
		/// </summary>
		daft,
		/// <summary>
		/// GS1 DataBar Expanded
		/// </summary>
		databarexpanded,
		/// <summary>
		/// GS1 DataBar Expanded Composite
		/// </summary>
		databarexpandedcomposite,
		/// <summary>
		/// GS1 DataBar Expanded Stacked
		/// </summary>
		databarexpandedstacked,
		/// <summary>
		/// GS1 DataBar Expanded Stacked Composite
		/// </summary>
		databarexpandedstackedcomposite,
		/// <summary>
		/// GS1 DataBar Limited
		/// </summary>
		databarlimited,
		/// <summary>
		/// GS1 DataBar Limited Composite
		/// </summary>
		databarlimitedcomposite,
		/// <summary>
		/// GS1 DataBar Omnidirectional
		/// </summary>
		databaromni,
		/// <summary>
		/// GS1 DataBar Omnidirectional Composite
		/// </summary>
		databaromnicomposite,
		/// <summary>
		/// GS1 DataBar Stacked
		/// </summary>
		databarstacked,
		/// <summary>
		/// GS1 DataBar Stacked Composite
		/// </summary>
		databarstackedcomposite,
		/// <summary>
		/// GS1 DataBar Stacked Omnidirectional
		/// </summary>
		databarstackedomni,
		/// <summary>
		/// GS1 DataBar Stacked Omnidirectional Composite
		/// </summary>
		databarstackedomnicomposite,
		/// <summary>
		/// GS1 DataBar Truncated
		/// </summary>
		databartruncated,
		/// <summary>
		/// GS1 DataBar Truncated Composite
		/// </summary>
		databartruncatedcomposite,
		/// <summary>
		/// Datalogic 2 of 5
		/// </summary>
		datalogic2of5,
		/// <summary>
		/// Data Matrix
		/// </summary>
		datamatrix,
		/// <summary>
		/// Data Matrix Rectangular
		/// </summary>
		datamatrixrectangular,
		/// <summary>
		/// DotCode
		/// </summary>
		dotcode,
		/// <summary>
		/// EAN-13
		/// </summary>
		ean13,
		/// <summary>
		/// EAN-13 Composite
		/// </summary>
		ean13composite,
		/// <summary>
		/// GS1-14
		/// </summary>
		ean14,
		/// <summary>
		/// EAN-2 (2 digit addon)
		/// </summary>
		ean2,
		/// <summary>
		/// EAN-5 (5 digit addon)
		/// </summary>
		ean5,
		/// <summary>
		/// EAN-8
		/// </summary>
		ean8,
		/// <summary>
		/// EAN-8 Composite
		/// </summary>
		ean8composite,
		/// <summary>
		/// Flattermarken
		/// </summary>
		flattermarken,
		/// <summary>
		/// GS1-128
		/// </summary>
		gs1_128,
		/// <summary>
		/// GS1-128 Composite
		/// </summary>
		gs1_128composite,
		/// <summary>
		/// GS1 Composite 2D Component
		/// </summary>
		gs1_cc,
		/// <summary>
		/// GS1 Data Matrix
		/// </summary>
		gs1datamatrix,
		/// <summary>
		/// GS1 Data Matrix Rectangular
		/// </summary>
		gs1datamatrixrectangular,
		/// <summary>
		/// GS1 North American Coupon
		/// </summary>
		gs1northamericancoupon,
		/// <summary>
		/// GS1 QR Code
		/// </summary>
		gs1qrcode,
		/// <summary>
		/// Han Xin Code
		/// </summary>
		hanxin,
		/// <summary>
		/// HIBC Aztec Code
		/// </summary>
		hibcazteccode,
		/// <summary>
		/// HIBC Codablock F
		/// </summary>
		hibccodablockf,
		/// <summary>
		/// HIBC Code 128
		/// </summary>
		hibccode128,
		/// <summary>
		/// HIBC Code 39
		/// </summary>
		hibccode39,
		/// <summary>
		/// HIBC Data Matrix
		/// </summary>
		hibcdatamatrix,
		/// <summary>
		/// HIBC Data Matrix Rectangular
		/// </summary>
		hibcdatamatrixrectangular,
		/// <summary>
		/// HIBC MicroPDF417
		/// </summary>
		hibcmicropdf417,
		/// <summary>
		/// HIBC PDF417
		/// </summary>
		hibcpdf417,
		/// <summary>
		/// HIBC QR Code
		/// </summary>
		hibcqrcode,
		/// <summary>
		/// IATA 2 of 5
		/// </summary>
		iata2of5,
		/// <summary>
		/// Deutsche Post Identcode
		/// </summary>
		identcode,
		/// <summary>
		/// Industrial 2 of 5
		/// </summary>
		industrial2of5,
		/// <summary>
		/// Interleaved 2 of 5 (ITF)
		/// </summary>
		interleaved2of5,
		/// <summary>
		/// ISBN
		/// </summary>
		isbn,
		/// <summary>
		/// ISMN
		/// </summary>
		ismn,
		/// <summary>
		/// ISSN
		/// </summary>
		issn,
		/// <summary>
		/// ITF-14
		/// </summary>
		itf14,
		/// <summary>
		/// Japan Post 4 State Customer Code
		/// </summary>
		japanpost,
		/// <summary>
		/// Royal Dutch TPG Post KIX
		/// </summary>
		kix,
		/// <summary>
		/// Deutsche Post Leitcode
		/// </summary>
		leitcode,
		/// <summary>
		/// Matrix 2 of 5
		/// </summary>
		matrix2of5,
		/// <summary>
		/// MaxiCode
		/// </summary>
		maxicode,
		/// <summary>
		/// MicroPDF417
		/// </summary>
		micropdf417,
		/// <summary>
		/// Micro QR Code
		/// </summary>
		microqrcode,
		/// <summary>
		/// MSI Modified Plessey
		/// </summary>
		msi,
		/// <summary>
		/// USPS Intelligent Mail
		/// </summary>
		onecode,
		/// <summary>
		/// PDF417
		/// </summary>
		pdf417,
		/// <summary>
		/// Compact PDF417
		/// </summary>
		pdf417compact,
		/// <summary>
		/// Two-track Pharmacode
		/// </summary>
		pharmacode2,
		/// <summary>
		/// Pharmaceutical Binary Code
		/// </summary>
		pharmacode,
		/// <summary>
		/// USPS PLANET
		/// </summary>
		planet,
		/// <summary>
		/// Plessey UK
		/// </summary>
		plessey,
		/// <summary>
		/// PosiCode
		/// </summary>
		posicode,
		/// <summary>
		/// USPS POSTNET
		/// </summary>
		postnet,
		/// <summary>
		/// Pharmazentralnummer (PZN)
		/// </summary>
		pzn,
		/// <summary>
		/// QR Code
		/// </summary>
		qrcode,
		/// <summary>
		/// Codabar
		/// </summary>
		rationalizedCodabar,
		/// <summary>
		/// Custom 1D symbology
		/// </summary>
		raw,
		/// <summary>
		/// Royal Mail 4 State Customer Code
		/// </summary>
		royalmail,
		/// <summary>
		/// SSCC-18
		/// </summary>
		sscc18,
		/// <summary>
		/// Miscellaneous symbols
		/// </summary>
		symbol,
		/// <summary>
		/// Telepen
		/// </summary>
		telepen,
		/// <summary>
		/// Telepen Numeric
		/// </summary>
		telepennumeric,
		/// <summary>
		/// Ultracode
		/// </summary>
		ultracode,
		/// <summary>
		/// UPC-A
		/// </summary>
		upca,
		/// <summary>
		/// UPC-A Composite
		/// </summary>
		upcacomposite,
		/// <summary>
		/// UPC-E
		/// </summary>
		upce,
		/// <summary>
		/// UPC-E Composite
		/// </summary>
		upcecomposite,
	}
}