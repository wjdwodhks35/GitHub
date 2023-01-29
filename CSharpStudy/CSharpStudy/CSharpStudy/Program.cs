using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
	class Program
	{
		static void Main(string[] args)
		{
            //1 장
            ////WriteLine 사용법
            //System.Console.WriteLine("안녕하세요!");
            ////Write 사용법
            //System.Console.Write("저의 이름은 정재완 입니다.");
            //System.Console.WriteLine("저는 18살 입니다.");
            //System.Console.Write("저는 현재 남동구에 살고 있습니다.");
            //System.Console.WriteLine("저의 성별은 남자 입니다.");
            //System.Console.Write("저는 고등학생입니다.");
            //System.Console.WriteLine("저는 인제고등학교에 다니고 있습니다.");
            //System.Console.Write("현재 방학중에 있으며 내일부터 학교에 다시 나갑니다.");
            //System.Console.WriteLine("쓸만 한게 없네요.");
            //System.Console.Write("마지막줄 끝~");
            //string - 데이터 형
            //string myName;
            //myName = "제 이름은 정재완 입니다.";
            //System.Console.WriteLine(myName);
            //string myAge = "제 나이는 18살 입니다.";
            //System.Console.WriteLine(myAge);
            //string mySchool = "제 학교는 인제고등학교입니다.";
            //System.Console.WriteLine(mySchool);
            //string myGender = "저는 남성 입니다.";
            //System.Console.WriteLine(myGender);
            //string myName;
            //string myAge;
            //string myAdress;
            //string myGender;

            //System.Console.Write("이름을 입력해 주세요 :");
            //myName = System.Console.ReadLine();

            //System.Console.Write("나이를 입력해주세요 :");
            //myAge = System.Console.ReadLine();

            //System.Console.Write("주소를 입력해주세요 :");
            //myAdress = System.Console.ReadLine();

            //System.Console.Write("성별을 입력해주세요 :");
            //myGender = System.Console.ReadLine();

            //System.Console.Write("당신의 이름은 : ");
            //System.Console.WriteLine(myName);

            //System.Console.Write("당신의 나이는 :");
            //System.Console.WriteLine(myAge);

            //System.Console.Write("당신의 주소는 :");
            //System.Console.WriteLine(myAdress);

            //System.Console.Write("당신의 성별은 :");
            //System.Console.WriteLine(myGender);

            //System.Console.WriteLine($"당신의 이름은 {myName} 이고, 당신의 나이는 {myAge} 입니다.");
            //System.Console.WriteLine("당신의 이름은 {0} 이고, 당신의 나이는 {1} 입니다.", myName, myAge);

            //2장
            //int myAge = 18;
            //string myName = "정재완";
            //float Today = 1.29f;
            //string kk = null;

            //System.Console.WriteLine(int.MaxValue);
            //System.Console.WriteLine(int.MinValue);

            //System.Console.WriteLine("강사님이 말했다. \"안녕하세요\"라고")
            //System.Console.Write(myName);

            //string mm = myName + myAge;
            //System.Console.WriteLine(mm);

            //string myAge;
            //System.Console.Write("당신의 나이를 입력해주세요 :");
            //myAge = System.Console.ReadLine();

            //int myAgeNumber = Convert.ToInt32(myAge);

            //string nowAge = (2024 - myAgeNumber).ToString();
            //System.Console.WriteLine("태어난 년도는 {0} 입니다",nowAge);

            //            System.Console.WriteLine(@"@를 적으면
            //이렇게 나온다.");
            //            System.Console.WriteLine(@"
            //    @
            //   @@@
            //  @@@@@
            // @@@@@@@
            //@@@@@@@@@");
            //1. 변수형 종류 주석으로 작성후, 각 변수형들의 최대값 최소값 출력하기
            //int
            //		System.Console.WriteLine(int.MaxValue);
            //		System.Console.WriteLine(int.MinValue);
            //		//float
            //		System.Console.WriteLine(float.MaxValue);
            //		System.Console.WriteLine(float.MinValue);
            //		//char
            //		System.Console.WriteLine(char.MaxValue);
            //		System.Console.WriteLine(char.MinValue);

            //		//2. string으로 이름 나이 입력 받고, 출력하기
            //		//나이는 출생년도만 입력받기
            //		string myName;
            //		string myAge;

            //		System.Console.Write("이름 입력 : ");
            //		myName = System.Console.ReadLine();
            //		System.Console.Write("출생년도 : ");
            //		myAge = System.Console.ReadLine();
            //		int myCurAge = Convert.ToInt32(myAge);
            //		myCurAge = 2023 - myCurAge;

            //		System.Console.WriteLine("당신의 이름은 {0}이고, 당신의 나이는 {1}입니다.", myName, myCurAge);
            //		//3.@사용 해서 별 그리기
            //		System.Console.WriteLine(@"
            //     * 
            //   *****
            //*********** 
            //  *******
            // ***   ***
            //*         *  ");

            //		//4. int 값을 float 로 캐스팅하기
            //		//float값(3.12)를 int값으로 캐스팅하기
            //		int a = 0;
            //		float b = a;
            //		System.Console.WriteLine("{0} {1}",a, b);
            //		float c = 3.12f;
            //		int d = Convert.ToInt32(c);
            //		System.Console.WriteLine("{0} {1}",c, d);

            //이름을 입력받는다(실패)
            //입력받은 이름의 길이를 숫자로 바꾸고
            //받은 숫자를 출력한다.
            //string myName;
            //int myNameInt, i;
            //char[] a = new char[100];
            //System.Console.Write("이름을 입력하세요 :");
            //myName = System.Console.ReadLine();
            //a = myName.ToCharArray();
            //for (i = 0; a[i] != '\0'; i++) { }
            //myNameInt = i;
            //System.Console.Write("이름의 길이는 {0} 입니다.", myNameInt);

            //int[] n1 = new int[5] { 0, 1, 2, 3, 4 };
            //int[] n2 = new int[5] { 0, 1, 2, 3, 4 };
            //int[] n3 = new int[5] { 0, 1, 2, 3, 4 };
            //int[] n4 = new int[5] { 0, 1, 2, 3, 4 };
            //int[] n5 = new int[5] { 0, 1, 2, 3, 4 };
            //string[] str1 = new string[5] { "zero", "one", "two", "three", "forth"};
            //string[] str2 = new string[5] { "zero", "one", "two", "three", "forth" };
            //string[] str3 = new string[5] { "zero", "one", "two", "three", "forth" };
            //string[] str4 = new string[5] { "zero", "one", "two", "three", "forth" };
            //string[] str5 = new string[5] { "zero", "one", "two", "three", "forth" };

            //int[] LaterArray;
            //string ArraySize;

            //System.Console.WriteLine("배열의 크기는?");
            //ArraySize = System.Console.ReadLine();

            //LaterArray = new int[Convert.ToInt32(ArraySize)];

            //string[] _lang = new string[3];
            //_lang[0] = "c";
            //_lang[1] = "c++";
            //_lang[2] = "c#";

            //System.Console.WriteLine($"0번 값은 {_lang[0]}입니다.");
            //_lang[0] = "아무거나";

            // System.Console.WriteLine($"0번 값은 {_lang[0]}입니다.");

            //int n = 0;
            //string str;
            //string[] Food = new string[4] {"떡볶이","김밥","라면","라뽁이"};
            //System.Console.Write("1.떡볶이 2.김밥 3.라면 4.라뽁이가 있다. 먹고 싶은 음식의 번호 :");
            //str = System.Console.ReadLine();
            //n = Convert.ToInt32(str);
            //if(n>0&&n<5)
            //{
            //    n -= 1;
            //    Food[n] = "비어 있다.";
            //    System.Console.WriteLine("비어 있게 되었습니다.");
            //    System.Console.WriteLine("1.{0} 2.{1} 3.{2} 4.{3}",Food[0], Food[1], Food[2], Food[3]);
            //}
        }
	}
}
