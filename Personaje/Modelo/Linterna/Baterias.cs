using UnityEngine;
using System.Collections;

public class Baterias : MonoBehaviour {

	[SerializeField]
	private float bateriaRecargada = 10f;

	void OnTriggerEnter(Collider other){

		if (other.tag == "Player"){
			
		Linterna.bateria += bateriaRecargada;
			Destroy (this.gameObject);
		}
	}
}
