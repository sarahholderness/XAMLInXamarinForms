using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLInXamarinForms.ViewModels;
using XAMLInXamarinForms.Views.Routine;

namespace XAMLInXamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public PlannerViewModel model = new PlannerViewModel();

        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void FitnessButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Fitness());
        }

        private async void NutritionButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Nutrition());
        }
    }
}