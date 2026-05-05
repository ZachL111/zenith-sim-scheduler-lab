using ZenithSimSchedulerLab;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(60, 73, 10, 21, 5);
        if (Policy.Score(signalcase_1) != 89) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(86, 87, 19, 14, 13);
        if (Policy.Score(signalcase_2) != 172) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(75, 88, 22, 21, 6);
        if (Policy.Score(signalcase_3) != 100) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
