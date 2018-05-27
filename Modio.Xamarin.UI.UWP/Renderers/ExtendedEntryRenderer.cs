﻿using Modio.Xamarin.UI.Clients.UWP.Extensions;
using Modio.Xamarin.UI.Clients.UWP.Renderers;
using Modio.Xamarin.UI.Controls;
using System.ComponentModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace Modio.Xamarin.UI.Clients.UWP.Renderers
{
    public class ExtendedEntryRenderer : EntryRenderer
    {
        public ExtendedEntry ExtendedEntryElement => Element as ExtendedEntry;

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control != null)
                {
                    Control.Style = App.Current.Resources["FormTextBoxStyle"] as Windows.UI.Xaml.Style;
                }

                Control.Loaded -= OnControlLoaded;
                Control.Loaded += OnControlLoaded;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName.Equals(nameof(ExtendedEntry.LineColorToApply)))
            {
                UpdateLineColor();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (Control != null)
            {
                Control.Loaded -= OnControlLoaded;
            }

            base.Dispose(disposing);
        }

        private void UpdateLineColor()
        {
            var border = Control.FindVisualChildren<Border>()      
                .Where(c => c.Name == "BorderElement")
                .FirstOrDefault();

            if (border != null)
            {
                border.BorderBrush = new SolidColorBrush(ExtendedEntryElement.LineColorToApply.ToUwp());
            }
        }

        private void OnControlLoaded(object sender, RoutedEventArgs e)
        {
            UpdateLineColor();
        }
    }
}
