using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    private bool followPlayer;
    public float min_Y_Treshold = -2.6f; 

    // Start is called before the first frame update
    void Awake()
    {
        float xFactor = Screen.width / 720f;
        float yFactor = Screen.height / 1080f;

        Camera.main.rect = new Rect(0, 0, 1, xFactor / yFactor);
        GameObject[] gmOB = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject t in gmOB)
        {
            target = t.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    void Follow()
    {
        if (target.position.y < transform.position.y - min_Y_Treshold)
        {
            followPlayer = false;
        }
        if (target.position.y > transform.position.y)
        {
            followPlayer = true;
        }
        if (followPlayer)
        {
            Vector3 temp = transform.position;
            temp.y = target.position.y;
            transform.position = temp;
        }
    }

}
