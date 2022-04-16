using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		//se llama autmáticamente cuando otro objeto físico entra en el 
		//collider y trigger del objeto

		//revisamos las etiquetas
		if (other.CompareTag("Projectile"))
		{  
			//animal choca contra un proyectil
			//destruye la pelota
			Destroy(gameObject);

			//destruye el proyectil
			Destroy(other.gameObject);
		}
	}
}
