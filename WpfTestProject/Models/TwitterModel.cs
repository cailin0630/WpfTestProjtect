#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;

namespace WpfTestProject.Models
{
    public class Tweet
    {
        public string Id { get; set; }
        public DateTime Published { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public Author Author { get; set; }
        public string Image { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Uri { get; set; }
    }
}
