using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using System.Net;

namespace prueba1Proyecto.Droid
{

    [Activity(Label = "prueba1Proyecto", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
#if DEBUG
            // During development, we can trust all certificates, including ASP.NET developer certificates
            // DO NOT ENABLE THIS IN RELEASE BUILDS
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_, __, ___, ____) => true;
#endif
            base.OnCreate(savedInstanceState);
#if DEBUG
            // During development, we can trust all certificates, including ASP.NET developer certificates
            // DO NOT ENABLE THIS IN RELEASE BUILDS
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_, __, ___, ____) => true;
#endif
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
#if DEBUG
            // During development, we can trust all certificates, including ASP.NET developer certificates
            // DO NOT ENABLE THIS IN RELEASE BUILDS
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_, __, ___, ____) => true;
#endif
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
#if DEBUG
            // During development, we can trust all certificates, including ASP.NET developer certificates
            // DO NOT ENABLE THIS IN RELEASE BUILDS
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_, __, ___, ____) => true;
#endif
            LoadApplication(new App());
            #if DEBUG
            // During development, we can trust all certificates, including ASP.NET developer certificates
            // DO NOT ENABLE THIS IN RELEASE BUILDS
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (_, __, ___, ____) => true;
            #endif
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {

            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}