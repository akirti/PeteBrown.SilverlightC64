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
    public class ColorRam : RamBase
    {
        public ColorRam()
            : base(0x0400)
        { }

        public void InitializeWithRandomValues()
        {
            Random rand = new Random();

            for (int i = 0; i < 1024; i++)
                _bytes[i] = (byte)(rand.Next() & 0x0f);
        }




    }
}
