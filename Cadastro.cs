using System;
using System.Globalization;
using System.IO.Pipes;
using MySqlConnector;

class Cadastro
{
    public void Autenticacao()
    {
        Console.Clear();
        string conexaoString = "server=localhost;database=controle_gastos;uid=root;pwd=123456;";
        using var conexao = new MySqlConnection(conexaoString);
        try
        {
            conexao.Open();
                Console.WriteLine("=========================== GERAR PLANILHA 1.0V=================================");
                Console.Write("\nDigite seu nome de usuario: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                string senha = Console.ReadLine();
                Console.WriteLine("Digite Seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite seu sobrenome: ");
                string sobrenome = Console.ReadLine();
                Console.WriteLine("Digite sua data de nascimento: ");
                string dt_nasc = Console.ReadLine();
                string DataFinal = ConverterData.@Convert(dt_nasc);
                Console.WriteLine("Digite seu CPF: ");
                double cpf = double.Parse(Console.ReadLine());

                string sql = "INSERT INTO usuario(usuario,senha,nome,sobrenome,DT_Nascimento,CPF) VALUES(@usuario,@senha,@nome,@sobrenome,@DataFinal,@cpf)";
                using var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@sobrenome", sobrenome);
                comando.Parameters.AddWithValue("@DataFinal", DataFinal);
                comando.Parameters.AddWithValue("@cpf", cpf);

                comando.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro :" + ex.Message);
        }
    }
}