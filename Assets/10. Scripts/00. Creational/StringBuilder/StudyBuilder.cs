using UnityEngine;

namespace Study.OOP.Builder
{
    public class StudyBuilder : MonoBehaviour
    {
        // ================== [Builder Pattern] ==================
        // 객체를 생성하는 과정과 객체의 실제 형태를 완전히 분리, 
        // 동일한 생성 절차에서 서로 다른 결과물을 만들 수 있게 하는 생성 패턴의 한 종류
        //
        // 객체를 생성할 때 선택적인 매개변수가 많아지면 생성자나 Init() 메소드의 종류가 증가함
        // Builder 패턴은 이런 복잡성을 보완하기 위해 활용함
        //
        // ** 핵심 **
        // 재귀적 반환형태로 만들어서 코드를 마치 영어 문장처럼 읽히게 만드는 것!
        // ex list)
        // - 절차적 맵 생성기
        // - 절차적 몬스터 생성기
        // - 플레이 캐릭터 생성기
        // >> 이렇게 절차적인 객체 생성 등에 활용이 쌉Possible


        private void Awake()
        {
            Sword newSwordA = new SwordBuilder().CreateSword();
            Sword newSwordB = new SwordBuilder().SetRandomGrade().CreateSword();
            Sword newSwordC = new SwordBuilder().SetRandomGrade().SetName().CreateSword();
            
            Debug.Log(newSwordA.ToString());
            Debug.Log(newSwordB.ToString());
            Debug.Log(newSwordC.ToString());
        }
    }    
}


