using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
	public float tumble;
	private Rigidbody rb;

	void Awake ()
	{
		rb = GetComponent <Rigidbody> ();
	}

	void Start ()
	{
		rb.angularVelocity = Random.insideUnitSphere * tumble; 
	}
}