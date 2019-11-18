using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace DaysBetweenDates
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DaysBetweenDates.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=5f907c0d-3ae3-4d8f-8d08-fb29a7dbd10a;" +
                  "uwp=6eb2aa64-74ac-4182-8264-e03c9c245717;" +
                  "ios=f930c28d-672c-4279-b63f-fe09296fc3aa;",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
