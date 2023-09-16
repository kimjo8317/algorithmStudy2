//TODO 정수 하나를 입력 받아 , 2 부터 해당 수까지의 존재하는 모든 소수를 찾아 출력하기
//ex) 2~ 20 까지의 정수: 2,3,5,7,11,13,17,19 -> 8개
using System;

//소수에 대한 개수 구하기

    class PrimeNumberCount
    {
        static void Main()
        {
            //input
            var count = 0; //소수개수
            var sw = true; //소수 인지 확인하는 스위치변수(flag)
            var number = 0; //2 ~ number까지의 수 중 소수를 구함
            System.Console.Write("수 입력: _\b");
            number = Convert.ToInt32(Console.ReadLine());
        
            //process : 소수 -> 개수
            for (int i = 2; i < number; i++) //2부터 n까지 반복하면서 소수판별
            {
                sw = true; //일단 모든 반복마다 소수로 놓고 시작함

                //2부터 현재수(i) - 1까지 나누었을 때 나누어 떨어지면 소수가 아님
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sw = false;
                        break;
                    }                  
                }

                if (sw)
                {
                    System.Console.Write($"{i}\t"); //소수를 출력하는부분
                    count++; //카운트 알고리즘 적용

                    if (count % 5 == 0)
                    {
                        System.Console.WriteLine();//줄바꿈
                    }
                }
            }

            //output
            System.Console.WriteLine($"\n2부터 {number}까지의 소수의 개수:{count}");
        }
    }