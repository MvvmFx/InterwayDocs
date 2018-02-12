namespace System.IO
{
    public static class FileInfoRename
    {
        public static void Rename(this FileInfo fileInfo, string newFilename)
        {
            if (fileInfo == null)
                throw new ArgumentNullException("fileInfo");

            if (string.IsNullOrEmpty(newFilename))
                throw new ArgumentNullException("newFilename");

            if (fileInfo.Directory != null)
            {
                File.Delete(newFilename);
                fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + newFilename);
            }
        }
    }
}