﻿using System;
using System.IO;
using static Laba13.file.EVILog;
using static Laba13.file.EVIDirInfo;
using static Laba13.file.EVIFileInfo;
using static Laba13.file.EVIDiskInfo;
using static Laba13.file.EVIFileManager;

namespace Laba13
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            while (choice != 0)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Read Log\n"
                                  + "2. Search Log\n"
                                  + "3. Free Drive Space\n"
                                  + "4. Drive File System\n"
                                  + "5. Drives Info\n"
                                  + "6. Full Path to File\n"
                                  + "7. File Info\n"
                                  + "8. File Creation Time\n"
                                  + "9. Amount of Files in Directory\n"
                                  + "10. Directory Creation Time\n"
                                  + "11. Sub Directories Amount\n"
                                  + "12. List of Root Directories\n"
                                  + "13. Create Directory\n"
                                  + "14. Move & Delete\n"
                                  + "15. Archive\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Read();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 2:
                        Console.WriteLine("Input a time: ");
                        string time = Console.ReadLine();
                        Search(time);
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 3:
                        FreeSpace();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 4:
                        FileSystem();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 5:
                        DrivesInfo();
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 6:
                        Console.WriteLine("Input a path to file: ");
                        string fullPath = Console.ReadLine();
                        FullPath(fullPath);
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 7:
                        Console.WriteLine("Input a path to file: ");
                        string fileInfoPath = Console.ReadLine();
                        GetFileInfo(fileInfoPath);
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 8:
                        Console.WriteLine("Input a path to file: ");
                        string fileCreationPath = Console.ReadLine();
                        GetFileCreation(fileCreationPath);
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 9:
                        Console.WriteLine("Input a path to directory: ");
                        string dirPath = Console.ReadLine();
                        FileAmount(dirPath);
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 10:
                        Console.WriteLine("Input a path to directory: ");
                        string dirCreationPath = Console.ReadLine();
                        DirCreationTime(dirCreationPath);
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 11:
                        Console.WriteLine("Input a path to directory: ");
                        string dirSubPath = Console.ReadLine();
                        SubDirectoriesAmount(dirSubPath);
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 12:
                        Console.WriteLine("Input a path to directory: ");
                        string dirRoot = Console.ReadLine();
                        RootDirectoriesList(dirRoot);
                        Console.WriteLine("\n---------------------------------------------------------\n");
                        break;
                    case 13:
                        Console.WriteLine("Input a Drive Label: ");
                        string label = Console.ReadLine();
                        CreateDirectory(label);
                        break;
                    case 14:
                        MoveDelete();
                        break;
                    case 15:
                        Archive();
                        break;
                    default:
                        Console.WriteLine("No such choice");
                        break;
                }
            }
        }
    }
}
