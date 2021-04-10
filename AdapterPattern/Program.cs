using System;


/// <summary>
/// 
/// Adapter Pattern
/// : 기계, 가구 등을 다목적으로 사용하기 위한 부가 기구
/// 
/// 요구 사항
/// 두 수에 대한 다음 연산을 수행하는 객체를 만드세요
/// - 수의 두 배의 수를 반환 : twiceOf(Float) : Float
/// - 수의 반(1/2)의 수를 반환 : halfOf(Float):Float
/// 구현 개첵 이름은 'Adapter' 으로 해주세요
/// Math 클래스에서 두 배와 절반을 구하는 함수는 이미 구현되어있습니다.
/// 
/// https://www.youtube.com/watch?v=gJDZ7pcvlAU&list=PLsoscMhnRc7pPsRHmgN4M8tqUdWZzkpxY&index=3
/// </summary>

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        // public
    }

    public class Math
    {
        //두배
        public static double twoTime(double num) => num * 2;
        //half
        public static double half(double num) => num / 2;

        public static Double doubled(Double d) => d * 2;

    }
}
