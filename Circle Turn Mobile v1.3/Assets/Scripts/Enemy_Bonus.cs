using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
        }
    }
}
