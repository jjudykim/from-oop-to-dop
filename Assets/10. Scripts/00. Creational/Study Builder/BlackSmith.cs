using System;

namespace Study.OOP.Builder
{
    public class BlackSmith
    {
        public int Level = 1;

        public Sword GenerateSword(Grade grade)
        {
            // 3가지 기본 특징을 부여
            SwordBuilder builder = new SwordBuilder()
                .SetGrade(grade)
                .SetName()
                .SetRandomAttackValue();

            switch (grade)
            {
                case Grade.Magic:
                    builder.SetRandomOptions();
                    break;
                case Grade.Rare:
                    builder.SetRandomElementType()
                        .AddRandomOptions()
                        .AddRandomOptions();
                    break;
                case Grade.Unique:
                    builder.SetRandomElementType();
                    if (builder.AttackValue < 3000)
                    {
                        builder.AddAttackValue();
                    }

                    for (int i = 0; i < 3; ++i)
                    {
                        builder.SetRandomOptions();
                    }

                    break;
                default:
                    break;
            }
        }

        public Sword UpgradeSword(Sword sword)
        {
            var builder = new SwordBuilder().SetSword(sword);
            for (int i = 0; i < Level; ++i)
            {
                builder.SetRandomOptions();
            }

            return Builder.CreateSword();
        }
    }
}