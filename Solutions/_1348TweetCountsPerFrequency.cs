using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramClient
{
    public class Tweet
    {
        public string tweetName { get; set; }
        public int time { get; set; }
    }

    public class TweetCounts
    {

        private readonly List<Tweet> tweets;

        public TweetCounts()
        {
            tweets = new List<Tweet>();
        }

        public void RecordTweet(string tweetName, int time)
        {
            tweets.Add(new Tweet() { tweetName = tweetName, time = time });
        }

        public IList<int> GetTweetCountsPerFrequency(string freq, string tweetName, int startTime, int endTime)
        {

            int partitionIndicator = 60;
            if (freq == "hour") partitionIndicator = 60 * 60;
            if (freq == "day") partitionIndicator = 24 * 60 * 60;

            var filteredTweets = tweets
                .Where(_ => _.tweetName == tweetName && _.time >= startTime && _.time <= endTime);

            if (filteredTweets.Count() == 0) return new List<int>();

             filteredTweets.GroupBy(_ => (int)(_.time / partitionIndicator))
                 .Select(_ => _.Count()).ToList();
            return filteredTweets.Select(_=>_.time).ToList();
        }
    }
}
