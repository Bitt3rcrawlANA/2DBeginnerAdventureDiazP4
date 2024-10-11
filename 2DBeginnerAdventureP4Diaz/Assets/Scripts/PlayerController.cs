using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + 0.02f;
        transform.position = position;

        Vector2 position2 = transform.position;
        position2.y = position2.y + 0.02f;
        transform.position = position2;
    }
}
