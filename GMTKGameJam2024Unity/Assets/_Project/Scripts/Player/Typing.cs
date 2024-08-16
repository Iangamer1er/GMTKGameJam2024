using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Typing : MonoBehaviour
{
    [SerializeField] FormatedText text;

    private void Start() {
        // Debug.Log(text.words[0]);
    }

    [ContextMenu("Format")]
    public void FormatList(){
        text.words = new List<string>(text.wordList.text.Split('\n'));
    }
}
