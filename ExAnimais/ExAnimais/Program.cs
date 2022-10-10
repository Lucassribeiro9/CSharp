using System;

/*Crie um algoritmo/programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e peixes foram informados.

Regras que deverão ser seguidas para a implementação do algoritmo:

Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa deverá definir o tipo do animal como Peixe.
É obrigatório criar uma classe para representar o Animal. */
namespace ExAnimais
{
    class Program
    {
        static void Main(string[] args)
        {

            Animais an = new Animais() { Nome = "Bilu", Especie = "Mula" };
            an.VerificarEspecie();
        }
    }
}
