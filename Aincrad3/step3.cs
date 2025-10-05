//step3 

//1.메서드

    static void Sayhello()
    {
        Console.WriteLine("안녕하세요");
    }


//2.
static void StartGame()
{
    Console.WriteLine("게임을 시작합니다!");
}


//3.
static void PrintLine()
{
    Console.WriteLine("====================");
}


//4.
static void DisplayMenu()
{
    Console.WriteLine("메뉴: 1. 상태 보기");
    Console.WriteLine("      2. 인벤토리");
    Console.WriteLine("      3. 상점");
}


//5.
static void GreetPerson(string name)
{
    Console.WriteLine("이름을 입력해주세요.");
    name = Console.ReadLine(); //기본적으론 name을 main에서 전달받는 게 바람직하다.
    Console.WriteLine("안녕하세요, " + name + "님!");
}


//6.
static void PrintLevel(int Level)
{
    int input = Level;
    Console.WriteLine("당신의 레벨은 " + input + "입니다.");
}


//7.
static void PrintHp(int Hp)
{
    int input = Hp;
    Console.WriteLine("현재 Hp: [" + input + "]");
}


//8.
static void MonsterAttack(string Monstername)
{
    string input2 = Monstername;
    Console.WriteLine(input2 + "이(가) 공격합니다!");
}


//9.
static void TakeDamage(int Damage)
{
    int input3 = Damage;
    Console.WriteLine("[" + input3 + "]의 데미지를 입었습니다!");
}


//10.
static void PrintItemPrice(string itemName, int Price)
{
    string input4 = itemName;
    int input5 = Price;
    Console.WriteLine("[" + input4 + "]의 가격은 [" + input5 + "] 골드 입니다.");
}


//11.
static int add(int a, int b)
{
    return a + b;
}


//12.
static int Subtract(int c, int d)
{
    return c - d;
}


//13.
static int Multiply(int e, int f)
{
    return e * f;
}


//14.
static float Divide(float g, float h)
{
    return g / h;
}


//15.
static string GetMelcomeMessage(string name2)
{
    Console.WriteLine("환영합니다, [" + name2 + "] 님");
    return name2;
}

// 가동 키
static void main()
{
    Sayhello();
    StartGame();
    PrintLine();
    PrintLine();
    PrintLine();
    DisplayMenu();
    GreetPerson("Chad");
    PrintLevel(5);
    PrintHp(80);
    MonsterAttack("고블린");
    TakeDamage(10);
    PrintItemPrice("Hp 포션", 50);
    int result = add(10, 20);
    Console.WriteLine("ab의 합: [" + result + "]");
    int remainingHp = Subtract(100, 30);
    Console.WriteLine("아야!: [" + remainingHp + "]");
    int totalDamage = Multiply(5, 10);
    Console.WriteLine("총 데미지: [" + totalDamage + "]");
    float fresult = Divide(10.0f, 4.0f);
    Console.WriteLine("결과값: [" + fresult + "]");
    GetMelcomeMessage("스파르타");
}
main();