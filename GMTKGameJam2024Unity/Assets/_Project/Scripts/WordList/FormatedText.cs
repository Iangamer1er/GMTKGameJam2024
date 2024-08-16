using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Text", menuName = "TextObject")]
public class FormatedText : ScriptableObject{
    public TextAsset wordList;
    public List<string> words = new();
}