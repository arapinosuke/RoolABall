using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class PickUpCountPresenter : MonoBehaviour
{
    [SerializeField] private Text m_pickUpCountText = null;

    private static int m_pickUpCounter = 0;

    /// <summary>
    /// 外部からPickUpCounterを取得したい場合
    /// </summary>
    public int GetPickUpCount
    {
        get { return m_pickUpCounter; }
    }

    public void Update()
    {
        m_pickUpCountText.text = $"{m_pickUpCounter}";
    }

    /// <summary>
    /// 引数をpickUpCounterに加算する
    /// </summary>
    /// <param name="dissapperCount"></param>
    public static void CountDisplay(int dissapperCount)
    {
        m_pickUpCounter += dissapperCount;
    }
}
