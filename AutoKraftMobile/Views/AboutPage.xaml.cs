using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoKraftMobile.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            Task.Run(AnimateBorder);
        }

        private async void AnimateBorder()
        {

            uint delayTime = 25;

            while (true)
            {
                for(int degrees = 0; degrees < 360; degrees++)
                {
                    double angle = (Math.PI / 180) * degrees;
                    linearGradient.StartPoint = new Point(0.5 * Math.Sin(angle + Math.PI) + 0.5, 0.5 * Math.Cos(angle + Math.PI) + 0.5);
                    linearGradient.EndPoint   = new Point(0.5 * Math.Sin(angle) + 0.5, 0.5 * Math.Cos(angle) + 0.5);
                    await Task.Delay((int)delayTime);
                }
            }
        }
    }
}