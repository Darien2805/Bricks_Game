using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // public variables
    public Text scoreText ;
    public GameOverScreen GameOverScreen;
    //public BrickSpawner BrickSpawner;

    // private variables
    float playerSpeed = 5f;
    //bool flag = true;
    public static bool flag = true;
    
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (flag == true ){
            score ++;
            scoreText.text = "Score: " + score.ToString();

            float xupdate = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
            transform.Translate(xupdate , 0, 0);

        } else
        {
            return;
        }
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Brick")
        {
            //Reload scene when ball hit brick
            //StartCoroutine(Reload());
            flag = false;
            GameOverScreen.Setup(score);
            //BrickSpawner.flagB = false;
        }
    }

    // IEnumerator Reload()
    // {
    //     yield return new WaitForSeconds(0.2f);
    //     SceneManager.LoadScene("SampleScene");
    // }
}
