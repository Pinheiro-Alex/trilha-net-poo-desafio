using DesafioPOO.Models;

namespace DesafioPOO.Models 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia: ");
            Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo K", imei: "121111111", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatSapp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone: ");
            Smartphone iphone = new Iphone(numero: "789456", modelo: "K9", imei: "455454455", memoria: 120);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}


