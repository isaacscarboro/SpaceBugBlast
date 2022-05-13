using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapons : MonoBehaviour
{
    public GameObject shotgun;
    public GameObject pistol;
    public GameObject bat;
    public int currentweapon;

    // Start is called before the first frame update
    void Start()
    {
        currentweapon = Random.Range(0,3);
        swap_weapon(currentweapon);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.F1)){
            swap_weapon(1);
        }
         if(Input.GetKeyDown(KeyCode.F2)){
            swap_weapon(2);
        }
         if(Input.GetKeyDown(KeyCode.F3)){
            swap_weapon(3);
        }
        if(Input.GetKeyDown(KeyCode.F4)){
            GameObject.FindGameObjectsWithTag("player")[0].GetComponent<pStats>().gameStage += 1;
        }
    }
    public int swap_weapon(int swapTwo){
        switch(swapTwo){
            case 0:
            shotgun.SetActive(false);
            pistol.SetActive(true);
            bat.SetActive(false);
            break;
            case 1:
            shotgun.SetActive(true);
            pistol.SetActive(false);
            bat.SetActive(false);
            break;
            case 2:
            shotgun.SetActive(false);
            pistol.SetActive(false);
            bat.SetActive(true);
            break;
            
            default:
            shotgun.SetActive(false);
            pistol.SetActive(true);
            bat.SetActive(false);
            break;
        

        }
    int oldweapon = currentweapon;
    currentweapon = swapTwo;
    return oldweapon;
    }
}
