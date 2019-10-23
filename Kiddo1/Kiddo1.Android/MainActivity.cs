using Android.App;
using Android.Content.PM;
using Android.OS;
using FFImageLoading.Forms.Platform;
using FFImageLoading.Svg.Forms;
using Kiddo1.Droid.Persistance;
using Kiddo1.Persistance;
using Lottie.Forms.Droid;
using Prism;
using Prism.Ioc;
using Unity;
using Unity.Lifetime;

namespace Kiddo1.Droid
{
    [Activity(Label = "Kiddo1", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            SvgCachedImage.Init();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            AnimationViewRenderer.Init();

            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
            // Register any platform specific implementations
            container.RegisterType<ISQLiteDb, SQLiteDb>(new ContainerControlledLifetimeManager());

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterSingleton<ISQLiteDb, SQLiteDb>();
        }
    }
}

