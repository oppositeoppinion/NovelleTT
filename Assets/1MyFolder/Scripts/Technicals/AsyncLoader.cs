using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.ComponentModel;
using TMPro;

public class AsyncLoader : MonoBehaviour
{
    [SerializeField] private Image _filledImage;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private int _sceneId;
    private UnityEngine.AsyncOperation _asyncOperation;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1.0f);
        _asyncOperation = SceneManager.LoadSceneAsync(_sceneId);
        while (!_asyncOperation.isDone) 
        {
            float progress = _asyncOperation.progress / 0.9f;
            _filledImage.fillAmount = progress;
            _text.text = $"LOADING... {progress * 100f}%";
            yield return null;
        }
    }

}
