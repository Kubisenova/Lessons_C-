Console.Clear();
// // Console.SetCursorPosition(10, 4); // (x, y)
// // Console.WriteLine("+");

// введём обзначения 
int firstSpeedFriend = 1;
int secondSpeedFriend = 2;
int dogSpeed = 5;
int distans = 100;
int friend = 2;
int count = 0;

// // Найдём скрость сближения двух друзей

// int SpeedOfApproach = secondSpeedFriend - firstSpeedFriend;
// Console.WriteLine("Скорость сближения двух друзей =  " + SpeedOfApproach + " м/с");

// //  Найдём время через которое два друга втстретятся 

// int time = distans / SpeedOfApproach;
// Console.WriteLine("Время через которое два друга встретятся =  " + time + " сек");

// //  Теперь найдём расстояние, которое пробежала собака 

// int dogS = dogSpeed * time;
// Console.WriteLine("Растояние, которое пробежала собака =  " + dogS + " м");

// // Теперь найдём сколько именно раз пробежала раз 

// int resultDog = dogS / time;
// Console.WriteLine("Это сколько раз пробежала собака между друзьями =  " + resultDog + " раз");



// Найдём скрость сближения двух друзей

int SpeedOfApproach = secondSpeedFriend - firstSpeedFriend;
Console.WriteLine("Скорость сближения двух друзей =  " + SpeedOfApproach + " м/с");

//  Найдём время через которое два друга втстретятся 

int time = distans / SpeedOfApproach;
Console.WriteLine("Время через которое два друга встретятся =  " + time + " сек");

//  Теперь найдём расстояние, которое пробежала собака 

int dogS = dogSpeed * time;
Console.WriteLine("Растояние, которое пробежала собака =  " + dogS + " м");

// Теперь найдём сколько именно раз пробежала раз 

while (distans == 100)
{
    if (firstSpeedFriend == 1)
    {
        distans = dogS - (SpeedOfApproach * time);
    }
    
    if (secondSpeedFriend == 2)
    {
        distans = dogS - (SpeedOfApproach * time);
    }


    Console.WriteLine("Это сколько раз пробежала собака между друзьями = " + distans);
    count++;
}