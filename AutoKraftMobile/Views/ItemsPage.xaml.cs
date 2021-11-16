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
        int previousStringLength;
        public ItemsPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(0.2), () =>
            {
                if (Connection.Instance.client != null)
                {
                    if (Connection.Instance.client.Connected)
                    {
                        byte[] message = new byte[1024];
                        Connection.Instance.client.GetStream().Read(message, 0, message.Length);
                        string message_s = Encoding.UTF8.GetString(message).Replace("\0", "");
                        if (message_s.Length < (2 * previousStringLength) || previousStringLength == 0)
                        {
                            TotalWeightText.Text = "Total Weight " + message_s + "kg";
                            FrontWeightText.Text = message_s + " kg";
                            previousStringLength = message_s.Length;
                        }
                    }
                }
                return true; // True = Repeat again
            });
        }
    }
}