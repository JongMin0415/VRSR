using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject[] panels; // 모든 패널을 저장할 배열

    private int currentPanelIndex = 0; // 현재 활성화된 패널의 인덱스

    // 시작 시 첫 번째 패널을 활성화
    private void Start()
    {
        ShowPanel(currentPanelIndex);
    }

    // 다음 화면으로 이동하는 함수
    public void NextPanel()
    {
        // 현재 패널 비활성화
        panels[currentPanelIndex].SetActive(false);

        // 다음 패널 인덱스 증가
        currentPanelIndex = (currentPanelIndex + 1) % panels.Length;

        // 다음 패널 활성화
        panels[currentPanelIndex].SetActive(true);
    }

    // 이전 화면으로 이동하는 함수
    public void PreviousPanel()
    {
        // 현재 패널 비활성화
        panels[currentPanelIndex].SetActive(false);

        // 이전 패널 인덱스 계산 (반복)
        currentPanelIndex = (currentPanelIndex - 1 + panels.Length) % panels.Length;

        // 이전 패널 활성화
        panels[currentPanelIndex].SetActive(true);
    }

    // 특정 인덱스의 패널을 보여주는 함수
    private void ShowPanel(int index)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == index);
        }
    }
}
