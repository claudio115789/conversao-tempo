using System;

namespace conversao_tempo
{
    class Conversao
    {
        static void Main(string[] args)
        {
          
      int entrada = Int32.Parse(Console.ReadLine());

    int horasRestantes = entrada % 86400;
    int minutosRestantes = horasRestantes % 3600;

    int horas = entrada / 3600;
    int minutos = (entrada%3600) / 60;
    int segundos =minutosRestantes % 60;

    Console.Write(horas + ":" + minutos + ":" + segundos);
    }
  }
}

       
