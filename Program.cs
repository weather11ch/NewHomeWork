// See https://aka.ms/new-console-template for more information
var messages  = new List<string>();

for  (int i = 0; i < 2; i++)
{
    messages.Add(Console.ReadLine());
    
}

foreach  (var message in messages)
{ Console.WriteLine(message); }

var words = new Dictionary<string, string>()
{
    { "кот","cat"},
    { "собака","dog"},
    { "стол","table"},
    { "солнце","sun"},
    { "облако","cloud"}
};

while (true)
{
    string word = Console.ReadLine();
    bool result = words.TryGetValue(word, out var value);
    if (result)
    { Console.WriteLine(value); }
    else { Console.WriteLine("нет такого слова"); }

}

