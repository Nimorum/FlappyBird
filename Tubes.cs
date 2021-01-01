using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubes : MonoBehaviour
{

    private float velocity = 0.5f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-velocity * Time.deltaTime, 0, 0));
    }
}
