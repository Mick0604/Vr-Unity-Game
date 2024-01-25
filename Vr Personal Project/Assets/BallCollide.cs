using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollide : MonoBehaviour
{
    PlayerController playercontroller
    private int bounceCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other) {
        bounceCount++;

        if (bounceCount < 2)
        {
            gameObject.transform.position = new Vector3(25f, 0f, 0f);


        }
    }
}
