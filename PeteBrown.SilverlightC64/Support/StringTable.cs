using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PeteBrown.SilverlightC64.Support
{
    public class StringTable : List<String>
    {

        public int? CurrentItemIndex { get; set; }

        public string CurrentItem
        {
            get
            {
                if (CurrentItemIndex != null)
                    return this[(int)CurrentItemIndex];
                else
                    return null;
            }
        }

    }
}
