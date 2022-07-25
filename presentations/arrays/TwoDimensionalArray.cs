int t, i;
int[,] table = new int[3, 4];
for (t = 0; t< 3; ++t) {
    for (i = 0; i< 4; ++i) {
        table[t, i] = (t* 4) + i + 1;
        Console.Write(table[t, i] + " ");
    }
    Console.WriteLine();
}
/*
    1 2 3 4 
    5 6 7 8 
    9 10 11 12
*/