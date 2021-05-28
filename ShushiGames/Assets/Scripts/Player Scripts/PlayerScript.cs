using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D myBody;
    float dirX;
    public float move_Speed = 2f;
    public float extra_Push = 14f;
    public float normal_Push = 20f;
    public float super_Push = 40f;
    private float nextActionTime = 0.5f;
    public float period = 0.1f;
    public float y_dir = 4f;


    private bool initial_Push;
    private Text score;

    private bool player_Died;

    // Start is called before the first frame update

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        dirX = Input.acceleration.x * move_Speed * 3;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.75f, 2.75f), Mathf.Clamp(transform.position.y, -10000000000000000000000000000f, 10000000000000000000000000000000000f));
        //  new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f), Mathf.Clamp(transform.position.y, -10000000000000000000000000000f, 10000000000000000000000000000000000f));
    }

    // Update is called once per frame
    void FixedUpdate()
    {       
        Move();
    }

    void Move()
    {
        if (player_Died)
        {
            return;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            myBody.velocity = new Vector2(-move_Speed, y_dir);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            myBody.velocity = new Vector2(move_Speed, y_dir);
        } else
        {
            myBody.velocity = new Vector2(0, y_dir);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player_Died)
        {
            return;
        }
        if (collision.tag == "ExtraPush")
        {
            ScoreScript.scoreValue += 3;
            collision.gameObject.SetActive(false);
            SoundManager.instance.JumpSoundFX();


        }

        if (collision.tag == "NormalPush")
        {
            collision.gameObject.SetActive(false);
            ScoreScript.scoreValue += 1;
            SoundManager.instance.JumpSoundFX();

        }

        if (collision.tag == "SuperPush")
        {
            collision.gameObject.SetActive(false);
            SoundManager.instance.JumpSoundFX();

            ScoreScript.scoreValue += 5;


        }

        if (Time.time > nextActionTime)
        {
            PlatformSpawner.instance.SpawnPlatforms();

            // execute block of code here
        }

        if (collision.tag == "Platform" )
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
            y_dir = -4f;
            GameManager.instance.RestartGame();
            SoundManager.instance.GameOverSoundFX();
            player_Died = true;
            ScoreScript.scoreValue = 0;
        }
    }
}
