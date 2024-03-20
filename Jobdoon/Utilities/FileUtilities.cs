using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Formatters.Binary;

namespace Jobdoon.Utilities
{
    public static class FileUtilities
    {
        public static byte[] FileToByteArray(IFormFile file)
        {
            MemoryStream ms = new MemoryStream();
            file.CopyTo(ms);
            return ms.ToArray();
        }
    }
}
