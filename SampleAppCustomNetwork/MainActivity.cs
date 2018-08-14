using Android.App;
using Android.OS;
using Android.Widget;
using com.mopub.mobileads;
namespace SampleApp
{
    [Activity(Label = "SampleApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       


        int _count = 1;
      MoPubInterstitial mInterstitial;
        public Button button;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click +=Button_Click;


            //setup ads
           /* var moPubViewBanner = FindViewById<MoPubView>(Resource.Id.adview_banner);
            moPubViewBanner.Testing = true;
            moPubViewBanner.AdUnitId = Resources.GetString(Resource.String.mopub_ad_id_banner);
            moPubViewBanner.LoadAd();*/
            mInterstitial = new MoPubInterstitial(this, "21e005af2366472782920bbf705d7635");
            mInterstitial.Load();
        }

        void Button_Click(object sender, System.EventArgs e){
           
            if (mInterstitial.IsReady){
                
                mInterstitial.Show();

            }
            else{

                button.Text = string.Format("{0} clicks!", _count++);
            }
           

        }
    }
}

