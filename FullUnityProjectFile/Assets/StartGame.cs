using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    void Start(){
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    
    public void go()
    {
        SceneManager.LoadScene("FPS TEst", LoadSceneMode.Single);
    }
}