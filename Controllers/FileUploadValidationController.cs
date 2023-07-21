using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Web;

namespace FileValidationWeb.Controllers
{
    public class FileUploadValidationController : ApiController
    {
        [HttpPost]
        public void filevalidation()
        {
            if (HttpContext.Current.Request.Files.AllKeys.Any())
            {
                var imgfile = HttpContext.Current.Request.Files["Uploadingfiles"];
                if (imgfile != null)
                {
                    var savefiles = Path.Combine(HttpContext.Current.Server.MapPath("~/Images/"), imgfile.FileName);
                    imgfile.SaveAs(savefiles);
                }
            }
        }
    }
}
