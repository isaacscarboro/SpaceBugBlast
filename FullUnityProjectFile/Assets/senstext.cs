using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class senstext : MonoBehaviour
{
  
    
    void Update(){
        
        this.gameObject.GetComponent<Text>().text = PlayerPrefs.GetFloat("sens").ToString();
        
    }

}
