#pragma checksum "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e7a912ff9050ce921ba0e368cac41cf68fc3d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listagem), @"mvc.1.0.view", @"/Views/Home/Listagem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e7a912ff9050ce921ba0e368cac41cf68fc3d5f", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbeb2e62ff5bd534d38ee57f7f0a97e810f27fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemCalculoTaxEf>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
table, th, td {
  border: 1px solid black; text-align: center; vertical-align: middle; 
}
table.center {
  margin-left: auto;
  margin-right: auto;
}
</style>

<h2>Resumo do Calculo Taxa Nominal x Efetiva</h2>
<br>
<table>
    <tr>
        <th>Investimento</th>
        <th>Taxa Nominal Anual</th>
        <th>Início</th>
        <th>Vencimento</th>
        <th>Dias</th>
        <th>Anos</th>
        <th>Juros</th>
        <th>Retorno</th>
        <th>Taxa Efetiva Anual</th>
    </tr>
");
#nullable restore
#line 27 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
      double somaRetorno = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
     foreach (ItemCalculoTaxEf ip in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td> ");
#nullable restore
#line 31 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(ip.invest.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td> ");
#nullable restore
#line 32 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(ip.taxa);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td> ");
#nullable restore
#line 33 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(ip.hoje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td> ");
#nullable restore
#line 34 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(ip.Vencimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
           double dias;  dias = (ip.Vencimento - ip.hoje).TotalDays;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td> ");
#nullable restore
#line 36 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(dias.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 37 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
           double anos; anos = @dias / 365;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td> ");
#nullable restore
#line 38 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(anos.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 39 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
           double ir; 
            if ( dias < 180) ir = 0.225f;      
            else
                 if ( dias < 360) ir = 0.2f; else
                    if ( dias < 720) ir = 0.175f; 
                    else ir = 0.15f; 
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
           double juros;
        juros = (Math.Pow((1+ip.taxa/100),anos)-1) * ip.invest * (1-ir);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td> ");
#nullable restore
#line 48 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(juros.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 49 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
          double retorno;
         retorno = ip.invest + juros;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td> ");
#nullable restore
#line 51 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(retorno.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td> \r\n");
#nullable restore
#line 52 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
           double taxaefetiva;  
            taxaefetiva= (Math.Pow(retorno / ip.invest,(1/anos)) - 1)*100;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td> ");
#nullable restore
#line 54 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
        Write(taxaefetiva.ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr> \r\n");
#nullable restore
#line 56 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
    somaRetorno = somaRetorno + retorno;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br>\r\n<hr>\r\nTotal de Cálculos: ");
#nullable restore
#line 61 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
              Write(Dados.CalculoAtual.TotalRegistros());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> <hr>\r\nTotal Investido..: ");
#nullable restore
#line 62 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
              Write(Dados.CalculoAtual.somaItens().ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br> <hr>\r\nTotal Retornado..: ");
#nullable restore
#line 63 "C:\Users\flper\Documents\EAD Senac\ProjetoIntegradorV2\Views\Home\Listagem.cshtml"
              Write(somaRetorno.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br> <hr>\r\n \r\n<p>\r\n    <a href=\"/Home/Index\"> \r\n     Voltar\r\n    </a>\r\n</p>\r\n\t\t<footer>\r\n\t\t\t<hr>\r\n\t\t\t<h5>Elaborado por Fabio Perasso</h5>\r\n\r\n\t\t</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemCalculoTaxEf>> Html { get; private set; }
    }
}
#pragma warning restore 1591