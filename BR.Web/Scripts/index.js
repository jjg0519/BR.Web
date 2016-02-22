
$(function () {
    $(".uploadify").click(function (e) {
        bindUploadEvent($(e.target), 1);
    });
})

function bindUploadEvent(srcT, type) {
    //alert($(srcT).attr("hdt"));
    // alert($(srcT).parent().html());
   // var proId = $("#hidProId").val();
    //alert(proId);
    var obj = $(srcT);
    // var up = $(add_day).find("li:eq(6)").find("#uploadify");
    $(srcT).uploadify(
  {

      //指定swf文件
      'swf': '~/Scripts/uploadify/uploadify.swf',

      //后台处理的页面
      'uploader': 'HomeEdit/UploadImage',//?proId=' + $("#hidProId").val() + "&type=" + type
      //按钮显示的文字
      'buttonText': '',
      //显示的高度和宽度，默认 height 30；width 120
      'height': '24',
      'width': '54',
      //上传文件的类型  默认为所有文件    'All Files'  ;  '*.*'
      //在浏览窗口底部的文件类型下拉菜单中显示的文本
      'fileTypeDesc': 'Image Files',
      //允许上传的文件后缀
      'fileTypeExts': '*.gif; *.jpg; *.png',
      //发送给后台的其他参数通过formData指定
      //'formData': { 'someKey': 'someValue', 'someOtherKey': 1 },
      //上传文件页面中，你想要用来作为文件队列的元素的id, 默认为false  自动生成,  不带#
      //'queueID': 'fileQueue',
      //选择文件后自动上传
      'auto': true,
      //设置为true将允许多文件上传
      'multi': false,
      'onUploadSuccess': function (file, data, response) {
          alert("上传成功");
          //var jsonStr = eval('(' + data + ')');
          //if (jsonStr.err != "null") {
          //    alert(jsonStr.err);
          //    return;
          //}
          //var obj2 = "#" + $(obj).attr("id");


          ////alert()
          //var imgObj = $(obj2).parent().parent().prev().find("img");
          //var oldName = $(imgObj).attr("oldName");
          //$(imgObj).attr("hdt", jsonStr.fileName);
          //$(imgObj).attr("src", jsonStr.fileName);
          //$(imgObj).attr("oldName", oldName + "," + jsonStr.fileName);


      }


  });

}