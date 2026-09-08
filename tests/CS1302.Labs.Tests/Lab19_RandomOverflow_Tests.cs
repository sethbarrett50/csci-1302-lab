using CS1302.Lab19.RandomOverflow.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab19_RandomOverflow_Tests
{
    [Fact]
    public void DiceSimulator_With_Same_Seed_Produces_Same_Sequence()
    {
        DiceSimulator first = new DiceSimulator(42);
        DiceSimulator second = new DiceSimulator(42);

        for (int i = 0; i < 10; i++)
        {
            Assert.Equal(first.RollDie(), second.RollDie());
        }
    }

    [Fact]
    public void DiceSimulator_Always_Rolls_Between_One_And_Six()
    {
        DiceSimulator dice = new DiceSimulator(1);

        for (int i = 0; i < 100; i++)
        {
            int roll = dice.RollDie();
            Assert.InRange(roll, 1, 6);
        }
    }

    [Fact]
    public void UncheckedAdd_Wraps_Around_On_Overflow()
    {
        int result = OverflowDemo.UncheckedAdd(int.MaxValue, 1);

        Assert.Equal(int.MinValue, result);
    }

    [Fact]
    public void CheckedAdd_Throws_OverflowException()
    {
        Assert.Throws<OverflowException>(() => OverflowDemo.CheckedAdd(int.MaxValue, 1));
    }
}
