using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//**********************************************************************
//
// 文件名称(File Name)：RunStatus.CS        
// 功能描述(Description)：     
// 作者(Author)：Administrator               
// 日期(Create Date)： 2016/2/18 14:03:24         
//
// 修改记录(Revision History)： 
//       R1:
//             修改作者:          
//             修改日期:2016/2/18 14:03:24          
//             修改理由：         
//**********************************************************************

namespace BR.Web.Models
{
    public enum RunStatus
    {
        Sucess=0,
        Failed=1,
        Excption=2
    }
}