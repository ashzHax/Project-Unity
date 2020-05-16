using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        GameObject room = GameObject.Find("Open_Wall");
        GameObject up = GameObject.Find("Spawn_Up");
        GameObject down = GameObject.Find("Spawn_Down");
        GameObject right = GameObject.Find("Spawn_Right");
        GameObject left = GameObject.Find("Spawn_Left");

        int randInt = UnityEngine.Random.Range(0, 4);

        if (randInt == 0)
        {
            Vector2 spawn_point = up.transform.position;
            Instantiate(room, spawn_point, Quaternion.identity);
        }
        else if (randInt == 1)
        {
            Vector2 spawn_point = right.transform.position;
            Instantiate(room, spawn_point, Quaternion.identity);
        }
        else if (randInt == 2)
        {
            Vector2 spawn_point = down.transform.position;
            Instantiate(room, spawn_point, Quaternion.identity);
        }
        else if (randInt == 3)
        {
            Vector2 spawn_point = left.transform.position;
            Instantiate(room, spawn_point, Quaternion.identity);
        }
    }




    void Update()
    {
        
    }
}
