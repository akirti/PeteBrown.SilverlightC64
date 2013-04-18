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
    public class RamBytePointer
    {
        private int _address;
        private RamBase _memory;

        public RamBytePointer(RamBase memory, int address)
            : this(memory)
        {
            _address = address;
        }

        public RamBytePointer(RamBase memory)
        {
            _memory = memory;
        }

        public int Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public byte this[int offset]
        {
            get { return _memory[_address + offset]; }
            set { _memory[_address + offset] = value; }
        }

        public byte Value
        {
            get { return _memory[_address]; }
            set { _memory[_address] = value; }
        }

        public byte[] GetValues(int length)
        {
            return _memory.Read(_address, length);
        }

        public void SetValues(byte[] values)
        {
            _memory.Write(_address, values);
        }


        public RamBytePointer NewPointerAtOffset(int offset)
        {
            return new RamBytePointer(_memory, _address + offset);
        }

    }
}
