using UnityEngine;
using TMPro;

public class Player2D : MonoBehaviour
{
    [SerializeField]
    private float velocidad;

    private int puntuacion;

    [SerializeField]
    private GameObject puntuacionUI;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntuacionUI = (GameObject)GameObject.FindGameObjectWithTag("PuntuacionUI");

       /* if ( puntuacionUI != null )
        {
            Debug.Log("Encontrado");
        }
        else
        {
            Debug.Log("Lo siento no es este");
        }*/
      
        this.puntuacion = 0;
    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0.0f, 0.0f); //Desplazamiento haca la derecha.
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Balon"))
        {
            puntuacion = puntuacion + 1;
            puntuacionUI.gameObject.GetComponent<TMP_Text>().text = puntuacion.ToString();
        }
    }
}
