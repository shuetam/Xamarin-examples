using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;

namespace App02.Views
{
    public partial class MyPageCode : ContentPage
    {
        public MyPageCode()
        {
            InitializeComponent();
            var names = new List<string>{
                "mat",
                "kol",
                "mom"
            };

            var names1 = new Dictionary<string, string>()
            {
                {"mat","Bee"},
                {"mat1","Bee"},
                {"mat2","Bee2"}
            };


            var realmat = names1.Values.Where(x => x == "Bee").ToList();

            viewList.ItemsSource = realmat;
        }
    }
}
