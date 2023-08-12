using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tags.playerBall)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("DEATH");
        }
    }
}
