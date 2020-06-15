using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace GetFavTest
{
    public class CustomCheckBox : CheckBox
    {
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var normalRectangle = GetTemplateChild("NormalRectangle") as Rectangle;
            var rootGrid = normalRectangle.Parent as Grid;
            Grid.SetColumnSpan(rootGrid, 2);
            rootGrid.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
            var contentPresenter = GetTemplateChild("ContentPresenter") as ContentPresenter;
            Grid.SetColumn(contentPresenter, 0);
            Grid.SetColumnSpan(contentPresenter, 2);
            contentPresenter.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
        
        }
      
    }
}
