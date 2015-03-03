using System;

namespace CohesionAndCoupling
{
    static class Points
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        /// <summary>
        /// Static method calculates 2D distance between two points
        /// </summary>
        /// <param name="x1">coordinate X -> first point</param>
        /// <param name="y1">coordinate Y -> first point</param>
        /// <param name="x2">coordinate X -> second point</param>
        /// <param name="y2">coordinate Y -> second point</param>
        /// <returns>Returns double  2D distance</returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Static method calculates 3D distance between two points
        /// </summary>
        /// <param name="x1">coordinate X -> first point</param>
        /// <param name="y1">coordinate Y -> first point</param>
        /// <param name="z1">coordinate Z -> first point</param>
        /// <param name="x2">coordinate X -> second point</param>
        /// <param name="y2">coordinate Y -> second point</param>
        /// <param name="z2">coordinate Z -> second point</param>
        /// <returns>Returns double 3D distance</returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        /// <summary>
        /// Static method calculates volume
        /// </summary>
        /// <returns>Returns double volume</returns>
        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        /// <summary>
        /// Static method calculates distance in the 3D space between X, Y, Z
        /// </summary>
        /// <returns>Returns double distance between X, Y, Z</returns>
        public static double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        /// <summary>
        /// Static method calculates distance in the 2D space between X, Y
        /// </summary>
        /// <returns>Returns double distance between X, Y</returns>
        public static double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, Width, Height);
            return distance;
        }

        /// <summary>
        /// Static method calculates distance in the 2D space between X, Z
        /// </summary>
        /// <returns>Returns double distance between X, Z</returns>
        public static double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, Width, Depth);
            return distance;
        }

        /// <summary>
        /// Static method calculates distance in the 2D space between Y, Z
        /// </summary>
        /// <returns>Returns double distance between Y, Z</returns>
        public static double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
