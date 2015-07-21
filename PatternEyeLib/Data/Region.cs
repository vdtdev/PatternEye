using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PatternEye.Common;
using System.Drawing;

namespace PatternEye.Data
{
    /// <summary>
    /// Encapsulation of a rectangular region of pixels
    /// </summary>
    public class Region
    {  
        /// <summary>
        /// Region class constructor
        /// </summary>
        /// <param name="width">Region width</param>
        /// <param name="height">Region height</param>
        public Region(int width,int height)
        {
            
            this.Pixels = new RColor[width, height];
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

    }
}
