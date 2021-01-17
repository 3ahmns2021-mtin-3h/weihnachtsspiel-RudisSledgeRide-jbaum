using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Stone");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Hallo Rudi " + collision.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}