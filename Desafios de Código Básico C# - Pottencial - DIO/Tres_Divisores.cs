using System;
 
class Solution {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
 
        for (int i = 1; i <= n; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (n % i == 0) 
            {
                count++;
            }
            if (count >  3 ) 
            {
                Console.WriteLine(false);
            }
        }
         Console.WriteLine(count == 3);
    }
}
