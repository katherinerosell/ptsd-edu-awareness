using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IAmPlayer : MonoBehaviour {

    public Image blipPoint1;
    public Image blipPoint2;
    public Image blipPoint3;
    private Image[] blipPointArr;
    private Color blipColor;
    [SerializeField]
    Color grey; // rgb, 142 142 142, alpha = 100
    private static int blipPoints; // health points
    private Scene scene;
    
    void Start() {
        scene = SceneManager.GetActiveScene();
        blipPointArr = new Image[] { blipPoint1, blipPoint2, blipPoint3 };
        blipPoints = 3;
    }

    public int getBlipPoints() { return blipPoints; }
    public void setBlipPoints(int n) { blipPoints += n;  }

    // function called by the WordText object, since it uses isTrigger collider
    public void playerHit() {
        blipPoints--; // when player is hit, decrement blips
        blipPointArr[blipPoints].color = grey;
    }

    private void Update() {
        if (blipPoints <= 0) {
            SceneManager.LoadScene(scene.name); // game over, restart level
        }
    }

}
