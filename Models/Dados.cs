namespace ProjetoIntegrador.Models
{
    public static class Dados
    {
        public static CalculoTaxEf CalculoAtual {get;set;}  
        static Dados() 
        {
            CalculoAtual = new CalculoTaxEf();
        }  
    }
}