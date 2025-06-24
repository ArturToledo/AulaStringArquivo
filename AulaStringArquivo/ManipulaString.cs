namespace AulaStringArquivo;

public class ManipulaString
{
    public string Texto { get; set; }

    public void CarregaTexto()
    {
        Console.WriteLine("Digite seu texto: ");
        Texto = Console.ReadLine();
        MostraTamanhoStrig();
        MudeParaCaixaAlta();
        MudeParaCaixaBaixa();
        GetSubString();
        Replace();
        VerificaSeContem();
        TrimNaString();
        SplitPorEspaco();
        Exemplo();
    }

    public void MostraTamanhoStrig()
    {
        Console.WriteLine($"A String tem {Texto.Length} caracteres");
    }

    public void MudeParaCaixaAlta()
    {
        Texto = Texto.ToUpper();
        Console.WriteLine($"{Texto}");
    }
    public void MudeParaCaixaBaixa()
    {
        Texto = Texto.ToLower();
        Console.WriteLine($"{Texto}");
    }

    public void GetSubString()
    {
        if (Texto.Length > 7)
        {
            var sub = Texto.Substring(7);
            Console.WriteLine($"{sub}");
        }
        else
        {
            Console.WriteLine("Texto muito curto para Substring(7)");
        }

        if (Texto.Length >= 16)
        {
            var sub2 = Texto.Substring(7, 9);
            Console.WriteLine($"{sub2}");
        }
        else
        {
            Console.WriteLine("Texto muito curto para Substring(7,9)");
        }
    }

    public void Replace()
    {
        Texto = Texto.Replace('a', 'e');
        Console.WriteLine($"{Texto}");
    }

    public void VerificaSeContem()
    {
        var res = Texto.Contains("Silva");
        Console.WriteLine($"Contêm Silva {res}");

        var res2 = Texto.Contains("silve");
        Console.WriteLine($"Contêm silve {res2}");
    }

    public void SplitPorEspaco()
    {
        var strings = Texto.Split(' ');

        var i = 0;
        foreach (var item in strings)
        {
            Console.WriteLine($"String {i} = {item}");
            i++;
        }
    }

    public void TrimNaString()
    {
        Texto = Texto.Trim();
        Console.WriteLine($"{Texto}");
    }

    public void Exemplo()
    {
        string frase = " Olá, mundo! ";
        Console.WriteLine("\n\nOriginal: " + frase);
        Console.WriteLine("Maiúsculas: " + frase.ToUpper());
        Console.WriteLine("Sem espaços: " + frase.Trim());
        Console.WriteLine("Substituição: " + frase.Replace("mundo", "C#"));
        Console.WriteLine("Contém 'Olá': " + frase.Contains("Olá"));
    }
}