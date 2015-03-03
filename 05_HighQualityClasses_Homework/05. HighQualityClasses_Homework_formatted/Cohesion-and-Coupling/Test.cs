using System;

namespace CohesionAndCoupling
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("-----Test class File-----\n");
            // Console.WriteLine(File.GetFileExtension("")); // return exception
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));

            // Console.WriteLine(File.GetFileNameWithoutExtension("")); // return exception
            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("\n-----Test class Points-----\n");
            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Points.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Points.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Points.Width = 3;
            Points.Height = 4;
            Points.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Points.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Points.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Points.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Points.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Points.CalcDiagonalYZ());
        }
    }
}
