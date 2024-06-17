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


    public GameObject QuestionObj;
    public GameObject ResultObj;

    public Text Result;

    private bool[] CheckedAnswers = new bool[15];
    private bool[] CorrectCheckedAnswers = new bool[15];

    private int Question = 0;
    private string DisplayedNumber = "1";
    private string[] Question_list = { "Where do we use C#?","What year does created first C# version?","How many bool data type takes?", "What variable type stores variable addreses?","What data type is used for numbers?","Where is program pointers stored in RAM memory?", "What happens if the RAM(stack) is overflows?", "What is main unity object?","Unity object for transformation(with additional info)?","Unity object for creating triggers?","What object is used for unity UI elements?","Variable that used for storing large int numbers?","What variable(x,y,z) changes UI object height?" , "Unity object that stores audio.", "Unity object for visualizing elements?"};
    private string[,] Question_anwers = new string[15, 4] { { "GameDev", "Drivers", "WEB", "Cybersecurity" }, { "2004","2001","2000","1996"},{ "1 bit","1 byte","2 bit","4 bytes" },{ "int","string","pointer","char"},{ "string","int","byte","bool"},{" variables memory","static memory","function memory","pointer memory" },{"StackOverflow error","Stack extends","Deleting first stack element","Nothing" },{ "Text","Image","Transform","GameObject"},{"Transform","Trans","Rect Transform","RTransform"},{"Image","Collider","Panel","BoxCollider" },{"Panel","Audio","Video","Canva" },{"long","int","char","ulong" },{"x","y","z","Y"},{"Image","Button","Audio","AudioSource" },{"Canva","Camera","EventHandler","Display"} };



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
                if (toggle1.GetComponent<Toggle>().isOn && toggle3.GetComponent<Toggle>().isOn && toggle2.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 1:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 2:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn  && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 3:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn == false && toggle3.GetComponent<Toggle>().isOn  && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 4:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn && toggle3.GetComponent<Toggle>().isOn && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 5:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 6:
                if (toggle1.GetComponent<Toggle>().isOn && toggle2.GetComponent<Toggle>().isOn == false && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 7:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn == false && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn)
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
            case 8:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn == false && toggle3.GetComponent<Toggle>().isOn && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 9:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn)
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
            case 10:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn == false && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn)
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
            case 11:
                if (toggle1.GetComponent<Toggle>().isOn && toggle2.GetComponent<Toggle>().isOn == false && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn)
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
            case 12:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn == false)
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
            case 13:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn == false && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn)
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
            case 14:
                if (toggle1.GetComponent<Toggle>().isOn == false && toggle2.GetComponent<Toggle>().isOn && toggle3.GetComponent<Toggle>().isOn == false && toggle4.GetComponent<Toggle>().isOn == false)
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
        int AnsCheck = 0;
        for(int i = 0; i <= 14; i++)
        {
            if(CheckedAnswers[i] == true)
            {
                AnsCheck++;
            }
        }

        if (Question == 14 && AnsCheck == 15 || AnsCheck == 15)
        {
            QuestionObj.SetActive(false);
            int CorrectCounter = 0;
            for(int i = 0;i <= 14; i++)
            {
                if(CorrectCheckedAnswers[i] == true)
                {
                    CorrectCounter++;
                }
            }
            Result.text = "You have "+ CorrectCounter+ " out of 15 correct answers!";
            ResultObj.SetActive(true);

        }
        else
        {
            Debug.Log("Question not 15/ " + Question);
        }
    }



}
