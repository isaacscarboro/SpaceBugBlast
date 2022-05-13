using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pStats : MonoBehaviour
{
    public float health = 100f;
    public float maxhealth = 100f;
    public float armor = 0f;
    public float damage = 100f;
    public Transform healthBar;
    public GameObject hpTextObj;
    public Transform healthBarEmpty;
    public GameObject scoreTextObj;
    public GameObject gameStageTextObj;
    public Text hpText;
    public Text scoreText;
    public Text gameStageText;
    public float gameStage = 1;
    public float score = 0;
    public bool damaged; 
    public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        hpText = hpTextObj.GetComponent<Text>();
        scoreText = scoreTextObj.GetComponent<Text>();
        gameStageText = gameStageTextObj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
         if(this.transform.position.y <= -100){
            this.health = 0;
        }
    if(health <= 0){
        PlayerPrefs.SetFloat("last score", score);
        PlayerPrefs.SetFloat("last floor", gameStage);
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
    }
    if (damaged){
        sound.SetActive(true);
    damaged = false;
    }
    healthBar.localScale = new Vector3((health / 100f), .3f, 1);
    healthBarEmpty.localScale = new Vector3((maxhealth / 100f), .3f, 1);
    hpText.text = ("HP: "+ health+ " / "+ maxhealth);
    scoreText.text = ("Score: "+ score);
    gameStageText.text = ("Floor# "+ gameStage);
    
    }
    public void addScore(float toAdd){
        score = score + toAdd;
    }
    
    
}
