using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    // Este script me llama la estructura de los ciudadanos y los zombies para cuando haga collisión
    // imprima los mensajes de los ciudadanos y de los zombies.
	civiles civil;
	Zombies zom;
	void Start () 
	{           
		Camera.main.gameObject.AddComponent<FPSAim>();
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Zombie")
		{
			Debug.Log ("Hoy toca " + collision.gameObject.GetComponent<Zombie>().zom.part);
		}
		if (collision.gameObject.tag == "Ciudadano")
		{ 
			Debug.Log ("Mi nombre es " + collision.gameObject.GetComponent<Ciudadano>().civil.name + " y tengo " + collision.gameObject.GetComponent<Ciudadano>().civil.age + " años");
		}
	}
}
