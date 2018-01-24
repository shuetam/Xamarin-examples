using System;

using Xamarin.Forms;

namespace App02.Views
{
    public class MyPageXaml : ContentPage
    {
        public MyPageXaml()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

