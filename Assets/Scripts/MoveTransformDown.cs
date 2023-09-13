using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransformDown : MonoBehaviour
{
    public float transformSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveToBottom();
    }

    void moveToBottom()
    {
        transform.Translate(0, -transformSpeed,0);
    }
}
