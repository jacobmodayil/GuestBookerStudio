using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AvalonDock;

namespace Guest_Booker_Studio.Pages.Generic
{
    /// <summary>
    /// Interaction logic for InnerWindow.xaml
    /// </summary>
    public partial class InnerWindow : DockableContent
    {
        public InnerWindow()
        {
            InitializeComponent();
        }
        public void AddNewTab(DocumentContent newTab)
        {            
            this.DocumentManager.Items.Add(newTab);
            newTab.Focus();
        }
        public void FocusTab(string tabTitle)
        {
            var openTabs = DocumentManager.Items;
            foreach (var tab in openTabs)
            {
                var doc = tab as DocumentContent;
                if (doc.Title == tabTitle)
                {
                    doc.Focus();
                }
            }
        }
    }
}
