using System;

namespace AulaPOOSobrecarga.classes
{
    public class funcionario
    {
        public string[] lista = new string [4];
        
        public void Mostrar(){
            for (var i = 0; i < lista.Length; i++)
            {
               Console.Write($"{lista[i]}, "); 
            }
        }
        public void Mostrar(int indice){
            Console.WriteLine($"{lista[indice]}");
        }
        public void Mostrar(string busca){
            bool condicao= false;
            for (var i = 0; i < lista.Length; i++)
            {
                if (busca == lista[i])
                {
                    Console.WriteLine($"Achei o item {busca} no índice {i}");
                    condicao = true;
                }
                else if (i== 3 && condicao==false)
                {
                    Console.WriteLine($"Não achei o item {busca} em nenhum índice");
                }
            }
        }
    }
}