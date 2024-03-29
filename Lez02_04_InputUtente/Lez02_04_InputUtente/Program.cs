﻿using System.Linq.Expressions;

namespace Lez02_04_InputUtente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inserisci il tuo nominativo:");
            //string? input = Console.ReadLine();
            //Console.WriteLine($"Il tuo nome è {input}");

            Console.WriteLine("Inserisci la tua età");
            string? inputUtente = Console.ReadLine();
            try
            { 
                int valoreConvertito = Convert.ToInt32(inputUtente);

                if (valoreConvertito >= 18)
                    Console.WriteLine("Maggiorenne");
                else
                    Console.WriteLine("Minorenne");
            } catch(FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }    catch (Exception ex)
            {
                Console.WriteLine($"Errore generico");
            } finally
            {
                Console.WriteLine("Programma terminato");
            }


        }
    }
}
