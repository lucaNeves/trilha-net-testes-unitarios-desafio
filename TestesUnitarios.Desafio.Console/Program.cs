// Vou rodar aqui alguns dos métodos

using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista vl = new ValidacoesLista();
ValidacoesString vs = new ValidacoesString();

// List<int> listaInteiros = new List<int>();
// string saida = "";
// listaInteiros.Add(12);
// listaInteiros.Add(8);
// listaInteiros.Add(-15);
// listaInteiros.Add(-30);
// listaInteiros.Add(-6);
// listaInteiros.Add(6);
// listaInteiros.Add(48);
// listaInteiros.Add(124);
// listaInteiros.Add(91);
// listaInteiros.Add(-4);

// foreach (int item in listaInteiros)
// {
//     saida += item + " ";
// }
// Console.WriteLine(saida+"\n");

// List<int> listaSemNegativos = vl.RemoverNumerosNegativos(listaInteiros);
// foreach (int item in listaSemNegativos)
// {
//     saida += item + " ";
// }
// Console.WriteLine(saida);

// Console.WriteLine($"A lista contém -6 ? {vl.ListaContemDeterminadoNumero(listaInteiros, -6)}");
// Console.WriteLine($"A lista contém 40 ? {vl.ListaContemDeterminadoNumero(listaInteiros, 40)}");

// int multiplicarListaPor = 2;
// Console.WriteLine($"\nA lista multiplicada por {multiplicarListaPor} é:");
// List<int> listaMultiplicada = vl.MultiplicarNumerosLista(listaInteiros, multiplicarListaPor);
// saida = "";
// foreach (int item in listaMultiplicada)
// {
//     saida += item + " ";
// }
// Console.WriteLine(saida);
// Console.WriteLine($"Qual o maior número da lista? resposta:{vl.RetornarMaiorNumeroLista(listaInteiros)}");
// Console.WriteLine($"Qual o menor número da lista? resposta:{vl.RetornarMenorNumeroLista(listaInteiros)}");

// string fraseParaValidar = "A paz mundial não é somente possível, mas inevitável";
// Console.WriteLine($"A frase é: \"{fraseParaValidar}\"");
// Console.WriteLine($"Essa frase possui {vs.RetornarQuantidadeCaracteres(fraseParaValidar)} caracteres.");
// string buscarPor = "chama";
// string termino = "l";
// Console.WriteLine($"Essa frase possui a string \"{buscarPor}\" ? resposta: {vs.ContemCaractere(fraseParaValidar, buscarPor)}");
// Console.WriteLine($"Essa frase termina com \"{termino}\" ? resposta: {vs.TextoTerminaCom(fraseParaValidar,termino)}");