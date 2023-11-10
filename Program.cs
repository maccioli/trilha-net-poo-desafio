using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111122222", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Waze");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4321", modelo: "Modelo 2", imei: "3333122222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Linkedin");

