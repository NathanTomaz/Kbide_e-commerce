#pragma checksum "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "598dbb9026dfefd83626c6f076c61064e049230d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contato.cshtml", typeof(AspNetCore.Views_Home_Contato))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598dbb9026dfefd83626c6f076c61064e049230d", @"/Views/Home/Contato.cshtml")]
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
  
    ViewData["Title"] = "Contato";
    Kbide_desenvolvimento.Models.Contato contato = (Kbide_desenvolvimento.Models.Contato) ViewData["CONTATO"];

#line default
#line hidden
            BeginContext(157, 1269, true);
            WriteLiteral(@"<main role=""main"">
    <br />
    <br />
    <div class=""container"">
        <div class=""row"">
            <aside class=""col-md-6"">
                <h4 class=""subtitle-doc"">
                    Outros contatos
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode""></a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Suporte: </dt>
                            <dd>suporte@kbide.com.br</dd>
                        </dl>
                        <dl>
                            <dt>Telefone: </dt>
                            <dd>(33) 99104-8860</dd>
                        </dl>
                        <dl>
                            <dt>SAC:</dt>
                            <dd>sac@kbide.com.br</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
            ");
            WriteLiteral("<aside class=\"col-sm-6\">\r\n\r\n                <h4 class=\"subtitle-doc\">\r\n                    Contato\r\n                </h4>\r\n                <div>\r\n                    <article class=\"card\">\r\n                        <div class=\"card-body p-5\">\r\n\r\n");
            EndContext();
#line 42 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_S"] != null)
                            {

#line default
#line hidden
            BeginContext(1518, 63, true);
            WriteLiteral("                                <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(1582, 17, false);
#line 44 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
                                                          Write(ViewData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 45 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
            BeginContext(1636, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
                             if (ViewData["MSG_E"] != null)
                            {

#line default
#line hidden
            BeginContext(1730, 62, true);
            WriteLiteral("                                <p class=\"alert alert-danger\">");
            EndContext();
            BeginContext(1793, 27, false);
#line 49 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
                                                         Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 50 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
                            }

#line default
#line hidden
            BeginContext(1857, 691, true);
            WriteLiteral(@"

                            <form role=""form"" method=""post"" action=""/Home/ContatoAcao"">
                                <div class=""form-group"">
                                    <label for=""nome"">Nome</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-user""></i></span>
                                        </div>
                                        <input type=""text"" id=""nome"" class=""form-control"" name=""nome"" placeholder=""""
                                               required=""""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2548, "\"", 2593, 1);
#line 61 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
WriteAttributeValue("", 2556, contato != null ? contato.Nome: "", 2556, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2594, 630, true);
            WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <label for=""email"">E-mail</label>
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-at""></i></span>
                                        </div>
                                        <input type=""text"" class=""form-control"" name=""email"" id=""email"" placeholder=""""");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 3224, "\"", 3272, 1);
#line 71 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
WriteAttributeValue("", 3233, contato != null ? contato.Email : "", 3233, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3273, 570, true);
            WriteLiteral(@">
                                    </div>
                                </div>

                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <div class=""form-group"">
                                            <label for=""texto""><span class=""hidden-xs"">Texto</span> </label>
                                            <div class=""form-inline"">
                                                <textarea class=""form-control"" name=""texto"" id=""texto"" style=""width:100%"">");
            EndContext();
            BeginContext(3845, 36, false);
#line 80 "C:\Users\PROBOOK 640 G1\Desktop\Kbide_e-commerce\Views\Home\Contato.cshtml"
                                                                                                                      Write(contato != null ? contato.Texto : "");

#line default
#line hidden
            EndContext();
            BeginContext(3882, 496, true);
            WriteLiteral(@"</textarea>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <button class=""subscribe btn btn-primary btn-block"" type=""submit""> Enviar </button>
                            </form>
                        </div>
                    </article>
                </div>
            </aside>
        </div>
    </div>
</main>");
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
