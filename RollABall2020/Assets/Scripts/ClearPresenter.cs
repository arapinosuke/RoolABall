using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearPresenter : MonoBehaviour
{
    [SerializeField] private Text m_clearText = null;

    [SerializeField] private PickUpCountPresenter pickUpCountPresenter = null;

    private void Start()
    {
        //最初文字は消しておく
        m_clearText.text = string.Empty;
    }

    void Update()
    {
        if(pickUpCountPresenter.GetPickUpCount.Equals(12))
        {
            m_clearText.text="クリアー";
        }
    }
}
