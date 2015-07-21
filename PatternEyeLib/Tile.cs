using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace PatternEye
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
            return Color.FromArgb(red, green, blue, alpha);
        }
    }

    /// <summary>
    /// Encapsulation of a sample square of pixels
    /// </summary>
    public class Tile
    {

        private int edge_size = 1;
        /// <summary>
        /// Tile class constructor
        /// </summary>
        /// <param name="size">Width and height (in pixels) of region</param>
        /// <param name="edge">'Edge' radius size</param>
        public Tile(int size,int edge)
        {
            this.edge_size = 1;
            this.Pixels = new RColor[size, size];
        }

        /// <summary>
        /// Array of Pixel values
        /// </summary>
        public RColor[,] Pixels
        {
            get;
            set;
        }

        /// <summary>
        /// Sample a single color
        /// </summary>
        /// <param name="c">Column</param>
        /// <param name="r">Row</param>
        /// <returns>Sampled color</returns>
        public RColor sample(int c,int r){
            return this.Pixels[c,r];
        }

        /// <summary>
        /// Update a single color
        /// </summary>
        /// <param name="v">Color value</param>
        /// <param name="c">Column</param>
        /// <param name="r">Row</param>
        public void sample(RColor v, int c, int r)
        {
            this.Pixels[c, r] = v;
        }

        /// <summary>
        /// Update a single color
        /// </summary>
        /// <param name="v">System.Drawing Color value</param>
        /// <param name="c">Column</param>
        /// <param name="r">Row</param>
        public void sample(Color v, int c, int r)
        {
            this.sample(RColor.fromColor(v), c, r);
        }

        /// <summary>
        /// Tile edge radius
        /// </summary>
        public int EdgeSize
        {
            get { return this.edge_size; }
        }

    }
}
