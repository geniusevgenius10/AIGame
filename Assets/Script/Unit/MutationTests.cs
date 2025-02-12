using NUnit.Framework;
using System.Linq;

[TestFixture]
public class MutationTests
{
    private GeneticAlgorithm geneticAlgorithm;
    private NeuralNetwork network;

    [SetUp]
    public void Setup()
    {
        geneticAlgorithm = new GeneticAlgorithm();
        network = new NeuralNetwork(2, 2, 1);
        network.RandomizeWeights();
    }

    [Test]
    public void Mutation_Changes_Weights()
    {
        float[] oldWeights = network.weights.ToArray();
        geneticAlgorithm.Mutate(network, 1.0f); // 100% вероятность мутации

        bool weightsChanged = !oldWeights.SequenceEqual(network.weights);
        Assert.IsTrue(weightsChanged);
    }
}