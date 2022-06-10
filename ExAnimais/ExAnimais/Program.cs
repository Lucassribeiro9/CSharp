using System;

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
