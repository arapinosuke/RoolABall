using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPresenter : MonoBehaviour
{
    [SerializeField] private SphereStates m_sphereStates = null;
    [SerializeField] private Text m_gameOverText = null;

    private void Start()
    {
        m_gameOverText.text = string.Empty;
    }

    private void Update()
    {
        if (m_sphereStates.GameOver)
        {
            Time.timeScale = 0f;
            m_gameOverText.text = "ゲームオーバー";
        }
    }
}
