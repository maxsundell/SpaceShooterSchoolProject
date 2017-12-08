using UnityEngine;

public class LaserController : MonoBehaviour 
{

    public float laserSpeed = 10f;

    public GameObject laserHit;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("BigMeteor") && collision.transform.position.y <= Camera.main.orthographicSize - 1 || collision.CompareTag("Meteor") && collision.transform.position.y <= Camera.main.orthographicSize - 1)
        {

            GameObject laserHitParticle = Instantiate(laserHit, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));

            Destroy(laserHitParticle, 0.1f);

            Destroy(gameObject);
            
        }

    }

    void Start()
    {

        Destroy(gameObject, 2f);

    }

    void Update()
    {

        transform.Translate(0, laserSpeed * Time.deltaTime, 0);

    }

}
