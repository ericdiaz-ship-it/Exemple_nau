using System;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public GameObject jugador;
    public float vel = 10f;//en c# se suele poner el tipo de valor al final
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Camera camera;
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        MovimentNau();


    }
    void MovimentNau()
    {
        Vector3 limitInferiorEsquerra = camera.ViewportToWorldPoint(new Vector2(0, 0));
        Vector3 limitSuperiorDret = camera.ViewportToWorldPoint(new Vector2(1, 1));

        float direccioHorizontal = Input.GetAxisRaw("Horizontal");
        float direccioVertical = Input.GetAxisRaw("Vertical");
        Vector3 direccio = new Vector3(direccioHorizontal, direccioVertical, 0).normalized;
        Debug.Log("Direccio: " + direccio);
        Vector3 nouDesplacament = new Vector3(
            vel * direccio.x * Time.deltaTime,
            vel * direccio.y * Time.deltaTime,
            vel * direccio.z * Time.deltaTime);
        transform.position += nouDesplacament;
        Vector3 novapos = transform.position;
        nouDesplacament.x = Math.Clamp(novapos.x, limitInferiorEsquerra.x, limitSuperiorDret.x);
        nouDesplacament.y = Math.Clamp(novapos.y, limitInferiorEsquerra.y, limitSuperiorDret.y);
        
    }
}
