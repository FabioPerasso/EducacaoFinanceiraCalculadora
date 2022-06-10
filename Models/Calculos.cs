using System;
namespace ProjetoIntegrador.Models
{
    public class Calculos
    {
        public int IdPT {get;set;}
        public int Id {get;set;}
        public double Investimento {get;set;}
        public double TaxaNominal {get;set;}
        public DateTime Inicio {get;set;}
        public DateTime Vencimento {get;set;}
        public double Dias {get;set;}
        public double Anos {get;set;}
        public double IR {get;set;}
        public double Juros {get;set;}
        public double Retorno {get;set;}
        public double TaxaEfetiva {get;set;}
    }
}