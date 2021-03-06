using System;
using System.IO;

namespace DZ_17_01_2021
{
    public static class Extension
    {
        public static string GetFileSize(this FileInfo fileInfo)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = fileInfo.Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }
    }
}
