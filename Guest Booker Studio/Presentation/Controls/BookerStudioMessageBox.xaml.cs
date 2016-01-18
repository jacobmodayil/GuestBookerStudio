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
using System.Windows.Shapes;

namespace Guest_Booker_Studio.Presentation.Controls
{
    /// <summary>
    /// Interaction logic for BookerStudioMessageBox.xaml
    /// </summary>
    public partial class BookerStudioMessageBox : Window
    {
           #region Publicly Visible Memebers
        /// <summary>
        /// 0 if True, 
        /// 1-False, 
        /// Otherwise Returns -1
        /// </summary>
        new public int DialogResult { get; private set; }

        /// <summary>
        /// Dialog Type - specifies which actions to accept
        /// </summary>
        public GuestBookerMessageBoxButtons DialogType
        {
            get { return this.DialogType; }

            set
            {
                switch (value)
                {
                    case GuestBookerMessageBoxButtons.Yes:
                        {
                            cmdOk.Content = "Yes";
                            cmdOk.Margin = new Thickness(0, 0, 6, 6);
                            cmdCancel.Visibility = System.Windows.Visibility.Hidden;
                            break;
                        }
                    case GuestBookerMessageBoxButtons.YesNo:
                        {
                            cmdOk.Content = "Yes";
                            cmdOk.Margin = new Thickness(0, 0, 55, 6);
                            cmdOk.Visibility = Visibility.Visible;
                            cmdCancel.Content = "No";
                            cmdCancel.Visibility = Visibility.Visible;
                            break;
                        }
                    case GuestBookerMessageBoxButtons.Ok:
                        {
                            cmdOk.Content = "Ok";
                            cmdOk.Margin = new Thickness(0, 0, 6, 6);
                            cmdCancel.Visibility = System.Windows.Visibility.Hidden;
                            break;
                        }
                    case GuestBookerMessageBoxButtons.OkCancel:
                        {
                            cmdOk.Content = "Ok";
                            cmdOk.Margin = new Thickness(0, 0, 55, 6);
                            cmdOk.Visibility = Visibility.Visible;
                            cmdCancel.Content = "Cancel";
                            cmdCancel.Visibility = Visibility.Visible;
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        #endregion

        #region Constructors
        private BookerStudioMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Message Box with name and title
        /// </summary>
        /// <param name="title"></param>
        /// <param name="dialogMsg"></param>
        public BookerStudioMessageBox(string title, string dialogMsg)
            : this()
        {
            this.BookerStudioMessageBoxText.Text = dialogMsg;
            this.BookerStudioMessageBoxTitle.Text = title;
        }


        public BookerStudioMessageBox(string title, string dialogMsg, GuestBookerMessageBoxButtons dialogType)
            : this(title, dialogMsg)
        {
            DialogType = dialogType;
        }

        public BookerStudioMessageBox(string title, string dialogMsg, IconType iconType)
            : this(title, dialogMsg)
        {
            BookerStudioMessageBoximage.Source = new BitmapImage(new Uri(iconType.ToString(), UriKind.Relative));
        }

        /// <summary>
        /// Message Box with name, title and icon
        /// </summary>
        /// <param name="title"></param>
        /// <param name="dialogMsg"></param>
        /// <param name="iconType"></param>
        public BookerStudioMessageBox(string title, string dialogMsg, GuestBookerMessageBoxButtons dialogType, IconType iconType)
            : this(title, dialogMsg, dialogType)
        {
            BookerStudioMessageBoximage.Source = new BitmapImage(new Uri(iconType.ToString(), UriKind.Relative));
        }
        #endregion

        #region Event Handlers
        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = 1;
            this.Close();
        }

        private void cmdOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = 0;
            this.Close();
        }

        private void cmdClose_Click(object sender, RoutedEventArgs e)
        {
            FormFadeOut.Begin();
        }

        private void Part_Title_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        #endregion

        private void FormFadeOut_Completed(object sender, EventArgs e)
        {
            this.DialogResult = -1;
            this.Close();
        }


    }
}
    
namespace Guest_Booker_Studio.Presentation
{
    /// <summary>
    /// Icon Type and corresponding Image Path
    /// </summary>
    public sealed class IconType
    {

        private readonly string iconTypeName;
        private readonly string iconPath;

        private IconType(string iconTypeName, string iconPath)
        {
            this.iconTypeName = iconTypeName;
            this.iconPath = iconPath;
        }

        public static readonly IconType Info = new IconType("Info", "/Presentation/Resources/Images/info.png");
        public static readonly IconType Attention = new IconType("Attention", "/Presentation/Resources/Images/attention.png");


        public override string ToString()
        {
            return iconPath;
        }
    }
    public enum GuestBookerMessageBoxButtons
    {
        Yes,
        YesNo,
        Ok,
        OkCancel
    }
    
}

