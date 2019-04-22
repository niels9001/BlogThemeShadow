using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using UIFaces.NET.Models;
using UIFaces.NET.Services;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace BlogThemeShadow
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void DepthSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            float SliderValue = (float)e.NewValue;
            BedroomGrid.Translation = new Vector3(0, 0, (float)(SliderValue * 0.2));
            PoolGrid.Translation = new Vector3(0, 0, SliderValue);
            LoungeGrid.Translation = new Vector3(0, 0, (float)(SliderValue * 0.2));
            UserIDBox.Translation = new Vector3(0, 0, (float)(SliderValue * 0.2));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BackgroundGridShadow.Receivers.Add(BackgroundGrid);

            HeroImageShadow.Receivers.Add(BackgroundGrid);
            HeroImageShadow.Receivers.Add(LoungeGrid);
            HeroImageShadow.Receivers.Add(BedroomGrid);



        }

        private void TextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            if (UserIDBox.Text.Count() > 0)
            {
                SelectButton.IsEnabled = true;
                SelectButton.Translation = new Vector3(0, 0, 32);
            }
            else
            {
                SelectButton.IsEnabled = false;
                SelectButton.Translation = new Vector3(0, 0, 0);
            }
        }
    }
}
