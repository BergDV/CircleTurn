using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMove : MonoBehaviour
{

    [SerializeField] GameObject bonus;
    [SerializeField] float speed;

    private void FixedUpdate()
    {
        bonus.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
