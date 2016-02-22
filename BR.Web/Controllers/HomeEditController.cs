using BR.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BR.Web.Controllers
{
    public class HomeEditController : Controller
    {
        // GET: HomeEdit
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult UploadImage()
        {
            OperationResult res = new OperationResult() { Status = RunStatus.Sucess,Message="",Excption=null };
            HttpPostedFileBase file = Request.Files["Filedata"] ;
            //string proId = Request["proId"] == null || Request["proId"] == "undefined" ? "" : Request["proId"].ToString();
            //string type = Request["type"] == null || Request["type"] == "undefined" ? "" : Request["type"].ToString();
            //if (proId == "" || proId == "0")
            //{
            //    Response.Write(JsonConvert.SerializeObject(new { err = "未知的产品名称" }));
            //    return Json(res);
            //}
            //if (type == "")
            //{
            //    Response.Write(JsonConvert.SerializeObject(new { err = "未知的图片类型" }));
            //    return Json(res);
            //}

            //其他参数
            //string somekey = Request["someKey"];
            //string other = Request["someOtherKey"];
            //获取文件的保存路径
            
            string uploadPath = Server.MapPath(@"lineImg\" + System.Guid.NewGuid() + "\\");
            //判断上传的文件是否为空
            if (file != null)
            {
                if (!System.IO.Directory.Exists(uploadPath))
                {
                    System.IO.Directory.CreateDirectory(uploadPath);
                }
                int fNmPos = file.FileName.LastIndexOf('.');
                string fileEnd = file.FileName.Substring(fNmPos);
                string fName =  DateTime.Now.ToString("yymmddhhmmss") + fileEnd;

                //保存文件
                file.SaveAs(uploadPath + fName);
                System.Drawing.Image image = System.Drawing.Image.FromFile(uploadPath + fName);
                int originalImageHeight = image.Height;
                int originalImageWidth = image.Width;
                bool flag = false;
                //switch (type)
                //{
                //    case "1"://行程信息中的俩张图片
                //        if (originalImageWidth != 420 && originalImageHeight != 280)
                //        {
                //            flag = true;
                //            image.Dispose();
                //        }
                //        break;

                //    case "2"://首页图片
                //        if (originalImageWidth != 320 && originalImageHeight != 240)
                //        {
                //            flag = true;
                //            image.Dispose();
                //        }
                //        break;

                //    case "3"://最新优惠图片
                //        if (originalImageWidth != 740 && originalImageHeight != 240)
                //        {
                //            flag = true;
                //            image.Dispose();
                //        }
                //        break;

                //    case "4"://热点推荐图片
                //        if (originalImageWidth != 1920 && originalImageHeight != 480)
                //        {
                //            flag = true;
                //            image.Dispose();
                //        }
                //        break;

                //    case "5"://图片切换
                //        if (originalImageWidth != 600 && originalImageHeight != 400)
                //        {
                //            flag = true;
                //            image.Dispose();
                //        }
                //        break;
                //}
                if (flag)
                {
                    Response.Write(JsonConvert.SerializeObject(new { err = "上传图片尺寸不对" }));
                    System.IO.FileInfo fInfo = new System.IO.FileInfo(uploadPath + fName);
                    fInfo.Delete();
                    return Json(res);
                }
                return Json(res);
            }
            else
            {
                res = new OperationResult() { Status = RunStatus.Failed, Message = "未知的文件格式" };
                return Json(res);
                
            } 
        }
    }
}