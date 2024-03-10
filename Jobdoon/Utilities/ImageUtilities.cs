namespace Jobdoon.Utilities
{
    public static class ImageUtilities
    {
        public static byte[] ImageFileToByteArray(IFormFile imageFile)
        {
            MemoryStream ms = new MemoryStream();
            imageFile.CopyTo(ms);
            return ms.ToArray();
        }
        public static string GenerateImageDataUrl(byte[] bytes)
        {
            return string.Format("data:image/png;base64,{0}", Convert.ToBase64String(bytes));
        }
        //public static Image ByteArrayToImage(byte[] byteArrayIn)
        //{
        //    MemoryStream ms = new MemoryStream(byteArrayIn);
        //    Image imgOut = Image.FromStream(ms);
        //    return imgOut;
        //}
    }
}
