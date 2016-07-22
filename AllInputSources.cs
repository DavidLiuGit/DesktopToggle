using System;
using System.Runtime.InteropServices;

namespace InputTrackingExample
{
    public class AllInputSources
    {
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        public DateTime GetLastInputTime()
        {
            var lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);

            GetLastInputInfo(ref lastInputInfo);

            return DateTime.Now.AddMilliseconds(-(Environment.TickCount - lastInputInfo.dwTime));
        }


        [StructLayout(LayoutKind.Sequential)]
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        /// <summary>
        /// Returns the amount of time since the last input was received, in a TimeSpan struct
        /// </summary>
        /// <param name="last">DateTime struct of last input</param>
        /// <returns></returns>
        public TimeSpan getDiff(DateTime last) {
            return (DateTime.Now - last);
        }
    }
}
