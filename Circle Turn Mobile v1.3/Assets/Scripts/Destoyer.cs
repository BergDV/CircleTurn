using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);

        }

    }
}

