using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia  = new Nokia(numero: "978650043", modelo:"Nokia k9", iMEI:"435785", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "978660043", modelo: "Iphone 17 Pro Max", iMEI: "789324", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");