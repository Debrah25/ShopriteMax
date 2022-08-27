using DocumentFormat.OpenXml.Bibliography;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MAX_INVENTORY_SYSTEM.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Homepage : Page
    {
        public Homepage()
        {
            this.InitializeComponent();
            contentFrame.Navigate(typeof(Dashboard));
        }

        private void nvSample_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItem.ToString() == Dashboard.Content.ToString())
            {
                contentFrame.Navigate(typeof(Dashboard));
            }
            else if (args.InvokedItem.ToString() == Order.Content.ToString())
            {
                contentFrame.Navigate(typeof(Orders));
            }
            else if (args.InvokedItem.ToString() == Report.Content.ToString())
            {
                contentFrame.Navigate(typeof(Reports));
            }
            else if (args.InvokedItem.ToString() == Sales.Content.ToString())
            {
                contentFrame.Navigate(typeof(Sales));
            }
            else if (args.InvokedItem.ToString() == Contact.Content.ToString())
            {
                contentFrame.Navigate(typeof(Contacts));
            }
            else if (args.InvokedItem.ToString() == Invoice.Content.ToString())
            {
                contentFrame.Navigate(typeof(Invoice));
            }
        }
    }
}
