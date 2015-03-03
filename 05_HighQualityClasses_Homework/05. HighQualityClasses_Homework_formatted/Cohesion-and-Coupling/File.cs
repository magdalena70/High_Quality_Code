using System;

namespace CohesionAndCoupling
{
    public static class File
    {
        public static string FileName { get; set; }

        /// <summary>
        /// Static method getting file extension from file name
        /// </summary>
        /// <returns>Returns string file exension without file name</returns>
        public static string GetFileExtension(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("File name cannot be empty.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return "File name has no extension";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Static method getting file name without extension
        /// </summary>
        /// <returns>Returns string file name without extension</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("File name cannot be empty.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
