using UnityEngine;

public class Jugador : MonoBehaviour
{
    public GameObject jugador;
    public float vel = 10f;//en c# se suele poner el tipo de valor al final
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {

        }
        float direccioHorizontal = Input.GetAxisRaw("Horizontal");
        float direccioVertical = Input.GetAxisRaw("Vertical");
        Vector3 direccio = new Vector3(direccioHorizontal, direccioVertical, 0).normalized;
        Debug.Log("Direccio: " + direccio);
        Vector3 nouDesplacament = new Vector3(
            vel * direccio.x * Time.deltaTime,
            vel * direccio.y * Time.deltaTime,
            vel * direccio.z * Time.deltaTime);
        transform.position += nouDesplacament;

    }
}
