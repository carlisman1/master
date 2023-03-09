namespace MvcCryptographyBBDD.Helpers
{
    public class HelperSubirFichero
    {
        private HelperPathProvider helperPath;

        public HelperSubirFichero(HelperPathProvider helperPath)
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
