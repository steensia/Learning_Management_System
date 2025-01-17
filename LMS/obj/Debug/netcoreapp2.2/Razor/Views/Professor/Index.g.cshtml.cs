#pragma checksum "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\Professor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c42b65c78494507d16ab4f9a5bfeed659c80c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Index), @"mvc.1.0.view", @"/Views/Professor/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Professor/Index.cshtml", typeof(AspNetCore.Views_Professor_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\_ViewImports.cshtml"
using LMS;

#line default
#line hidden
#line 3 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\_ViewImports.cshtml"
using LMS.Models;

#line default
#line hidden
#line 4 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\_ViewImports.cshtml"
using LMS.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\_ViewImports.cshtml"
using LMS.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c42b65c78494507d16ab4f9a5bfeed659c80c21", @"/Views/Professor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363c4fd446cecdc21217d95f921ea2b5901a3ca3", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\Professor\Index.cshtml"
  
    ViewData["Title"] = "ProfessorHome";
    Layout = "~/Views/Shared/ProfessorLayout.cshtml";

#line default
#line hidden
            BeginContext(106, 471, true);
            WriteLiteral(@"
<h4 id=""ProfessorInfo""></h4>
<h4 id=""Department""></h4>

<div class=""col-md-12"">
  <h4>My Classes</h4>
  <table id=""tblClasses"" class=""table table-bordered table-striped table-responsive table-hover"">
    <thead>
      <tr>
        <th align=""left"" class=""productth"">Course</th>
        <th align=""left"" class=""productth"">Name</th>
        <th align=""left"" class=""productth"">Semester</th>
      </tr>
    </thead>
    <tbody></tbody>
  </table>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(598, 199, true);
                WriteLiteral("\r\n  <script type=\"text/javascript\">\r\n\r\n    LoadData();\r\n\r\n    //$(function () {\r\n    //  LoadData();\r\n    //});\r\n\r\n    function LoadData() {\r\n\r\n\r\n      $.ajax({\r\n        type: \'POST\',\r\n        url: \'");
                EndContext();
                BeginContext(798, 31, false);
#line 39 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\Professor\Index.cshtml"
         Write(Url.Action("GetUser", "Common"));

#line default
#line hidden
                EndContext();
                BeginContext(829, 53, true);
                WriteLiteral("\',\r\n        dataType: \'json\',\r\n        data: { uid: \'");
                EndContext();
                BeginContext(883, 18, false);
#line 41 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\Professor\Index.cshtml"
                 Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(901, 896, true);
                WriteLiteral(@"' },
        success: function (data, status) {

          if (data.success == false) {
            alert(""An error occured when loading user's information"");
          }
          else {
            ProfessorInfo.innerText = data.fname + "" "" + data.lname + ""    "" + data.uid;
            Department.innerText = ""Department: "" + data.department;
          }
        },
        error: function (ex) {
          var r = jQuery.parseJSON(response.responseText);
          alert(""Message: "" + r.Message);
          alert(""StackTrace: "" + r.StackTrace);
          alert(""ExceptionType: "" + r.ExceptionType);
        }
      });

      var tbl = document.getElementById(""tblClasses"");
      var body = tbl.getElementsByTagName(""tbody"")[0];
      tbl.removeChild(body);

      var newBody = document.createElement(""tbody"");

      $.ajax({
        type: 'POST',
        url: '");
                EndContext();
                BeginContext(1798, 39, false);
#line 68 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\Professor\Index.cshtml"
         Write(Url.Action("GetMyClasses", "Professor"));

#line default
#line hidden
                EndContext();
                BeginContext(1837, 53, true);
                WriteLiteral("\',\r\n        dataType: \'json\',\r\n        data: { uid: \'");
                EndContext();
                BeginContext(1891, 18, false);
#line 70 "C:\Users\steen\Desktop\CS5530S19\Phase 3\LMS\Views\Professor\Index.cshtml"
                 Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1909, 1543, true);
                WriteLiteral(@"' },
        success: function (data, status) {

          //alert(JSON.stringify(data));

          $.each(data, function (i, item) {

            var tr = document.createElement(""tr"");
            
            var td = document.createElement(""td"");
            td.appendChild(document.createTextNode(item.subject + item.number));
            tr.appendChild(td);

            var td = document.createElement(""td"");
            var a = document.createElement(""a"");
            a.setAttribute(""href"", ""/Professor/Class/?subject="" + item.subject + ""&num="" + item.number + ""&season="" + item.season + ""&year="" + item.year);            
            a.appendChild(document.createTextNode(item.name));
            td.appendChild(a);
            tr.appendChild(td);

            var td = document.createElement(""td"");
            td.appendChild(document.createTextNode(item.season + "" "" + item.year ));
            tr.appendChild(td);

            //var td = document.createElement(""td"");
            //td.a");
                WriteLiteral(@"ppendChild(document.createTextNode(item.grade));
            //tr.appendChild(td);

            newBody.appendChild(tr);

          });
          tbl.appendChild(newBody);
          
        },
        error: function (ex) {
          var r = jQuery.parseJSON(response.responseText);
          alert(""Message: "" + r.Message);
          alert(""StackTrace: "" + r.StackTrace);
          alert(""ExceptionType: "" + r.ExceptionType);
        }
        });


      return false;
    }



  </script>

");
                EndContext();
            }
            );
            BeginContext(3455, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
