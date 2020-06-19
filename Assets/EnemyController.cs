using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var objects = GameObject.FindGameObjectsWithTag("Enemy");
        var objectCount = objects.Length;
        foreach (var obj in objects)
        {
            // Move the players accordingly
            var rb = obj.GetComponent<Rigidbody2D>();
            Debug.Log(rb);
            Vector2 direction = new Vector2(Random.Range(0,10), Random.Range(0,10));
            rb.velocity = direction * 0.1f;
        }
    }
}
