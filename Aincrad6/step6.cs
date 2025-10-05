// step6 공통

//1.
int[] score = new int[5];
    score[0] = 100;
    score[2] = 80;
    if (score[0] ==100)
{
    Console.WriteLine("만점입니다!");
}
Console.WriteLine(score[0] + score[2]);

//2.
string[] items = {"철검", "가죽 갑옷", "Hp포션"};
string item = items[2];
int count = items.Length;
Console.WriteLine(item);
Console.WriteLine(count);
for (int i = 0; i < items.Length ; i++)
{
    Console.WriteLine(items[i]);
}

//3.
string[] monsternames = new string[3];
monsternames[0] = "슬라임";
monsternames[1] = "골렘";
monsternames[2] = "킬러 머신";
for (int i = 0;i < monsternames.Length ; i++)
{
    Console.WriteLine($"{i}번 몬스터 : {monsternames[i]}");
}
Console.WriteLine("====================");
foreach (string monstername in monsternames)
{ Console.WriteLine(monstername); }

//4.
int[] data = { 5, 12, 3, 8, 10 };
for (int i = 0; i < data.Length ; i++)
{
    if(data[i] > 10)
    {
        Console.WriteLine(data[i]);
    }
}
Console.WriteLine("====================");
for (int i = 0; i < data.Length; i++)
{
    if (data[i] % 2 == 0)
    {
        Console.WriteLine(data[i]);
    }
}
Console.WriteLine("====================");
int sum = 0;
for (int i = 0; i < data.Length; i++)
{
  sum += data[i];
}
Console.WriteLine(sum);
Console.WriteLine("====================");
foreach (int datas in data)
{
    if (datas > 5)
    {
        Console.WriteLine(datas);
    }
}
Console.WriteLine("====================");

//5.
List<string> inventory = new List<string>();
inventory.Add("검");
inventory.Add("방패");
inventory.Add("포션");
int count2 = inventory.Count;
Console.WriteLine(count2);
string item2 = inventory[0];
Console.WriteLine(item2);
inventory[1] = "강철 방패";
inventory.Remove("포션");
inventory.RemoveAt(0);
int count3 = inventory.Count;
Console.WriteLine(count3);
bool hasShield = inventory.Contains("강철 방패");
Console.WriteLine(hasShield);
bool hasSword = inventory.Contains("검");
Console.WriteLine(hasSword);
inventory.Clear();
int count4 = inventory.Count;
Console.WriteLine(count4);
static void PrintInventory(List<string>inv)
{
    foreach (string item2 in inv)
        { Console.WriteLine(item2); }
}

//기동 키
void main()
{
    inventory.Add("검");
    inventory.Add("방패");
    inventory.Add("포션");
    PrintInventory(inventory);
}
main();