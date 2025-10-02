using Unity.VisualScripting;
using UnityEngine;

public class Parets : MonoBehaviour
{
    private float vel = 30f;
    private const float LIMIT_Z_NEGATIU = -12f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - vel * Time.deltaTime
        );
        if (transform.position.z < LIMIT_Z_NEGATIU)
        {
            Destroy(gameObject);
        }
    }
}
