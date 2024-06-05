using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsChangeScript : MonoBehaviour
{
    public GameObject Buttons;
    public Text Number;
    public Text QuestionDes;
    public Text Choose1;
    public Text Choose2;
    public Text Choose3;
    public Text Choose4;
    public Button Next;

    private int Question = 1;
    private string DisplayedNumber = "1";
    private string[] Question_list = { "quest1","quest2"};
    private string[,] Question_anwers = new string[2, 4] { { "1", "2", "3", "4" }, { "da","net","danet","netda"} };

    private void Start()
    {
        Number.text = Question.ToString();
    }

    public void ButtonClicked(int number)
    {
        Question = number-1;
        DisplayedNumber = number.ToString();
        GameObject child = Buttons.transform.GetChild(Question).gameObject;
        QuestionDes.text = (string) Question_list[Question];
        Number.text = (Question+1).ToString();
        Choose1.text = Question_anwers[Question,0];
        Choose2.text = Question_anwers[Question,1];
        Choose3.text = Question_anwers[Question,2];
        Choose4.text = Question_anwers[Question,3];
    }

    public void NextButton()
    {
        Question += 1;
        ButtonClicked(Question);
    }



}
