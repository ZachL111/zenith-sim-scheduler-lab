using ZenithSimSchedulerLab;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(76, 49, 27, 46);
        if (DomainReviewLens.Score(item) != 166) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
