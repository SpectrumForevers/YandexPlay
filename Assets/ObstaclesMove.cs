using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMove : MonoBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 endPosition;
    [SerializeField] float speedLerping = 2f;
    private float timer;
    float percentageComplete = 0f;
    bool startShooting = true;
    
    private void Start()
    {
        startPosition = transform.localPosition;
        endPosition = transform.localPosition;
        endPosition.y -= 1f;
    }

    
    private void Update()
    {
        
        if (startShooting == true)
        {
            timer += Time.deltaTime;
            percentageComplete = timer / speedLerping;
            Debug.Log(percentageComplete);
            transform.localPosition = Vector3.Lerp(startPosition, endPosition, percentageComplete);
            if (percentageComplete >= 1f)
            {
                startShooting = false;
            }
        }
        else
        {
            timer -= Time.deltaTime;
            percentageComplete = timer / speedLerping;
            Debug.Log(percentageComplete);
            transform.localPosition = Vector3.Lerp(startPosition, endPosition, percentageComplete);
            if (percentageComplete <= 0f)
            {
                startShooting = true;
            }
        }
        
    }
}
