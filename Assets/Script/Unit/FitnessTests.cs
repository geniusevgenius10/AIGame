using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class FitnessTests
{
    private GameObject agentObject;
    private Agent agent;

    [SetUp]
    public void Setup()
    {
        agentObject = new GameObject();
        agent = agentObject.AddComponent<Agent>();
    }

    [Test]
    public void Fitness_Increases_Over_Time()
    {
        float initialFitness = agent.fitness;
        agent.Update();
        Assert.Greater(agent.fitness, initialFitness);
    }

    [Test]
    public void Fitness_Decreases_On_Collision()
    {
        float initialFitness = agent.fitness;
        GameObject obstacle = new GameObject();
        obstacle.tag = "Obstacle";

        Collision2D collision = new Collision2D();
        agent.OnCollisionEnter2D(collision);

        Assert.Less(agent.fitness, initialFitness);
    }
}