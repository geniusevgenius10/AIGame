using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class TrainingLoopTests
{
    private TrainingLoop trainingLoop;
    private GameObject trainingLoopObject;

    [SetUp]
    public void Setup()
    {
        trainingLoopObject = new GameObject();
        trainingLoop = trainingLoopObject.AddComponent<TrainingLoop>();
        trainingLoop.populationManager = new PopulationManager();
    }

    [Test]
    public void Generation_Increments_When_All_Agents_Are_Eliminated()
    {
        int initialGeneration = trainingLoop.generation;

        GameObject[] allAgents = GameObject.FindObjectsOfType<Agent>();
        foreach (var agent in allAgents)
        {
            GameObject.Destroy(agent.gameObject);
        }

        trainingLoop.Update();
        Assert.Greater(trainingLoop.generation, initialGeneration);
    }
}