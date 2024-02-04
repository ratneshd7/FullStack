using System;

class TOH
{
    // Recursive function to solve Tower of Hanoi
    static void Hanoi(int n, char source, char target, char auxiliary)
    {
        // Base case: if there's only one disk, move it from source to target
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {source} to {target}");
            return;
        }

        // Move (n-1) disks from source to auxiliary using target as the auxiliary
        Hanoi(n - 1, source, auxiliary, target);

        // Move the nth disk from source to target
        Console.WriteLine($"Move disk {n} from {source} to {target}");

        // Move the (n-1) disks from auxiliary to target using source as the auxiliary
        Hanoi(n - 1, auxiliary, target, source);
    }

    static void Main()
    {
        int numberOfDisks = 3;
        char sourceRod = 'A';
        char targetRod = 'C';
        char auxiliaryRod = 'B';

        Console.WriteLine($"Solving Tower of Hanoi with {numberOfDisks} disks.");
        Hanoi(numberOfDisks, sourceRod, targetRod, auxiliaryRod);
    }
}

