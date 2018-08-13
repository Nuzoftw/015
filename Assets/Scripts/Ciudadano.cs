using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{
    // Este script contiene la estructura de los ciudadanos, y sus enums tanto del nombre como de la edad.
    public civiles civil;
    void Start()
    {
        civil.name = (civilname)Random.Range(1, 20);
        civil.age = Random.Range(15, 101);
    }
}
public enum civilname
{
	Norfi, Sindy, Paola, Nuzo, Alirio, Ismael, Celeste, Sara, Mónica,
    Kelly, Santiago, Jacobo, Michael, Anthua, Nayibi, Cony, Margot, Sebastián , Nasly,
    Caca
	
}
public struct civiles                                              
{
	public int age; 
	public civilname name; 
}