using System;

namespace EDA_Atv4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Thalyson Luan Menezes Pereira \t\t");

            ArvoreBinaria arvoreBinaria = new ArvoreBinaria();
            ArvoreAVL arvoreAVL = new ArvoreAVL();

            Console.WriteLine();

            Console.WriteLine("Árvore Binária ----------------------------------------------");

            arvoreBinaria.Inserir(4);   //---------- Caso Médio : O(log n) || Pior Caso : O(n)
            arvoreBinaria.Inserir(10);  //---------- Caso Médio : O(log n) || Pior Caso : O(n)
            arvoreBinaria.Inserir(50);  //---------- Caso Médio : O(log n) || Pior Caso : O(n)
            arvoreBinaria.Inserir(25);  //---------- Caso Médio : O(log n) || Pior Caso : O(n)
            arvoreBinaria.Inserir(5);   //---------- Caso Médio : O(log n) || Pior Caso : O(n)
            arvoreBinaria.Inserir(4);   //---------- Caso Médio : O(log n) || Pior Caso : O(n)
            arvoreBinaria.Inserir(150); //---------- Caso Médio : O(log n) || Pior Caso : O(n)
            arvoreBinaria.Exibir();     //---------- Caso Médio : O(n)     || Pior Caso : O(n)

            arvoreBinaria.Remover(50);  //---------- Caso Médio : O(log n) || Pior Caso : O(n)
			arvoreBinaria.Exibir();     //---------- Caso Médio : O(n)     || Pior Caso : O(n)

            // EXPRESSÃO NO CASO MÉDIO : 2O(n) + 8O(log n) {Expressão do tipo linear O(n)}
            // EXPRESSÃO NO PIOR CASO  : 10O(n)            {Expressão do tipo linear O(n)}

            Console.WriteLine("Árvore AVL --------------------------------------------------");

            arvoreAVL.Inserir(50);      //---------- Caso Médio : O(log n) || Pior Caso : O(log n)
            arvoreAVL.Inserir(20);      //---------- Caso Médio : O(log n) || Pior Caso : O(log n)
            arvoreAVL.Inserir(15);      //---------- Caso Médio : O(log n) || Pior Caso : O(log n)
            arvoreAVL.Exibir();         //---------- Caso Médio : O(n)     || Pior Caso : O(n)

            arvoreAVL.Inserir(42);      //---------- Caso Médio : O(log n) || Pior Caso : O(log n)
            arvoreAVL.Inserir(60);      //---------- Caso Médio : O(log n) || Pior Caso : O(log n)
            arvoreAVL.Inserir(30);      //---------- Caso Médio : O(log n) || Pior Caso : O(log n)
            arvoreAVL.Exibir();         //---------- Caso Médio : O(n)     || Pior Caso : O(n)

            arvoreAVL.Remover(50);      //---------- Caso Médio : O(log n) || Pior Caso : O(log n)
            arvoreAVL.Remover(42);      //---------- Caso Médio : O(log n) || Pior Caso : O(log n)
            arvoreAVL.Exibir();         //---------- Caso Médio : O(n)     || Pior Caso : O(n)

            // EXPRESSÃO NO CASO MÉDIO : 3O(n) + 8O(log n) {Expressão do tipo linear O(n)}
            // EXPRESSÃO NO PIOR CASO  : 3O(n) + 8O(log n) {Expressão do tipo linear O(n)}


        }
    }
}
