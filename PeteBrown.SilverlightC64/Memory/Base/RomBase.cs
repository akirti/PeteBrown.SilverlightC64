using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PeteBrown.SilverlightC64.Memory.Base
{
    public abstract class RomBase : MemoryBase
    {
        public RomBase(int size)
            : base(size)
        {  }

        public RomBase(byte[] data)
            : base(data.Length)
        {
            _bytes = data;
        }


        public byte this[int index]
        {
            get { return _bytes[index]; }
        }

    }
}
