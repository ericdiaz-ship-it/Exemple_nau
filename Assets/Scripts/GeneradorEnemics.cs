using UnityEngine;

public class GneradorEnemics : MonoBehaviour
{
    private const float LIMIT_ESQUERRA = -7f;
    private const float LIMIT_INFERIOR = -1f;
    private const float LIMIT_DRET = 7f;
    private const float LIMIT_SUPERIOR = 7f;
    private const float LIMIT_POSTERIOR = 90f;
    public GameObject prefabEnemic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("GeneradorEnemics",0.5f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void GeneradorEnemics()
    {
        GameObject Enemic = Instantiate(prefabEnemic);
        Enemic.transform.position = new Vector3(
            Random.RandomRange(LIMIT_DRET,LIMIT_ESQUERRA ),
            Random.RandomRange(LIMIT_SUPERIOR,LIMIT_INFERIOR ),
            LIMIT_POSTERIOR
        );
    }
}
