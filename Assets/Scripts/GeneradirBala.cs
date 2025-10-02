using UnityEngine;

public class GeneradirBala : MonoBehaviour
{
    public GameObject prefabBala;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject jugador;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GeneradorEnemics();
        }
    }
    private void GeneradorEnemics()
    {
        GameObject Enemic = Instantiate(prefabBala);
        Enemic.transform.position = new Vector3(
            jugador.transform.position.x,
           jugador.transform.position.y,
            jugador.transform.position.z
        );
    }
}
