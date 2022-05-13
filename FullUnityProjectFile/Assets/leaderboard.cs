using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class leaderboard : MonoBehaviour
{
    public int place;
    // Start is called before the first frame update
    void Start()
    {
        switch(place){
            case 1:
            if(PlayerPrefs.HasKey("first")){
this.gameObject.GetComponent<Text>().text = "First = " + PlayerPrefs.GetString("first");
        }break;
            case 2:
            if(PlayerPrefs.HasKey("second")){
this.gameObject.GetComponent<Text>().text = "Second = " +PlayerPrefs.GetString("second");
        }
        break;
         case 3:
            if(PlayerPrefs.HasKey("third")){
                this.gameObject.GetComponent<Text>().text = "Third = " +PlayerPrefs.GetString("third");
        }
        break;
    default:
    break;
        }
    
    }

    // Update is called once per frame
    void Update()
    {
           {
        switch(place){
            case 1:
            if(PlayerPrefs.HasKey("first")){
this.gameObject.GetComponent<Text>().text = "First = " + PlayerPrefs.GetString("first");
        }break;
            case 2:
            if(PlayerPrefs.HasKey("second")){
this.gameObject.GetComponent<Text>().text = "Second = " +PlayerPrefs.GetString("second");
        }
        break;
         case 3:
            if(PlayerPrefs.HasKey("third")){
                this.gameObject.GetComponent<Text>().text = "Third = " +PlayerPrefs.GetString("third");
        }
        break;
    default:
    break;
        }
    
    }
    }
}
