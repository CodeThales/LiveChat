#pragma checksum "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4f74155af7f53b7f49ab0dfcad81278e714ff47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
#nullable restore
#line 1 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\_ViewImports.cshtml"
using ThayNailDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\_ViewImports.cshtml"
using ThayNailDesign.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4f74155af7f53b7f49ab0dfcad81278e714ff47", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4432c0f54daeb70b9307644c734ecfc7b9dd3651", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SendMessageForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
  
    var messages = ViewBag.Messages as List<Message>;
    var username = ViewBag.CurrentUserName as string;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .chat {
        max-height: 500px;
        overflow-y: scroll;
        border: 1px solid black;
    }

        .chat::-webkit-scrollbar {
            width: 5px;
        }

        .chat::-webkit-scrollbar-thumb {
            box-shadow: inset 0 0 6px rgba(0,0,0,.3);
            background-color: silver;
        }
</style>

<h2>Let's Chat!</h2>
<div class=""jumbotron bg-light chat"" id=""chat"">
");
#nullable restore
#line 26 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
     if (messages != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
         foreach (var message in messages.OrderBy(m => m.Date_time))
        {
            var position = username == message.UserName ? "text-right" : "text-left";
            var alert = username == message.UserName ? "alert-info" : "alert-secondary";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 905, "\"", 932, 2);
            WriteAttributeValue("", 913, "col-md-12", 913, 9, true);
#nullable restore
#line 33 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
WriteAttributeValue(" ", 922, position, 923, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <small class=\"text-dark\">");
#nullable restore
#line 34 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
                                        Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1032, "\"", 1057, 3);
            WriteAttributeValue("", 1040, "alert", 1040, 5, true);
            WriteAttributeValue(" ", 1045, "mb-0", 1046, 5, true);
#nullable restore
#line 35 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
WriteAttributeValue(" ", 1050, alert, 1051, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n                        <span class=\"d-block\" style=\"word-wrap: break-word;\">");
#nullable restore
#line 36 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
                                                                        Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <small class=\"text-info\">");
#nullable restore
#line 38 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
                                        Write(message.Date_time.ToString("dd/MM HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4f74155af7f53b7f49ab0dfcad81278e714ff478977", async() => {
                WriteLiteral("\r\n    <div class=\"input-group mb-4 col-md-12\">\r\n        <input name=\"Text\" id=\"MessageText\" class=\"form-control\" />\r\n        <button type=\"submit\" id=\"submitBtn\" class=\"btn btn-info\">Send</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.7/signalr.min.js\"></script>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\r\n\r\n    <script>\r\n        var username = \"");
#nullable restore
#line 57 "D:\O Talito\Documents\Cursos\Programação e Desenvolvimento\Blue EdTech\Modulo 04 - BackEnd\LiveChat\ThayNailDesignWebChat\Views\Chat\Index.cshtml"
                   Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
        var objDiv = document.getElementById(""chat"");
        objDiv.scrollTop = objDiv.scrollHeight;

        var connection = new signalR.HubConnectionBuilder().withUrl(""/chathub"").build();

        function formatDate(dateString) {
            var date = new Date(Date.parse(dateString))
            var dateStr =
                (""00"" + date.getDate()).slice(-2) + ""/"" +
                (""00"" + (date.getMonth() + 1)).slice(-2) + "" "" +
                (""00"" + date.getHours()).slice(-2) + "":"" +
                (""00"" + date.getMinutes()).slice(-2)
            return dateStr
        }

        connection.on(""ReceiveMessage"", (data) => {            
            var position = data.userName === username ? ""text-right"" : ""text-left"";
            var alert = data.userName === username ? ""alert-info"" : ""alert-secondary"";

            var message = document.createElement(""div"");
            message.className = ""row"";

            var messageCol = document.createElement(""div"");
            me");
                WriteLiteral(@"ssageCol.classList = ""col-md-12 "" + position;

            var messageUser = document.createElement(""small"");
            messageUser.className = ""text-dark"";
            messageUser.textContent = data.userName;

            var messageAlert = document.createElement(""div"");
            messageAlert.classList = ""alert mb-0 "" + alert;

            var messageAlertMessage = document.createElement(""div"");
            messageAlertMessage.className = ""d-block"";
            messageAlertMessage.style.cssText = ""word-wrap: break-word;"";
            messageAlertMessage.innerHTML = data.text;

            var messageDt = document.createElement(""small"");
            messageDt.className = ""text-info"";
            messageDt.textContent = formatDate(data.date_time);

            messageAlert.appendChild(messageAlertMessage);
            messageCol.appendChild(messageUser);
            messageCol.appendChild(messageAlert);
            messageCol.appendChild(messageDt);
            message.appendChild(me");
                WriteLiteral(@"ssageCol);
            console.log(message);
            document.getElementById(""chat"").appendChild(message);
            objDiv.scrollTop = objDiv.scrollHeight;
        });

        connection.start().then(function () {
            console.log(""Connected"");
            document.getElementById(""SendMessageForm"").addEventListener(""submit"", function (event) {
                event.preventDefault();

                var data = {
                    Text: document.getElementById(""MessageText"").value,
                    UserName: username
                }

                //Essa expressão regular vai testar esse texto verificando se no inicio do texto (^) existe espaço em branco (\s) na quantidade de 1 ou mais (+) e que depois disso o texto termina ($).
                if (document.getElementById(""MessageText"").value == """" || document.getElementById(""MessageText"").value.match(/^(\s)+$/)) return;

                document.getElementById(""MessageText"").value = """";

                connection.");
                WriteLiteral(@"invoke(""sendMessage"", data).catch(function (err) {
                    return console.error(err.toString());
                });
            });
        }).catch(function (err) {
            return console.error(err.toString());
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
