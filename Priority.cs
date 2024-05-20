using System.Runtime.InteropServices.JavaScript;

namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue and Dequeue with different priority
        // Expected Result: Items are stored in the queue sorted by their priority, with the lowest priority items come first.
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Apple", 1);
        priorityQueue.Enqueue("Banana", 2);
        priorityQueue.Enqueue("Milk",3);
        
        
        Console.WriteLine(priorityQueue);
        
        // Defect(s) Found:  Items Not Sorted by Priority on Enqueue

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue and Dequeue with same priority
        // Expected Result: Items are stored in a queue sorted by priority, and if the priority is the same, the items entered first are displayed first
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Apple", 1);
        priorityQueue2.Enqueue("Banana", 2);
        priorityQueue2.Enqueue("Milk",1);
        
        Console.WriteLine(priorityQueue2);
        
        // Defect(s) Found: none

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}