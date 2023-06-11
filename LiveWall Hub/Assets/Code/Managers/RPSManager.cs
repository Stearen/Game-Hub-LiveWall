using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RPSManager : MonoBehaviour
{
    public TextMeshProUGUI Result;
    public Image AIChoice;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors, Question;

    public GameObject WinPage;
    public GameObject RPSGame;

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case "Rock":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "It's a Tie, try again!";
                        break;

                    case "Paper":
                        WinPage.SetActive(true);
                        RPSGame.SetActive(false);
                        PointManager.AddPoints(200);
                        AIChoice.sprite = Question;
                        Result.text = "Result";


                        break;

                    case "Scissors":
                        Result.text = "You Lose, try again!";

                        break;
                }

                AIChoice.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "You Lose, try again!";

                        break;

                    case "Paper":
                        Result.text = "It's a Tie, try again!";
                        break;

                    case "Scissors":
                        WinPage.SetActive(true);
                        RPSGame.SetActive(false);
                        PointManager.AddPoints(200);
                        AIChoice.sprite = Question;
                        Result.text = "Result";

                        break;
                }

                AIChoice.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        WinPage.SetActive(true);
                        RPSGame.SetActive(false);
                        PointManager.AddPoints(200);
                        AIChoice.sprite = Question;
                        Result.text = "Result";

                        break;

                    case "Paper":
                        Result.text = "You Lose, try again!";
                        break;

                    case "Scissors":
                        Result.text = "It's a tie, try again!";

                        break;
                }

                AIChoice.sprite = Scissors;
                break;



        }


    }



}
