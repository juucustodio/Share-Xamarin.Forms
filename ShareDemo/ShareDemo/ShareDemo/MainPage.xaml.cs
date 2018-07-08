using Plugin.Share;
using System;
using Xamarin.Forms;

namespace ShareDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Share_Tapped(object sender, EventArgs e)
        {
            var ShareMessage = new Plugin.Share.Abstractions.ShareMessage
            {
                Text = "Exemplo de como compartilhar textos e links em Aplicações Xamarin.Forms. / Example of how to share texts and links in Xamarin.Forms Applications.",
                Title = "Share",
                Url = "https://www.julianocustodio.com"
            };

            CrossShare.Current.Share(ShareMessage);
        }
    }
}
