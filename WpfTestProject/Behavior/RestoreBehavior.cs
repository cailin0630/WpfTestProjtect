#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using Syncfusion.Windows.Shared;

namespace WpfTestProject.Behavior
{
    public class RestoreBehavior : Behavior<Button>
    {
        protected override void OnAttached()
        {
            this.AssociatedObject.Click += new RoutedEventHandler(AssociatedObject_Click);
            base.OnAttached();
        }

        void AssociatedObject_Click(object sender, RoutedEventArgs e)
        {
            TileViewControl tileControl = ((MainWindow)App.Current.MainWindow).Tiles;
            TileViewItem tileitem = tileControl.ItemContainerGenerator.ContainerFromIndex(tileControl.SelectedIndex) as TileViewItem;
            tileitem.TileViewItemState = TileViewItemState.Normal;
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.Click -= new RoutedEventHandler(AssociatedObject_Click);
            base.OnDetaching();
        }
    }
}