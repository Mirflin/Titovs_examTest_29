using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;
    public Toggle toggle4;

    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    public Button Button6;
    public Button Button7;
    public Button Button8;
    public Button Button9;
    public Button Button10;
    public Button Button11;
    public Button Button12;
    public Button Button13;
    public Button Button14;
    public Button Button15;

    public Button nextB;

    private bool[] CheckedAnswers = new bool[15];
    private bool[] CorrectCheckedAnswers = new bool[15];

    private int Question = 0;
    private string DisplayedNumber = "1";
    private string[] Question_list = { "Where do we use C#?","What year does C# released?","How many bool data type takes?", "What variable type stores variable addreses?","What data type is used for numbers?","Where is pointers stored in RAM memory?","What is main unity object?"};
    private string[,] Question_anwers = new string[7, 4] { { "GameDev", "Drivers", "WEB", "Cybersecurity" }, { "2004","2001","2000","1996"},{ "1 bit","1 byte","2 bit","4 bytes" },{ "int","string","pointer","char"},{ "string","int","byte","bool"},{" variables memory","static memory","function memory","pointer memory" },{ "Text","Image","Transform","GameObject"} };

    private void Start()
    {
       
        

    }

    public void ButtonClicked(int number)
    {
        DisplayedNumber = number.ToString();
        Question = number;
        GameObject child = Buttons.transform.GetChild(Question).gameObject;
        QuestionDes.text = (string) Question_list[Question];
        Number.text = (Question+1).ToString();
        Choose1.text = Question_anwers[Question,0];
        Choose2.text = Question_anwers[Question,1];
        Choose3.text = Question_anwers[Question,2];
        Choose4.text = Question_anwers[Question,3];
        toggle1.isOn = false;
        toggle2.isOn = false;
        toggle3.isOn = false;
        toggle4.isOn = false;
    }

    public void NextButton()
    {
        
        var colors = nextB.GetComponent<Button>().colors;
        colors.normalColor = Color.green;
        colors.highlightedColor = Color.green;
        colors.pressedColor = Color.green;
        colors.selectedColor = Color.green;
        colors.disabledColor = Color.green;
        GameObject child = Buttons.transform.GetChild(Question).gameObject;
        child.GetComponent<Button>().colors = colors;


        switch (Question)
        {
            case 0:
                if (toggle2.GetComponent<Toggle>().isOn && toggle1.GetComponent<Toggle>().isOn == false && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn == false)
                {
                    Debug.Log(true);
                    CorrectCheckedAnswers[Question] = true;
                }
                else
                {
                    Debug.Log(false);
                    CorrectCheckedAnswers[Question] = false;
                }
                break;
        }
        CheckedAnswers[Question] = true;
        Submit();
        Question += 1;
        ButtonClicked(Question);
    }

    public void Submit()
    {
        if (Question == 13)
        {
            SceneManager.LoadScene("ResultsScene", LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("Question not 15/ " + Question);
        }
    }



}
