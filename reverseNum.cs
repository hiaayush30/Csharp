int number = 123450;
int num = number;

int reversedNumber = 0;

int length = 0;

while (num > 0)
{
    length++;
    num /= 10;
}

num = number;

for (int i = 0; i < length; i++)
{
    reversedNumber *= 10;
    int digit = num % 10;  //take last digit
    reversedNumber += digit; //append it to reveresed number
    num /= 10;
}

Console.WriteLine(reversedNumber);

int var1 = 5;
int var2 = 20;

if (var1 > 10 || var2 > 10 && !(var1 > 10 && var2 > 10))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}