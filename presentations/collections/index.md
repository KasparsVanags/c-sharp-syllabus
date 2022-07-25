---?color=linear-gradient(to right, #4caf50, #dbff3d)
@title[Collections]

@snap[midpoint announce-section-title text-white span-100]
Collections
@snapend
+++
@title[Lesson objective]

@snap[north]
After this lesson you will know:
@snapend

@ul[list-bullets-black](false)
- Collection types and how to operate with them: 
  - [ArrayList](https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=netframework-4.8)
  - [List<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8)
  - [SortedList<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.sortedlist?view=netframework-4.8)
  - [Stack<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=netframework-4.8)
  - [HashSet<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=netframework-4.8)
@ulend

- How to choose appropriate collection
+++
@title[Why Array is not enough?]

@snap[north span-100]
Why Array is not enough?
@snapend

@snap[midpoint span-100]
@code[java zoom-15](collections/Example1.cs)
@snapend

@snap[south span-100]
What if there will be more books?
@snapend

+++
@title[List]

@snap[north span-100]
List
@snapend

@ul[list-bullets-black](false)
- Modifiable list
- Internally implemented with arrays
- Features
  - Get/Insert items by index
  - Add/Remove items
  - Delete items
  - Loop over all items
  - GetRange/RemoveRange
@ulend

+++
@title[Array -> List]

@snap[north]
Array -> List
@snapend

@snap[midpoint]
@code[java zoom-10](collections/Example2.cs)
@snapend

+++
@title[ArrayList]

@snap[north span-100]
ArrayList
@snapend

@ul[list-bullets-black](false)
- Modifiable list
- Features
  - Get/Insert items by index
  - Add/Remove items
  - AddRange/RemoveRange items
  - Loop over all items
  - Sort
  - Reverse

@ulend

+++
@title[ArrayList]

@snap[north]
ArrayList
@snapend

@snap[midpoint]
@code[java zoom-10](collections/Example3.cs)
@snapend

+++
@title[ArrayList points to remember]

@snap[north]
points to remember
@snapend

@ul[list-bullets-black](false)
- ArrayList can store items(elements) of any datatype.
- ArrayList resizes automatically as you add the elements.
- ArrayList values must be cast to appropriate data types before using it.
- ArrayList can contain multiple null and duplicate items.
- ArrayList can be accessed using foreach or for loop or indexer.
- Use Add(), AddRange(), Remove(), RemoveRange(), Insert(), InsertRange(), Sort(), Reverse() methods.
@ulend

+++
@title[SortedList]

@snap[north span-100]
SortedList
@snapend

@ul[list-bullets-black](false)
- Modifiable list
- Internally implemented with arrays
- Features
  - Get/Insert items by index
  - Add/Remove items
  - AddRange/RemoveRange items
  - Loop over all items
  - Sort

@ulend

+++ 
@title[Note]
@snap[midpoint span-100]
Internally, SortedList maintains two object[] array, one for keys and another for values. 
So when you add key-value pair, it runs a binary search using the key to find an appropriate index to store a key and value in respective arrays. 
It re-arranges the elements when you remove the elements from it.
@snapend

+++
@title[Example]

@snap[midpoint span-100]
@code[java zoom-10](collections/Example4.cs)
@snapend

+++
@title[Points to remember]

@ul[list-bullets-black](false)
 - C# has generic and non-generic SortedList.
 - SortedList stores the key-value pairs in ascending order of the key. Key must be unique and cannot be null whereas value can be null or duplicate.
 - Non-generic SortedList stores keys and values of any data types. So values needs to be cast to appropriate data type.
 - Key-value pair can be cast to DictionaryEntry.
 - Access individual value using indexer. SortedList indexer accepts key to return value associated with it.
@ulend

+++
@title[Hashtable]

@snap[north span-100]
Hashtable
@snapend

@ul[list-bullets-black](false)
- Modifiable table
- Features
  - Add/Remove items
  - Check for existence either by key or value
  - Clear all the entries in collection
@ulend

+++
@title[Example]

@snap[midpoint span-100]
@code[java zoom-10](collections/Example5.cs)
@snapend

+++
@title[Points to remember]

@ul[list-bullets-black](false)
- Hashtable stores key-value pairs of any datatype where the Key must be unique.
- The Hashtable key cannot be null whereas the value can be null.
- Hashtable retrieves an item by comparing the hashcode of keys. So it is slower in performance than Dictionary collection.
- Hashtable uses the default hashcode provider which is object.GetHashCode(). You can also use a custom hashcode provider.
- Use DictionaryEntry with foreach statement to iterate Hashtable.
@ulend

+++
@title[Stack]

@snap[north span-100]
Stack
@snapend

@ul[list-bullets-black](false)
- stores elements in LIFO style (Last In First Out).
- Stack allows null value and also duplicate values. 
- It provides a Push() method to add a value and Pop() or Peek() methods to retrieve values.
@ulend

+++
@title[Example]

@snap[midpoint span-100]
@code[java zoom-10](collections/Example6.cs)
@snapend

+++
@title[Points to remember]

@ul[list-bullets-black](false)
- Stack stores the values in LIFO (Last in First out) style. The element which is added last will be the element to come out first.
- Use the Push() method to add elements into Stack.
- The Pop() method returns and removes elements from the top of the Stack. Calling the Pop() method on the empty Stack will throw an exception.
- The Peek() method always returns top most element in the Stack.
@ulend

+++
@title[Queue]

@snap[north span-100]
Queue
@snapend

@ul[list-bullets-black](false)
- Queue stores the elements in FIFO style (First In First Out)
- Queue collection allows multiple null and duplicate values.
- Use the Enqueue() method to add values and the Dequeue() method to retrieve the values from the Queue.
@ulend

+++
@title[Example]

@snap[midpoint span-100]
@code[java zoom-10](collections/Example7.cs)
@snapend

+++
@title[Points to remember]

@ul[list-bullets-black](false)
- The Queue stores the values in FIFO (First in First out) style. The element which is added first will come out First.
- Use the Enqueue() method to add elements into Queue
- The Dequeue() method returns and removes elements from the beginning of the Queue. Calling the Dequeue() method on an empty queue will throw an exception.
- The Peek() method always returns top most element.
@ulend

+++?image=collections/Capture.png&size=auto 75%
@title[How to choose?]

@snap[north span-100]
How to choose what's right?
@snapend

+++?color=linear-gradient(to top, #ffb347, #ffcc33)
@title[Quiz]

@snap[midpoint announce-quiz text-white]
QUIZ
@snapend

+++?color=#1E1F21
@title[Question #1]

@snap[midpoint span-100]
@code[cs zoom-07](collections/src/stack.cs)
@snapend

+++
@title[Question #2]

@snap[north span-100]
Which among the following is not the ordered collection class?
@snapend

@ol[list-bullets-black](false)
- List
- SortedList
- Queue
- Stack
- None of the mentioned
@olend

+++
@title[Question #3]

@snap[north span-100]
Which among the following is the correct way to find out the number of elements currently present in an ArrayListCollection called arr?
@snapend

@ol[list-bullets-black](false)
- arr.Capacity
- arr.Count
- arr.MaxIndex
- arr.UpperBound
@olend

+++
@title[Must read]

@snap[span-100 text-center]
*C# Programming Yellow Book*
@snapend
@ul[list-bullets-black span-100](false)
- Generics and Collections [Chapter 5.1]
@ulend

<br/>

@snap[span-100 text-center]
*C# Notes for Professionals*
@snapend
@ul[list-bullets-black span-100](false)
- An overview of C# collections [Chapter 27]
@ulend

<br/>

@snap[span-100 text-center]
*Documentation*
@snapend
@ul[list-bullets-black span-100](false)
- [Collections](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)
- [Choosing collection class](https://docs.microsoft.com/en-us/dotnet/standard/collections/selecting-a-collection-class)
@ulend
