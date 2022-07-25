SortedList sortedList = new SortedList()
                            {
                                {3, "Three"},
                                {4, "Four"},
                                {1, "One"},
                                {5, "Five"},
                                {2, "Two"}
                            };
for (int i = 0; i < sortedList.Count; i++)
{
    Console.WriteLine("key: {0}, value: {1}", 
        sortedList.GetKey(i), sortedList.GetByIndex(i));
}