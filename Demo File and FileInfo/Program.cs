using System.IO;


namespace Demo_File_and_FileInfo
{
    class Program
    {
        public static void Main(string[] args)
        {   
            // File
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temps\myfile.jpg", @"d:\temps\myfile.jpg", true);
            File.Delete(path);
            if(File.Exists(path));
            {
                //
            }
            var content = File.ReadAllText(path);

            // FileInfo
            var FileInfo= new FileInfo(path);
            FileInfo.CopyTo("..."); //pathing
            FileInfo.Delete();
            if(FileInfo.Exists)
            {
                //
            }
        }
    }      
}    
