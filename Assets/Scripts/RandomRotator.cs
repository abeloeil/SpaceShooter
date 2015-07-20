using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour 
{
	public float tumble;
	void Start ()
	{
		var rigidbody = GetComponent<Rigidbody> ();
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
