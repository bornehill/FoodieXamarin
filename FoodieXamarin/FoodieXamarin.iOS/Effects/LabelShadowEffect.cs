using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using FoodieXamarin.iOS.Effects;
using FoodieXamarin.Effects;
using CoreGraphics;

[assembly: ResolutionGroupName("com.bornehill")]
[assembly: ExportEffect(typeof(LabelShadowEffect), "ShadowEffect")]
namespace FoodieXamarin.iOS.Effects
{
    public class LabelShadowEffect : PlatformEffect
    {
        UIColor oldColor;
        CGSize oldOffset;

        protected override void OnAttached()
        {
            var c = Control as UILabel;
            oldColor = c.ShadowColor;
            oldOffset = c.ShadowOffset;

            var routingEffect = (ShadowEffect)Element.Effects.First((arg) => arg is ShadowEffect);
            var shadowColor = routingEffect.ShadowColor;

            c.ShadowColor = shadowColor.ToUIColor();
            c.ShadowOffset = new CGSize(2, 2);
        }

        protected override void OnDetached()
        {
            var c = Control as UILabel;
            c.ShadowColor = oldColor;
            c.ShadowOffset = oldOffset;
        }
    }
}