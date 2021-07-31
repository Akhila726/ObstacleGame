using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You have bumped into the thing many times: " + hits);
        }
    }
}
