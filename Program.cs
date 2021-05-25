using System;
using AulaPOOSobrecarga.classes;

namespace AulaPOOSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            funcionario f = new funcionario();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"Adicione um item para o índice {i}");
                f.lista[i]= Console.ReadLine(); 
            }
            string caminho;
            bool caminhoValido = false;
            string resposta;
            bool indiceValido = false;
            do
            {
                Console.WriteLine(@"O que deseja fazer com a lista feita?
            1-Mostar lista
            2-Procurar um índice específico
            3-Procurar um item específico");
                caminho= Console.ReadLine().Substring(0,1);
                if (caminho=="1")
                {
                    f.Mostrar();
                    caminhoValido = true;
                }
                else if (caminho=="2")
                {
                    do
                    {
                        Console.WriteLine("Qual índice você deseja consultar?");
                        resposta=Console.ReadLine();
                        if (int.Parse(resposta) >= f.lista.Length)
                        {
                            Console.WriteLine("índice maior do que o esperado, digite um valor menor.");
                            indiceValido = false;
                        }
                        else{
                            f.Mostrar(int.Parse(resposta));
                            indiceValido = true;
                        }
                    } while (indiceValido==false);
                    caminhoValido = true;
                }
                else if (caminho=="3")
                {
                    Console.WriteLine("Qual item você deseja consultar?");
                    resposta=Console.ReadLine();
                    f.Mostrar(resposta);
                    caminhoValido = true;
                }
                else
                {
                    Console.WriteLine("Caminho inválido, digite '1' para mostrar os itens da lista, '2' para consultar um índice específico da lista e '3' para consultar um item específico da lista.");
                    caminhoValido = false;
                }
            } while (caminhoValido==false);            
        }
    }
}
