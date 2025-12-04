using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "654321", modelo: "1100", imei: "12121212", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "456789", modelo: "XS", imei: "45454545", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");