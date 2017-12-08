using UnityEngine;

public class ScrollingBackground : MonoBehaviour 
{

    void Update()
    {

        transform.Translate(0, -5 * Time.deltaTime, 0);

        if(transform.position.y < (-Camera.main.orthographicSize * 2 ))
        {

            transform.position = new Vector3(transform.position.x, Camera.main.orthographicSize * 2, transform.position.z);

        }

    }

}
