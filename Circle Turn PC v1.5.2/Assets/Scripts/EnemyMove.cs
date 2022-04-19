using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float speed;

    private void FixedUpdate()
    {
        enemy.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
            Destroy(other.gameObject);
    }

}
