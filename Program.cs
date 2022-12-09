//Task 1
// void isPalindrom(string num){

//     if(num.Length != 5){
//         Console.WriteLine("Число должно быть пятизначным");
//         return;
//     }
//     if(num[0] == num[4] && num[1] == num[3]){
//         Console.WriteLine("Да");
//     }else{
//         Console.WriteLine("Нет");
//     }
// }

//Task 2
void distance(double[] dot1, double[] dot2){
    double distance = Math.Sqrt((Math.Pow(dot1[0] - dot2[0], 2)) + (Math.Pow(dot1[1] - dot2[1], 2)) + (Math.Pow(dot1[2] - dot2[2], 2)));
    Console.WriteLine($"Дистанция между точками = {Math.Round(distance, 2)}");
}

//Task 3
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
// Console.Write("Введите  число : ");
// string num = Console.ReadLine();
// isPalindrom(num);


//Task 2
Console.Write("Введите первую точку (x, y, z) : ");
double[] dot1 = new double[3];
for(int i = 0; i < dot1.Length; i++){
    Console.Write($"Введите {i + 1}  координату : ");
    dot1[i] =  Convert.ToDouble(Console.ReadLine());
}
Console.Write("Введите вторую точку (x, y, z) : ");
double[] dot2 = new double[3];
for(int i = 0; i < dot2.Length; i++){
    Console.Write($"Введите {i + 1}  координату : ");
    dot2[i] =  Convert.ToDouble(Console.ReadLine());
}
distance(dot1, dot2);

//Task 3
// Console.Write("Введите  число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// square(num);
