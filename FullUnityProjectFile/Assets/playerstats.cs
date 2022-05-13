using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
public class playerstats : MonoBehaviour
{
    public float hp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (hp <= 0){
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
       }

    }
}
