using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class youmadeittofloor : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.GetComponent<Text>().text = "You made it to Floor# "+PlayerPrefs.GetFloat("last floor").ToString();
    }
}
