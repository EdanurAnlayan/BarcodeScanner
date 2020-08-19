# BarcodeScanner
Simple barcode scanner app with Xamarin.

In this project, I use Zxing.Net.Mobile.Forms library. Firstly should download this nuget. After that, there are some necessity for platforms. 

**For Android**

In MainActivity class :
```ruby
 ZXing.Net.Mobile.Forms.Android.Platform.Init(); 
```
and create new method in MainActivity class: 
```ruby
 public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            ZXing.Net.Mobile.Forms.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
```
In AssemblyInfo class :
```ruby
 [assembly: UsesPermission(Android.Manifest.Permission.Internet)]
 [assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
``` 
**For iOs**
 
 In AppDelegate class:
 ```ruby
   ZXing.Net.Mobile.Forms.iOS.Platform.Init();
 ```
 
After that, if you get error, please check them:

 -In nuget package, are you have *Zxing.Net.Mobile* ?
 
 -Your *updates* is ok ?
