namespace MvcCoreUtilidades.Helpers
{
    public class HelperUploadFiles
    {
        private HelperPathProvider helperPath;

        public HelperUploadFiles(HelperPathProvider helperPath)
        {
            this.helperPath = helperPath;
        }

        public async Task<string> UploadFileAsync(IFormFile file, Folders folder)
        {
            string fileName = file.FileName;
            string path =
                this.helperPath.MapPath(fileName, folder);
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
                return path;
            }
        }
    }
}
