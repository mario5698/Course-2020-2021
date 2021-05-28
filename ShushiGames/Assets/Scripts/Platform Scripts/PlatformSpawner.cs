using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    public static PlatformSpawner instance;

    [SerializeField]
    private GameObject left_Platform, right_Platform;

    private float left_X_min = -1.4f, left_X_max = -1.8f, right_X_min = 1.4f, right_X_max = 1.8f;
    private float y_TresHold = 9.6f;
    private float last_Y;

    public int spawn_Count = 8;
    private int platform_Spawned;

    [SerializeField]
    private Transform platform_Parent;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        last_Y = transform.position.y;
        SpawnPlatforms();
    }

    public void SpawnPlatforms()
    {
        Vector2 temp = Vector2.zero;
        GameObject newPlatform = null;

        for (int i = 0; i < spawn_Count; i++)
        {
            temp.y = last_Y;
            if ((platform_Spawned%2)==0)
            {
                temp.x = Random.Range(left_X_min, left_X_max);
                newPlatform = Instantiate(right_Platform, temp, Quaternion.identity);
            }
            else
            {
                temp.x = Random.Range(right_X_min, right_X_max);
                newPlatform = Instantiate(left_Platform, temp, Quaternion.identity);
            }
            newPlatform.transform.parent = platform_Parent;
            last_Y += y_TresHold;
            platform_Spawned++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
