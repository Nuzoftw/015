using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Este script contiene la estructura del zombie, los enums de los estados del mismo, un caso (switch)
    // que controla el movimiento y los estados del zombie, y otra estructura que contiene el color del zombie.
    public Zombies zom;
    int randomint;
    Estado estado;
    int moving;
    IEnumerator MovimientoZombie()
    {
        yield return new WaitForSeconds(5);
        estado = (Estado)Random.Range(0, 2);
        randomint = Random.Range(0, 4);
        StartCoroutine(MovimientoZombie());
    }
    void Start()
    {
        zom.part = (body)Random.Range(0, 5);
        StartCoroutine(MovimientoZombie());
    }

    void Update()
    {
        switch (estado)
        {
            case Estado.idle:
                break;
            case Estado.moving:
                Moving();
                break;
        }
    }

    public void Moving()
    {
        zom.Speed = 1.5f;
        switch (randomint)
        {
            case 0:
                transform.position += transform.forward * zom.Speed * Time.deltaTime;
                break;
            case 1:
                transform.position -= transform.forward * zom.Speed * Time.deltaTime;
                break;
            case 2:
                transform.position += transform.right * zom.Speed * Time.deltaTime;
                break;
            case 3:
                transform.position -= transform.right * zom.Speed * Time.deltaTime;
                break;
        }
    }
}

public struct Zombies                                                     
{
	public  Color[] col; 
	public body part; 
	public float Speed;
	
}

public enum body                                           
{
	Cabeza, piernas, brazos, torso, Cerebro 
}

public enum Estado
{
	idle, moving
}