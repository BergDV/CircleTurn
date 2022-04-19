using UnityEngine;

public class Destoyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")       
            Destroy(other.gameObject);        
        else
            Destroy(other.gameObject);
       
    }
}

