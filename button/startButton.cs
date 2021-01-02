using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour {

  void Start () {
    // ボタンクリックでStartGame関数を実行
    gameObject.GetComponent<Button>().onClick.AddListener(StartGame);
  }

  void StartGame()
    {
        // GameSceneをロード
        SceneManager.LoadScene("GameScene");
    }
}
