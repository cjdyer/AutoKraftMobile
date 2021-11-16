using System;
using System.Net.Sockets;
using System.Text;
using AutoKraftMobile.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoKraftMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Connect : ContentPage
    {
        private TcpClient client;
        public Connect()
        {
            InitializeComponent();
            client = new TcpClient();

        }

        private void btnConnect_Clicked(object sender, EventArgs e)
        {
            try
            {
                client.Connect(edtIpAddress.Text, int.Parse(edtPort.Text));
                if (client.Connected)
                {
                    Connection.Instance.client = client;
                    DisplayAlert("Connection Status", "Connection Success", "Ok");
                }
                else
                {
                    DisplayAlert("Connection Status", "Failure - Server not allowing connection, try to refresh the server application", "Ok");
                }
            }
            catch
            {
                DisplayAlert("Connection Status", "Failure - Bad Input, follow the steps below:\n" +
                    "Leave the bottom box as is" + "\n" +
                    "On the host machine:" + "\n" +
                    "Windows:" + "\n" +
                    "1: Open CMD" + "\n" +
                    "2: type 'ipconfig'" + "\n" +
                    "3: Under the heading 'Wireless LAN adapter WiFi:'" + "\n" +
                    "4: 'IPV4 Address' is the ip address used", "Ok");


            }
        }
    }
}