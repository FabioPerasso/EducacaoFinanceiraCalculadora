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
    
  public class UsuarioController : Controller
  {
      public IActionResult Login(){
        return View();
      }
      [HttpPost]

      public IActionResult Login(Usuario usuario) {
        UsuarioRepository ur = new UsuarioRepository();
        Usuario usuarioSessao = ur.ValidarLogin(usuario);
        if (usuarioSessao==null) {
          //não localizado usuario
          ViewBag.mensagem= "Usuario não localizado com Login e Senha";
          return View();
        } else {
          // login e senha localizado
          ViewBag.mensagem= "Você está logado!";
          //registra na sessao dados do usuario
          HttpContext.Session.SetInt32("IdUsuario",usuarioSessao.Id);
          HttpContext.Session.SetString("NomeUsuario",usuarioSessao.Nome);
          //redirecionamento
          return View();

        }
          
      }
      public IActionResult Logout(){
        //limpar dados da sessao
        HttpContext.Session.Clear(); //limpa todos dados da sessão
        //redirecionamento
        return View("Login");

      }



      public IActionResult Lista() {
        //validando se o usuario está logado. Se não, é redirecionado para o Login.
        if (HttpContext.Session.GetInt32("IdUsuario")==null){
            return RedirectToAction("Login","Usuario");
        }

        UsuarioRepository ur = new UsuarioRepository();
        List<Usuario> lista = ur.Listar();
        return View(lista);
      }

      public IActionResult Excluir(int Id){
        UsuarioRepository ur = new UsuarioRepository();
        Usuario userEncontrado = ur.BuscarPorID(Id);
        if(userEncontrado.Id>0) {
          ur.remover(userEncontrado);
        } else {
          ViewData["mensagem"] = "Usuário não localizado";
        }
        
        return RedirectToAction("Lista");
      }

      public IActionResult Inserir(){
        return View();
      }

      [HttpPost]

      public IActionResult Inserir(Usuario novoUser) {
        UsuarioRepository ur = new UsuarioRepository();
        ur.inserir(novoUser);
        ViewData["mensagem"] = "Cadastro realizado com sucesso";
        return View();
      }

      public IActionResult Alterar(int Id) {
      //validando se o usuario está logado. Se não, é redirecionado para o Login.
        if (HttpContext.Session.GetInt32("IdUsuario")==null){
            return RedirectToAction("Login","Usuario");
        }

        UsuarioRepository ur = new UsuarioRepository();
        Usuario userEncontrado = ur.BuscarPorID(Id);

        return View(userEncontrado);
      }
      [HttpPost]

      public IActionResult Alterar(Usuario usuario) {
        UsuarioRepository ur = new UsuarioRepository();
        ur.atualizar(usuario);

        return RedirectToAction("Lista");
      }
  } 
}