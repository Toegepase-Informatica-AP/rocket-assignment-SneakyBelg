using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour
{
    public int mLevelToLoad;

    public void LoadLevel()
    {
        SceneManager.LoadScene(mLevelToLoad);
    }
}
