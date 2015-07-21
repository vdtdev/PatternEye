using System;
using System.Collections.Generic;
using PatternEye.Common;
using System.Drawing;

namespace PatternEye.Data
{
   
    /// <summary>
    /// Encapsulation of a sample square of pixels, extending <see cref="PatternEye.Data.Region">Region</see>
    /// </summary>
    public class Tile:Region
    {

        private int edge_size = 1;
        /// <summary>
        /// Tile class constructor
        /// </summary>
        /// <param name="size">Width and height (in pixels) of region</param>
        /// <param name="edge">'Edge' radius size</param>
        public Tile(int size,int edge):base(size,size)
        {
            this.edge_size = 1;
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
