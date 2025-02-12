using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class EvolutionTests
{
    private EvolutionManager evolutionManager;
    private List<NeuralNetwork> agents;

    [SetUp]
    public void Setup()
    {
        evolutionManager = new EvolutionManager();
        agents = new List<NeuralNetwork>
        {
            new NeuralNetwork(2, 2, 1) { fitness = 10 },
            new NeuralNetwork(2, 2, 1) { fitness = 50 },
            new NeuralNetwork(2, 2, 1) { fitness = 30 }
        };
    }

    [Test]
    public void Best_Agents_Are_Selected()
    {
        List<NeuralNetwork> bestAgents = evolutionManager.SelectBestAgents(agents);
        Assert.AreEqual(2, bestAgents.Count);
        Assert.AreEqual(50, bestAgents[0].fitness);
        Assert.AreEqual(30, bestAgents[1].fitness);
    }
}