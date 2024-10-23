using Memento;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        Caretaker caretaker = new Caretaker(editor);

        editor.Type("Hello ");
        caretaker.Save();

        editor.Type("World!");
        caretaker.Save();

        editor.Type(" How are you?");
        Console.WriteLine($"Current Text: {editor.GetText()}"); 

        caretaker.Undo(); 
        Console.WriteLine($"After Undo: {editor.GetText()}"); 

        caretaker.Undo();
        Console.WriteLine($"After Another Undo: {editor.GetText()}");
    }
}