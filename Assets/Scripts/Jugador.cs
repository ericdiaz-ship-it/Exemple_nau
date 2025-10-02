using System;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public GameObject jugador;
    public float vel = 10f;//en c# se suele poner el tipo de valor al final
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Camera camera;
    private Vector3 limitInferiorEsquerra;
    private Vector3 limitSuperiorDret;
    void Start()
    {
        camera = Camera.main;
        float distanciaZCamaraNau = Mathf.Abs(transform.position.z - camera.transform.position.z);

        limitInferiorEsquerra = camera.ViewportToWorldPoint(new Vector3(0, 0, distanciaZCamaraNau));
        limitSuperiorDret = camera.ViewportToWorldPoint(new Vector3(1, 1, distanciaZCamaraNau));
    }

    // Update is called once per frame
    void Update()
    {

        MovimentNau();
        ControlLimitsPantalla();


    }
    void MovimentNau()
    {
        float direccioHorizontal = Input.GetAxisRaw("Horizontal");
        float direccioVertical = Input.GetAxisRaw("Vertical");
        Vector3 direccio = new Vector3(direccioHorizontal, direccioVertical, 0).normalized;
        //Debug.Log("Direccio: " + direccio);
        Vector3 nouDesplacament = new Vector3(
            vel * direccio.x * Time.deltaTime,
            vel * direccio.y * Time.deltaTime,
            vel * direccio.z * Time.deltaTime);
        transform.position += nouDesplacament;
        
    }
    void ControlLimitsPantalla()
    {
        Vector3 novapos = transform.position;
        novapos.x = (float)Math.Clamp(novapos.x, limitInferiorEsquerra.x+ 1, limitSuperiorDret.x-1);
        novapos.y = (float)Math.Clamp(novapos.y, limitInferiorEsquerra.y+0.7, limitSuperiorDret.y-0.7);
        transform.position = novapos;
    }
}
