using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Controllers
{
    public class CalculosController : Controller
    {
     public IActionResult Lista() {
        //validando se o usuario está logado. Se não, é redirecionado para o Login.
        if (HttpContext.Session.GetInt32("IdUsuario")==null){
            return RedirectToAction("Login","Usuario");
        }
          CalculosRepository ptr = new CalculosRepository();
          List<Calculos> listapt = ptr.Listar();
          return View(listapt);
      }   

       public IActionResult Excluir(int IdPT){
        CalculosRepository ur = new CalculosRepository();
        Calculos PacoteEncontrado = ur.BuscarPorID(IdPT);
        if(PacoteEncontrado.IdPT>0) {
          ur.remover(PacoteEncontrado);
        } else {
          ViewData["mensagem"] = "Pacote não localizado";
        }
        
        return RedirectToAction("Lista");
      }

      public IActionResult Inserir(){
        return View();
      }

      [HttpPost]

      public IActionResult Inserir(Calculos novoUser) {
      
        double ir, Dias, Anos, Juros, Retorno, TaxaEfetiva;
        Dias= (novoUser.Vencimento - novoUser.Inicio).TotalDays;
        Anos= (novoUser.Vencimento - novoUser.Inicio).TotalDays / 365;
        if ( Dias < 180) ir = 0.225f;      
            else
                 if ( Dias < 360) ir = 0.2f; else
                    if ( Dias < 720) ir = 0.175f; 
                    else ir = 0.15f; 
        Juros = (Math.Pow((1+novoUser.TaxaNominal/100),Anos)-1) * novoUser.Investimento * (1-ir);
        Retorno = novoUser.Investimento + Juros;
        TaxaEfetiva= (Math.Pow(Retorno / novoUser.Investimento,(1/Anos)) - 1)*100;
              
        //alimentando o objeto com informações
        novoUser.Dias = Dias;
        novoUser.Anos = Anos;
        novoUser.Juros = Juros;
        novoUser.Retorno = Retorno;
        novoUser.TaxaEfetiva = TaxaEfetiva;

        // cria o objeto
        CalculosRepository ur = new CalculosRepository();
        ur.inserir(novoUser);
        ViewData["mensagem"] = "Cadastro realizado com sucesso";
        return View();
      }

      public IActionResult Alterar(int IdPT) {
        //validando se o usuario está logado. Se não, é redirecionado para o Login.
        if (HttpContext.Session.GetInt32("IdUsuario")==null){
            return RedirectToAction("Login","Usuario");
        }

      /*  double ir, Dias, Anos, Juros, Retorno, TaxaEfetiva;
        Dias= (novoUser.Vencimento - novoUser.Inicio).TotalDays;
        Anos= (novoUser.Vencimento - novoUser.Inicio).TotalDays / 365;
        if ( Dias < 180) ir = 0.225f;      
            else
                 if ( Dias < 360) ir = 0.2f; else
                    if ( Dias < 720) ir = 0.175f; 
                    else ir = 0.15f; 
        Juros = (Math.Pow((1+novoUser.TaxaNominal/100),Anos)-1) * novoUser.Investimento * (1-ir);
        Retorno = novoUser.Investimento + Juros;
        TaxaEfetiva= (Math.Pow(Retorno / novoUser.Investimento,(1/Anos)) - 1)*100;
              
        //alimentando o objeto com informações
        novoUser.Dias = Dias;
        novoUser.Anos = Anos;
        novoUser.Juros = Juros;
        novoUser.Retorno = Retorno;
        novoUser.TaxaEfetiva = TaxaEfetiva;

      */





        CalculosRepository ur = new CalculosRepository();
        Calculos PacoteEncontrado = ur.BuscarPorID(IdPT);

        return View(PacoteEncontrado);
      }
      [HttpPost]

      public IActionResult Alterar(Calculos pacote) {
        CalculosRepository ur = new CalculosRepository();
        ur.atualizar(pacote);

        return RedirectToAction("Lista");
      } 
    }
}