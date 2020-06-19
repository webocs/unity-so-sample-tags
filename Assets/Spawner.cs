using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        tillNextSpawn = 0;
    }
float tillNextSpawn;
public GameObject circle;
    // Update is called once per frame
   void Update()

{
    tillNextSpawn += Time.deltaTime;
    Debug.Log(tillNextSpawn);

    if (tillNextSpawn >= 2)
    {
        UnityEngine.Debug.Log("Instantiating circle");
        Instantiate(circle,  Vector2.zero, Quaternion.identity);
        tillNextSpawn = 0.0f;
    }
} 
    
}
