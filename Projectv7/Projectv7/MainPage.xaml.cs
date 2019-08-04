using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projectv7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            HomeImage.Source = ImageSource.FromFile("home.jpg");
        }

        private async void MyBills_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyBills());
        }
     
        private async void ToDoLifeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToDo());
        }

        private async void ToDoHomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToDoHome());
        }

        private async void ToDoWorkButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoWork());
        }
    }
}
