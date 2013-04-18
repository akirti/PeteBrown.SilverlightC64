using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.IO;
using System.Diagnostics;

namespace PeteBrown.SilverlightC64
{
    public partial class UserInterface : UserControl
    {
        private C64 _c64;

        public UserInterface()
        {
            InitializeComponent();

            BrowseDrive08File.Click += new RoutedEventHandler(BrowseDrive08File_Click);
            BrowseDrive09File.Click += new RoutedEventHandler(BrowseDrive09File_Click);
            BrowseDrive10File.Click += new RoutedEventHandler(BrowseDrive10File_Click);
            BrowseDrive11File.Click += new RoutedEventHandler(BrowseDrive11File_Click);

            VideoDisplay.MediaFailed += new EventHandler<ExceptionRoutedEventArgs>(VideoDisplay_MediaFailed);

            Loaded += new RoutedEventHandler(UserInterface_Loaded);
        }

        void UserInterface_Loaded(object sender, RoutedEventArgs e)
        {
            _c64 = new C64(this);

            // should probably be in C64Display which is where other Silverlight-specific stuff ended up
            HumanInput.AttachKeyboardEventHandlers();

            VideoDisplay.SetSource(_c64.Video);

            _c64.Run();
        }

        void VideoDisplay_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("**** Media Failed ****");
            System.Diagnostics.Debug.WriteLine(e.ErrorException.ToString());
        }

        void BrowseDrive08File_Click(object sender, RoutedEventArgs e)
        {
            LoadFile(8);
        }

        void BrowseDrive09File_Click(object sender, RoutedEventArgs e)
        {
            LoadFile(9);
        }

        void BrowseDrive10File_Click(object sender, RoutedEventArgs e)
        {
            LoadFile(10);
        }

        void BrowseDrive11File_Click(object sender, RoutedEventArgs e)
        {
            LoadFile(11);
        }

        private void LoadFile(int driveNumber)
        {
            Debug.Assert(driveNumber >= 8 && driveNumber <= 11, string.Format("Invalid drive number {0}",driveNumber));

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "D64 Disk Image (*.d64)|*d64";

            if (dlg.ShowDialog() == true)
            {
                FileStream stream = dlg.File.OpenRead();
            
                int driveIndex = driveNumber - 8;

                GlobalPrefs.ThePrefs.DriveType[driveIndex] = DriveType.DRVTYPE_D64;
                GlobalPrefs.ThePrefs.DriveData[driveIndex] = stream;
                GlobalPrefs.ThePrefs.DrivePath[driveIndex] = dlg.File.Name;
                
                // HACK!
                _c64.NewPrefs(GlobalPrefs.ThePrefs);

                switch (driveNumber)
                {
                    case 8:
                        Drive08File.Text = "08: " + dlg.File.Name;
                        break;
                    case 9:
                        Drive09File.Text = "09: " + dlg.File.Name;
                        break;
                    case 10:
                        Drive10File.Text = "10: " + dlg.File.Name;
                        break;
                    case 11:
                        Drive11File.Text = "11: " + dlg.File.Name;
                        break;
                }


            }

            
        }
        

    }
}
