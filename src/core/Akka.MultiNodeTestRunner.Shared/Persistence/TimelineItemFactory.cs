namespace Akka.MultiNodeTestRunner.Shared.Persistence
{
    using System;

    public static class TimelineItemFactory
    {
        private static readonly string[] CssClasses =
            {
                "vis-item-one",
                "vis-item-two",
                "vis-item-three",
                "vis-item-four",
                "vis-item-five",
                "vis-item-six",
                "vis-item-seven",
                "vis-item-eight",
                "vis-item-nine",
                "vis-item-ten",
                "vis-item-eleven",
                "vis-item-twelve",
                "vis-item-thirteen",
                "vis-item-fourteen",
                "vis-item-fifteen"
            };

        private static readonly string passedTestContent = @"<div class=""tick-image"" />";

        public static TimelineItem CreateSpecMessage(string prefix, string title, int groupId, long startTimeStamp)
        {
            var content = title.Replace(prefix, string.Empty);
            return new TimelineItem("timeline-message", content, title, new DateTime(startTimeStamp), groupId);
        }

        public static TimelineItem CreateNodeFact(string prefix, string title, int groupId, long startTimeStamp)
        {
            var content = title.Replace(prefix, string.Empty);
            if (title.EndsWith("PASS") || title.EndsWith("passed."))
            {
                content = passedTestContent;
            }
            return new TimelineItem(CssClasses[startTimeStamp % 15], content, title, new DateTime(startTimeStamp), groupId);
        }
    }
}