using System.Drawing;

namespace PatternEye.Common
{
    /// <summary>
    /// Raw Color structure
    /// </summary>
    public struct RColor
    {
        public byte red;
        public byte green;
        public byte blue;
        public byte alpha;
        /// <summary>
        /// Raw Color constructor
        /// </summary>
        /// <param name="r">Red byte</param>
        /// <param name="g">Green byte</param>
        /// <param name="b">Blue byte</param>
        /// <param name="a">Alpha byte</param>
        public RColor(byte r, byte g, byte b, byte a)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }
        /// <summary>
        /// Convert System.Drawing.Color to RColor
        /// </summary>
        /// <param name="c">Source Color</param>
        /// <returns>Converted RColor</returns>
        public static RColor fromColor(Color c)
        {
            return new RColor(c.R, c.G, c.B, c.A);
        }
        /// <summary>
        /// Convert RColor to System.Drawing.Color
        /// </summary>
        /// <returns>Converted Color</returns>
        public Color toColor()
        {
            return Color.FromArgb(alpha, red, green, blue);
        }
    }

}