#pragma checksum "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dea6766c0092c3fb72b5c1ac7101517d81926df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mouvement_MouvementSortant), @"mvc.1.0.view", @"/Views/Mouvement/MouvementSortant.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dea6766c0092c3fb72b5c1ac7101517d81926df", @"/Views/Mouvement/MouvementSortant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeb3f15e6fe4c93c69a9c71b6bb2235d4cef8eca", @"/Views/_ViewImports.cshtml")]
    public class Views_Mouvement_MouvementSortant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionProduitChimiques.Models.Entities.MouvementStock>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("quantite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "qt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-val", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-val-required", new global::Microsoft.AspNetCore.Html.HtmlString("La Quantité est obligatoire"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Achat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Emprunt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Recherche", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Enseignement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Autre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formmvt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
  
    ViewData["title"] = "Gestion des Mouvements Sortant";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <label title=""Add New Mouvement"" id=""addproduit"" class=""btn btn-white  pull-right miseEnformetable"" onclick=""AddMouvementSortant()"">
        <br />
        <i class=""ace-icon fa fa-plus""></i>
        Ajouter
    </label>
    <div class=""col-lg-12 "">
        <div class=""panel panel-default miseEnformetable"">
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
                                    <i class=""fa fa-search""><");
            WriteLiteral(@"/i>
                                </button>
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
                                <th>Nom du Prodruit</th>
                                <!--<th>Purete</th>
                                <th>Concentration</th>
                                <th>Date de péremption</th>-->
                                <th>Quantité</th>
                                <th>Unite de Mesure</th>
                                <!---<th>Action</th>-->
               ");
            WriteLiteral("             </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                             foreach (var item in @ViewBag.ListMouvement)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"search\">\r\n\r\n                                    <td>\r\n");
#nullable restore
#line 57 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                         if (item.DateMouvement != null)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                       Write(item.DateMouvement.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                                                                           
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 63 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                   Write(item.TypeMvt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 66 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                   Write(item.Raison);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 69 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                   Write(item.produit.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 72 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                   Write(item.Quantite);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 75 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                   Write(item.UniteMesure);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <!----<td>
                                        <div class=""row"">
                                            <div class=""col-md-2 tools action-buttons"">
                                                <a href=""#"" class=""red"" title=""Delete Produit"" id=""idDeleteProduit"" onclick=""showModelDeleteMouvement(");
#nullable restore
#line 80 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                                                                                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")"">
                                                    <i class=""ace-icon fa fa-trash-o bigger-140""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </td>-->
                                </tr>
");
#nullable restore
#line 87 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
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
    <div class=""modal-dialog centmodelAddMvt widthmodeladdmvt"">
        <div class=""modal-content"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df15332", async() => {
                WriteLiteral(@"
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                            <h4 class=""modal-title text-center"" id=""myModalLabel"">Ajouter un Mouvement</h4>
                        </div>
                        <div class=""modal-body"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""MiseFormeTypeMvt"">Type Mouvement</label>
                                        <select class=""form-control MiseFormeTypeMvt"" id=""typmouv"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df16389", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df17449", async() => {
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
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label for=""DateMvt"" class=""MiseFormeDMvt"">Date</label>
                                        <input type=""date""");
                BeginWriteAttribute("value", " value=\"", 6105, "\"", 6149, 1);
#nullable restore
#line 126 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
WriteAttributeValue("", 6113, DateTime.Now.ToString("yyyy-MM-dd"), 6113, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control MiseFormeDMvt"" id=""DateMvt"">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <fieldset class=""scheduler-border"">
                                    <legend class=""scheduler-border colorlegende"">Produit</legend>
                                    <div class=""col-lg-12"">
                                        <div class=""form-group"">
                                            <label for=""lotId"">Nom</label>
                                            <select class=""form-control chosen"" id=""typprod"">
");
#nullable restore
#line 137 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                                 foreach (var prod in ViewBag.ListProduits)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df20455", async() => {
#nullable restore
#line 139 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
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
#line 139 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
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
#line 140 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            </select>
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label for=""purete"" id=""labPurete"">Pureté</label>
                                            <input type=""text"" class=""form-control"" id=""purete"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label for=""concentration"" id=""labconcent"">Concentration </label>
                                            <input type=""text"" class=""form-control"" id=""concentration"">
                                        </div>
                                    </div>
                                ");
                WriteLiteral(@"    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label for=""dateperemtion"" id=""labpremtion"">Date Peremption</label>
                                            <input type=""date""");
                BeginWriteAttribute("value", " value=\"", 8420, "\"", 8464, 1);
#nullable restore
#line 159 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
WriteAttributeValue("", 8428, DateTime.Now.ToString("yyyy-MM-dd"), 8428, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" id=""dateperemtion"">
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                            <div class=""row"">
                                <fieldset class=""scheduler-border"">
                                    <legend class=""scheduler-border colorlegende"">Détails</legend>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label for=""quantite"">Quantite<font color=""blue"">*</font> </label>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6dea6766c0092c3fb72b5c1ac7101517d81926df25271", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 170 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Quantite);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 171 "C:\Users\ahmad\source\repos\GestionProduitChimiques\GestionProduitChimiques\Views\Mouvement\MouvementSortant.cshtml"
                                       Write(Html.ValidationMessage("qt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""col-lg-3"">
                                        <label for=""unitemvt"">Unité</label>
                                        <select class=""form-control"" id=""unitemvt"">
                                        </select>
                                    </div>
                                    <div class=""col-lg-5"">
                                        <label for=""raison"">Raison</label>
                                        <select class=""form-control"" id=""raison"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df28397", async() => {
                    WriteLiteral("Achat");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df29664", async() => {
                    WriteLiteral("Emprunt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df30933", async() => {
                    WriteLiteral("Recherche");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df32204", async() => {
                    WriteLiteral("Enseignement");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dea6766c0092c3fb72b5c1ac7101517d81926df33478", async() => {
                    WriteLiteral("Autre");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
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
                                    <div class=""col-lg-12"">
                                        <div class=""form-group"">
                                            <label>Observation</label>
                                            <textarea class=""form-control"" rows=""5"" id=""observation""></textarea>
                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Fermer</button>
                            <button type=""button"" class=""btn btn-primary"" onclick=""AddMouvement(formmvt)"">Enregistrer</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
                        <h4 class=""modal-title text-center"" style=""color:white !important"" id=""exampleModalLongTitle"">Supprimer un  Mouvement</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" style=""font-size:22px;color:white !important;top:5px;right:20px;position:absolute;"">
                            <span aria-hidden=""true"">&times;</span>
                        </but");
            WriteLiteral(@"ton>
                    </div>
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

");
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
