// Задача 1. Задача с собакой и друзьями 
// Условие 
// Два друга движутся 
// навстречу с заданной скоростью. 
// Скорость первого — 1 м/с, второго — 2 м/с. 
// У них есть собака, которая бегает со скоростью 5 м/с. 
// Когда друзья начинают свой путь, собака бежит от одного друга 
// к другому, добегает, разворачивается и тут же бежит обратно. 
// Сколько раз собака перебежит от одного друга к другому, 
// пока они не встретятся? Введение в программирование | 
// Лекция 1 Решить с конкретными числами Решить в общем виде


// Решение 1: 

// Console.Clear();

// // введём обзначения 
// int firstSpeedFriend = 1;
// int secondSpeedFriend = 2;
// int dogSpeed = 5;
// int distans = 100;
// int friend = 2;
// int count = 0;

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




// Решение 2 

// Console.Clear();

// // введём обзначения 
// int firstSpeedFriend = 1;
// int secondSpeedFriend = 2;
// int dogSpeed = 5;
// int distans = 1000;
// int friend = 2;
// int count = 0;


// // Найдём скрость сближения двух друзей

// int SpeedOfApproach = secondSpeedFriend - firstSpeedFriend;
// Console.WriteLine("Скорость сближения двух друзей =  " + SpeedOfApproach + " м/с");

// //  Найдём время через которое два друга втстретятся 

// int time = distans / SpeedOfApproach;
// Console.WriteLine("Время через которое два друга встретятся =  " + time + " сек");

// //  Теперь найдём расстояние, которое пробежала собака 

// int dogS = dogSpeed * time;
// Console.WriteLine("Растояние, которое пробежала собака =  " + dogS + " м");

// // Теперь найдём сколько именно раз пробежала собака

// while (distans == 1000)
// {
//     if (friend == 1)
//     {
//         distans = distans - (SpeedOfApproach * time);

//     }
//     count++;
//     if (friend == 2)
//     {
//         distans = distans - (SpeedOfApproach * time);
//     }

//     count++;

//     Console.WriteLine("Собака пробежала между друзьями = " + count + " раз");

// }



// // Решение 3

// Console.Clear();

// int firstSpeedFriend = 1;
// int secondSpeedFriend = 2;
// int dogSpeed = 5;
// int distans = 100;
// int friend = 2;
// int count = 0;

// while (distans < 10)
// {
//     if (friend == 1)

//     {
//         int time2 = distans / (secondSpeedFriend + dogSpeed);
//         distans = distans - (secondSpeedFriend + dogSpeed) * time2;
//         count++;
//     }

//     if (friend == 2)
//     {
//         int time1 = distans / (firstSpeedFriend + dogSpeed);
//         distans = distans - (firstSpeedFriend + dogSpeed) * time1;
//         count++;
//     }
//     count++;

//     Console.WriteLine("Собака пробежала между друзьями = " + count + " раз");
// }


// // Решение 4 (1 часть моя, а вторая часть преподавателя Констанина)

// Console.Clear();

// int firstSpeedFriend = 1;
// int secondSpeedFriend = 2;
// int dogSpeed = 5;
// int distans = 100;
// int friend = 2;
// int count = 0;

// // Время первого друга
// int time1Friend = distans / firstSpeedFriend;
// // Время второго друга 
// int time2Friend = distans / secondSpeedFriend;

// // Растояние первого друга до собаки
// int dis1Friend = firstSpeedFriend * time1Friend;
// // Растояние второго друга до собаки
// int dis2Friend = secondSpeedFriend * time2Friend;

// while (distans < 10)
// {
//     if (friend == 1)
//     {
//         distans = distans - (dis1Friend / dogSpeed);
//         count++;
//     }

//     if (friend == 2)
//     {
//         distans = distans - (dis2Friend / dogSpeed);
//         count++;
//     }

//     count++;
//     Console.WriteLine("Собака пробежала между друзьями = " + count + " раз");

// }

//  задаче с собакой и друзьями я вижу такое решение 
// (детали могут быть неверными, основано на 4 способе)

// // Продолжаем пока дистанция больше нуля (пока друзья не подошли друг к другу)
// while (distans > 0)
// {
//     if (friend == 1)
//     {
//         distans = distans - (dis1Friend / dogSpeed);
//         // убираем count++, потому что увеличиваем его 
//         // один раз в самом конце цикла while

//         // обозначаем, что собака бежит к другому другу
//         friend = 2;
//     }

//     if (friend == 2)
//     {
//         distans = distans - (dis2Friend / dogSpeed);
//         // убираем count++, потому что увеличиваем его один раз в самом конце цикла while

//         // обозначаем, что собака бежит к другому другу
//         friend = 1;
//     }
//     count++;
// }
// // вывод в консоль происходит уже после цикла и после всех подсчётов
// Console.WriteLine("Собака пробежала между друзьями = " + count + " раз");








// Решение 4 
//  (1 часть моя, а вторая часть преподавателя Констанина) 
//  - оформление нормальное

Console.Clear();

int firstSpeedFriend = 1;
int secondSpeedFriend = 2;
int dogSpeed = 5;
int distans = 10000;
int friend = 2;
int count = 0;

int time1Friend = distans / firstSpeedFriend;
int time2Friend = distans / secondSpeedFriend;
int dis1Friend = firstSpeedFriend * time1Friend;
int dis2Friend = secondSpeedFriend * time2Friend;

while (distans > 0)
{
    if (friend == 1)
    {
        distans = distans - (dis1Friend / dogSpeed);
        // friend = 2;
    }
    if (friend == 2)
    {
        distans = distans - (dis2Friend / dogSpeed);
        // friend = 1;
    }
    count++;
}
Console.WriteLine("Собака пробежала между друзьями = " + count + " раз");

