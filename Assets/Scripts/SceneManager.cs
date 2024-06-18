using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string LoadToScene;
    void Start()
    {
        LoadScene(LoadToScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene(string levelToLoad)
    {
        print(levelToLoad);
    }
}
