using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour
{

    public GameObject projectile;
    public float playerSpeed = 1.0f;
    public float maxPlayerXDistance = 29.0f;
    public float shootingSpeed = 0.5f;
    public bool isShooting = true;
    float projectileCollisionOffset = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(projectileShootTimer());
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    void playerMovement()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxPlayerXDistance)
        {
            transform.Translate(-playerSpeed,0,0);
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x <= maxPlayerXDistance)
        {
            transform.Translate(playerSpeed,0,0);
        }
    }

    IEnumerator projectileShootTimer()
    {
        while (isShooting == true)
        {
            spawnProjectile(); 
            yield return new WaitForSeconds(shootingSpeed);
        }
    }

    void spawnProjectile()
    {
        Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + projectileCollisionOffset, 0), Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D tempCollision)
    {
        if(tempCollision.gameObject.tag == "Collision")
        {
            SceneManager.LoadScene("GameScene");
        }
    }

}
