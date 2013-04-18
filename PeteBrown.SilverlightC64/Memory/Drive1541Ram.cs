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

using PeteBrown.SilverlightC64.Memory.Base;

namespace PeteBrown.SilverlightC64.Memory
{
    public class Drive1541Ram : RamBase
    {
        private const int _bamStartIndex = 0x700;

        public Drive1541Ram()
            : base(0x0800)
        
        { 
        }


        public int BamStartIndex
        {
            get { return _bamStartIndex; }
        }


    }
}
