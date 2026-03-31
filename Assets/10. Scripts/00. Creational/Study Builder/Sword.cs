using System.Collections.Generic;

namespace Study.OOP.Builder
{
    public enum ElementType
    {
        None = 0,
        Fire,
        Ice,
        Leaf,
        END,
    }

    public enum Grade
    {
        Normal = 0,
        Magic,
        Rare,
        Unique,
        END,
    }

    public class Sword
    {
        public string Name { get; private set; }
        public int AttackValue { get; private set; }
        public ElementType Type { get; private set; }
        public Grade Grade { get; private set; }

        public List<string> Options { get;  private set; }

        // 생성자
        public Sword()
        {
            Name = "미완성의 칼";
            AttackValue = 1;
            Type = ElementType.None;
            Grade = Grade.Normal;
            Options = new List<string>();
        }

        public Sword(string name, int attackValue, ElementType type, Grade grade, List<string> options)
        {
            Name = name;
            AttackValue = attackValue;
            Type = type;
            Grade = grade;
            Options = options;
        }
        
        public void SetName(string name) => Name = name;
        public void SetAttackValue(int atk) => AttackValue = atk;
        public void SetType(ElementType type) => Type = type;
        public void SetGrade(Grade grade) => Grade = grade;

        public void SetOptions(List<string> options) => Options = options;

        public override string ToString()
        {
            string colorCode = Grade switch
            {
                Grade.Normal => "#FFFFFF",
                Grade.Magic => "#4EA5F5",
                Grade.Rare => "#F5D64E",
                Grade.Unique => "#C74EF5",
                _ => "#FFFFFF"
            };

            string optionText = Options != null && Options.Count > 0
                ? string.Join("\n    - ", Options)
                : "없음";

            return $"<color={colorCode}><b>[{Grade}] {Name}</b></color>\n" +
                   $"<b>공격력:</b> {AttackValue}\n" +
                   $"<b>속성:</b> {Type}\n" +
                   $"<b>옵션:</b>\n    - {optionText}";
        }
    }
}