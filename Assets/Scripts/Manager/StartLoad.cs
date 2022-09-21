using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadSinglePlayerMode()
    {
        StartCoroutine(LoadAsyncScene("SinglePlayerMode"));
    }
    IEnumerator LoadAsyncScene(string sceneName)
    {
       // SetLoadingWindowActive(true);

        yield return new WaitForSeconds(0.2f);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        asyncLoad.allowSceneActivation = false;

        bool isDone = false;

        while (!isDone)
        {
            if (asyncLoad.progress >= 0.3f)
                isDone = true;

            yield return null;
        }

       // blanckScreen.SetActive(true);
       // SetLoadingWindowActive(false);
        yield return new WaitForSeconds(0.5f);
        asyncLoad.allowSceneActivation = true;
        yield break;
    }
}
