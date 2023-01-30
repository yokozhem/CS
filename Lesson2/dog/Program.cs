// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int count, friend1Speed, friend2Speed, dogSpeed, friend;
double time, distance;
count=0;
distance=10000;
friend1Speed=1;
friend2Speed=2;
dogSpeed=5;
friend=2;
time=distance/(friend2Speed+dogSpeed);

while(distance>10)
{
    if(friend==1){
        time=distance/(friend2Speed+dogSpeed);
        friend=1;
    }
    distance=distance-(friend1Speed+friend2Speed)*time;
    count++;

}
System.Console.WriteLine(count);
