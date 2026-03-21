public class Scripture
{
    //Atributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    //Constructors
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word neword=new Word(word);
            _words.Add(neword);
        }
    }
    //Methods
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i=0; i < numberToHide; i++)
        {
            int index = random.Next(0, _words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}