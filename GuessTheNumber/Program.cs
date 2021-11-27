/*Консольная игра "Угадай число"

Комп загадал число в некотором диапазоне, например от 1 до 100. Далее он предлагает игроку угадать это число. 
Игрок вводит некоторое число и комп "отвечает":

1. правильное ли это число или
2. Загаданное число больше чем введенное
3. загаданное число меньше чем введенное. После этого игрок делает следующую догадку. 
    У Игрока есть некоторое количество попыток.

Если игрок потратил все свои попытки, то игра заканчивается. 
Если игрок угадал число, но попытки еще остались, игра также заканчивается.

1. Определить условия. (какой диапазон для загадывания чисел - мы его задаем, формируем рандомно или запрашиваем у пользователя?; определиться с количеством попыток - высчитать необходимое количество попыток, либо запросить у участника)
2. Загадать число в указанном диапазоне.
3. Начало игры - описываем правила.
4. Запрашиваем у пользователя число. Пользователь вводит некоторое число (добавить проверку нештатных ситуаций). 
   Определяем как оно соотносится с нашим загаданным и даем следующие инструкции игроку. 
   Если пользователь не угадал, то у него сгорает 1 попытка.
5. Игра продолжается пока есть попытки или пока пользователь не угадал число.

int requestNumber() - метод запросит у игрока число, сделает все необходимые преобразования и вернет нам это число. 
int createNumber(int leftBound, int rightBound) - загадает число в указанном диапазоне и вернет его нам. 
bool MakeMove(int SecretNumber, int CountOfAttempts) - метод, в котором запрограммирован 1 игровой ход, 
  в результате метод возвращает либо true, либо false. 
true если пользователь угадал число и игру надо остановить, false, если пользователь не угадал.

int SecretNumber = createNumber(1, 100); int PlayersNumber = requestNumber();*/

//Мое решение
/*int createNumber(int leftBound, int rightBound)
{
    int res;
    res=new Random().Next(leftBound,rightBound);
    return res;
}

void FindNumber(int SecretNumber)
 {
        int k=7;
        while (k>0)
        {
            Console.WriteLine("Введите число: ");
            int PlayersNumber = Convert.ToInt32(Console.ReadLine());  

                if (SecretNumber > PlayersNumber)
                {
                    Console.WriteLine("Недолет. Попыток осталось: " + $"{k-1}");
                }
                else if (SecretNumber < PlayersNumber)
                {
                    Console.WriteLine("Перелет. Попыток осталось: " + $"{k-1}");
                }

                else if (SecretNumber == PlayersNumber)
                {
                    Console.WriteLine("УРА! Вы выиграли!"); 
                    Console.ReadKey(); 
                }
                 k = k-1;
        }
       Console.WriteLine("Жаль, вы проиграли"); 
       Console.ReadKey(); 
}

int leftBound = 1;
int rightBound = 99;
int SecretNumber = createNumber(leftBound,rightBound);
Console.WriteLine("Нужно угадать число от " + $"{leftBound}" + " до " + $"{rightBound}");
FindNumber(SecretNumber);*/

// Примеры методов для решения задачи с практикума
int RequestNumber(string message) 
{
    Console.WriteLine(message);
    string line = Console.ReadLine();
    return Convert.ToInt32(line);
}

int CreateSecretNumber(int leftBound, int rightBound) {
    return new Random().Next(leftBound, rightBound);
}

bool MakeMove(int secretNumber, int countOfAttempts) 
{
    int playersNumber = RequestNumber("У вас осталось " + countOfAttempts + " попыток. " + "Введите число: ");
    if (playersNumber == secretNumber) 
    {
        return true;
    }
    if (playersNumber > secretNumber) 
    {
        Console.WriteLine("Ваше число больше того, которое мы загадали");
    } else 
    {
        Console.WriteLine("Ваше число меньше того, которое мы загадали");
    }
    return false;

}

int leftBound = 0;
int rightBound = 100;
int countOfAttempts = 7;
int secretNumber = CreateSecretNumber(leftBound, rightBound);
// int number = RequestNumber("Введите число: ");
Console.WriteLine(secretNumber);