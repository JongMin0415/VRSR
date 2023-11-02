using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject[] panels; // ��� �г��� ������ �迭

    private int currentPanelIndex = 0; // ���� Ȱ��ȭ�� �г��� �ε���

    // ���� �� ù ��° �г��� Ȱ��ȭ
    private void Start()
    {
        ShowPanel(currentPanelIndex);
    }

    // ���� ȭ������ �̵��ϴ� �Լ�
    public void NextPanel()
    {
        // ���� �г� ��Ȱ��ȭ
        panels[currentPanelIndex].SetActive(false);

        // ���� �г� �ε��� ����
        currentPanelIndex = (currentPanelIndex + 1) % panels.Length;

        // ���� �г� Ȱ��ȭ
        panels[currentPanelIndex].SetActive(true);
    }

    // ���� ȭ������ �̵��ϴ� �Լ�
    public void PreviousPanel()
    {
        // ���� �г� ��Ȱ��ȭ
        panels[currentPanelIndex].SetActive(false);

        // ���� �г� �ε��� ��� (�ݺ�)
        currentPanelIndex = (currentPanelIndex - 1 + panels.Length) % panels.Length;

        // ���� �г� Ȱ��ȭ
        panels[currentPanelIndex].SetActive(true);
    }

    // Ư�� �ε����� �г��� �����ִ� �Լ�
    private void ShowPanel(int index)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == index);
        }
    }
}
