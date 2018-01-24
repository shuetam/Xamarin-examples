using System;

using Xamarin.Forms;

namespace App02.Views
{
    public class MyPage00 : ContentPage
    {
        public MyPage00()
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

