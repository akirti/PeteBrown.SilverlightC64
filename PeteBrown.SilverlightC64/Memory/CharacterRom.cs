﻿using System;
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
    public class CharacterRom : RomBase
    {
        public CharacterRom()
            :base(
            new byte[] {
                0x3c, 0x66, 0x6e, 0x6e, 0x60, 0x62, 0x3c, 0x0, 0x18, 0x3c, 0x66, 0x7e, 0x66, 0x66, 0x66, 0x0, 
                0x7c, 0x66, 0x66, 0x7c, 0x66, 0x66, 0x7c, 0x0, 0x3c, 0x66, 0x60, 0x60, 0x60, 0x66, 0x3c, 0x0, 
                0x78, 0x6c, 0x66, 0x66, 0x66, 0x6c, 0x78, 0x0, 0x7e, 0x60, 0x60, 0x78, 0x60, 0x60, 0x7e, 0x0, 
                0x7e, 0x60, 0x60, 0x78, 0x60, 0x60, 0x60, 0x0, 0x3c, 0x66, 0x60, 0x6e, 0x66, 0x66, 0x3c, 0x0, 
                0x66, 0x66, 0x66, 0x7e, 0x66, 0x66, 0x66, 0x0, 0x3c, 0x18, 0x18, 0x18, 0x18, 0x18, 0x3c, 0x0, 
                0x1e, 0xc, 0xc, 0xc, 0xc, 0x6c, 0x38, 0x0, 0x66, 0x6c, 0x78, 0x70, 0x78, 0x6c, 0x66, 0x0, 
                0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x7e, 0x0, 0x63, 0x77, 0x7f, 0x6b, 0x63, 0x63, 0x63, 0x0, 
                0x66, 0x76, 0x7e, 0x7e, 0x6e, 0x66, 0x66, 0x0, 0x3c, 0x66, 0x66, 0x66, 0x66, 0x66, 0x3c, 0x0, 
                0x7c, 0x66, 0x66, 0x7c, 0x60, 0x60, 0x60, 0x0, 0x3c, 0x66, 0x66, 0x66, 0x66, 0x3c, 0xe, 0x0, 
                0x7c, 0x66, 0x66, 0x7c, 0x78, 0x6c, 0x66, 0x0, 0x3c, 0x66, 0x60, 0x3c, 0x6, 0x66, 0x3c, 0x0, 
                0x7e, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x0, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x3c, 0x0, 
                0x66, 0x66, 0x66, 0x66, 0x66, 0x3c, 0x18, 0x0, 0x63, 0x63, 0x63, 0x6b, 0x7f, 0x77, 0x63, 0x0, 
                0x66, 0x66, 0x3c, 0x18, 0x3c, 0x66, 0x66, 0x0, 0x66, 0x66, 0x66, 0x3c, 0x18, 0x18, 0x18, 0x0, 
                0x7e, 0x6, 0xc, 0x18, 0x30, 0x60, 0x7e, 0x0, 0x3c, 0x30, 0x30, 0x30, 0x30, 0x30, 0x3c, 0x0, 
                0xc, 0x12, 0x30, 0x7c, 0x30, 0x62, 0xfc, 0x0, 0x3c, 0xc, 0xc, 0xc, 0xc, 0xc, 0x3c, 0x0, 
                0x0, 0x18, 0x3c, 0x7e, 0x18, 0x18, 0x18, 0x18, 0x0, 0x10, 0x30, 0x7f, 0x7f, 0x30, 0x10, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x18, 0x18, 0x18, 0x18, 0x0, 0x0, 0x18, 0x0, 
                0x66, 0x66, 0x66, 0x0, 0x0, 0x0, 0x0, 0x0, 0x66, 0x66, 0xff, 0x66, 0xff, 0x66, 0x66, 0x0, 
                0x18, 0x3e, 0x60, 0x3c, 0x6, 0x7c, 0x18, 0x0, 0x62, 0x66, 0xc, 0x18, 0x30, 0x66, 0x46, 0x0, 
                0x3c, 0x66, 0x3c, 0x38, 0x67, 0x66, 0x3f, 0x0, 0x6, 0xc, 0x18, 0x0, 0x0, 0x0, 0x0, 0x0, 
                0xc, 0x18, 0x30, 0x30, 0x30, 0x18, 0xc, 0x0, 0x30, 0x18, 0xc, 0xc, 0xc, 0x18, 0x30, 0x0, 
                0x0, 0x66, 0x3c, 0xff, 0x3c, 0x66, 0x0, 0x0, 0x0, 0x18, 0x18, 0x7e, 0x18, 0x18, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x18, 0x18, 0x30, 0x0, 0x0, 0x0, 0x7e, 0x0, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x18, 0x18, 0x0, 0x0, 0x3, 0x6, 0xc, 0x18, 0x30, 0x60, 0x0, 
                0x3c, 0x66, 0x6e, 0x76, 0x66, 0x66, 0x3c, 0x0, 0x18, 0x18, 0x38, 0x18, 0x18, 0x18, 0x7e, 0x0, 
                0x3c, 0x66, 0x6, 0xc, 0x30, 0x60, 0x7e, 0x0, 0x3c, 0x66, 0x6, 0x1c, 0x6, 0x66, 0x3c, 0x0, 
                0x6, 0xe, 0x1e, 0x66, 0x7f, 0x6, 0x6, 0x0, 0x7e, 0x60, 0x7c, 0x6, 0x6, 0x66, 0x3c, 0x0, 
                0x3c, 0x66, 0x60, 0x7c, 0x66, 0x66, 0x3c, 0x0, 0x7e, 0x66, 0xc, 0x18, 0x18, 0x18, 0x18, 0x0, 
                0x3c, 0x66, 0x66, 0x3c, 0x66, 0x66, 0x3c, 0x0, 0x3c, 0x66, 0x66, 0x3e, 0x6, 0x66, 0x3c, 0x0, 
                0x0, 0x0, 0x18, 0x0, 0x0, 0x18, 0x0, 0x0, 0x0, 0x0, 0x18, 0x0, 0x0, 0x18, 0x18, 0x30, 
                0xe, 0x18, 0x30, 0x60, 0x30, 0x18, 0xe, 0x0, 0x0, 0x0, 0x7e, 0x0, 0x7e, 0x0, 0x0, 0x0, 
                0x70, 0x18, 0xc, 0x6, 0xc, 0x18, 0x70, 0x0, 0x3c, 0x66, 0x6, 0xc, 0x18, 0x0, 0x18, 0x0, 
                0x0, 0x0, 0x0, 0xff, 0xff, 0x0, 0x0, 0x0, 0x8, 0x1c, 0x3e, 0x7f, 0x7f, 0x1c, 0x3e, 0x0, 
                0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x0, 0x0, 0x0, 0xff, 0xff, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0x0, 0x0, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 
                0xc, 0xc, 0xc, 0xc, 0xc, 0xc, 0xc, 0xc, 0x0, 0x0, 0x0, 0xe0, 0xf0, 0x38, 0x18, 0x18, 
                0x18, 0x18, 0x1c, 0xf, 0x7, 0x0, 0x0, 0x0, 0x18, 0x18, 0x38, 0xf0, 0xe0, 0x0, 0x0, 0x0, 
                0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xff, 0xff, 0xc0, 0xe0, 0x70, 0x38, 0x1c, 0xe, 0x7, 0x3, 
                0x3, 0x7, 0xe, 0x1c, 0x38, 0x70, 0xe0, 0xc0, 0xff, 0xff, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 
                0xff, 0xff, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x0, 0x3c, 0x7e, 0x7e, 0x7e, 0x7e, 0x3c, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0x0, 0x36, 0x7f, 0x7f, 0x7f, 0x3e, 0x1c, 0x8, 0x0, 
                0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x0, 0x0, 0x0, 0x7, 0xf, 0x1c, 0x18, 0x18, 
                0xc3, 0xe7, 0x7e, 0x3c, 0x3c, 0x7e, 0xe7, 0xc3, 0x0, 0x3c, 0x7e, 0x66, 0x66, 0x7e, 0x3c, 0x0, 
                0x18, 0x18, 0x66, 0x66, 0x18, 0x18, 0x3c, 0x0, 0x6, 0x6, 0x6, 0x6, 0x6, 0x6, 0x6, 0x6, 
                0x8, 0x1c, 0x3e, 0x7f, 0x3e, 0x1c, 0x8, 0x0, 0x18, 0x18, 0x18, 0xff, 0xff, 0x18, 0x18, 0x18, 
                0xc0, 0xc0, 0x30, 0x30, 0xc0, 0xc0, 0x30, 0x30, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 
                0x0, 0x0, 0x3, 0x3e, 0x76, 0x36, 0x36, 0x0, 0xff, 0x7f, 0x3f, 0x1f, 0xf, 0x7, 0x3, 0x1, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 
                0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 
                0xcc, 0xcc, 0x33, 0x33, 0xcc, 0xcc, 0x33, 0x33, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 
                0x0, 0x0, 0x0, 0x0, 0xcc, 0xcc, 0x33, 0x33, 0xff, 0xfe, 0xfc, 0xf8, 0xf0, 0xe0, 0xc0, 0x80, 
                0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x18, 0x18, 0x18, 0x1f, 0x1f, 0x18, 0x18, 0x18, 
                0x0, 0x0, 0x0, 0x0, 0xf, 0xf, 0xf, 0xf, 0x18, 0x18, 0x18, 0x1f, 0x1f, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0xf8, 0xf8, 0x18, 0x18, 0x18, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 
                0x0, 0x0, 0x0, 0x1f, 0x1f, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0xff, 0xff, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0xff, 0xff, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0xf8, 0xf8, 0x18, 0x18, 0x18, 
                0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 
                0x7, 0x7, 0x7, 0x7, 0x7, 0x7, 0x7, 0x7, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
                0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0xff, 
                0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0xf0, 0xf0, 0xf0, 0xf0, 
                0xf, 0xf, 0xf, 0xf, 0x0, 0x0, 0x0, 0x0, 0x18, 0x18, 0x18, 0xf8, 0xf8, 0x0, 0x0, 0x0, 
                0xf0, 0xf0, 0xf0, 0xf0, 0x0, 0x0, 0x0, 0x0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf, 0xf, 0xf, 0xf, 
                0xc3, 0x99, 0x91, 0x91, 0x9f, 0x99, 0xc3, 0xff, 0xe7, 0xc3, 0x99, 0x81, 0x99, 0x99, 0x99, 0xff, 
                0x83, 0x99, 0x99, 0x83, 0x99, 0x99, 0x83, 0xff, 0xc3, 0x99, 0x9f, 0x9f, 0x9f, 0x99, 0xc3, 0xff, 
                0x87, 0x93, 0x99, 0x99, 0x99, 0x93, 0x87, 0xff, 0x81, 0x9f, 0x9f, 0x87, 0x9f, 0x9f, 0x81, 0xff, 
                0x81, 0x9f, 0x9f, 0x87, 0x9f, 0x9f, 0x9f, 0xff, 0xc3, 0x99, 0x9f, 0x91, 0x99, 0x99, 0xc3, 0xff, 
                0x99, 0x99, 0x99, 0x81, 0x99, 0x99, 0x99, 0xff, 0xc3, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xc3, 0xff, 
                0xe1, 0xf3, 0xf3, 0xf3, 0xf3, 0x93, 0xc7, 0xff, 0x99, 0x93, 0x87, 0x8f, 0x87, 0x93, 0x99, 0xff, 
                0x9f, 0x9f, 0x9f, 0x9f, 0x9f, 0x9f, 0x81, 0xff, 0x9c, 0x88, 0x80, 0x94, 0x9c, 0x9c, 0x9c, 0xff, 
                0x99, 0x89, 0x81, 0x81, 0x91, 0x99, 0x99, 0xff, 0xc3, 0x99, 0x99, 0x99, 0x99, 0x99, 0xc3, 0xff, 
                0x83, 0x99, 0x99, 0x83, 0x9f, 0x9f, 0x9f, 0xff, 0xc3, 0x99, 0x99, 0x99, 0x99, 0xc3, 0xf1, 0xff, 
                0x83, 0x99, 0x99, 0x83, 0x87, 0x93, 0x99, 0xff, 0xc3, 0x99, 0x9f, 0xc3, 0xf9, 0x99, 0xc3, 0xff, 
                0x81, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0xc3, 0xff, 
                0x99, 0x99, 0x99, 0x99, 0x99, 0xc3, 0xe7, 0xff, 0x9c, 0x9c, 0x9c, 0x94, 0x80, 0x88, 0x9c, 0xff, 
                0x99, 0x99, 0xc3, 0xe7, 0xc3, 0x99, 0x99, 0xff, 0x99, 0x99, 0x99, 0xc3, 0xe7, 0xe7, 0xe7, 0xff, 
                0x81, 0xf9, 0xf3, 0xe7, 0xcf, 0x9f, 0x81, 0xff, 0xc3, 0xcf, 0xcf, 0xcf, 0xcf, 0xcf, 0xc3, 0xff, 
                0xf3, 0xed, 0xcf, 0x83, 0xcf, 0x9d, 0x3, 0xff, 0xc3, 0xf3, 0xf3, 0xf3, 0xf3, 0xf3, 0xc3, 0xff, 
                0xff, 0xe7, 0xc3, 0x81, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 0xef, 0xcf, 0x80, 0x80, 0xcf, 0xef, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 0xff, 0xe7, 0xff, 
                0x99, 0x99, 0x99, 0xff, 0xff, 0xff, 0xff, 0xff, 0x99, 0x99, 0x0, 0x99, 0x0, 0x99, 0x99, 0xff, 
                0xe7, 0xc1, 0x9f, 0xc3, 0xf9, 0x83, 0xe7, 0xff, 0x9d, 0x99, 0xf3, 0xe7, 0xcf, 0x99, 0xb9, 0xff, 
                0xc3, 0x99, 0xc3, 0xc7, 0x98, 0x99, 0xc0, 0xff, 0xf9, 0xf3, 0xe7, 0xff, 0xff, 0xff, 0xff, 0xff, 
                0xf3, 0xe7, 0xcf, 0xcf, 0xcf, 0xe7, 0xf3, 0xff, 0xcf, 0xe7, 0xf3, 0xf3, 0xf3, 0xe7, 0xcf, 0xff, 
                0xff, 0x99, 0xc3, 0x0, 0xc3, 0x99, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0x81, 0xe7, 0xe7, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xcf, 0xff, 0xff, 0xff, 0x81, 0xff, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xff, 0xff, 0xfc, 0xf9, 0xf3, 0xe7, 0xcf, 0x9f, 0xff, 
                0xc3, 0x99, 0x91, 0x89, 0x99, 0x99, 0xc3, 0xff, 0xe7, 0xe7, 0xc7, 0xe7, 0xe7, 0xe7, 0x81, 0xff, 
                0xc3, 0x99, 0xf9, 0xf3, 0xcf, 0x9f, 0x81, 0xff, 0xc3, 0x99, 0xf9, 0xe3, 0xf9, 0x99, 0xc3, 0xff, 
                0xf9, 0xf1, 0xe1, 0x99, 0x80, 0xf9, 0xf9, 0xff, 0x81, 0x9f, 0x83, 0xf9, 0xf9, 0x99, 0xc3, 0xff, 
                0xc3, 0x99, 0x9f, 0x83, 0x99, 0x99, 0xc3, 0xff, 0x81, 0x99, 0xf3, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 
                0xc3, 0x99, 0x99, 0xc3, 0x99, 0x99, 0xc3, 0xff, 0xc3, 0x99, 0x99, 0xc1, 0xf9, 0x99, 0xc3, 0xff, 
                0xff, 0xff, 0xe7, 0xff, 0xff, 0xe7, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xff, 0xff, 0xe7, 0xe7, 0xcf, 
                0xf1, 0xe7, 0xcf, 0x9f, 0xcf, 0xe7, 0xf1, 0xff, 0xff, 0xff, 0x81, 0xff, 0x81, 0xff, 0xff, 0xff, 
                0x8f, 0xe7, 0xf3, 0xf9, 0xf3, 0xe7, 0x8f, 0xff, 0xc3, 0x99, 0xf9, 0xf3, 0xe7, 0xff, 0xe7, 0xff, 
                0xff, 0xff, 0xff, 0x0, 0x0, 0xff, 0xff, 0xff, 0xf7, 0xe3, 0xc1, 0x80, 0x80, 0xe3, 0xc1, 0xff, 
                0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 0xff, 0xff, 0x0, 0x0, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0xff, 0xff, 0xcf, 0xcf, 0xcf, 0xcf, 0xcf, 0xcf, 0xcf, 0xcf, 
                0xf3, 0xf3, 0xf3, 0xf3, 0xf3, 0xf3, 0xf3, 0xf3, 0xff, 0xff, 0xff, 0x1f, 0xf, 0xc7, 0xe7, 0xe7, 
                0xe7, 0xe7, 0xe3, 0xf0, 0xf8, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xc7, 0xf, 0x1f, 0xff, 0xff, 0xff, 
                0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x0, 0x0, 0x3f, 0x1f, 0x8f, 0xc7, 0xe3, 0xf1, 0xf8, 0xfc, 
                0xfc, 0xf8, 0xf1, 0xe3, 0xc7, 0x8f, 0x1f, 0x3f, 0x0, 0x0, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 
                0x0, 0x0, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xff, 0xc3, 0x81, 0x81, 0x81, 0x81, 0xc3, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0xff, 0xc9, 0x80, 0x80, 0x80, 0xc1, 0xe3, 0xf7, 0xff, 
                0x9f, 0x9f, 0x9f, 0x9f, 0x9f, 0x9f, 0x9f, 0x9f, 0xff, 0xff, 0xff, 0xf8, 0xf0, 0xe3, 0xe7, 0xe7, 
                0x3c, 0x18, 0x81, 0xc3, 0xc3, 0x81, 0x18, 0x3c, 0xff, 0xc3, 0x81, 0x99, 0x99, 0x81, 0xc3, 0xff, 
                0xe7, 0xe7, 0x99, 0x99, 0xe7, 0xe7, 0xc3, 0xff, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 0xf9, 
                0xf7, 0xe3, 0xc1, 0x80, 0xc1, 0xe3, 0xf7, 0xff, 0xe7, 0xe7, 0xe7, 0x0, 0x0, 0xe7, 0xe7, 0xe7, 
                0x3f, 0x3f, 0xcf, 0xcf, 0x3f, 0x3f, 0xcf, 0xcf, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 
                0xff, 0xff, 0xfc, 0xc1, 0x89, 0xc9, 0xc9, 0xff, 0x0, 0x80, 0xc0, 0xe0, 0xf0, 0xf8, 0xfc, 0xfe, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf, 0xf, 0xf, 0xf, 0xf, 0xf, 0xf, 0xf, 
                0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 
                0x33, 0x33, 0xcc, 0xcc, 0x33, 0x33, 0xcc, 0xcc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 
                0xff, 0xff, 0xff, 0xff, 0x33, 0x33, 0xcc, 0xcc, 0x0, 0x1, 0x3, 0x7, 0xf, 0x1f, 0x3f, 0x7f, 
                0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xe7, 0xe7, 0xe7, 0xe0, 0xe0, 0xe7, 0xe7, 0xe7, 
                0xff, 0xff, 0xff, 0xff, 0xf0, 0xf0, 0xf0, 0xf0, 0xe7, 0xe7, 0xe7, 0xe0, 0xe0, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0x7, 0x7, 0xe7, 0xe7, 0xe7, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 
                0xff, 0xff, 0xff, 0xe0, 0xe0, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0x0, 0x0, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0x0, 0x0, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0x7, 0x7, 0xe7, 0xe7, 0xe7, 
                0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x1f, 0x1f, 0x1f, 0x1f, 0x1f, 0x1f, 0x1f, 0x1f, 
                0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 
                0x0, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 
                0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xf, 0xf, 0xf, 0xf, 
                0xf0, 0xf0, 0xf0, 0xf0, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xe7, 0x7, 0x7, 0xff, 0xff, 0xff, 
                0xf, 0xf, 0xf, 0xf, 0xff, 0xff, 0xff, 0xff, 0xf, 0xf, 0xf, 0xf, 0xf0, 0xf0, 0xf0, 0xf0, 
                0x3c, 0x66, 0x6e, 0x6e, 0x60, 0x62, 0x3c, 0x0, 0x0, 0x0, 0x3c, 0x6, 0x3e, 0x66, 0x3e, 0x0, 
                0x0, 0x60, 0x60, 0x7c, 0x66, 0x66, 0x7c, 0x0, 0x0, 0x0, 0x3c, 0x60, 0x60, 0x60, 0x3c, 0x0, 
                0x0, 0x6, 0x6, 0x3e, 0x66, 0x66, 0x3e, 0x0, 0x0, 0x0, 0x3c, 0x66, 0x7e, 0x60, 0x3c, 0x0, 
                0x0, 0xe, 0x18, 0x3e, 0x18, 0x18, 0x18, 0x0, 0x0, 0x0, 0x3e, 0x66, 0x66, 0x3e, 0x6, 0x7c, 
                0x0, 0x60, 0x60, 0x7c, 0x66, 0x66, 0x66, 0x0, 0x0, 0x18, 0x0, 0x38, 0x18, 0x18, 0x3c, 0x0, 
                0x0, 0x6, 0x0, 0x6, 0x6, 0x6, 0x6, 0x3c, 0x0, 0x60, 0x60, 0x6c, 0x78, 0x6c, 0x66, 0x0, 
                0x0, 0x38, 0x18, 0x18, 0x18, 0x18, 0x3c, 0x0, 0x0, 0x0, 0x66, 0x7f, 0x7f, 0x6b, 0x63, 0x0, 
                0x0, 0x0, 0x7c, 0x66, 0x66, 0x66, 0x66, 0x0, 0x0, 0x0, 0x3c, 0x66, 0x66, 0x66, 0x3c, 0x0, 
                0x0, 0x0, 0x7c, 0x66, 0x66, 0x7c, 0x60, 0x60, 0x0, 0x0, 0x3e, 0x66, 0x66, 0x3e, 0x6, 0x6, 
                0x0, 0x0, 0x7c, 0x66, 0x60, 0x60, 0x60, 0x0, 0x0, 0x0, 0x3e, 0x60, 0x3c, 0x6, 0x7c, 0x0, 
                0x0, 0x18, 0x7e, 0x18, 0x18, 0x18, 0xe, 0x0, 0x0, 0x0, 0x66, 0x66, 0x66, 0x66, 0x3e, 0x0, 
                0x0, 0x0, 0x66, 0x66, 0x66, 0x3c, 0x18, 0x0, 0x0, 0x0, 0x63, 0x6b, 0x7f, 0x3e, 0x36, 0x0, 
                0x0, 0x0, 0x66, 0x3c, 0x18, 0x3c, 0x66, 0x0, 0x0, 0x0, 0x66, 0x66, 0x66, 0x3e, 0xc, 0x78, 
                0x0, 0x0, 0x7e, 0xc, 0x18, 0x30, 0x7e, 0x0, 0x3c, 0x30, 0x30, 0x30, 0x30, 0x30, 0x3c, 0x0, 
                0xc, 0x12, 0x30, 0x7c, 0x30, 0x62, 0xfc, 0x0, 0x3c, 0xc, 0xc, 0xc, 0xc, 0xc, 0x3c, 0x0, 
                0x0, 0x18, 0x3c, 0x7e, 0x18, 0x18, 0x18, 0x18, 0x0, 0x10, 0x30, 0x7f, 0x7f, 0x30, 0x10, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x18, 0x18, 0x18, 0x18, 0x0, 0x0, 0x18, 0x0, 
                0x66, 0x66, 0x66, 0x0, 0x0, 0x0, 0x0, 0x0, 0x66, 0x66, 0xff, 0x66, 0xff, 0x66, 0x66, 0x0, 
                0x18, 0x3e, 0x60, 0x3c, 0x6, 0x7c, 0x18, 0x0, 0x62, 0x66, 0xc, 0x18, 0x30, 0x66, 0x46, 0x0, 
                0x3c, 0x66, 0x3c, 0x38, 0x67, 0x66, 0x3f, 0x0, 0x6, 0xc, 0x18, 0x0, 0x0, 0x0, 0x0, 0x0, 
                0xc, 0x18, 0x30, 0x30, 0x30, 0x18, 0xc, 0x0, 0x30, 0x18, 0xc, 0xc, 0xc, 0x18, 0x30, 0x0, 
                0x0, 0x66, 0x3c, 0xff, 0x3c, 0x66, 0x0, 0x0, 0x0, 0x18, 0x18, 0x7e, 0x18, 0x18, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x18, 0x18, 0x30, 0x0, 0x0, 0x0, 0x7e, 0x0, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x18, 0x18, 0x0, 0x0, 0x3, 0x6, 0xc, 0x18, 0x30, 0x60, 0x0, 
                0x3c, 0x66, 0x6e, 0x76, 0x66, 0x66, 0x3c, 0x0, 0x18, 0x18, 0x38, 0x18, 0x18, 0x18, 0x7e, 0x0, 
                0x3c, 0x66, 0x6, 0xc, 0x30, 0x60, 0x7e, 0x0, 0x3c, 0x66, 0x6, 0x1c, 0x6, 0x66, 0x3c, 0x0, 
                0x6, 0xe, 0x1e, 0x66, 0x7f, 0x6, 0x6, 0x0, 0x7e, 0x60, 0x7c, 0x6, 0x6, 0x66, 0x3c, 0x0, 
                0x3c, 0x66, 0x60, 0x7c, 0x66, 0x66, 0x3c, 0x0, 0x7e, 0x66, 0xc, 0x18, 0x18, 0x18, 0x18, 0x0, 
                0x3c, 0x66, 0x66, 0x3c, 0x66, 0x66, 0x3c, 0x0, 0x3c, 0x66, 0x66, 0x3e, 0x6, 0x66, 0x3c, 0x0, 
                0x0, 0x0, 0x18, 0x0, 0x0, 0x18, 0x0, 0x0, 0x0, 0x0, 0x18, 0x0, 0x0, 0x18, 0x18, 0x30, 
                0xe, 0x18, 0x30, 0x60, 0x30, 0x18, 0xe, 0x0, 0x0, 0x0, 0x7e, 0x0, 0x7e, 0x0, 0x0, 0x0, 
                0x70, 0x18, 0xc, 0x6, 0xc, 0x18, 0x70, 0x0, 0x3c, 0x66, 0x6, 0xc, 0x18, 0x0, 0x18, 0x0, 
                0x0, 0x0, 0x0, 0xff, 0xff, 0x0, 0x0, 0x0, 0x18, 0x3c, 0x66, 0x7e, 0x66, 0x66, 0x66, 0x0, 
                0x7c, 0x66, 0x66, 0x7c, 0x66, 0x66, 0x7c, 0x0, 0x3c, 0x66, 0x60, 0x60, 0x60, 0x66, 0x3c, 0x0, 
                0x78, 0x6c, 0x66, 0x66, 0x66, 0x6c, 0x78, 0x0, 0x7e, 0x60, 0x60, 0x78, 0x60, 0x60, 0x7e, 0x0, 
                0x7e, 0x60, 0x60, 0x78, 0x60, 0x60, 0x60, 0x0, 0x3c, 0x66, 0x60, 0x6e, 0x66, 0x66, 0x3c, 0x0, 
                0x66, 0x66, 0x66, 0x7e, 0x66, 0x66, 0x66, 0x0, 0x3c, 0x18, 0x18, 0x18, 0x18, 0x18, 0x3c, 0x0, 
                0x1e, 0xc, 0xc, 0xc, 0xc, 0x6c, 0x38, 0x0, 0x66, 0x6c, 0x78, 0x70, 0x78, 0x6c, 0x66, 0x0, 
                0x60, 0x60, 0x60, 0x60, 0x60, 0x60, 0x7e, 0x0, 0x63, 0x77, 0x7f, 0x6b, 0x63, 0x63, 0x63, 0x0, 
                0x66, 0x76, 0x7e, 0x7e, 0x6e, 0x66, 0x66, 0x0, 0x3c, 0x66, 0x66, 0x66, 0x66, 0x66, 0x3c, 0x0, 
                0x7c, 0x66, 0x66, 0x7c, 0x60, 0x60, 0x60, 0x0, 0x3c, 0x66, 0x66, 0x66, 0x66, 0x3c, 0xe, 0x0, 
                0x7c, 0x66, 0x66, 0x7c, 0x78, 0x6c, 0x66, 0x0, 0x3c, 0x66, 0x60, 0x3c, 0x6, 0x66, 0x3c, 0x0, 
                0x7e, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x0, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x3c, 0x0, 
                0x66, 0x66, 0x66, 0x66, 0x66, 0x3c, 0x18, 0x0, 0x63, 0x63, 0x63, 0x6b, 0x7f, 0x77, 0x63, 0x0, 
                0x66, 0x66, 0x3c, 0x18, 0x3c, 0x66, 0x66, 0x0, 0x66, 0x66, 0x66, 0x3c, 0x18, 0x18, 0x18, 0x0, 
                0x7e, 0x6, 0xc, 0x18, 0x30, 0x60, 0x7e, 0x0, 0x18, 0x18, 0x18, 0xff, 0xff, 0x18, 0x18, 0x18, 
                0xc0, 0xc0, 0x30, 0x30, 0xc0, 0xc0, 0x30, 0x30, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 
                0x33, 0x33, 0xcc, 0xcc, 0x33, 0x33, 0xcc, 0xcc, 0x33, 0x99, 0xcc, 0x66, 0x33, 0x99, 0xcc, 0x66, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf0, 
                0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 
                0xcc, 0xcc, 0x33, 0x33, 0xcc, 0xcc, 0x33, 0x33, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 
                0x0, 0x0, 0x0, 0x0, 0xcc, 0xcc, 0x33, 0x33, 0xcc, 0x99, 0x33, 0x66, 0xcc, 0x99, 0x33, 0x66, 
                0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x3, 0x18, 0x18, 0x18, 0x1f, 0x1f, 0x18, 0x18, 0x18, 
                0x0, 0x0, 0x0, 0x0, 0xf, 0xf, 0xf, 0xf, 0x18, 0x18, 0x18, 0x1f, 0x1f, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0xf8, 0xf8, 0x18, 0x18, 0x18, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 
                0x0, 0x0, 0x0, 0x1f, 0x1f, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0xff, 0xff, 0x0, 0x0, 0x0, 
                0x0, 0x0, 0x0, 0xff, 0xff, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0xf8, 0xf8, 0x18, 0x18, 0x18, 
                0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 0xe0, 
                0x7, 0x7, 0x7, 0x7, 0x7, 0x7, 0x7, 0x7, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
                0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0xff, 
                0x1, 0x3, 0x6, 0x6c, 0x78, 0x70, 0x60, 0x0, 0x0, 0x0, 0x0, 0x0, 0xf0, 0xf0, 0xf0, 0xf0, 
                0xf, 0xf, 0xf, 0xf, 0x0, 0x0, 0x0, 0x0, 0x18, 0x18, 0x18, 0xf8, 0xf8, 0x0, 0x0, 0x0, 
                0xf0, 0xf0, 0xf0, 0xf0, 0x0, 0x0, 0x0, 0x0, 0xf0, 0xf0, 0xf0, 0xf0, 0xf, 0xf, 0xf, 0xf, 
                0xc3, 0x99, 0x91, 0x91, 0x9f, 0x99, 0xc3, 0xff, 0xff, 0xff, 0xc3, 0xf9, 0xc1, 0x99, 0xc1, 0xff, 
                0xff, 0x9f, 0x9f, 0x83, 0x99, 0x99, 0x83, 0xff, 0xff, 0xff, 0xc3, 0x9f, 0x9f, 0x9f, 0xc3, 0xff, 
                0xff, 0xf9, 0xf9, 0xc1, 0x99, 0x99, 0xc1, 0xff, 0xff, 0xff, 0xc3, 0x99, 0x81, 0x9f, 0xc3, 0xff, 
                0xff, 0xf1, 0xe7, 0xc1, 0xe7, 0xe7, 0xe7, 0xff, 0xff, 0xff, 0xc1, 0x99, 0x99, 0xc1, 0xf9, 0x83, 
                0xff, 0x9f, 0x9f, 0x83, 0x99, 0x99, 0x99, 0xff, 0xff, 0xe7, 0xff, 0xc7, 0xe7, 0xe7, 0xc3, 0xff, 
                0xff, 0xf9, 0xff, 0xf9, 0xf9, 0xf9, 0xf9, 0xc3, 0xff, 0x9f, 0x9f, 0x93, 0x87, 0x93, 0x99, 0xff, 
                0xff, 0xc7, 0xe7, 0xe7, 0xe7, 0xe7, 0xc3, 0xff, 0xff, 0xff, 0x99, 0x80, 0x80, 0x94, 0x9c, 0xff, 
                0xff, 0xff, 0x83, 0x99, 0x99, 0x99, 0x99, 0xff, 0xff, 0xff, 0xc3, 0x99, 0x99, 0x99, 0xc3, 0xff, 
                0xff, 0xff, 0x83, 0x99, 0x99, 0x83, 0x9f, 0x9f, 0xff, 0xff, 0xc1, 0x99, 0x99, 0xc1, 0xf9, 0xf9, 
                0xff, 0xff, 0x83, 0x99, 0x9f, 0x9f, 0x9f, 0xff, 0xff, 0xff, 0xc1, 0x9f, 0xc3, 0xf9, 0x83, 0xff, 
                0xff, 0xe7, 0x81, 0xe7, 0xe7, 0xe7, 0xf1, 0xff, 0xff, 0xff, 0x99, 0x99, 0x99, 0x99, 0xc1, 0xff, 
                0xff, 0xff, 0x99, 0x99, 0x99, 0xc3, 0xe7, 0xff, 0xff, 0xff, 0x9c, 0x94, 0x80, 0xc1, 0xc9, 0xff, 
                0xff, 0xff, 0x99, 0xc3, 0xe7, 0xc3, 0x99, 0xff, 0xff, 0xff, 0x99, 0x99, 0x99, 0xc1, 0xf3, 0x87, 
                0xff, 0xff, 0x81, 0xf3, 0xe7, 0xcf, 0x81, 0xff, 0xc3, 0xcf, 0xcf, 0xcf, 0xcf, 0xcf, 0xc3, 0xff, 
                0xf3, 0xed, 0xcf, 0x83, 0xcf, 0x9d, 0x3, 0xff, 0xc3, 0xf3, 0xf3, 0xf3, 0xf3, 0xf3, 0xc3, 0xff, 
                0xff, 0xe7, 0xc3, 0x81, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 0xef, 0xcf, 0x80, 0x80, 0xcf, 0xef, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 0xff, 0xe7, 0xff, 
                0x99, 0x99, 0x99, 0xff, 0xff, 0xff, 0xff, 0xff, 0x99, 0x99, 0x0, 0x99, 0x0, 0x99, 0x99, 0xff, 
                0xe7, 0xc1, 0x9f, 0xc3, 0xf9, 0x83, 0xe7, 0xff, 0x9d, 0x99, 0xf3, 0xe7, 0xcf, 0x99, 0xb9, 0xff, 
                0xc3, 0x99, 0xc3, 0xc7, 0x98, 0x99, 0xc0, 0xff, 0xf9, 0xf3, 0xe7, 0xff, 0xff, 0xff, 0xff, 0xff, 
                0xf3, 0xe7, 0xcf, 0xcf, 0xcf, 0xe7, 0xf3, 0xff, 0xcf, 0xe7, 0xf3, 0xf3, 0xf3, 0xe7, 0xcf, 0xff, 
                0xff, 0x99, 0xc3, 0x0, 0xc3, 0x99, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0x81, 0xe7, 0xe7, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xcf, 0xff, 0xff, 0xff, 0x81, 0xff, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xff, 0xff, 0xfc, 0xf9, 0xf3, 0xe7, 0xcf, 0x9f, 0xff, 
                0xc3, 0x99, 0x91, 0x89, 0x99, 0x99, 0xc3, 0xff, 0xe7, 0xe7, 0xc7, 0xe7, 0xe7, 0xe7, 0x81, 0xff, 
                0xc3, 0x99, 0xf9, 0xf3, 0xcf, 0x9f, 0x81, 0xff, 0xc3, 0x99, 0xf9, 0xe3, 0xf9, 0x99, 0xc3, 0xff, 
                0xf9, 0xf1, 0xe1, 0x99, 0x80, 0xf9, 0xf9, 0xff, 0x81, 0x9f, 0x83, 0xf9, 0xf9, 0x99, 0xc3, 0xff, 
                0xc3, 0x99, 0x9f, 0x83, 0x99, 0x99, 0xc3, 0xff, 0x81, 0x99, 0xf3, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 
                0xc3, 0x99, 0x99, 0xc3, 0x99, 0x99, 0xc3, 0xff, 0xc3, 0x99, 0x99, 0xc1, 0xf9, 0x99, 0xc3, 0xff, 
                0xff, 0xff, 0xe7, 0xff, 0xff, 0xe7, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xff, 0xff, 0xe7, 0xe7, 0xcf, 
                0xf1, 0xe7, 0xcf, 0x9f, 0xcf, 0xe7, 0xf1, 0xff, 0xff, 0xff, 0x81, 0xff, 0x81, 0xff, 0xff, 0xff, 
                0x8f, 0xe7, 0xf3, 0xf9, 0xf3, 0xe7, 0x8f, 0xff, 0xc3, 0x99, 0xf9, 0xf3, 0xe7, 0xff, 0xe7, 0xff, 
                0xff, 0xff, 0xff, 0x0, 0x0, 0xff, 0xff, 0xff, 0xe7, 0xc3, 0x99, 0x81, 0x99, 0x99, 0x99, 0xff, 
                0x83, 0x99, 0x99, 0x83, 0x99, 0x99, 0x83, 0xff, 0xc3, 0x99, 0x9f, 0x9f, 0x9f, 0x99, 0xc3, 0xff, 
                0x87, 0x93, 0x99, 0x99, 0x99, 0x93, 0x87, 0xff, 0x81, 0x9f, 0x9f, 0x87, 0x9f, 0x9f, 0x81, 0xff, 
                0x81, 0x9f, 0x9f, 0x87, 0x9f, 0x9f, 0x9f, 0xff, 0xc3, 0x99, 0x9f, 0x91, 0x99, 0x99, 0xc3, 0xff, 
                0x99, 0x99, 0x99, 0x81, 0x99, 0x99, 0x99, 0xff, 0xc3, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xc3, 0xff, 
                0xe1, 0xf3, 0xf3, 0xf3, 0xf3, 0x93, 0xc7, 0xff, 0x99, 0x93, 0x87, 0x8f, 0x87, 0x93, 0x99, 0xff, 
                0x9f, 0x9f, 0x9f, 0x9f, 0x9f, 0x9f, 0x81, 0xff, 0x9c, 0x88, 0x80, 0x94, 0x9c, 0x9c, 0x9c, 0xff, 
                0x99, 0x89, 0x81, 0x81, 0x91, 0x99, 0x99, 0xff, 0xc3, 0x99, 0x99, 0x99, 0x99, 0x99, 0xc3, 0xff, 
                0x83, 0x99, 0x99, 0x83, 0x9f, 0x9f, 0x9f, 0xff, 0xc3, 0x99, 0x99, 0x99, 0x99, 0xc3, 0xf1, 0xff, 
                0x83, 0x99, 0x99, 0x83, 0x87, 0x93, 0x99, 0xff, 0xc3, 0x99, 0x9f, 0xc3, 0xf9, 0x99, 0xc3, 0xff, 
                0x81, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xff, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0xc3, 0xff, 
                0x99, 0x99, 0x99, 0x99, 0x99, 0xc3, 0xe7, 0xff, 0x9c, 0x9c, 0x9c, 0x94, 0x80, 0x88, 0x9c, 0xff, 
                0x99, 0x99, 0xc3, 0xe7, 0xc3, 0x99, 0x99, 0xff, 0x99, 0x99, 0x99, 0xc3, 0xe7, 0xe7, 0xe7, 0xff, 
                0x81, 0xf9, 0xf3, 0xe7, 0xcf, 0x9f, 0x81, 0xff, 0xe7, 0xe7, 0xe7, 0x0, 0x0, 0xe7, 0xe7, 0xe7, 
                0x3f, 0x3f, 0xcf, 0xcf, 0x3f, 0x3f, 0xcf, 0xcf, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 
                0xcc, 0xcc, 0x33, 0x33, 0xcc, 0xcc, 0x33, 0x33, 0xcc, 0x66, 0x33, 0x99, 0xcc, 0x66, 0x33, 0x99, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf, 0xf, 0xf, 0xf, 0xf, 0xf, 0xf, 0xf, 
                0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 
                0x33, 0x33, 0xcc, 0xcc, 0x33, 0x33, 0xcc, 0xcc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 
                0xff, 0xff, 0xff, 0xff, 0x33, 0x33, 0xcc, 0xcc, 0x33, 0x66, 0xcc, 0x99, 0x33, 0x66, 0xcc, 0x99, 
                0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xfc, 0xe7, 0xe7, 0xe7, 0xe0, 0xe0, 0xe7, 0xe7, 0xe7, 
                0xff, 0xff, 0xff, 0xff, 0xf0, 0xf0, 0xf0, 0xf0, 0xe7, 0xe7, 0xe7, 0xe0, 0xe0, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0x7, 0x7, 0xe7, 0xe7, 0xe7, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 
                0xff, 0xff, 0xff, 0xe0, 0xe0, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0x0, 0x0, 0xff, 0xff, 0xff, 
                0xff, 0xff, 0xff, 0x0, 0x0, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0xe7, 0x7, 0x7, 0xe7, 0xe7, 0xe7, 
                0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x3f, 0x1f, 0x1f, 0x1f, 0x1f, 0x1f, 0x1f, 0x1f, 0x1f, 
                0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0xf8, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 
                0x0, 0x0, 0x0, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x0, 0x0, 0x0, 
                0xfe, 0xfc, 0xf9, 0x93, 0x87, 0x8f, 0x9f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf, 0xf, 0xf, 0xf, 
                0xf0, 0xf0, 0xf0, 0xf0, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe7, 0xe7, 0x7, 0x7, 0xff, 0xff, 0xff, 
                0xf, 0xf, 0xf, 0xf, 0xff, 0xff, 0xff, 0xff, 0xf, 0xf, 0xf, 0xf, 0xf0, 0xf0, 0xf0, 0xf0
                }
            )
        { }
    }
}
