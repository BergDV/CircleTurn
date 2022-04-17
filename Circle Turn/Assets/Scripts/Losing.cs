using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Losing : MonoBehaviour
{
    public void Lose()
    {
        SceneManager.LoadScene(2);
    }
    



}
