using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone7 = new Iphone("1199999999", "7", "xpto", 8);
iphone7.Ligar();
iphone7.ReceberLigacao();
iphone7.InstalarAplicativo("X");


Smartphone nokia = new Nokia(numero: "1188888888", modelo: "NK015", iMEI: "wkrv", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");