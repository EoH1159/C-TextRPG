//텍스트 RPG 만들기

using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

void Main()
{
    Player player1 = new Player(1, "크레스", "전사", 50, 0, 50, 0, 50, 100, 0);
    Intro(player1); // player1 객체를 인자로 전달
   
}
Main();
// Intro()에서 Status() 호출 시 player1 객체를 인자로 전달하도록 수정
void Intro(Player player1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    string intro = @"스파르타 마을에 오신 것을 환영합니다.
이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.";
    Console.WriteLine(intro);
    Console.ResetColor();
    Console.WriteLine("====================");

    Console.WriteLine("1. 상태 보기\n2. 인벤토리");
    bool introloop = true;
    while (introloop == true)
    {
        introloop = true;
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("상태보기를 선택했습니다.");
                introloop = false;
                Status(player1); // player1 객체 전달
                break;
            case "2":
                Console.WriteLine("인벤토리를 선택했습니다.");
                introloop = false;
                Inventory(player1); // player1 객체 전달
                break;
            default:
                Console.WriteLine("잘못된 입력입니다.");
                break;
        }
    }
}



void Status(Player player1)
{
    player1.Showinfo();
    bool infoloop = true;
    while (infoloop == true)
    {
        string zero = Console.ReadLine();
        switch (zero)
        {
            case "0":
                Console.WriteLine("돌아갑니다.");
                Console.WriteLine("====================\n ");
                infoloop = false;
                Intro(player1); // player1 객체 전달
                break;
            default:
                Console.WriteLine("잘못된 입력입니다.");
                break;
        }
    }
}
// Inventory()에 Player 객체 전달
void Inventory(Player player1)
{
    bool itemloop = true;
    Inventory inventory = new Inventory();
    Item item1 = new Item("무쇠 갑옷", "방어력", 5, "무쇠로 만들어져 튼튼한 갑옷", false);
    Item item2 = new Item("낡은 검", "공격력", 2, "쉽게 볼 수 있는 낡은 검", false);
    Item item3 = new Item("연습용 창", "공격력", 3, "쉽게 볼 수 있는 연습용 창", false);
    Item item4 = new Item("레이피어", "공격력", 4, "가볍지만 섬세한 세검", false);
    inventory.AddItems(item1);
    inventory.AddItems(item2);
    inventory.AddItems(item3);
    inventory.AddItems(item4);
    inventory.ShowInventory();
    Console.WriteLine($" \n\n1. 장착 관리\n0.나가기");
    Console.WriteLine($" \n원하시는 행동을 입력 >> ");
    while (itemloop == true)
    {
        string zerone = Console.ReadLine();
        switch (zerone)
        {
            case "0":
                Console.WriteLine("돌아갑니다.");
                Console.WriteLine("====================\n ");
                itemloop = false;
                Intro(player1); // player1 객체 전달
                break;
            case "1":
                Console.WriteLine("장착 관리를 실행합니다.");
                Console.WriteLine("====================\n ");
                Console.WriteLine($" \n\n0.나가기");
                Console.WriteLine($" \n원하시는 행동을 입력 >> ");
                Console.Clear();
                inventory.EquipManage();
                inventory.EquipManage2(player1); // player1 객체 전달
                break;
            default:
                Console.WriteLine("잘못된 입력입니다.");
                break;
        }
    }
}



    


public class Player
{
    public int level;
    public string name;
    public string job;
    public int atk;
    public int def;
    public int hp;
    public int gold;
    public int Equipatk;
    public int Equipdef;
    public int Exp;
    public Player(int level, string name, string job, int atk, int Equipatk, int def, int Equipdef, int hp, int gold, int exp)
    {
        this.level = level;
        this.name = name;
        this.job = job;
        this.atk = atk;
        this.def = def;
        this.hp = hp;
        this.gold = gold;
        this.Equipatk = Equipatk;
        this.Equipdef = Equipdef;
        this.Exp = exp;
    }

    public void Showinfo()
    {

        Console.WriteLine($"LV: {level}\n{name} ({job})\n공격력: {atk} +({Equipatk})\n방어력: {def} +({Equipdef})\n체력: {hp}\nGold: {gold}");
        Console.WriteLine($" \n0. 나가기");
        Console.WriteLine($" \n원하시는 행동을 입력 >> ");
    }
}

public class Item
{
    public string itemnames; 
    public string itemtypes ;
    public int itemint ;
    public string itemstring;
    public bool isequip;
  public Item(string name, string itemtypes, int itemint, string itemstring, bool isequip)
    {
        this.itemnames = name;
        this.itemtypes = itemtypes;
        this.itemint = itemint;
        this.itemstring = itemstring;
       this.isequip = isequip;
    }
}
public class Inventory
{
    public List<Item> Itemlist;
    public Inventory()
    {
        Itemlist = new List<Item>();
    }
    public void AddItems(Item items)
    {
        Itemlist.Add(items);
    }
    public void ShowInventory()
    {
        for (int i = 0; i < Itemlist.Count; i++)
        {
            if (Itemlist[i].isequip == true)
            {
                Console.Write("[E]");
                Console.WriteLine($"{Itemlist[i].itemnames} | {Itemlist[i].itemtypes} + {Itemlist[i].itemint} | {Itemlist[i].itemstring}");
            }
            else
            {
                Console.WriteLine($"{Itemlist[i].itemnames} | {Itemlist[i].itemtypes} + {Itemlist[i].itemint} | {Itemlist[i].itemstring}");
            }
        }
    }//인벤토리의 인덱스 값을 가져와야 한다.
    public void EquipManage()
    {


        Console.Clear();
        Console.WriteLine("장착 관리창");
        for (int i = 0; i < Itemlist.Count; i++)
        {
            Console.Write($"- {i + 1}");
            if (Itemlist[i].isequip == true)
            {
                Console.Write("[E]");
                Console.WriteLine($"{Itemlist[i].itemnames} | {Itemlist[i].itemtypes} + {Itemlist[i].itemint} | {Itemlist[i].itemstring}");
            }
            else
            {
                Console.WriteLine($"{Itemlist[i].itemnames} | {Itemlist[i].itemtypes} + {Itemlist[i].itemint} | {Itemlist[i].itemstring}");
            }
        }

    }
    // Inventory 클래스에서 Player의 Equipatk, Equipdef를 수정하려면 Player 객체에 대한 참조가 필요합니다.
    // EquipManage2 메서드에 Player 객체를 매개변수로 전달하도록 수정합니다.

    // 1. Inventory 클래스의 EquipManage2 메서드 시그니처 수정
    public void EquipManage2(Player player1)
    {
        bool equiploop = true;
        while (equiploop == true)
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("====================");
            Console.WriteLine("\n0.나가기");
            Console.WriteLine($" \n원하시는 행동을 입력 >> ");
            if (i == 0)
            {
                Console.Clear();
                Console.WriteLine("돌아갑니다.");
                Console.WriteLine("====================\n ");
                equiploop = false;
                ShowInventory();
                Console.WriteLine($" \n\n1. 장착 관리\n0.나가기");
                Console.WriteLine($" \n원하시는 행동을 입력 >> ");
                break;
            }
            else if (i > 0 && i <= Itemlist.Count && Itemlist[i - 1] != null)
            {
                if (Itemlist[i - 1].isequip == true)//장비 해제
                {
                    Itemlist[i - 1].isequip = false;
                    if (Itemlist[i - 1].itemtypes == "공격력") player1.Equipatk -= Itemlist[i - 1].itemint;
                    else if (Itemlist[i - 1].itemtypes == "방어력") player1.Equipdef -= Itemlist[i - 1].itemint;
                    EquipManage();
                    Console.WriteLine($" \n\n1. 장착 관리\n0.나가기");
                    Console.WriteLine($" \n원하시는 행동을 입력 >> ");
                }
                else //장비 장착
                {
                    Itemlist[i - 1].isequip = true;
                    if (Itemlist[i - 1].itemtypes == "공격력") player1.Equipatk += Itemlist[i - 1].itemint;
                    else if (Itemlist[i - 1].itemtypes == "방어력") player1.Equipdef += Itemlist[i - 1].itemint;
                    EquipManage();
                    Console.WriteLine($" \n\n0.나가기");
                    Console.WriteLine($" \n원하시는 행동을 입력 >> ");
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                break;
            }
        }
    }
}

