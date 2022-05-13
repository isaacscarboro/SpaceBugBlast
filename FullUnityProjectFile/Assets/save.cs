using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class save : MonoBehaviour
{
    public GameObject controler;
    public GameObject controler2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void go(){
        if(PlayerPrefs.HasKey("firstfloat")){
            if(PlayerPrefs.GetFloat("firstfloat") <PlayerPrefs.GetFloat("last score")){
                PlayerPrefs.SetString("third", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("second").ToString()) ;
                PlayerPrefs.SetFloat("thirdfloat", PlayerPrefs.GetFloat("secondfloat"));
                PlayerPrefs.SetString("second", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("first").ToString()) ;
                PlayerPrefs.SetFloat("secondfloat", PlayerPrefs.GetFloat("firstfloat"));
                PlayerPrefs.SetString("first", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("last score").ToString()) ;
                PlayerPrefs.SetFloat("firstfloat", PlayerPrefs.GetFloat("last score"));
            }




            else if(PlayerPrefs.HasKey("secondfloat")){if(PlayerPrefs.GetFloat("secondfloat") <PlayerPrefs.GetFloat("last score")){
                 PlayerPrefs.SetString("third", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("second").ToString()) ;
                PlayerPrefs.SetFloat("thirdfloat", PlayerPrefs.GetFloat("secondfloat"));
                PlayerPrefs.SetString("second", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("last score").ToString()) ;
                PlayerPrefs.SetFloat("secondfloat", PlayerPrefs.GetFloat("last score"));
                }else if(PlayerPrefs.HasKey("thirdfloat")){if(PlayerPrefs.GetFloat("firstfloat") <PlayerPrefs.GetFloat("last score")){
                PlayerPrefs.SetString("third", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("last score").ToString()) ;
                PlayerPrefs.SetFloat("thirdfloat", PlayerPrefs.GetFloat("last score"));
                }
                    if(PlayerPrefs.GetFloat("last score") > PlayerPrefs.GetFloat("firstfloat")){
                         PlayerPrefs.SetString("first", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("last score").ToString()) ;
                        PlayerPrefs.SetFloat("firstfloat", PlayerPrefs.GetFloat("last score"));
                    }else if(PlayerPrefs.GetFloat("last score") > PlayerPrefs.GetFloat("secondfloat")){
                         PlayerPrefs.SetString("second", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text +" "+PlayerPrefs.GetFloat("last score").ToString()) ;
                    PlayerPrefs.SetFloat("secondfloat", PlayerPrefs.GetFloat("last score"));
                    }else if(PlayerPrefs.GetFloat("last score") > PlayerPrefs.GetFloat("thirdfloat")){
PlayerPrefs.SetFloat("thirdfloat", PlayerPrefs.GetFloat("last score"));
 PlayerPrefs.SetString("third", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("last score").ToString()) ;
                    }



            }else{PlayerPrefs.SetFloat("thirdfloat", PlayerPrefs.GetFloat("last score"));
             PlayerPrefs.SetString("third", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text +" "+PlayerPrefs.GetFloat("last score").ToString());
             }
            }else{PlayerPrefs.SetFloat("secondfloat", PlayerPrefs.GetFloat("last score"));
             PlayerPrefs.SetString("second", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text + " "+PlayerPrefs.GetFloat("last score").ToString()) ;
             }
        }else{PlayerPrefs.SetFloat("firstfloat", PlayerPrefs.GetFloat("last score"));
         PlayerPrefs.SetString("first", this.gameObject.transform.GetChild(1).gameObject.GetComponent<InputField>().text +" "+PlayerPrefs.GetFloat("last score").ToString());}

       
        
        
        PlayerPrefs.Save();
        controler.GetComponent<endmenu>().menu = 1;

    }
}
