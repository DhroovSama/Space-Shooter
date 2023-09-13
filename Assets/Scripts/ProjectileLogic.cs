using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{

    public float transformSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveTransformToTop();
    }

    void moveTransformToTop()
    {
        transform.Translate(0, transformSpeed, 0);
    }
}
