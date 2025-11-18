using System;
using System.Text;
public class Score
{
    private int[] _scores = new int[5];
    private string[] _subjects = { 
        "Математика", "Физика", "Русский", "Информатика", "История"
    };
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < 5) return _scores[index];
            return 0;
        }
        set
        {
            if (index >= 0 && index < 5) _scores[index] = value;
        }
    }
    public Score()
    {
        for (int i = 0; i < _scores.Length; i++)
            _scores[i] = 0;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < _scores.Length; i++)
            sb.Append($"{_subjects[i]}: {_scores[i]}\n");
        return sb.ToString();
    }
}
