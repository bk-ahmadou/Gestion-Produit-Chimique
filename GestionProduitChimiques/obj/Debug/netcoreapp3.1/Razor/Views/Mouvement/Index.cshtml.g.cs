#pragma checksum "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0140a33dae7e2022e13ce5716e9735b554ad67e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mouvement_Index), @"mvc.1.0.view", @"/Views/Mouvement/Index.cshtml")]
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
#line 1 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\_ViewImports.cshtml"
using GestionProduitChimiques;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\_ViewImports.cshtml"
using GestionProduitChimiques.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0140a33dae7e2022e13ce5716e9735b554ad67e1", @"/Views/Mouvement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb3f15e6fe4c93c69a9c71b6bb2235d4cef8eca", @"/Views/_ViewImports.cshtml")]
    public class Views_Mouvement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionProduitChimiques.Models.Entities.MouvementStock>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formmvt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
  
    ViewData["title"] = "Gestion des Mouvements";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <label title=""Add New Produit"" id=""addproduit"" class=""btn btn-white  pull-right"" onclick=""showModelAddMouvement()"">
        <i class=""ace-icon fa fa-plus""></i>
        Add Mouvement
    </label>
    <div class=""col-lg-12 "">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-lg-9"">
                        Historiques des Mouvements
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""input-group custom-search-form"">
                            <input type=""text"" class=""form-control"" id=""search"" placeholder=""Search..."" onclick=""RechercheMouvement()"">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default"" type=""button"" onclick=""RechercheMouvement()"">
                                    <i class=""fa fa-search""></i>
                                </butto");
            WriteLiteral(@"n>
                            </span>
                        </div>
                    </div>
                </div>
            </div>

            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <table class=""table table-striped table-bordered table-hover"">
                        <thead>
                            <tr>

                                <th>Date</th>
                                <th>Type </th>
                                <th>Raison</th>
                                <th>Reference produit</th>
                                <th>Nom-Prod</th>
                                <!--<th>Purete</th>
                                <th>Concentration</th>
                                <th>Date de péremption</th>-->
                                <th>Quantité</th>
                                <th>Action</th>
                            </tr>
                        </thead>
   ");
            WriteLiteral("                     <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                             foreach (var item in @ViewBag.ListMouvement)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"search\">\r\n\r\n                                    <td>\r\n");
#nullable restore
#line 56 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                         if (item.DateMouvement != null)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                       Write(item.DateMouvement.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                                                                           
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 62 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                   Write(item.TypeMvt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 65 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                   Write(item.Raison);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 68 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                   Write(item.produit.Reference);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 71 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                   Write(item.produit.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 74 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                   Write(item.Quantite);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>
                                        <div class=""row"">
                                            <div class=""col-md-2 tools action-buttons"">
                                                <a href=""#"" class=""red"" title=""Delete Produit"" id=""idDeleteProduit""");
            BeginWriteAttribute("onclick", " onclick=\"", 3717, "\"", 3761, 3);
            WriteAttributeValue("", 3727, "showModelDeleteMouvement(", 3727, 25, true);
#nullable restore
#line 79 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
WriteAttributeValue("", 3752, item.Id, 3752, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3760, ")", 3760, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <i class=""ace-icon fa fa-trash-o bigger-140""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 86 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <!-- /.table-responsive -->
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
</div>

<!--Modal Add Mouvements-->


<div class=""modal fade"" id=""ModelAddmouvement"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog centmodel widthmodel"">
        <div class=""modal-content"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0140a33dae7e2022e13ce5716e9735b554ad67e111852", async() => {
                WriteLiteral(@"
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                            <h4 class=""modal-title text-center"" id=""myModalLabel"">Add mouvement</h4>
                        </div>
                        <div class=""modal-body"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label>Type Mouvement</label>
                                        <select class=""form-control"" id=""typmouv"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0140a33dae7e2022e13ce5716e9735b554ad67e112858", async() => {
                    WriteLiteral("Entrant");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0140a33dae7e2022e13ce5716e9735b554ad67e113918", async() => {
                    WriteLiteral("Sortant");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </select>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""raison"">Raison</label>
                                        <input type=""text"" class=""form-control"" id=""raison"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""quantite"">Quantite </label>
                                        <input type=""number"" class=""form-control"" id=""quantite"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""observation"">Observation</label>
                                        <input type=""text"" class=""form-control"" id=""observation"">
                                    </div>
                                    <div class=""form-group"">
             ");
                WriteLiteral(@"                           <label for=""DateMvt"">Date</label>
                                        <input type=""date"" class=""form-control"" id=""DateMvt"">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label for=""lotId"">Produit</label>
                                        <select class=""form-control chosen"" id=""typprod"">
");
#nullable restore
#line 142 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                             foreach (var prod in ViewBag.ListProduits)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0140a33dae7e2022e13ce5716e9735b554ad67e116973", async() => {
#nullable restore
#line 144 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                                                    Write(prod.Nom);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                                   WriteLiteral(prod.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 145 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </select>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""concentration"" id=""labconcent"">Concentration </label>
                                        <input type=""text"" class=""form-control"" id=""concentration"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""dateperemtion"" id=""labpremtion"">Date de Peremption</label>
                                        <input type=""date"" class=""form-control"" id=""dateperemtion"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""purete"" id=""labPurete"">Pureté</label>
                                        <input type=""text"" class=""form-control"" id=""purete"">
                                    </div>
     ");
                WriteLiteral(@"                           </div>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                            <button type=""button"" class=""btn btn-primary"" onclick=""AddMouvement(formmvt)"">Save</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>

<!--Modal Delete Mouvement-->

<div class=""modal fade"" id=""ModalDeleteMouvement"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog centmodel widthmodel"" role=""document"">
        <div class=""modal-content"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""modal-header"" style=""background-color:#478fca;padding:4px"">
                        <h4 class=""modal-title text-center"" style=""color:white !important"" id=""exampleModalLongTitle"">Delete Mouvements</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" style=""font-size:22px;color:white !important;top:5px;right:20px;position:absolute;"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
");
            WriteLiteral(@"                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <div class=""row"">
                                    <h3><i class=""ace-icon fa fa-hand-o-right blue bigger-120""></i>Are you sure wanting to delete this ?</h3>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn  btn-sm btn-default"" onclick=""hideModelDeleteMouvement()""><i class=""ace-icon fa fa-times""></i>Close</button>
                        <button type=""button"" class=""btn btn-sm btn-danger"" onclick=""DeleteMouvement()""><i class=""ace-icon fa fa-check""></i>Delete</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!--Modal Update Mouvement

<div class=""");
            WriteLiteral(@"modal fade"" id=""ModelUpdatemouvement"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog centmodel widthmodel"">
        <div class=""modal-content"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <form id=""formmvtup"">
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                            <h4 class=""modal-title text-center"" id=""myModalLabel"">Update mouvement</h4>
                        </div>
                        <div class=""modal-body"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label>Type Mouvement</label>
                                        <select class=""form-control"" id=""typmouv"">
                    ");
            WriteLiteral(@"                        <option>Entrant</option>
                                            <option>Sortant</option>
                                        </select>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""raison"">Raison</label>
                                        <input type=""text"" class=""form-control"" id=""raison"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""quantite"">Quantite </label>
                                        <input type=""number"" class=""form-control"" id=""quantite"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""observation"">Observation</label>
                                        <input type=""text"" class=""form-control"" id=""observation"">
 ");
            WriteLiteral(@"                                   </div>
                                    <div class=""form-group"">
                                        <label for=""DateMvt"">Date</label>
                                        <input type=""date"" class=""form-control"" id=""updatemouv"">
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label for=""lotId"">Produit</label>
                                        <select class=""form-control"" id=""typprod"">
");
#nullable restore
#line 251 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                             foreach (var prod in ViewBag.ListProduits)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0140a33dae7e2022e13ce5716e9735b554ad67e127244", async() => {
#nullable restore
#line 253 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                                                    Write(prod.Nom);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 253 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                                   WriteLiteral(prod.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 254 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </select>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""concentration"" id=""labconcent"">Concentration </label>
                                        <input type=""text"" class=""form-control"" id=""concentration"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""dateperemtion"" id=""labpremtion"">Date de Peremption</label>
                                        <input type=""date"" class=""form-control"" id=""dateperemtion"">
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""purete"" id=""labPurete"">Pureté</label>
                                        <input type=""text"" class=""form-control"" id=""purete"">
                                    </div>
     ");
            WriteLiteral(@"                           </div>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                            <button type=""button"" class=""btn btn-primary"" onclick=""UpdateMouvement(formmvtup)"">Save</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionProduitChimiques.Models.Entities.MouvementStock> Html { get; private set; }
    }
}
#pragma warning restore 1591
