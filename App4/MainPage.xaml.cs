using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public CBConversionType_data conversionType = new CBConversionType_data();
        public DependencyProperty currentSelected;
        public MainPage()
        {
            this.InitializeComponent();
            this.conversionType.initConversionData();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void CBConversionType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /// currentSelected = CBConversionType.GetValue;

                    
        }

        private void CBConversionType_Loaded(object sender, RoutedEventArgs e)
        {
            // Create a new combo box, set it's items source, and add a SelectionChanged handler.
            CBConversionType.ItemsSource = conversionType.conversionTypeList;
            CBConversionType.SelectionChanged += CBConversionType_SelectionChanged;
        }

        private void CBConversionFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
