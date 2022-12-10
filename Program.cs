//Task 1
// void isPalindrom(int num){

//     if(num < 10000 ){
//         Console.WriteLine("Число должно быть пятизначным");
//         return;
//     }
//     if((num % 10 == num / 10000 % 10) && (num / 1000 % 10 == num / 10 % 10)){
//         Console.WriteLine("Да");
//     }else{
//         Console.WriteLine("Нет");
//     }
// }

//Task 2
// void distance(int x1, int y1, int z1, int x2, int y2, int z2){

//     double distance = Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)) + (Math.Pow(z1 - z2, 2)));
//     Console.WriteLine($"Дистанция между точками = {Math.Round(distance, 2)}");
// }

// Task 3
void square(int num){
    for(int i = 1; i <= num; i++){
        if(i == num){
            Console.Write($"{Math.Pow(i,3)} ");    
        }else{
            Console.Write($"{Math.Pow(i,3)}, ");
        }
    }
}



//Task1 
// Console.WriteLine("Введите  число : ");
// int num =Convert.ToInt32(Console.ReadLine());
// isPalindrom(num);

//Task 2
// Console.WriteLine("Введите первую точку : ");
// Console.WriteLine(" x : ");
// int x1 =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" y : ");
// int y1 =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" z : ");
// int z1 =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую точку : ");
// Console.WriteLine(" x : ");
// int x2 =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" y : ");
// int y2 =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" z : ");
// int z2 =Convert.ToInt32(Console.ReadLine());
// distance(x1, y1, z1, x2, y2, z2);

//Task 3
Console.WriteLine("Введите  число : ");
int num =Convert.ToInt32(Console.ReadLine());
square(num);