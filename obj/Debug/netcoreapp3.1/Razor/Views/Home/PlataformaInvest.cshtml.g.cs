#pragma checksum "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\PlataformaInvest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8525ed354b3f921ecfc7c6d8828ee2ca185734f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PlataformaInvest), @"mvc.1.0.view", @"/Views/Home/PlataformaInvest.cshtml")]
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
#line 1 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\_ViewImports.cshtml"
using ProjetoIntegrador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\_ViewImports.cshtml"
using ProjetoIntegrador.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8525ed354b3f921ecfc7c6d8828ee2ca185734f2", @"/Views/Home/PlataformaInvest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbeb2e62ff5bd534d38ee57f7f0a97e810f27fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PlataformaInvest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"PT-BR\">\r\n\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8525ed354b3f921ecfc7c6d8828ee2ca185734f23327", async() => {
                WriteLiteral("\r\n\t\t<title>EAD PlatafInvest</title>\r\n\t\t<meta charset=\"utf-8\">\r\n\t\t<meta name=\"keywords\" content=\"Senac, Senac RS, Projeto Integrador, Atividades, Educação Financeira\"/>\r\n        <meta name=\"description\" content=\"Projeto Informática\"/>\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8525ed354b3f921ecfc7c6d8828ee2ca185734f24558", async() => {
                WriteLiteral(@"
		<header>
		<div>
			<h1>Educação Financeira</h1>
			Esta lâmina mostra vários sites úteis para quem quer investir. Hoje a XP fornece mais de 400 produtos financeiros 
            nas mais diversas modalidades, desde: <br> Renda Fixa (CDB / LCI / LCA) com proteção do Fundo Garantidor de Crédito e 
            Crédito Privado (Debêntures / CRA / CRI); <br> Renda Variável com Ações, ETS´s e Fundos Imobiliários; <br> Fundos de Investimentos 
            (Renda fixa, Multimercados, Ações) e <br> Previdência Privada ( PGBL / VGBL ).
			<hr>
			<!--  		
			<form action=""cadastrar"" method=""post"">
	            <table>
	                <tr>
	                    <td>
	                        <input type=""text"" name=""produto"" id=""produto""/>
	                    </td>
	                    <td width=""20""></td>
	                    <td><input type=""submit"" value=""Buscar""></td>   
	                </tr>
	            </table>             
	        </form>
			<hr>
			--> 
        </div>
		</header>
");
                WriteLiteral(@"		<main>
		  <h3>Principais plataformas de investimento e informações bancárias</h3>
			<div class=""box"">
				<a href=""https://www.xpi.com.br/""> 
					<img src=""\Imagem\XP_LogoOficial2.jpg"" width=""250"" height=""250""/> 
				<br>
				
				Maior plataforma de investimentos no país. 
				</a>
				<h5>
					<ul>
						<li>Renda Fixa Emissão Bancária: CDB/LCI/LCA/LC/LH</li>
						<li>Renda Fixa Crédito Privado: Debêntures/CRA/CRI</li>
						<li>Fundos de Investimentos</li>
						<li>Renda Variável: Ações/ETF´s/Fundos Imobiliários</li>
						<li>Previdência Privada: PGBL/VGBL</li>
					</ul>
				</h5>
				
			</div>
			
			
			<div class=""box"">
				<a href=""https://bancodata.com.br/""> 
					<img src=""\Imagem\BancoData.jpg"" width=""250"" height=""300""/>
					<br>
				Principais informações sobre bancos:</a>
                <h5>
					<ul>
						<li>Índices de Basiléia e Imobilização</li>
						<li>Lucro Líquido/Patrimônio Líquido/ Capitalizações</li>
						<li>Número Agências/Clientes (PFxPJ");
                WriteLiteral(@")</li>
						<li>Carteira de Crédito x Nível de Risco e outros</li>
					</ul>
				</h5>
			</div>
            <p>
                <a href=""/Home/Index""> 
                Voltar
                </a>
            </p>
			
			<style>
            main {background-color: #9dd3d3b6;}
			div.box {
				width: 35%; margin: 10px; 
				display: inline-table;
			}
            h1 {
            color: #e7d6d6;
            background-color: #221807;
            }
			</style>
					


		</main>

		<footer>
			<hr>
			<h5>Elaborado por Fabio Perasso</h5>

		</footer>
		


	");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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