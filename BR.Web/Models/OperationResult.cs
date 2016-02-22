using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//**********************************************************************
//
// 文件名称(File Name)：OperationResult.CS        
// 功能描述(Description)：     
// 作者(Author)：Administrator               
// 日期(Create Date)： 2016/2/18 14:02:26         
//
// 修改记录(Revision History)： 
//       R1:
//             修改作者:          
//             修改日期:2016/2/18 14:02:26          
//             修改理由：         
//**********************************************************************

namespace BR.Web.Models
{

    public class OperationResult:OperationResult<object>
    { }
    
    public class OperationResult<TData>
    {
        /// <summary>
        /// 运行状态
        /// </summary>
        public RunStatus Status { get; set; }

        /// <summary>
        /// 状态消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 异常
        /// </summary>
        public Exception Excption { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        public TData Data { get; set; }
    }
}