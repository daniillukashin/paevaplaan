using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace paevaplaan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            StackLayout st = new StackLayout();
            Title = "Моя неделя";
            BackgroundColor = Color.Black;
            Button pon_btn = new Button { Text = "Понедельник", BackgroundColor = Color.Yellow};
            Button vtor_btn = new Button { Text = "Вторник", BackgroundColor = Color.Yellow};
            Button sred_btn = new Button { Text = "Среда", BackgroundColor = Color.Yellow};
            Button chet_btn = new Button { Text = "Четверг", BackgroundColor = Color.Yellow};
            Button pjat_btn = new Button { Text = "Пятница", BackgroundColor = Color.Yellow};
            Button subb_btn = new Button { Text = "Суббота", BackgroundColor = Color.Yellow};
            Button vos_btn = new Button { Text = "Воскресенье", BackgroundColor = Color.Yellow};
            pon_btn.Clicked += new EventHandler(Buttons_Clicked);
            vtor_btn.Clicked += new EventHandler(Buttons_Clicked);
            sred_btn.Clicked += new EventHandler(Buttons_Clicked);
            chet_btn.Clicked += new EventHandler(Buttons_Clicked);
            pjat_btn.Clicked += new EventHandler(Buttons_Clicked);
            subb_btn.Clicked += new EventHandler(Buttons_Clicked);
            vos_btn.Clicked += new EventHandler(Buttons_Clicked);
            st.Children.Add(pon_btn);
            st.Children.Add(vtor_btn);
            st.Children.Add(sred_btn);
            st.Children.Add(chet_btn);
            st.Children.Add(pjat_btn);
            st.Children.Add(subb_btn);
            st.Children.Add(vos_btn);

            Content = st;
        }
        private async void Buttons_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Понедельник":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new ponedejlnik());
                    break;
                case "Вторник":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new vtornik());
                    break;
                case "Среда":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new sreda());
                    break;
                case "Четверг":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new tsetverg());
                    break;
                case "Пятница":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new pjatnitsa());
                    break;
                case "Суббота":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new subbota());
                    break;
                case "Воскресенье":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new voskresenje());
                    break;
            }
        }
    }
}
