using System;
using System.Collections.Generic;
using MySqlConnector;

namespace ProjetoIntegrador.Models
{
    public class UsuarioRepository
    {
        private const string DadosConexao = "Database=ProjIntegrador;Data Source=localhost;User Id=root;";
        public void TestarConexao(){
            //conectar com banco de dados
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 
            Console.WriteLine("Banco de Dados funcionando");
            Conexao.Close();
        }

        public Usuario ValidarLogin(Usuario usuario) {
        //abrir a conexao    
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open();
        //criar um usuario vazio com NULL
            Usuario UsuarioEncontrado = null;
        //informando uma Query do objeto Conexao
            String Query = "SELECT * FROM Usuario WHERE Login=@Login and Senha=@Senha";
        //prepara o comando e executa
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);            
        //SQL INJECTION
            Comando.Parameters.AddWithValue("@Login",usuario.Login);
            Comando.Parameters.AddWithValue("@Senha",usuario.Senha);
        //executamos o comando e guardamos as informações no objeto da classe MySqlDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();
        //percurso
        if (Reader.Read()){
                UsuarioEncontrado= new Usuario();
                UsuarioEncontrado.Id = Reader.GetInt32("Id");
            //não inserir dados NULL
            if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))) {   
                UsuarioEncontrado.Nome = Reader.GetString("Nome");
            }   
            if (!Reader.IsDBNull(Reader.GetOrdinal("Login"))) {   
                UsuarioEncontrado.Login = Reader.GetString("Login");
            }   
            if (!Reader.IsDBNull(Reader.GetOrdinal("Senha"))) {  
                UsuarioEncontrado.Senha = Reader.GetString("Senha");
            }  
            
            UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
        }
        //fechar a conexao
            Conexao.Close();
        //retornar Usuario Encontrado ou NULL
        return UsuarioEncontrado;
        
        }
    // CRUD
    // inserir, alterar, listar e escluir Usuarios no BD

    //inserir
    public void inserir(Usuario novoUser) {
        //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open();
        //informando uma Query do objeto Conexao
            String Query = "INSERT INTO Usuario (Nome,Login,Senha,DataNascimento) VALUES(@Nome,@Login,@Senha,@DataNascimento)";
        //preparar o comando    
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
        //tratar do SQL INJECTION
            Comando.Parameters.AddWithValue("@Nome",novoUser.Nome);
            Comando.Parameters.AddWithValue("@Login",novoUser.Login);
            Comando.Parameters.AddWithValue("@Senha",novoUser.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento",novoUser.DataNascimento);
        //executar o comando
            Comando.ExecuteNonQuery();                    
        //fechar a conexao
            Conexao.Close();
    }


    //alterar
    public void atualizar(Usuario user) {
        //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 

        //informando uma Query do objeto Conexao
            String Query = "UPDATE Usuario SET Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento WHERE Id=@Id";
        //preparar o comando    
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

        //tratar do SQL INJECTION
            Comando.Parameters.AddWithValue("@Nome",user.Nome);
            Comando.Parameters.AddWithValue("@Login",user.Login);
            Comando.Parameters.AddWithValue("@Senha",user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento",user.DataNascimento);
            Comando.Parameters.AddWithValue("@Id",user.Id);
           
        //executar o comando
            Comando.ExecuteNonQuery();
        //fechar a conexao
            Conexao.Close();
    }

    // remover (Delete)

    public void remover(Usuario user) {
        //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 

            //informando uma Query do objeto Conexao
            String Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //executamos o comando 
            Comando.Parameters.AddWithValue("@Id",user.Id);
            //substituir o valor informado na variavel @Id
            //validar internamente se o valor não é mal intensionado (SQL INJECTION)

            //executar no banco de dados
            Comando.ExecuteNonQuery();

            //fechar a conexao
            Conexao.Close();

    }
//buscar um Id

    public Usuario BuscarPorID(int Id) {
        //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 
        //criar um usuario vazio
            Usuario UsuarioEncontrado = new Usuario();
        //informando uma Query do objeto Conexao
            String Query = "SELECT * FROM Usuario WHERE Id=@Id";
        //prepara o comando e executa
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);            
        //SQL INJECTION
            Comando.Parameters.AddWithValue("@Id",Id);
        //executamos o comando e guardamos as informações no objeto da classe MySqlDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();
        //percurso
        if (Reader.Read()){
                
                UsuarioEncontrado.Id = Reader.GetInt32("Id");
            //não inserir dados NULL
            if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))) {   
                UsuarioEncontrado.Nome = Reader.GetString("Nome");
            }   
            if (!Reader.IsDBNull(Reader.GetOrdinal("Login"))) {   
                UsuarioEncontrado.Login = Reader.GetString("Login");
            }   
            if (!Reader.IsDBNull(Reader.GetOrdinal("Senha"))) {  
                UsuarioEncontrado.Senha = Reader.GetString("Senha");
            }  
            
            UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            
        }

        //fechar a conexao
            Conexao.Close();
        //retorna o usuario encontrado
        return UsuarioEncontrado;
    }



    // listar (Read)
        public List<Usuario> Listar(){
            //abrir a conexao
            MySqlConnection Conexao= new MySqlConnection(DadosConexao); 
            Conexao.Open(); 

            //criando a lista mas está vazia
            List<Usuario> ListaDeUsuarios = new List<Usuario>();

            //informando uma Query do objeto Conexao
            String Query = "SELECT * FROM Usuario";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //executamos o comando e guardamos as informações no objeto da classe MySqlDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();

            //percorrer registro a registro o Reader retornado
            while(Reader.Read()){
                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");
            //não inserir dados NULL
            if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))) {   
                UsuarioEncontrado.Nome = Reader.GetString("Nome");
            }   
            if (!Reader.IsDBNull(Reader.GetOrdinal("Login"))) {   
                UsuarioEncontrado.Login = Reader.GetString("Login");
            }   
            if (!Reader.IsDBNull(Reader.GetOrdinal("Senha"))) {  
                UsuarioEncontrado.Senha = Reader.GetString("Senha");
            }  
            
                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            
                ListaDeUsuarios.Add(UsuarioEncontrado);
            }

            Conexao.Close();

            return ListaDeUsuarios;
        }
    }
}