using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startgameint : MonoBehaviour
{
    public int screen = 1;
    public GameObject main;
    public GameObject leaderboard;
    public GameObject settings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        
        switch(screen){
            case 1:
            main.SetActive(true);
            leaderboard.SetActive(false);
            settings.SetActive(false);
            break;
            case 2:
            main.SetActive(false);
            leaderboard.SetActive(true);
            settings.SetActive(false);
            break;
            case 3:
            main.SetActive(false);
            leaderboard.SetActive(false);
            settings.SetActive(true);
            break;
            default:
            main.SetActive(true);
            leaderboard.SetActive(false);
            settings.SetActive(false);
            break;
        }


    }
}
