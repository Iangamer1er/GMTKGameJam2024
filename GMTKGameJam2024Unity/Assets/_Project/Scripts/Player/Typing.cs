using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class Typing : MonoBehaviour
{
    [SerializeField] FormatedText text;
    [SerializeField] string testString = "A";
    [SerializeField] TextMeshProUGUI textMeshPro;
    string textInput = "";

    private void Start() {
        Debug.Log(text.words[50]);
        Debug.Log(CheckList(text.words, testString));
    }

    private void Update() {
        string input = Input.inputString;
        if(input.Equals("")) return;
        char C = input[0];
        if(C == "\b"[0]){
            if(textInput.Length != 0) textInput = textInput.Substring(0, textInput.Length - 1);
        }else if (C == "\n"[0] || C == "\r"[0]){
            if(CheckList(text.words, textInput)) WordExists();
        } else{
            textInput += C;
        }
        UpdateTMPVisual();
    }

    private void UpdateTMPVisual() => textMeshPro.text = textInput; 

    private void WordExists(){
        Debug.Log("Word exists");
    }

    private void WordnotExists(){
        textInput = "";
        //TODO handle timer
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
