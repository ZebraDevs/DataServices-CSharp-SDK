# Savanna-CSharp-SDK
C# library for accessing Zebra Savanna APIs

## Usage guide

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
