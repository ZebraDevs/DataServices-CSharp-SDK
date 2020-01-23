Zebra Savanna Data Services CSharp SDK
======================================

This is the source code for the Savanna CSharp SDK.  
The core of this SDK is a basic API connection call to the Zebra Savanna Data Services in the SavannaAPI class.  Corrently the API has public methods for the three public APIs that are part of the Barcode Intelligence Product.  These APIs are:

* Barcode Generate
* UPC Lookup
* FDA Recall

This SDK also has models for all the data sent and recieved by these APIs in order to make it easier to work with them.  

API Key
-------

To get an API key to work with these APIs, use the [Getting Started Guide](https://developer.zebra.com/gsg) and select the Barcode Intelligence product.  

Documentation
-------------

For more information on these APIs, go to [Developer.zebra.com/apis](https://developer.zebra.com/apis) or visit the [Forums](https://developer.zebra.com/forum/search?keys=&field_zebra_curated_tags_tid%5B%5D=273)

Usage guide
-----------

Set Zebra Savanna API key

`SavannaAPI.APIKey = Resources.GetString("apikey", "");`

FDA Food Recall

`var foodUpcJson = await FDARecall.FoodUpcAsync(barcode);`

FDA Drug Recall

`var drugUpcJson = await FDARecall.DrugUpcAsync(barcode);`

UPC Lookup

`var upcLookupJson = await UPCLookup.LookupAsync(barcode);`

Create Barcode

`var barcodeBytes = await CreateBarcode.CreateAsync(symbology, barcodeText.Text);`

FDA Device Recall Search

`var deviceSearchJson = await FDARecall.DeviceSearchAsync(searchText.Text);`

FDA Drug Recall Search

`var drugSearchJson = await FDARecall.DrugSearchAsync(searchText.Text);`

UPC Lookup

`var upcLookupJson = await UPCLookup.LookupAsync(lookupText.Text);`
