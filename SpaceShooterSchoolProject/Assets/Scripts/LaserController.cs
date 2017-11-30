using UnityEngine;

public class LaserController : MonoBehaviour 
{

    public float laserSpeed = 10f;

    void Start()
    {

        Destroy(gameObject, 2f);

    }

    void Update()
    {

        transform.Translate(0, laserSpeed * Time.deltaTime, 0);

    }

}
