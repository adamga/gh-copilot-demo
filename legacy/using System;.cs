using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AlbumCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var albumFile = "ALBUMS.DAT";
            var monthCounts = new Dictionary<int, int>();
            var albums = new List<Album>();

            // Read and parse the album file
            foreach (var line in File.ReadLines(albumFile))
            {
                var album = Album.Parse(line);
                if (album != null)
                {
                    albums.Add(album);
                    if (!monthCounts.ContainsKey(album.ReleaseDate.Month))
                    {
                        monthCounts[album.ReleaseDate.Month] = 0;
                    }
                    monthCounts[album.ReleaseDate.Month]++;
                }
            }

            // Display the count of albums released in each month
            foreach (var monthCount in monthCounts)
            {
                Console.WriteLine($"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthCount.Key)}: {monthCount.Value}");
            }
        }
    }

    class Album
    {
        public int AlbumId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        public static Album Parse(string line)
        {
            // Assuming a simple CSV format for the line, adjust parsing logic as needed
            var parts = line.Split(',');
            if (parts.Length >= 5)
            {
                return new Album
                {
                    AlbumId = int.Parse(parts[0]),
                    Artist = parts[1],
                    Title = parts[2],
                    ReleaseDate = DateTime.ParseExact(parts[3], "yyyyMMdd", CultureInfo.InvariantCulture),
                    Genre = parts[4]
                };
            }
            return null;
        }
    }
}