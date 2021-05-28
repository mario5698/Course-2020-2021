using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [SerializeField]
    private GameObject shiba, doge, bitcoin, cardano, ethereum, xrp;
    private bool move_right;

    [SerializeField]
    private Transform spawn_Point;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newCoin = null;
        int num = Random.Range(0, 25);
         if (num >= 0 && num <= 3)
        {
            newCoin = Instantiate(shiba, spawn_Point.position, Quaternion.identity);
        }
        else if (num >= 4 && num <= 8)
        {
            newCoin = Instantiate(cardano, spawn_Point.position, Quaternion.identity);
        }
        else if (num >= 9 && num <= 12)
        {
            newCoin = Instantiate(xrp, spawn_Point.position, Quaternion.identity);
        }
        else if (num >= 13 && num <= 16)
        {
            newCoin = Instantiate(ethereum, spawn_Point.position, Quaternion.identity);
        }
        else if (num == 17)
        {
            newCoin = Instantiate(bitcoin, spawn_Point.position, Quaternion.identity);
        }
        else
        {
            newCoin = Instantiate(doge, spawn_Point.position, Quaternion.identity);
        }
            newCoin.transform.parent = transform;
    }


    void Update()
    {
        if (move_right)
        {
            transform.Translate(0.025f, 0, 0);
        }
        else
        {
            transform.Translate(-0.025f, 0, 0);
        }
        if (transform.position.x > 2.75f)
        {
            move_right = false;
        }
        if (transform.position.x < -2.75f)
        {
            move_right = true;
        }
    }
}
