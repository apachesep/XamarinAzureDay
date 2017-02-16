﻿using Prism.Unity;
using XFCreative.Views;

namespace XFCreative
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.Navigate("LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<HomePage>();
            Container.RegisterTypeForNavigation<BusinessSpacePage>();
            Container.RegisterTypeForNavigation<BusinessSpaceDetailPage>();
            Container.RegisterTypeForNavigation<WebView更多資訊Page>();
            Container.RegisterTypeForNavigation<SelectCityPage>();
            Container.RegisterTypeForNavigation<LoginPage>();
        }
    }
}
