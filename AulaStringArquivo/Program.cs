using AulaStringArquivo;

ManipulaString manipulaString = new ManipulaString();

manipulaString.CarregaTexto();

ManipulacaoArquivo manipulacaoArquivo = new ManipulacaoArquivo();

manipulacaoArquivo.ValidaArquivo();
manipulacaoArquivo.RegistrarUsuario();
manipulacaoArquivo.ContarPalavraCSharp("exemplo.txt");