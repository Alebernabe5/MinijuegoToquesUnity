using UnityEngine;

public class Balon : MonoBehaviour
{

    private GameObject panelDerrota;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        panelDerrota = (GameObject) GameObject.FindGameObjectWithTag("PanelDerrota");
        if (panelDerrota == null )
        {
            Debug.Log("No se ha encontrado");
        }
        panelDerrota.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SensorDeDerrota")
        {
            Debug.Log("Perdiste");
            panelDerrota.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
