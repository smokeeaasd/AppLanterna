using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace AppLanterna.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lanterna : ContentPage
    {
        string status;
        public Lanterna()
        {
            InitializeComponent();
            switch (Battery.State)
            {
                case BatteryState.Charging:
                    status = "Carregando.";
                break;

                case BatteryState.Full:
                    status = "Carregado.";
                break;

                case BatteryState.NotCharging:
                    status = "Não carregando.";
                break;
            }
            lblBateria.Text = $"Status da bateria: {status}";
        }

        void FlashLightOff()
        {
            btnLanterna.BorderColor = Color.FromHex("#e01033");
            btnLanterna.TextColor = Color.FromHex("#e01033");
            btnLanterna.Text = "OFF";
            Flashlight.TurnOffAsync();
        }

        void FlashLightOn()
        {
            btnLanterna.Text = "ON";
            btnLanterna.BorderColor = Color.FromHex("#10e090");
            btnLanterna.TextColor = Color.FromHex("#10e090");
            Flashlight.TurnOnAsync();
        }

        bool ligado = false;
        private void btnLanterna_Clicked(object sender, EventArgs e)
        {
            ligado = !ligado;

            if (ligado)
                FlashLightOn();
            if (!ligado)
                FlashLightOff();
        }
    }
}