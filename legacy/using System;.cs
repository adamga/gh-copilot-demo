using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AlbumReleaseCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "ALBUMS.DAT";
            var monthlyAlbumCounts = new Dictionary<int, int>();

            try
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var details = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (details.Length >= 4) // Assuming the file format is consistent with the COBOL structure
                    {
                        int monthOfRelease = int.Parse(details[3]); // Assuming the month is the fourth element

                        if (monthlyAlbumCounts.ContainsKey(monthOfRelease))
                        {
                            monthlyAlbumCounts[monthOfRelease]++;
                        }
                        else
                        {
                            monthlyAlbumCounts.Add(monthOfRelease, 1);
                        }
                    }
                }

                foreach (var month in monthlyAlbumCounts.OrderBy(m => m.Key))
                {
                    Console.WriteLine($"Month: {month.Key}, Albums Released: {month.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}