using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    public class colorInfo
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] colorMapMinor;
    
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static colorInfo()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }

    /// <summary>
    /// data type defined to hold the two colors of clor pair
    /// </summary>
    public class ColorPair
    {
        internal Color majorColor;
        internal Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}
