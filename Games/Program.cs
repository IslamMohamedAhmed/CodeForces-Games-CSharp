using static System.Console;
using static System.Convert;
using static System.Math;


int n,counter1 = 0;
int[] team1 = new int[35];
int[] team2 = new int[35];


n = ToInt32(ReadLine());


for(int i = 0; i < n; i++)
{
    string str = ReadLine();
    var arr = str.Split(" ");
    team1[i] = ToInt32(arr[0]);
    team2[i] = ToInt32(arr[1]);
    
   
}

for(int j = 0; j < n; j++)
{
  for(int k = 0; k < n; k++)
    {
        if (team1[j] == team2[k])
        {
            counter1++;
        }
    }
}

WriteLine(counter1);










