using UnityEngine;
using System.Collections;

public class Linterna : MonoBehaviour {

	[SerializeField]
	private bool encender = false;

	static public float bateria = 100f;

	[SerializeField]
	private float batMax = 100f;

	[SerializeField]
	private float batMin = 0f;

	public GameObject linterna;

	void Update() {

		if (encender == true){

			bateria -=1 *Time.deltaTime;

		}

		if(Input.GetKeyDown(KeyCode.F)) {
			
			if(encender == true) {
				
				linterna.SetActive (false);

				encender = false;



			} else if (encender == false && bateria > batMin){
				
				linterna.SetActive (true);

				encender = true;


			}
		}

		if (bateria <= batMin && encender == true){

			linterna.SetActive (false);
			encender = false;
		}

		if (bateria >= batMax){

			bateria = batMax;

		}else if(bateria <= batMin){

			bateria = batMin;
		}
	}
}