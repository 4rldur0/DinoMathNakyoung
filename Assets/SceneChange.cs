using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void ToMyAvatarScene()
    {
        SceneManager.LoadScene("MyAvatarScene");
    }
    public void ToDinoBookScene()
    {
        SceneManager.LoadScene("DinoBookScene");
    }
    public void ToCountryChoiceScene()
    {
        SceneManager.LoadScene("CountryChoiceScene");
    }
    public void ToStageChoiceScene()
    {
        SceneManager.LoadScene("StageChoiceScene");
    }
}
