using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            StatController.Instance.ReduceLife();
            if (StatController.Instance.playerLife <= 0)
            {
                StatController.Instance.GameOver();
                Destroy(this.gameObject);
            }
        }
    }
}
