using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Typing : MonoBehaviour
{
    [SerializeField] FormatedText text;
    [SerializeField] string testString = "A";

    private void Start() {
        Debug.Log(text.words[50]);
        Debug.Log(CheckList(text.words, testString));
    }

    private bool CheckList(List<string> list, string word)
    {
        return list.Any(e => e.ToLower().Contains(word.ToLower()));
    }

    [ContextMenu("Format")]
    public void FormatList(){
        text.words = new List<string>(text.wordList.text.Split('\n'));
    }
}
