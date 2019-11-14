using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingMVVM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainViewModel MainViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            MainViewModel = new MainViewModel();
            BindingContext = MainViewModel;
            MainViewModel.SetVisibility_LabelResult(false);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LabelChangeVisibilityAsync();
        }

        public async Task<int> LabelChangeVisibilityAsync()
        {
            var result = await Task.Run(() =>
            {
                Thread.Sleep(5000);
                MainViewModel.SetVisibility_LabelResult(true);
                return 1;
            });
            return result;
        }


    }
}
