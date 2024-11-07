using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste Nokia");
Nokia nokia = new Nokia("+258 84 243 5404", "Lumia", "IMEI125446983", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("======================");
Console.WriteLine("Teste Iphone");
Smartphone iphone = new Iphone("+258 86 361 0601", "Iphone 13", "IMEI125446983", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
