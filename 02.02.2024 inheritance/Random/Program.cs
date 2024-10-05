using Random;

RandomList randomList = new RandomList();

// Добавяне на елементи към списъка
randomList.Add("Елемент 1");
randomList.Add("Елемент 2");
randomList.Add("Елемент 3");

try
{
    // Вземане и премахване на случаен елемент като string
    string randomString = randomList.RandomString();
    Console.WriteLine($"Случаен елемент: {randomString}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}