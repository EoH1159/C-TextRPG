// Step7 basic
using System.Collections.Generic;

void main()
{
    Player player1 = new Player("전사", 100);
    player1.Attack();
    player1.TakeDamage(30);
    Monster slime = new Monster("슬라임", 1);
    slime.Displayinfo();
    Monster goblin = new Monster("고블린", 3);
    goblin.hp = 10;
    goblin.Displayinfo();
    Item potion = new Item("hp포션", 50);
    Item sword = new Item("철검", 150);
    sword.price = 200;
    potion.Displayinfo2();
    sword.Displayinfo2();
    Skill Majinken = new Skill("마신검", 50, 20);
    Skill heal = new Skill("힐", -30, 15);
    Majinken.damage = 60;
    Majinken.Activate();
    heal.Activate();
    Shop shop = new Shop();
    shop.AddItem(new Item("hp포션", 50));
    shop.AddItem(new Item("mp포션", 70));
    shop.AddItem(new Item("철검", 150));
    shop.items[0].price = 60;
    shop.dispplayItems();
}
main();

//1.
class Player
{
    public string name;
    public int hp;
    public Player(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    } //생성자추가, 초기화
    public void Attack()
    {
        Console.WriteLine($"{name}이(가) 공격합니다!");
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Console.WriteLine($"{name}이(가) {damage} 데미지를 입음 남은 hp: {hp}");
    }
}

//2.
class Monster
{
    public string name;
    public int level;
    public int hp;
    public Monster(string name, int level)
    {
        this.name = name;
        this.level = level;
        this.hp = level * 50;
    }
    public void Displayinfo()
    {
        Console.WriteLine($"이름: {name} \n레벨: {level} \nHP: {hp}");
    }
}

//3.
class Item
{
    public string name;
    public int price;
    public Item(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
    public void Displayinfo2()
    {
        Console.WriteLine($"아이템: {name} \n가격: {price}G");
    }
}

//4.
class Skill
{
    public string name;
    public int damage;
    public int mpCost;
    public Skill(string name, int damage, int mpCost)
    {
        this.name = name;
        this.damage = damage;
        this.mpCost = mpCost;
    }
    public void Activate()
    {
        Console.WriteLine($"{name} 발동 데미지: {damage} mp {mpCost}소모");
    }
}

//5.
class Shop
{
    public List<Item> items;
    public Shop() 
    { items = new List<Item>(); }
    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine($"상점에 {item.name}추가됨");
    }
    public void dispplayItems()
    {
        Console.WriteLine("--- 상점 목록 ---");
        foreach (Item item in items)
        {
            item.Displayinfo2();
        }
    }
}

//팁: 컨트롤 r을 두 번 누르면 한꺼번에 함수라던가 이름을 바꿀 수 있다.