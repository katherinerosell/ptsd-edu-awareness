using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicRestart : MonoBehaviour { 

    public void Restart() {
        SceneManager.LoadScene("Level1-2", LoadSceneMode.Single);
    }

}
