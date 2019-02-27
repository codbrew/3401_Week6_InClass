using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EagleController : MonoBehaviour
{
    public AudioSource flapSound;
    public AudioSource hitSound;
    //refence to birds rigid body; holds variable
    public Rigidbody2D birdRB;
    //variable for Y velocity
    public float jumpSpeed = 5;
    // Start is called before the first frame update
    public GameObject gameOverCanvas;
    public int currentScore = 0;
    public Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Pressed");
            birdRB.velocity = new Vector2(birdRB.velocity.x, jumpSpeed);
            flapSound.Play();
           
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Caw!");
        gameOverCanvas.SetActive(true);
        hitSound.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //add one to the score
        currentScore++;
        scoreText.text = currentScore.ToString();
    }
}
