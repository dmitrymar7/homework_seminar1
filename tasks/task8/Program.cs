Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int start = 1;

while (Math.Abs(start) <= Math.Abs(a)){
    if (start % 2 == 0){
        Console.WriteLine(start);    
    }

    if (a > 0) start++;
    else start--;
     
}