using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsChangeScript : MonoBehaviour
{
    public GameObject Buttons;
    public Text Number;
    public Text QuestionDes;

    
    private int Question = 0;
    private string[] Question_list = { };
    private bool[] submited = new bool[15];

    private void Start()
    {
        for(int i = 0; i < 15; i++)
        {
            submited[i] = false;
        }
        Number.text = (Question+1).ToString();
    }



}
