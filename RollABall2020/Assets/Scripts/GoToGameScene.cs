﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGameScene : MonoBehaviour
{
    public void StartGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
