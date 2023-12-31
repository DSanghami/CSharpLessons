﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class FileOperatorProgram
    {
        public static void FileWriteAllLines()
        {
            String fName = @"c:\temp\myfileA.txt";
            string[] lines =
            {
                "Chennai is the capital city",
            "Madhurai is the temple city",
            "Salem is the steal city."
        };
            try
            {
                File.WriteAllLines(fName, lines);
                System.Console.WriteLine("File Created");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error!!{err.Message}");
            }
        }
        public static void FileReadAllText()
        {
            string line = String.Empty;
            String fName = @"c:\temp\myfileA.txt";
            line = File.ReadAllText(fName);
            Console.WriteLine(line);
        }
        public static void FileRename()
        {
            String oldfName = @"c:\temp\myfileA.txt";
            String newfName = @"c:\temp\renamedfileA.txt";
            File.Copy(oldfName, newfName);
            File.Delete(oldfName);
            Console.WriteLine("File Renamed");
        }
        public static void FileDelete()
        {
            String fName = @"c:\temp\myfileA.txt";
            if (File.Exists(fName))
                File.Delete(fName);
            else
                Console.WriteLine("File DELETE FAILED");
        }
        public static void ListDirectoryContent()
        {
            String currentDir = @"c:\temp\";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (String name in fileNames)
            {
                Console.WriteLine(name);
            }

            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*");
            foreach (String name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowCurrentDirectory()
            // These are two ways to access directory
        {   //ONE
            String currentworkingdirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentworkingdirectory);

            //TWO
            currentworkingdirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentworkingdirectory);
        }
        public static void CreateDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Create");
            String path = @"c:\temp\" + Console.ReadLine();
            DirectoryInfo dir = Directory.CreateDirectory(path);
            Console.WriteLine("Directory Created " + dir.FullName);
        }
        public static void DeleteDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Delete");
            String path = @"c:\temp\" + Console.ReadLine();
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("Directory DELETED");
            }
            else
            {
                Console.WriteLine("Directory Not Available");
            }
        }
        // if it is from another resource
        public static void FileWriteAllText()
        {
            String fNameb = @"c:\temp\myfileB.txt";
            string[] lines =
            {
          "Chennai is the capital city",
          "Madurai is the Temple city",
          "Salem is the steal city"
      };
            StringBuilder sb = new StringBuilder(100);
            sb.Append(lines[0]);
            sb.Append(Environment.NewLine); // sb.Append("\\n");
            sb.Append(lines[1]);
            sb.Append(Environment.NewLine);
            sb.Append(lines[2]);
            sb.Append(Environment.NewLine);
            File.WriteAllText(fNameb, sb.ToString());
            System.Console.WriteLine("File Created");
        }
        public static void StreamWriterDemo()
        {
            String fName = @"c:\temp\myfileC.txt";
            string[] lines =
            {
          "Chennai is the capital city",
          "Madurai is the Temple city",
          "Salem is the steal city"
      };
            //  StreamWriter
            //  Write one line at a time to a file.
            //  The second String is added as a new Line.
            using (StreamWriter sw = new StreamWriter(fName)) // when a obj within a user object , we should nt use outside of the 'using'
                                                              // it will close we do not need finally.
            {       
                foreach (string s in lines) // write one line at a time
                {
                    sw.WriteLine(s);
                }
            }
            System.Console.WriteLine("File Created"); // object closed
        }
        public static void StreamReaderFromFileDemo()
        {
            StringBuilder line = new StringBuilder(250);
            String fName = @"c:\temp\myfileA.txt";
            using (StreamReader sr = new StreamReader(fName))
            {
                line.Append(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    line.Append(sr.ReadLine());
                    line.Append(Environment.NewLine);
                }
                Console.WriteLine(line.ToString());
            }
            System.Console.WriteLine("Completed");
        }
    }
    static class ImageCache
    {
        public static byte[] Logo
        {
            get
            {
                byte[] _logoBytes = null;
                if(_logoBytes == null)
                {
                    _logoBytes = File.ReadAllBytes(@"c:\temp\Html_Logo.png");
                }
                return _logoBytes; 
            }
        }
    }
}
// Stream reader and stream writer 