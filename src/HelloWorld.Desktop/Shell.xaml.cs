// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Windows;
using MahApps.Metro.Controls;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : MetroWindow
    {
        public Shell()
        {
            InitializeComponent();
         }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var newWindow = new Shell();
            newWindow.Show();

        }
    }
}
