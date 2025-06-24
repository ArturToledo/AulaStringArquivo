namespace AulaStringArquivo;

public class ManipulacaoArquivo
{
    public void ValidaArquivo()
    {
        if (File.Exists("C:\\Users\\robso\\source\\repos\\AulaStringArquivo\\arquivos\\texto.txt"))
        {
            Console.WriteLine("Existe");
        }
        else
        {
            Console.WriteLine("Não Existe");
        }
    }

    public void RegistrarUsuario()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        File.AppendAllText("usuarios.txt", nome + Environment.NewLine);

        Console.WriteLine("Nomes registrados:");
        using (StreamReader leitor = new StreamReader("usuarios.txt"))
        {
            string linha;
            while ((linha = leitor.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }

    public void ContarPalavraCSharp(string caminhoArquivo)
    {
        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string conteudo = File.ReadAllText(caminhoArquivo);
        int contador = 0;
        int index = 0;

        while ((index = conteudo.IndexOf("C#", index)) != -1)
        {
            contador++;
            index += 2;
        }

        Console.WriteLine($"A palavra 'C#' aparece {contador} vezes.");
    }
}