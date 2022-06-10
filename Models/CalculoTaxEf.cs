using System;
using System.Collections.Generic;

namespace ProjetoIntegrador.Models
{
    public class CalculoTaxEf
    {
         private List<ItemCalculoTaxEf> lista;

        //metodos

        public CalculoTaxEf(){
           lista = new List<ItemCalculoTaxEf>(); 
        }

        public void Adicionar(ItemCalculoTaxEf item){
            lista.Add(item);
        }

        public List<ItemCalculoTaxEf> Listar(){
            return lista;
        }

        public int TotalRegistros(){
            return lista.Count;
        }

       public double somaItens(){
            
            double somaValor = 0; 
            for(int i = 0; i<lista.Count;i++){
               somaValor = somaValor + lista[i].invest ; //acumulador
            }    
            return somaValor;
        }
    
        
    }
}