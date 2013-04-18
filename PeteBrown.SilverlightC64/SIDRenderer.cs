using System;
using System.IO;

namespace PeteBrown.SilverlightC64
{
    public abstract class SIDRenderer
    {
        public abstract void Reset();
        public abstract void EmulateLine();
        public abstract void VBlank();
	    public abstract void WriteRegister(UInt16 adr, Byte abyte);
	    public abstract void NewPrefs(Prefs prefs);
	    public abstract void Pause();
	    public abstract void Resume();

        public abstract Stream AudioStream { get; set; }

    }
}
