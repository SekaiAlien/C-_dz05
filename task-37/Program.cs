// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = { 1, 2, 3, 4, 5, 6}; // { 1, 6, 72, 2, 84 };
int len = array.Length % 2;
int index = array.Length - 1;

int[] result = new int[array.Length / 2 + array.Length % 2];


if (len == 0)
{
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[i] * array[index - i];    
        Console.Write(result[i] + ", "); 
    }
}

else
{
    for (int i = 0; i < result.Length - 1; i++)
    {
        result[i] = array[i] * array[index - i];    
        Console.Write(result[i] + ", "); 
    }
    Console.Write(array[array.Length/2]);
}



//РЕШИЛА!
// вначале проверка len - четное или нет
// для четного перемножаем все числа
// для нечетного - за исключением среднего (i < result.Length - 1;)
// и просто дописываем его (Console.Write(array[array.Length/2]);)
// причем тут надо просто делить на 2 (как ребята предлагали) и не добавлять единичку,
// иначе получается следующее за средним число
// я с этим предложением /2+1 всех запутала, извините! это работало бы если бы индексация шла с 1, а не 0

// переменные newIndex и newNum - лишние
// строчка Console.WriteLine(newNum); выводила 0 - это, как поняла, остаток от деления с остатком + 1
// (в массиве с четным количеством элементов там выводится 1)
// а 5184, которое перед нулем выводилось, - умноженное на себя средее число в нечетном массиве (72*72)

// безумно интересно узнать, как вы раньше эту задачку решали, и как доделали это решение))
// Мне не нравится, что тело цикла в моем решении двоится. Стоит его заменить методом? Вот с ними я путаюсь((



// int[] array = { 1, 6, 72, 2, 84 };
// int len = array.Length % 2;
// int newIndex = 0;
// int newNum = 0;

// int index = array.Length - 1;


// int[] result = new int[array.Length / 2 + array.Length % 2];


// if (len > 0)
// {
//     newIndex = array.Length / 2 + 1;
// }


// for (int i = 0; i < result.Length; i++)
// {
//     result[i] = array[i] * array[index - i];
//     Console.WriteLine(result[i]);
//     if (newIndex == i)
//     {
//         newNum = array[i];
//     }
// }



// Console.WriteLine(newNum);