using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endmenu : MonoBehaviour
{
public int menu = 1;
public GameObject imput;
public GameObject normal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(menu){
            case 1:
            normal.SetActive(true);
            imput.SetActive(false);
            break;
            case 2:
            normal.SetActive(false);
            imput.SetActive(true);
            break;
            default:
            normal.SetActive(false);
            imput.SetActive(true);
            break;

        }
    }
}
