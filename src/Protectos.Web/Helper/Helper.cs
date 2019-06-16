using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Protectos.Web.Helper
{
    public static class Helper
    {      


        public static bool SalvarImagem(HttpPostedFileBase img, Guid id)
        {
                        
            if (img == null || img.ContentLength <= 0) return false;
            string directory = ConfigurationManager.AppSettings["Imagens"];
            var fileName = id + Path.GetExtension(img.FileName);
            img.SaveAs(Path.Combine(directory, fileName));
            return File.Exists(Path.Combine(directory, fileName));
        }
    }
}