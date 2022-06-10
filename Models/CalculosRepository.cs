using System;
using System.Collections.Generic;
using MySqlConnector;

namespace ProjetoIntegrador.Models
{
    public class CalculosRepository
    {
        private const string DadosConexao = "Database=ProjIntegrador;Data Source=localhost;User Id=root;";
        public void TestarConexao(){
            //conectar com banco de dados
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 
            Console.WriteLine("Banco de Calculos");
            Conexao.Close();
        }
    
    // CRUD

        // inserir, alterar, listar e escluir Usuarios no BD
    //inserir
    public void inserir(Calculos novoUser) {
       /* double @ir, @Dias, @Anos, @Juros, @Retorno, @TaxaEfetiva;
        int @Idpt;
        @Dias= (novoUser.Vencimento - novoUser.Inicio).TotalDays;
        @Anos= (novoUser.Vencimento - novoUser.Inicio).TotalDays / 365;
        if ( @Dias < 180) @ir = 0.225f;      
            else
                 if ( @Dias < 360) @ir = 0.2f; else
                    if ( @Dias < 720) @ir = 0.175f; 
                    else @ir = 0.15f; 
        @Juros = (Math.Pow((1+novoUser.TaxaNominal/100),@Anos)-1) * novoUser.Investimento * (1-@ir);
        @Retorno = novoUser.Investimento + @Juros;
        @TaxaEfetiva= (Math.Pow(@Retorno / novoUser.Investimento,(1/@Anos)) - 1)*100;*/
        //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open();
        //informando uma Query do objeto Conexao
            String Query = "INSERT INTO Calculos (Investimento,TaxaNominal,Inicio,Vencimento,Id) VALUES(@Investimento,@TaxaNominal,@Inicio,@Vencimento,@Id)";
            String Query2 = "UPDATE Calculos set Dias = Datediff(Vencimento,Inicio)";
            String Query3 = "UPDATE Calculos set Anos = Dias/365 ";
            String Query4 = "UPDATE Calculos set IR = 0.15 WHERE Dias>=720";
            String Query5 = "UPDATE Calculos set IR = 0.225 WHERE Dias<180";
            String Query6 = "UPDATE Calculos set IR = 0.20 WHERE Dias>=180 and Dias<=360";
            String Query7 = "UPDATE Calculos set IR = 0.175 WHERE Dias>360 and Dias<720";
            String Query8 = "UPDATE Calculos set Juros = (Power(1+TaxaNominal/100,Anos)-1) * Investimento * (1-IR)";
            String Query9 = "UPDATE Calculos set Retorno = Juros + Investimento";
            String Query10 = "UPDATE Calculos set TaxaEfetiva = (Power(Retorno/Investimento,1/Anos)-1) * 100";
        //preparar o comando    
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            MySqlCommand Comando2 = new MySqlCommand(Query2,Conexao);
            MySqlCommand Comando3 = new MySqlCommand(Query3,Conexao);
            MySqlCommand Comando4 = new MySqlCommand(Query4,Conexao);
            MySqlCommand Comando5 = new MySqlCommand(Query5,Conexao);
            MySqlCommand Comando6 = new MySqlCommand(Query6,Conexao);
            MySqlCommand Comando7 = new MySqlCommand(Query7,Conexao);
            MySqlCommand Comando8 = new MySqlCommand(Query8,Conexao);
            MySqlCommand Comando9 = new MySqlCommand(Query9,Conexao);
            MySqlCommand Comando10 = new MySqlCommand(Query10,Conexao);
        //tratar do SQL INJECTION
            Comando.Parameters.AddWithValue("@Investimento",novoUser.Investimento);
            Comando.Parameters.AddWithValue("@TaxaNominal",novoUser.TaxaNominal);
            Comando.Parameters.AddWithValue("@Inicio",novoUser.Inicio);
            Comando.Parameters.AddWithValue("@Vencimento",novoUser.Vencimento);
            Comando.Parameters.AddWithValue("@Dias",novoUser.Dias);
            Comando.Parameters.AddWithValue("@Anos",novoUser.Anos);
            Comando.Parameters.AddWithValue("@IR",novoUser.IR);
            Comando.Parameters.AddWithValue("@Juros",novoUser.Juros);
            Comando.Parameters.AddWithValue("@Retorno",novoUser.Retorno);
            Comando.Parameters.AddWithValue("@TaxaEfetiva",novoUser.TaxaEfetiva);
            Comando.Parameters.AddWithValue("@Id",novoUser.Id);
        //executar o comando
            Comando.ExecuteNonQuery();  
            Comando2.ExecuteNonQuery();
            Comando3.ExecuteNonQuery();   
            Comando4.ExecuteNonQuery();   
            Comando5.ExecuteNonQuery();  
            Comando6.ExecuteNonQuery();   
            Comando7.ExecuteNonQuery(); 
            Comando8.ExecuteNonQuery();  
            Comando9.ExecuteNonQuery();   
            Comando10.ExecuteNonQuery();        
        //fechar a conexao
            Conexao.Close();
    }


    //alterar
    public void atualizar(Calculos user) {
        //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 

        //informando uma Query do objeto Conexao
            String Query = "UPDATE Calculos SET Investimento=@Investimento,TaxaNominal=@TaxaNominal,Inicio=@Inicio,Vencimento=@Vencimento  WHERE IdPT=@IdPT";
            String Query2 = "UPDATE Calculos SET Dias = Datediff(Vencimento,Inicio)";
            String Query3 = "UPDATE Calculos set Anos = Dias/365 ";
            String Query4 = "UPDATE Calculos set IR = 0.15 WHERE Dias>=720";
            String Query5 = "UPDATE Calculos set IR = 0.225 WHERE Dias<180";
            String Query6 = "UPDATE Calculos set IR = 0.20 WHERE Dias>=180 and Dias<=360";
            String Query7 = "UPDATE Calculos set IR = 0.175 WHERE Dias>360 and Dias<720";
            String Query8 = "UPDATE Calculos set Juros = (Power(1+TaxaNominal/100,Anos)-1) * Investimento * (1-IR)";
            String Query9 = "UPDATE Calculos set Retorno = Juros + Investimento";
            String Query10 = "UPDATE Calculos set TaxaEfetiva = (Power(Retorno/Investimento,1/Anos)-1) * 100";
        //preparar o comando    
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            MySqlCommand Comando2 = new MySqlCommand(Query2,Conexao);
            MySqlCommand Comando3 = new MySqlCommand(Query3,Conexao);
            MySqlCommand Comando4 = new MySqlCommand(Query4,Conexao);
            MySqlCommand Comando5 = new MySqlCommand(Query5,Conexao);
            MySqlCommand Comando6 = new MySqlCommand(Query6,Conexao);
            MySqlCommand Comando7 = new MySqlCommand(Query7,Conexao);
            MySqlCommand Comando8 = new MySqlCommand(Query8,Conexao);
            MySqlCommand Comando9 = new MySqlCommand(Query9,Conexao);
            MySqlCommand Comando10 = new MySqlCommand(Query10,Conexao);
        //tratar do SQL INJECTION
            Comando.Parameters.AddWithValue("@Investimento",user.Investimento);
            Comando.Parameters.AddWithValue("@TaxaNominal",user.TaxaNominal);
            Comando.Parameters.AddWithValue("@Inicio",user.Inicio);
            Comando.Parameters.AddWithValue("@Vencimento",user.Vencimento);
            Comando.Parameters.AddWithValue("@Dias",user.Dias);
            Comando.Parameters.AddWithValue("@Anos",user.Anos);
            Comando.Parameters.AddWithValue("@Juros",user.Juros);
            Comando.Parameters.AddWithValue("@Retorno",user.Retorno);
            Comando.Parameters.AddWithValue("@TaxaEfetiva",user.TaxaEfetiva);
            Comando.Parameters.AddWithValue("@IdPT",user.IdPT);
         //   Comando.Parameters.AddWithValue("@Id",user.Id);
           
        //executar o comando
            Comando.ExecuteNonQuery();
            Comando2.ExecuteNonQuery();
            Comando3.ExecuteNonQuery();
            Comando4.ExecuteNonQuery();   
            Comando5.ExecuteNonQuery();  
            Comando6.ExecuteNonQuery();   
            Comando7.ExecuteNonQuery(); 
            Comando8.ExecuteNonQuery();  
            Comando9.ExecuteNonQuery();   
            Comando10.ExecuteNonQuery();
        //fechar a conexao
            Conexao.Close();
    }

    // remover (Delete)

    public void remover(Calculos user) {
        //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 

            //informando uma Query do objeto Conexao
            String Query = "DELETE FROM Calculos WHERE IdPT=@IdPT";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //executamos o comando 
            Comando.Parameters.AddWithValue("@IdPT",user.IdPT);
            //substituir o valor informado na variavel @IdPT
            //validar internamente se o valor não é mal intensionado (SQL INJECTION)

            //executar no banco de dados
            Comando.ExecuteNonQuery();

            //fechar a conexao
            Conexao.Close();

    }

//buscar um Id

    public Calculos BuscarPorID(int IdPT) {
        //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 
        //criar um usuario vazio
            Calculos PacoteEncontrado = new Calculos();
        //informando uma Query do objeto Conexao
            String Query = "SELECT * FROM Calculos WHERE IdPT=@IdPT";
        //prepara o comando e executa
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);            
        //SQL INJECTION
            Comando.Parameters.AddWithValue("@IdPT",IdPT);
        //executamos o comando e guardamos as informações no objeto da classe MySqlDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();
        //percurso
        if (Reader.Read()){
                
                PacoteEncontrado.IdPT = Reader.GetInt32("IdPT");
            //não inserir dados NULL
           if (!Reader.IsDBNull(Reader.GetOrdinal("Investimento"))) {   
                PacoteEncontrado.Investimento = Reader.GetDouble("Investimento");
            }   
            if (!Reader.IsDBNull(Reader.GetOrdinal("TaxaNominal"))) {   
                PacoteEncontrado.TaxaNominal = Reader.GetDouble("TaxaNominal");
            }   
            
            PacoteEncontrado.Inicio = Reader.GetDateTime("Inicio");
            PacoteEncontrado.Vencimento = Reader.GetDateTime("Vencimento");
            PacoteEncontrado.Dias = Reader.GetDouble("Dias");
            PacoteEncontrado.Anos = Reader.GetDouble("Anos");
            PacoteEncontrado.IR = Reader.GetDouble("IR");
            PacoteEncontrado.Juros = Reader.GetDouble("Juros");
            PacoteEncontrado.Retorno = Reader.GetDouble("Retorno");
            PacoteEncontrado.Id = Reader.GetInt32("Id");
            PacoteEncontrado.TaxaEfetiva = Reader.GetDouble("TaxaEfetiva");
        }

        //fechar a conexao
            Conexao.Close();
        //retorna o usuario encontrado
        return PacoteEncontrado;
    }



    // listar (Read)
        public List<Calculos> Listar(){
            //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 

            //criando a lista mas está vazia
            List<Calculos> ListaDeCalculos = new List<Calculos>();

            //informando uma Query do objeto Conexao
            String Query = "SELECT * FROM Calculos";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //executamos o comando e guardamos as informações no objeto da classe MySqlDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();

            //percorrer registro a registro o Reader retornado
            while(Reader.Read()){
                Calculos PacoteEncontrado = new Calculos();

                PacoteEncontrado.IdPT = Reader.GetInt32("IdPT");
            //não inserir dados NULL
           if (!Reader.IsDBNull(Reader.GetOrdinal("Investimento"))) {   
                PacoteEncontrado.Investimento = Reader.GetDouble("Investimento");
            }   
            if (!Reader.IsDBNull(Reader.GetOrdinal("TaxaNominal"))) {   
                PacoteEncontrado.TaxaNominal = Reader.GetDouble("TaxaNominal");
            }   
            
            PacoteEncontrado.Inicio = Reader.GetDateTime("Inicio");
            PacoteEncontrado.Vencimento = Reader.GetDateTime("Vencimento");
            PacoteEncontrado.Dias = Reader.GetDouble("Dias");
            PacoteEncontrado.Anos = Reader.GetDouble("Anos");
            PacoteEncontrado.IR = Reader.GetDouble("IR");
            PacoteEncontrado.Juros = Reader.GetDouble("Juros");
            PacoteEncontrado.Retorno = Reader.GetDouble("Retorno");
            PacoteEncontrado.Id = Reader.GetInt32("Id");
            PacoteEncontrado.TaxaEfetiva = Reader.GetDouble("TaxaEfetiva");
            ListaDeCalculos.Add(PacoteEncontrado);
            }

            Conexao.Close();
        //retorna o Pacote Encontrado
            return ListaDeCalculos;
        } 
    }
}