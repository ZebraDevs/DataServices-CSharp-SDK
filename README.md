Zebra Savanna Data Services C# SDK
======================================

This is the source code for the Savanna C# SDK.  
The core of this SDK is a basic API connection call to the Zebra Savanna Data Services in the SavannaAPI class.  Currently the API has public methods for the three public APIs that are part of the Barcode Intelligence Product.  These APIs are:

* Barcode Generate
* UPC Lookup
* FDA Recall

This SDK also has models for all the data sent and received by these APIs to make it easier to work with them.  

API Key
-------

To get an API key to work with these APIs, use the [Getting Started Guide](https://developer.zebra.com/gsg) and select the Barcode Intelligence product.  

Documentation
-------------

For more information on these APIs, go to [developer.zebra.com/apis](https://developer.zebra.com/apis) or visit the [Forums](https://developer.zebra.com/forum/search?keys=&field_zebra_curated_tags_tid%5B%5D=273)

Usage guide
-----------

Set Zebra Savanna API key

```c#
SavannaAPI.APIKey = Resources.GetString("apikey", "");
```

Create Barcode

```c#
byte[] barcodeBytes = await CreateBarcode.CreateAsync(symbology, barcodeText.Text);
```

UPC Lookup

```c#
string upcLookupJson = await UPCLookup.LookupAsync(barcode);
```

FDA Food Recall

```c#
string foodUpcJson = await FDARecall.FoodUpcAsync(barcode);
```

FDA Drug Recall

```c#
string drugUpcJson = await FDARecall.DrugUpcAsync(barcode);
```

FDA Device Recall Search

```c#
string deviceSearchJson = await FDARecall.DeviceSearchAsync(searchText.Text);
```

FDA Drug Recall Search

```c#
string drugSearchJson = await FDARecall.DrugSearchAsync(searchText.Text);
```
