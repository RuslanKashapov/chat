using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App13
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            grid.Children.Add(stack_layout);
            if(Message_Enty.Text.Length < 10)
            {
                Frame frame1 = new Frame
                {
                    Padding = 0,
                    CornerRadius = 10,
                    WidthRequest = 100,
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    Content = new Label
                    {
                        Padding = new Thickness(0, 0, 0, 0),
                        Text = Message_Enty.Text,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        HeightRequest = 60,
                        WidthRequest = 100,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        BackgroundColor = Color.FromHex("ADB9FA")
                    }
                };
                stack_layout.Children.Add(frame1);
            }
            else
            {
                Frame frame2 = new Frame
                {
                    Padding = 0,
                    CornerRadius = 10,
                    WidthRequest = Message_Enty.Text.Length * 10,
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    Content = new Label
                    {
                        Padding = new Thickness(0, 0, 0, 0),
                        Text = Message_Enty.Text,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        HeightRequest = 60,
                        WidthRequest = Message_Enty.Text.Length * 10,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        BackgroundColor = Color.FromHex("ADB9FA")
                    }
                };
                stack_layout.Children.Add(frame2);
            }           
        }
    }
}
