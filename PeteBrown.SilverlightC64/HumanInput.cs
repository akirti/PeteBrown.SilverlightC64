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

namespace PeteBrown.SilverlightC64
{

    public enum KeyboardEventType
    {
        KeyDown,
        KeyUp
    }

    public class KeyboardEvent
    {
        public Key Key { get; set; }
        public int PlatformKeyCode { get; set; }
        public KeyboardEventType EventType { get; set; }


        internal KeyboardEvent(KeyboardEventType eventType, Key key, int platformKeyCode)
        {
            Key = key;
            PlatformKeyCode = platformKeyCode;
            EventType = eventType;
        }



    }

    public class HumanInput
    {
        private static List<KeyboardEvent> _keyboardEvents = new List<KeyboardEvent>();


        public HumanInput()
        {
        }

        public static void AttachKeyboardEventHandlers()
        {
            App.Current.RootVisual.KeyDown += new KeyEventHandler(OnKeyDown);
            App.Current.RootVisual.KeyUp += new KeyEventHandler(OnKeyUp);
        }


        public static void AttachKeyboardEventHandlers(Control control)
        {
            control.KeyDown += new KeyEventHandler(OnKeyDown);
            control.KeyUp += new KeyEventHandler(OnKeyUp);
        }


        private static void OnKeyUp(object sender, KeyEventArgs e)
        {
            KeyboardEvent keyEvent = new KeyboardEvent(KeyboardEventType.KeyUp, e.Key, e.PlatformKeyCode);

            lock (_keyboardEvents)
            {
                _keyboardEvents.Add(keyEvent);
            }

            e.Handled = true;
        }

        private static void OnKeyDown(object sender, KeyEventArgs e)
        {
            KeyboardEvent keyEvent = new KeyboardEvent(KeyboardEventType.KeyDown, e.Key, e.PlatformKeyCode);

            lock (_keyboardEvents)
            {
                _keyboardEvents.Add(keyEvent);
            }

            e.Handled = true;
        }


        public static KeyboardEvent[] GetKeyboardEvents()
        {
            KeyboardEvent[] events;

            lock (_keyboardEvents)
            {
                events = _keyboardEvents.ToArray();
                _keyboardEvents.Clear();
            }

            return events;
        }


    }
}
