using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File system!");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
            {
                Console.WriteLine("Drive {0}", driveInfo.Name);
                Console.WriteLine("	File type: {0}", driveInfo.DriveType);
                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", driveInfo.VolumeLabel);
                    Console.WriteLine("  File system:				 {0}", driveInfo.DriveFormat);
                    Console.WriteLine("  Spazio disponibile:  {0,10} KBytes", (driveInfo.AvailableFreeSpace >> 10));
                    Console.WriteLine("  Spazio totale:		   {0,10} KBytes", driveInfo.TotalFreeSpace >> 10);
                    Console.WriteLine("  Total size of drive: {0,10} KBytes", driveInfo.TotalSize >> 10);
                }
            }

        }
    }
}
