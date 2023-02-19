using LuckySistem.Consol;
using LuckySistem.Consol.Entities;

var SelectionManager = new SelectionManager();

SelectionManager.AddAttendee("Ayfer Yıldırım");
SelectionManager.AddAttendee("Aybike Boran");
SelectionManager.AddAttendee("Öznur Fidan");
SelectionManager.AddAttendee("Merve Albayrak");
SelectionManager.AddAttendee("Dilara Demirhan");

int luckyCount = 3;

SelectionManager.MakeSelection(luckyCount);

var luckiestOnes = SelectionManager.GetTheLuckyOnes();

luckiestOnes.ForEach(x => Console.WriteLine(x.FullName)); //luckiestOnes içerisine atılan her bir değeri consola yaz.

Console.ReadLine();
