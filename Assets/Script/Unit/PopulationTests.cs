using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class PopulationTests
{
    private PopulationManager populationManager;

    [SetUp]
    public void Setup()
    {
        populationManager = new PopulationManager();
        populationManager.populationSize = 10;
        populationManager.Start();
    }

    [Test]
    public void Population_Size_Is_Correct()
    {
        Assert.AreEqual(10, populationManager.agents.Count);
    }

    [Test]
    public void Agents_Have_Initialized_Weights()
    {
        foreach (var agent in populationManager.agents)
        {
            Assert.IsNotNull(agent);
            Assert.AreEqual(2, agent.inputSize);
            Assert.AreEqual(2, agent.hiddenSize);
            Assert.AreEqual(1, agent.outputSize);
        }
    }
}