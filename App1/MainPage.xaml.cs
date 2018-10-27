using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = widthInput.Text;
            width = double.Parse(widthString);

            heightString = heightInput.Text;
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea =  2 * (width * height);

            woodLengthOutput.Text = woodLength + " feet";
            glassAreaOutput.Text = glassArea + " square meters";
        }

        

        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            var slider = sender as Slider;

            var quantity = slider.Value;

            sldQuantity.Text = quantity.ToString();
        }

        private void widthInput_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string widthString = widthInput.Text;
            if (!int.TryParse(widthString, out int width))
            {
                widthNum.Text = "Width must be a number:";
            }
            else
            {
                widthNum.Text = "";
            }
        }

        private void heightInput_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string heightString = heightInput.Text;
            if (!int.TryParse(heightString, out int height))
            {
                heightNum.Text = "Height must be a number:";
            }
            else
            {
                heightNum.Text = "";
            }
        }
    }
}
