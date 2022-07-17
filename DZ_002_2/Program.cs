// Массивы и функции в программировании

Console.WriteLine("Задача № 13");
void hasThirdNumber(int x) {
    int div = 1;
    while ( x / div >= 10) {
        div *= 10;
    }
    if (div < 100) {
        Console.WriteLine("Меньшее число");
    } else {
        //last number of x / (div/100)    123456
        int digit = (x / (div/100))  % 10;
        Console.WriteLine("Third is {0}", digit);      
    }
}

 hasThirdNumber(645);
 hasThirdNumber(78);
 hasThirdNumber(32679);