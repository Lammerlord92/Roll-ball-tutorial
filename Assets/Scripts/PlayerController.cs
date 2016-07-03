using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
    public Text contadorObjetos;
    public Text objetivoCompletado;

    private Rigidbody rb;
    private int contador;

	void Start(){
		rb=GetComponent<Rigidbody>();
        contador = 0;
        SetNumeroObjetos();
        objetivoCompletado.text = "";
    }
	//físicas
	void FixedUpdate()
	{
		//Ctrl+' para ver la referencia de la función
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement=new Vector3(moveHorizontal,0.0f,moveVertical);
		
		rb.AddForce(movement*speed);
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            contador++;
            SetNumeroObjetos();
        }
    }
    void SetNumeroObjetos()
    {
        contadorObjetos.text = "Recogidos: " + contador.ToString();
        if (contador >= 12)
        {
            objetivoCompletado.text = "Objetivo completado";
        }
    }
}

//Destroy(other.gameObject);
