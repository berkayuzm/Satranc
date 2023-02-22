// See https://aka.ms/new-console-template for more information
using Satranc_oyunu;
//Satranç tahtasını çizdirmek için GameManager nesnesi oluşturuyoruz.
GameManager gm = new GameManager();
Console.WriteLine("input your file path");
var path = Console.ReadLine(); //Dosya okuma işlemi
gm.ReadBoard(path);

