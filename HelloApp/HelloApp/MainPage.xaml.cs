using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label label1 = new Label()
            {
                Text = "Леонов Денис Александрович",
                FontSize = 14,
                TextColor = Color.Black
            };
            Label label2 = new Label()
            {
                Text = "Группа: ПКС-31",
                FontSize = 14,
                TextColor = Color.Red
            };

            Image1.Source = ImageSource.FromResource("HelloApp.Images.photo_l.jpg");

            Label label3 = new Label()
            {
                Text = "Мои интересы: 1)Спорт; 2)Музыка.",
                FontSize = 14,
                TextColor = Color.Black
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { label1, label2, Image1, label3 }
            };
            stackLayout.Spacing = 8;
            this.Content = stackLayout;
            

        }

    }
}


