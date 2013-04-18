using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PeteBrown.SilverlightC64.Extensions
{
    public static class ColorExtensions
    {
        public static int ToBrg32(this Color color)
        {
            int brg = color.R << 16;
            brg |= color.G << 8;
            brg |= color.B << 0;

            return brg;
        }
    }
}
