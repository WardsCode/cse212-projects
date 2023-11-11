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
        // Scenario: I add 4 people to the Q and then dequeue 1 according to their priority
        // Expected Result: Retreive the one that is highest priority and then the next one
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Wards", 1);
        priorityQueue.Enqueue("Seth", 3);
        priorityQueue.Enqueue("Matt", 5);
        priorityQueue.Enqueue("Ethan", 2);
        Console.WriteLine(priorityQueue);
        for (int i = 0; i < 4 ; i++ ){
        Console.WriteLine("Next in turn for priority is " + priorityQueue.Dequeue());
        }
        // Defect(s) Found: it does not dequeue

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: it will arrange fifo on equal priority
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Wards", 5);
        priorityQueue.Enqueue("Seth", 3);
        priorityQueue.Enqueue("Matt", 5);
        priorityQueue.Enqueue("Ethan", 2);
        Console.WriteLine(priorityQueue);
        for (int i = 0; i < 4 ; i++ ){
        Console.WriteLine("Next in turn for priority is " + priorityQueue.Dequeue());
        }

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}