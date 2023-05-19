﻿// Задача 1. Задача с собакой и друзьями 
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

Console.Clear();

// введём обзначения 
int firstSpeedFriend = 1;
int secondSpeedFriend = 2;
int dogSpeed = 5;
int distans = 100;
int friend = 2;
int count = 0;


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


    Console.WriteLine("Собака пробежала между друзьями = " + distans + " раз");
    count++;
}