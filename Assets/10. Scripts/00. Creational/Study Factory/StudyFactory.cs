using System.Collections.Generic;
using UnityEngine;

namespace Study.OOP.Factory
{
    // ========== [Factory Pattern] ========== 
    // 객체를 생성하는 로직을 사용하는 쪽으로부터 분리하여,
    // 별도의 "공장" 클래스가 전담하도록 만드는 생성 패턴의 한 종류
    //
    // 호출하는 쪽에서는 구체적인 클래스를 알 수 없게 설계하는게 좋음
    // 공장에 "( ) 하나 만들어주세욤" 라고 요청하고, 반환된 추상적인 객체를 사용하도록 설계하는 것이 좋은 방향
    //
    // 핵심은 새로운 종류의 클래스가 추가될 때마다 핵심 로직(게임 로직)의 수정이 필요없도록 설계하는 것
    // 오직 팩토리 내부의 생산 조건만 추가하도록 설계
    // ex list)
    // - 아이템 드롭시스템
    // - 다양한 프로젝타일 생성
    // =======================================
    
    // Normal, Rare, Unique, Legendary, Epic 5개 등급의 카드를 생성할거임!
    // 
    public class StudyFactory : MonoBehaviour
    {
        private List<Card.Factory> cardFactories = new List<Card.Factory>();
        
        private void Awake()
        {
            cardFactories.Add(new NormalCard.NormalCardFactory(30, 100));
            cardFactories.Add(new RareCard.RareCardFactory(50, 120));
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var card = cardFactories[0].CreateCard();
                LogColor($"Card = {card.Name}, {card.Value}", card.Color);
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                for (int i = 0; i < 1000; ++i)
                {
                    CreateCard();
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                cardFactories.Add(new RareCard.RareCardFactory());
            }

        }

        private void CreateCard()
        {
            int rand = Random.Range(0, 100);
            Card.Factory targetFactory = cardFactories[0];

            for (int i = 1; i < cardFactories.Count; ++i)
            {
                if (cardFactories[i].InRange(rand))
                {
                    targetFactory = cardFactories[i];
                }
            }
        }
        
        public void LogColor(string meesage, )
    }
}