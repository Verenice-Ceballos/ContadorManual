using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContadorManual
{
    public partial class MainPage : ContentPage
    {
        private int Conteo;
        public MainPage()
        {
            InitializeComponent();
            Conteo = 0;
            ConteoLabel.Text = Conteo.ToString();
        }

        private void ContarButton_Clicked(object sender, EventArgs e)
        {
            Conteo++;
            ConteoLabel.Text = Conteo.ToString();
        }

        private void ReiniciarButton_Clicked(object sender, EventArgs e)
        {
            Conteo = 0;
            ConteoLabel.Text = Conteo.ToString();
        }
    }
}
