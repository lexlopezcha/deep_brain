using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIController : MonoBehaviour
{
    public GameObject HomePageButton;
    public GameObject MainGameButtonOptionsButton;
    public GameObject NewGameButtonOptionsButton;
    public GameObject RiddleGameButton;
    public GameObject ScapeRoomGameButton;

    private bool isInGame;
    private CanvasGroup HomePageCG;
    private CanvasGroup MainGameOptionsCG;
    enum Status
    {
        HomePage, MainGameButtonOptions, NewGameButtonOptions, RiddleGame, ScapeRoomGame

    };
    private Status stat;

    void Start()
    {
        HomePageCG = HomePageButton.GetComponent<CanvasGroup>();
        MainGameOptionsCG = MainGameButtonOptionsButton.GetComponent<CanvasGroup>();

        stat = Status.HomePage;
    }
    void Update()
    {
        Status currentStat;
        currentStat = MainControlStatus(stat);
        // Debug.Log("Current Status " + currentStat);

    }
    Status MainControlStatus(Status stat)
    {
        switch (stat)
        {
            case Status.HomePage:

                HomePageCG.alpha = 1f;
                HomePageCG.blocksRaycasts = true;

                MainGameOptionsCG.alpha = 0f;
                MainGameOptionsCG.blocksRaycasts = false;

                if (isInGame)
                {
                    HomePageCG.alpha = 0f;
                    HomePageCG.blocksRaycasts = false;

                    MainGameOptionsCG.alpha = 1f;
                    MainGameOptionsCG.blocksRaycasts = true;

                    stat = Status.MainGameButtonOptions;

                }

                break;
            case Status.MainGameButtonOptions:

                break;
            case Status.NewGameButtonOptions:
                break;
            case Status.RiddleGame:
                break;
            case Status.ScapeRoomGame:
                break;

        }

        return stat;

    }

    public void GameButtonClicked()
    {
        isInGame = true;
    }

}
