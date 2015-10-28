using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;

    // PRIVATE INSTANCE VARIABLES
    private GameObject[] tanks;
	
	// Use this for initialization
	void Start () {
		this._GenerateTanks ();
        tanks = GameObject.FindGameObjectsWithTag("Enemy");
    }
	
	// Update is called once per frame
	void Update () {

        if (StatController.Instance.gameOver)
        {
            for (int i = 0; i < tanks.Length; i++)
            {
                Destroy(tanks[i]);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
                StatController.Instance.Reset();
                StatController.Instance.GameOver();
            }
        }
    }

	// generate Clouds
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}
}
