using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePoint : MonoBehaviour
{
    [SerializeField] GameObject point;
    GameObject player;
    [SerializeField] float speedPoint = 3f;
    float timer;
    float percentage;
    bool startMove = false;

    private void FixedUpdate()
    {
        if(startMove)
        {
            timer += Time.deltaTime;
            percentage = timer / speedPoint;
            point.transform.position = Vector3.Lerp(point.transform.position, player.transform.position, percentage);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == Tags.playerBall)
        {
            startMove = true;
            player = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == Tags.playerBall)
        {
            point.GetComponent<Rigidbody>().velocity = Vector3.zero;
            startMove = false;
        }
    }
}
