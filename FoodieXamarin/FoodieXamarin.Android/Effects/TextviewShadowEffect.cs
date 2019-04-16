using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using FoodieXamarin.Effects;
using FoodieXamarin.Droid.Effects;

[assembly: ResolutionGroupName("com.bornehill")]
[assembly: ExportEffect(typeof(TextviewShadowEffect), "ShadowEffect")]
namespace FoodieXamarin.Droid.Effects
{
    public class TextviewShadowEffect : PlatformEffect
    {
        Android.Graphics.Color oldColor;
        float oldRadius;
        float oldDx;
        float oldDy;

        protected override void OnAttached()
        {
            var tv = Control as TextView;

            oldColor = tv.ShadowColor;
            oldRadius = tv.ShadowRadius;
            oldDx = tv.ShadowDx;
            oldDy = tv.ShadowDy;

            var routingEffect = (ShadowEffect)Element.Effects.First((arg) => arg is ShadowEffect);
            var shadowColor = routingEffect.ShadowColor;

            tv.SetShadowLayer(2f, 2f, 2f, shadowColor.ToAndroid());
        }

        protected override void OnDetached()
        {
            var tv = Control as TextView;
            tv.SetShadowLayer(oldRadius, oldDx, oldDy, oldColor);
        }
    }
}