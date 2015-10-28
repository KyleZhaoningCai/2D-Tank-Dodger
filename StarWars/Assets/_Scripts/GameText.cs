using UnityEngine;
using System.Collections;

public class GameText : MonoBehaviour {

    public GUISkin skin;

    public void OnGUI()
    {
        GUI.skin = skin;

        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));

        GUILayout.BeginVertical(skin.GetStyle("GameText"));

        // Displays the score
        GUILayout.Label(string.Format("Points: {0}", StatController.Instance.points), skin.GetStyle("PointsText"));

        // Displays the life and game over information
        GUILayout.Label(StatController.Instance.life, skin.GetStyle("LifeText"));

        GUILayout.EndVertical();

        GUILayout.EndArea();
    }
}
