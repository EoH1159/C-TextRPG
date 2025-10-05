// step4 basic

//1.
for (int a =1; a < 11; a++)
{
    Console.WriteLine(a);
}

//2.
static void PrintLine()
{
    Console.WriteLine("====================");
}
for (int b = 0; b < 5; b++)
{
    PrintLine();
}

//3.
for (int c = 10; c >0; c--)
{
    Console.WriteLine(c);
}

//4.
for (int a = 0; a < 11; a += 2 )
{

        Console.WriteLine(a);
}
Console.WriteLine("====================");

//5.
int sum = 0;
for (int d = 0; d < 11; d++)
{
    sum += d;
}
Console.WriteLine(sum);

//6.
static void GreetRepeat(int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("안녕하세요.");
    }  
}

//7.
for (int i = 0; i < 20; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("====================");

//8.
int e = 1;
while (e <= 10)
{
    Console.WriteLine(e);
    e++;
}

//9.
int f = 10;
while (f >= 1)
{
    Console.WriteLine(f);
    f--;
}
Console.WriteLine("====================");

//10.
int sum2 = 0;
int g = 1;
while (g <= 10)
{
    sum2 += g;
    g++;
}
Console.WriteLine(sum2);

//11.
int h = 1;
while (h <= 20)
{
    if ((h % 2) == 0)
    {
        Console.WriteLine(h);
    }
    h++;
}

//12.
string password = "1234";
string input = "";
while (input != password)
{
    Console.WriteLine("비밀번호를 입력하세요: ");
    input = Console.ReadLine();
}
if (input == password)
{
    Console.WriteLine("로그인 성공!");
}
Console.WriteLine("====================");

//13.
while (true)
{
    Console.WriteLine("숫자를 입력하세요 (0 = 종료): ");
    int number = int.Parse(Console.ReadLine());
    if (number == 0)
    {
        Console.WriteLine("종료합니다.");
        break;
    }
    else if (number % 2 == 0)
    {
        Console.WriteLine("짝수");
    }
    else
    {
        Console.WriteLine("홀수");
    }
}

//14.
for (int j= 1; j <=100; j++)
{
    if (j ==5)
    {
        Console.WriteLine(j);
        break;
    }
}

//15.
for (int k= 1; k <=10; k++)
{
    if (k %2 !=0)
    {
        continue;
    }
    Console.WriteLine(k);
}
Console.WriteLine("====================");

//16.
int l = 1;
while(true)
{
    Console.WriteLine(l);
    l++;
    if (l > 5)
    {
        break;
    }
}

//17.
while(true)
{
    Console.WriteLine("명령어 입력(exit 입력 시 종료):");
    string input3 = Console.ReadLine();
    if (input3 == "exit")
    {
        break;
    }
}

//18.
int m = 0;
while(m < 20)
{
    m++;
    if (m % 3 !=0)
    {
        continue;
    }
    Console.WriteLine(m);
}
Console.WriteLine("====================");

//19.
for (int n = 1; n <= 100; n++)
{
    if (n %7 ==0)
    {
        Console.WriteLine(n); 
        break;
    }
}

//20.
while(true)
{
    Console.WriteLine("비밀번호 (1234): ");
    string input4 = Console.ReadLine();
    if (input4 == "1234")
    {
        Console.WriteLine("로그인 성공!");
        break;
    }
    else
    {
        Console.WriteLine("비밀번호 오류!");
    }
}

//main 기동 키
static void main()
{
    Console.WriteLine("====================");
    GreetRepeat(3);
}
main();