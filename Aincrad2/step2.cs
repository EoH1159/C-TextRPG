//step 2 standard

//1. 삼항 연산자, 기본적으로 bool형태로 들어가며 
// 조건 ? 참 : 거짓 ; 의 형식을 지닌다
int playerhp = 100;
string status = (playerhp > 0) ? "생존" : "사망";
Console.WriteLine(status);

//2. 삼항 연산자 
int number = 11;

string istwo = (number % 2 == 0) ? "짝수" : "홀수";
Console.WriteLine(istwo);

//3.중첩 if , 4. 응용
string itemtype = "Weapon";
int itemlevel = 5;

if (itemtype == "Weapon")
{
    if (itemlevel >= 5)
    {
        Console.WriteLine("강화된 무기");
    }
    else
    {
        Console.WriteLine("일반 무기");
    }
}
else if (itemtype == "Armor")
{
    if (itemlevel >= 5)
    {
        Console.WriteLine("강화된 방어구");
    }
    else
    {
        Console.WriteLine("일반 방어구");
    }
}

//5.중첩 if 응용
int playerlevel = 10;
bool isQuestCompleted = true;
isQuestCompleted = (playerlevel >= 10) ? true : false ;
if (playerlevel >= 10)
{
    if (isQuestCompleted == true)
    {
        Console.WriteLine("보상을 지급합니다!");
    }
    else if (isQuestCompleted == false)
    {
        Console.WriteLine("퀘스트를 완료하세요.");
    }
}
else
{
    Console.WriteLine("레벨이 부족합니다.");
}

//6. 복합 논리 1
Console.WriteLine("레벨을 입력하세요: ");
string input = Console.ReadLine();
int level = Int32.Parse(input); //입력값을 수로 변환
Console.WriteLine("직업을 입력하세요(전사 / 마법사): ");
string job = Console.ReadLine();
if ((job == "전사" && level >= 10) || (job == "마법사" && level >= 12))
{
    Console.WriteLine("특수 던전 입장이 가능합니다.");
}

//7. 복합 논리 2
bool hasRedKey = true;
bool hasBlueKey = false;
int playerlevel2 = 15;
if(((hasRedKey == true)&&(hasBlueKey == true))||(playerlevel2>=20))
{
    Console.WriteLine("보스 방에 입장할 수 있습니다.");
}

//8. 전위 증감 응용
int x = 3;
int y = 2 + ++x;
//2에 X + 1의 값인 4를 더해 6이 나올 것이다.
//만약 후위인 x++를 더했다면 2 + 3 = 5가 나올 것이다.
Console.WriteLine(y);

//9. 중첩 if - 로그인
string id = "myid";
string password = "mypassword";
Console.WriteLine("아이디: ");
string inputid = Console.ReadLine();
Console.WriteLine("비밀번호: ");
string inputpassword = Console.ReadLine();

bool iscorrect1 = (inputid == id) ? true : false;
bool iscorrect2 = (inputpassword == password) ? true : false;
if ((iscorrect1 == true) && (iscorrect2 == true))
{
    Console.WriteLine("로그인 성공!");
}
else if ((iscorrect1 == true) && (iscorrect2 == false))
{
    Console.WriteLine("비밀번호 오류!");
}
else if ((iscorrect1 == false) && (iscorrect2 == true))
{
    Console.WriteLine("아이디 존재하지 않음!");
}
else
{
    Console.WriteLine("계정이 존재하지 않음!");
}