using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FoodieXamarin.Effects
{
    public class ShadowEffect : RoutingEffect
    {
        public Color ShadowColor { get; set; } = Color.Black;

        public ShadowEffect() : base("com.bornehill.ShadowEffect")
        {

        }
    }
}
