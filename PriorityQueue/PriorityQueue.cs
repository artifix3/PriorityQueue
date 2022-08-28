//Creatubg Priority Queue

using Xunit;

PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();


//Adding Items to Queue 
priorityQueue.Enqueue("Apple", 4);
priorityQueue.Enqueue("Banana", 3);
priorityQueue.Enqueue("Orange", 1);
priorityQueue.Enqueue("Strawberry", 5);
priorityQueue.Enqueue("Grape", 0);
priorityQueue.Enqueue("Pineapple", 6);
priorityQueue.Enqueue("Peach",7);

// if you use dequeue our items will be removed from our priority queue
while(priorityQueue.TryDequeue(out string item , out int priority))
{
    Console.WriteLine($"Fruit Name : {item} Priority : {priority} ");
}

Console.WriteLine("------------------------ After using Dequeu  -----------------------------");
Console.WriteLine($"Priority Queue size = {priorityQueue.Count}");
//Let's add our items again 


//Adding Items to Queue 
priorityQueue.Enqueue("Apple", 4);
priorityQueue.Enqueue("Banana", 3);
priorityQueue.Enqueue("Orange", 1);
priorityQueue.Enqueue("Strawberry", 5);
priorityQueue.Enqueue("Grape", 0);
priorityQueue.Enqueue("Pineapple", 6);
priorityQueue.Enqueue("Peach", 7);
Console.WriteLine("------------------------ After adding items  -----------------------------");
Console.WriteLine($"Priority Queue size = {priorityQueue.Count}");


Console.WriteLine($"Using Peek method---------> {priorityQueue.Peek()}");

Console.WriteLine($"Priority Queue size = {priorityQueue.Count}");



Console.WriteLine($"GetType method - --------------> {priorityQueue.GetType()}");
Console.WriteLine($"GetHashCode method - --------------> {priorityQueue.GetHashCode()}");

priorityQueue.Clear();

Console.WriteLine($"Priority Queue size = {priorityQueue.Count}");



