using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Pausene : MonoBehaviour
{
    public Animator fadeScreenAnimator;
    public static Pausene ins;
    public GameObject PauseScren;
    public GameObject PauseButton;
    bool GamePaused;
    // Start is called before the first frame update
    void Start()
    {
        INS();
        GamePaused = false;
    }
    void INS()
    {
        if (ins == null)
        {
            ins = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (GamePaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
    public void PauseGame()
    {
        GamePaused = true;
        PauseScren.SetActive(true);
        PauseButton.SetActive(false);
    }
    public void ResumeGame()
    {
        GamePaused = false;
        PauseScren.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void Menu(int seneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(seneID);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SinglePlayerMode");
    }

    //public void ReturnToMainMenu()
    //{
    //    StartCoroutine("GoToMainMenu");
    //}

    //private IEnumerator GoToMainMenu()
    //{
    //    fadeScreenAnimator.SetTrigger("FadeIn");

    //    yield return new WaitForSeconds(1f);

    //    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
    //    asyncLoad.allowSceneActivation = false;

    //    bool isDone = false;

    //    while (!isDone)
    //    {
    //        if (asyncLoad.progress >= 0.9f)
    //            isDone = true;

    //        yield return null;
    //    }

    //    yield return new WaitForSeconds(1.5f);
    //    asyncLoad.allowSceneActivation = true;
    //    yield break;
    //}
}
