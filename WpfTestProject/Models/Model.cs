#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows;

namespace WpfTestProject.Models
{
    public class ApplicationTile
    {
        public string Name { get; set; }

        public string Icon { get; set; }

        public string Description { get; set; }

        public string Color { get; set; }

        public string Header { get; set; }

        public string SlideImage { get; set; }

        public bool CanSlide { get; set; }

        public FrameworkElement View { get; set; }
    }
}
