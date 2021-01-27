using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace paevaplaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sreda: ContentPage
    {
        public sreda()
        {
            Title = "Среда";
            BackgroundColor = Color.Black;
            string[] tasks = new string[] { "Подъем", "Душ", "Завтрак", "Работа", "Тренировка", "Душ", "Обед", "Прогулка", "Ужин", "Отдых", "Сон" };
            ListView list = new ListView();
            Button back = new Button { Text = "Назад", BackgroundColor = Color.Yellow};
            back.Clicked += Back_Clicked;
            Button next = new Button { Text = "Далее", BackgroundColor = Color.Yellow};
            next.Clicked += Next_Clicked; ;
            list.ItemsSource = tasks;
            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list, back, next } };
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tsetverg());
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        string kell;
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)
                {
                    kell = "11:00";
                }
                else if (e.SelectedItemIndex == 1)
                {
                    kell = "11:30";
                }
                else if (e.SelectedItemIndex == 2)
                {
                    kell = "12:00";
                }
                else if (e.SelectedItemIndex == 3)
                {
                    kell = "13:00";
                }
                else if (e.SelectedItemIndex == 4)
                {
                    kell = "16:15";
                }
                else if (e.SelectedItemIndex == 5)
                {
                    kell = "17:00";
                }
                else if (e.SelectedItemIndex == 6)
                {
                    kell = "17:15";
                }
                else if (e.SelectedItemIndex == 7)
                {
                    kell = "17:45";
                }
                else if (e.SelectedItemIndex == 8)
                {
                    kell = "20:00";
                }
                else if (e.SelectedItemIndex == 9)
                {
                    kell = "20:30";
                }
                else if (e.SelectedItemIndex == 10)
                {
                    kell = "21:00";
                }
                else if (e.SelectedItemIndex == 11)
                {
                    kell = "1:00";
                }
                await DisplayAlert(kell, text, "Да");
            }
        }
    }
}