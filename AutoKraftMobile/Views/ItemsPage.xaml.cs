using AutoKraftMobile.Models;
using AutoKraftMobile.ViewModels;
using AutoKraftMobile.Views;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoKraftMobile.Views
{
    public partial class ItemsPage : ContentPage
    {

        public ItemsPage()
        {
            InitializeComponent();
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            var info = args.Info;
            var surface = args.Surface;
            var canvas = surface.Canvas;

            canvas.Clear();

            // In this example, we will draw a circle in the middle of the canvas
            var paint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = Color.Red.ToSKColor(), // Alternatively: SKColors.Red
            };
            canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);
        }
    }
}