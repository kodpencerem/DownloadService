namespace DownloadService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DownloadService" in both code and config file together.
    public class DownloadService : IDownloadService
    {
        public File DownloadDocument()
        {
            File file = new File();

            file.Content = System.IO.File.ReadAllBytes(@"D:/Data/Sunu1.pptx");
            file.Name = "Sunu1.pptx";

            return file;
        }
    }
}