using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool collideStone = false;
    public bool collidePresent = false;
    public bool collideTree = false;
    public int points = 0;
    public GameObject RudiObjekt;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI timeText;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Stone"))
        {
            Destroy(collision.gameObject);
            collideStone = true;
            points--;
            scoreDisplay.text = points.ToString();
        }

        if (collision.name.Contains("Tree"))
        {
            Destroy(collision.gameObject);
            collideTree = true;
            points--;
            scoreDisplay.text = points.ToString();
        }

        if (collision.name.Contains("Present"))
        {
            Destroy(collision.gameObject);
            collidePresent = true;
            points++;
            scoreDisplay.text = points.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    { 
        if (points < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
