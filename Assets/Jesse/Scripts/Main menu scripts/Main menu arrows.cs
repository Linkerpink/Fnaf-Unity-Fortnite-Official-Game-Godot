using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenuarrows : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    void Start()
    {
        _textMeshPro.enabled = false;
    }

    public void OnClicker()
    {
        Debug.Log("klik");
    }

    public void OnButton()
    {
        _textMeshPro.enabled = true;
    }

    public void OnButtonExit()
    {
        _textMeshPro.enabled = false;
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void Continue()
    {
        SceneManager.LoadScene("Main Scene");
    }
}