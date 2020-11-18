using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour {

    private void Start() {
        gameObject.SetActive(false);
        Invoke("Appear", 2.40f);
    }

    private void Appear() {
        gameObject.SetActive(true);
    }

    public void LevelBegin(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

}
