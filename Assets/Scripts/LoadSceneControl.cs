using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneControl: MonoBehaviour {

    public string levelToLoad;
     public SceneManager SceneManager;
    // Start is called before the first frame update
    void Start(){
       
    }

    // Update is called once per frame
    void Update()
    {
        LoadScene(levelToLoad);
    }
    public void LoadScene(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
