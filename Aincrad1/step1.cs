//C# 반복학습 step1
//베이직
int playerhp = 100; //1.정수 선언
string playername = "내 이름"; //2.문자열 내 이름 
bool isplayeralive = true; //3.불리언 변수, 참과 거짓만 가능
float movespeed = 3.5f; //4.실수 선언. 소숫점 표기가 가능
long worldpopulation = 7000000000L; //5.int를 64비트로 
byte potioncount = 20; //6.int를 8비트로
double pi = 3.1415926535; //7.float를 8비트로
string monstername = "슬라임";
Console.WriteLine(monstername); //8.문자열 출력
int a = 500;
Console.WriteLine(a); //9.500출력
string camelCase = "낡은 검"; //낡은 검 할당
Console.WriteLine(camelCase);// 혹시 몰라 넣었다
//생각 1. byte다. 1부터 99까지인데다 -가 없는 레벨 특성 상
//양도 더 적고 충분히 표현 가능한 byte가 이득이다.
byte playerlevel = 1;

//생각 2. byte는 0에서 255까지 표현 가능하기에, 1에서 적었듯
//그 이하의 수는 표현 가능하나 그 이상은 데이터가 너무 많아 
//표기하지 못 한다.

//생각 3. 앞의 문제와 비슷한 이유다. int또한 약 21억까지의 
//숫자까지밖에 기억 목 한다.

//생각 4. int를 쓰면 이게 불러내는건 어디까지나 정수다.
//그러므로 실수의 영역인 소숫점이 싹 날아간다.
//손실을 피하려면 실수 지정인 float를 쓰자.

//생각 5. bool = true. 다른 변수들이 존재하는 int와 string과는
//다르게, bool은 보스인지 아닌지에 대한 것만 
//참, 거짓으로 나타내기 때문이다.

