using System;

using Xamarin.Forms;

namespace App02
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();



            Item = new Item
            {
                Text = "Item name Mateusz",
                Description = "This is an item description Wkat is that!!??."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopToRootAsync();
        }
    }
}
