using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMaster : MonoBehaviour
{
    // 시작 화면에서 시작 버튼 눌렀을 때 "VRFishInfo"화면으로 전환
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("VRFishInfo");
    }
}
