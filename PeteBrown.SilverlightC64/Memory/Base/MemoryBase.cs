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

namespace PeteBrown.SilverlightC64.Memory.Base
{
    public abstract class MemoryBase
    {
        //private int _size;
        protected byte[] _bytes;

        public MemoryBase(int size)
        {
            _bytes = new byte[size];
        }


        public byte Read(int address)
        {
            return _bytes[address];
        }

        // this is going to be so much slower than the original pointer-based version
        public byte[] Read(int startAddress, int length)
        {
            int endAddress = startAddress + length;

            byte[] bytes = new byte[length];

            for (int i = startAddress; i < endAddress; i++)
            {
                bytes[i] = _bytes[i];
            }

            return bytes;
        }




    }
}
