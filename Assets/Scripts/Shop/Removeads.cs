using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Removeads : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Select_Level");
    }
    public void OnClickRemove()
    {
        SceneManager.LoadScene("RemoveAds");
    }
}
