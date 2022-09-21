using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    float time, second;
    public Image FillImage;
    // Start is called before the first frame update
    void Start()
    {
        second = 2;
        Invoke("LoadGame", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < 2)
        {
            time += Time.deltaTime;
            FillImage.fillAmount = time / second;
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
