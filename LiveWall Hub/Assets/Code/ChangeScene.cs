using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField]public string SceneName;

    public void NextScene ()
    {
        Debug.Log("JOeJoe");
        SceneManager.LoadScene(SceneName);
    }

}
