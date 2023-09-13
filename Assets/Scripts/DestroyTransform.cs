using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTransform : MonoBehaviour
{
    ScoreLogic addToScore;
    public GameObject particles;

    void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if(transformCollision.gameObject.tag == "Collision")
        {
            Destroy(transformCollision.gameObject);
            spawnParticle(transformCollision.transform.position);
            
            callScoreLogicScript();
        }
    }

    void callScoreLogicScript()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
        addToScore.addToScoreVOID();
    }

    void spawnParticle(Vector2 tempPosition)
    {
        Instantiate(particles, tempPosition,Quaternion.identity);
    }
}