using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    // 물고기 객체 생성
    public GameObject fish01;
    public GameObject fish02;
    public GameObject fish03;
    public GameObject fish04;
    public GameObject fish05;
    public GameObject fish06;
    public GameObject fish07;
    public GameObject fish08;
    public GameObject fish09;
    public GameObject fish10;

    // Transform 변수 생성
    private Transform tr;

    // 물고기 객체에 대한 이미지, 설명
    public Image img01;
    public Image img02;
    public Image img03;
    public Image img04;
    public Image img05;
    public Image img06;
    public Image img07;
    public Image img08;
    public Image img09;
    public Image img10;

    public GameObject text01;
    public GameObject text02;
    public GameObject text03;
    public GameObject text04;
    public GameObject text05;
    public GameObject text06;
    public GameObject text07;
    public GameObject text08;
    public GameObject text09;
    public GameObject text10;

    // 물고기 객체에 대한 효과음
    private AudioSource audio;

    void Start()
    {
        // 객체 호출
        fish01 = GameObject.Find("fish");
        fish02 = GameObject.Find("fish02");
        fish03 = GameObject.Find("fish03");
        fish04 = GameObject.Find("fish04");
        fish05 = GameObject.Find("fish05");
        fish06 = GameObject.Find("fish06");
        fish07 = GameObject.Find("fish07");
        fish08 = GameObject.Find("fish08");
        fish09 = GameObject.Find("fish09");
        fish10 = GameObject.Find("fish10");

        // Transform 컴포넌트를 tr 변수에 할당
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        // 충돌체의 정보
        RaycastHit hit;

        // 사용자의 시선과 객체가 충돌했는지 확인
        if (Physics.Raycast(tr.position, tr.forward, out hit, Mathf.Infinity))
        {
            // 물고기1과 충돌했을 경우
            if (hit.collider.tag == ("fish01"))
            {
                FindFish01();
            }
            // 물고기2과 충돌했을 경우
            if (hit.collider.tag == ("fish02"))
            {
                FindFish02();
            }
            //이하 동일
            if (hit.collider.tag == ("fish03"))
            {
                FindFish03();
            }
            if (hit.collider.tag == ("fish04"))
            {
                FindFish04();
            }
            if (hit.collider.tag == ("fish05"))
            {
                FindFish05();
            }
            if (hit.collider.tag == ("fish06"))
            {
                FindFish06();
            }
            if (hit.collider.tag == ("fish07"))
            {
                FindFish07();
            }
            if (hit.collider.tag == ("fish08"))
            {
                FindFish08();
            }
            if (hit.collider.tag == ("fish09"))
            {
                FindFish09();
            }
            if (hit.collider.tag == ("fish10"))
            {
                FindFish10();
            }
        }
        else
        {
            NotFindFish();
        }
    }

    // 물고기와 충돌하지 않았을 경우
    void NotFindFish()
    {
        // 물고기 객체의 오디오소스컴포넌트 멈춤
        fish01.GetComponent<AudioSource>().Stop();
        fish02.GetComponent<AudioSource>().Stop();
        fish03.GetComponent<AudioSource>().Stop();
        fish04.GetComponent<AudioSource>().Stop();
        fish05.GetComponent<AudioSource>().Stop();
        fish06.GetComponent<AudioSource>().Stop();
        fish07.GetComponent<AudioSource>().Stop();
        fish08.GetComponent<AudioSource>().Stop();
        fish09.GetComponent<AudioSource>().Stop();
        fish10.GetComponent<AudioSource>().Stop();

        // 물고기의 이미지, 설명 비활성화
        img01.gameObject.SetActive(false);
        img02.gameObject.SetActive(false);
        img03.gameObject.SetActive(false);
        img04.gameObject.SetActive(false);
        img05.gameObject.SetActive(false);
        img06.gameObject.SetActive(false);
        img07.gameObject.SetActive(false);
        img08.gameObject.SetActive(false);
        img09.gameObject.SetActive(false);
        img10.gameObject.SetActive(false);

        text01.GetComponent<Text>().text = "";
        text02.GetComponent<Text>().text = "";
        text03.GetComponent<Text>().text = "";
        text04.GetComponent<Text>().text = "";
        text05.GetComponent<Text>().text = "";
        text06.GetComponent<Text>().text = "";
        text07.GetComponent<Text>().text = "";
        text08.GetComponent<Text>().text = "";
        text09.GetComponent<Text>().text = "";
        text10.GetComponent<Text>().text = "";
    }

    // 물고기1과 충돌했을 경우
    void FindFish01()
    {
        // 물고기1 객체의 오디오소스컴포넌트 재생 - 효과음(음성 텍스트)
        fish01.GetComponent<AudioSource>().Play();

        // 물고기1의 이미지, 설명 활성화
        img01.gameObject.SetActive(true);
        text01.GetComponent<Text>().text = "1번물고기 입니다";
    }

    // 물고기2과 충돌했을 경우
    void FindFish02()
    {
        // 물고기2 객체의 오디오소스컴포넌트 재생 - 효과음(음성 텍스트)
        fish02.GetComponent<AudioSource>().Play();

        // 물고기2의 이미지, 설명 활성화
        img02.gameObject.SetActive(true);
        text02.GetComponent<Text>().text = "2번물고기 입니다";
    }
    // 물고기3과 충돌했을 경우
    void FindFish03()
    {
        // 물고기3 객체의 오디오소스컴포넌트 재생 - 효과음(음성 텍스트)
        fish03.GetComponent<AudioSource>().Play();

        // 물고기3의 이미지, 설명 활성화
        img03.gameObject.SetActive(true);
        text03.GetComponent<Text>().text = "3번물고기 입니다";
    }
    // 이하 동일
    void FindFish04()
    {
        fish04.GetComponent<AudioSource>().Play();

        img04.gameObject.SetActive(true);
        text04.GetComponent<Text>().text = "4번물고기 입니다";
    }
    void FindFish05()
    {
        fish05.GetComponent<AudioSource>().Play();

        img05.gameObject.SetActive(true);
        text05.GetComponent<Text>().text = "5번물고기 입니다";
    }
    void FindFish06()
    {
        fish06.GetComponent<AudioSource>().Play();

        img06.gameObject.SetActive(true);
        text06.GetComponent<Text>().text = "6번물고기 입니다";
    }
    void FindFish07()
    {
        fish07.GetComponent<AudioSource>().Play();

        img07.gameObject.SetActive(true);
        text07.GetComponent<Text>().text = "7번물고기 입니다";
    }
    void FindFish08()
    {
        fish08.GetComponent<AudioSource>().Play();

        img08.gameObject.SetActive(true);
        text08.GetComponent<Text>().text = "8번물고기 입니다";
    }
    void FindFish09()
    {
        fish09.GetComponent<AudioSource>().Play();

        img09.gameObject.SetActive(true);
        text09.GetComponent<Text>().text = "9번물고기 입니다";
    }
    void FindFish10()
    {
        fish10.GetComponent<AudioSource>().Play();

        img10.gameObject.SetActive(true);
        text10.GetComponent<Text>().text = "10번물고기 입니다";
    }

}

