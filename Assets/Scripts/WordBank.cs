using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using System.Linq;

public class WordBank : MonoBehaviour
{
    [SerializeField] UnityEngine.TextAsset WordBankTXT;
    private List<string> originalWords = new List<string>();
    private List<string> workingWords = new List<string>();

    private void Awake()
    {
        ReadWordBank();
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConvertToLower(workingWords);
    }

    private void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }

    private void ConvertToLower(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string GetWord()
    {
        if (workingWords.Count == 0)
        {
            ResetWorkingWords();
        }

        if (workingWords.Count > 0)
        {
            string newWord = workingWords.Last();
            workingWords.RemoveAt(workingWords.Count - 1);
            return newWord;
        }

        return string.Empty;
    }

    private void ResetWorkingWords()
    {
        workingWords.Clear();
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConvertToLower(workingWords);
    }

    void ReadWordBank()
    {
        string[] lines = WordBankTXT.text.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);

        foreach (string line in lines)
        {
            originalWords.Add(line.Trim());
        }
    }
}
