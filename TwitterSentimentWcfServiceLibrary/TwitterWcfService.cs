using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TwitterSentimentWcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TwitterWcfService : ITwitterWcfService
    {
        /*public List<ITwitterWcfService.twits> GetTweets()
        {
            var ctx = new TwitterDataContext();
            var query = (from twit in ctx.twits select twit);
            return ConvertQueryToList(query);
        }*/

       /* public string GetTweetText(int id)
        {

            var ctx = new TwitterDataContext();
            var c = (from Twit in ctx.twits where Twit.id == id select Twit).SingleOrDefault();
            return c.text;
        }

        public List<T> ConvertQueryToList<T>(IQueryable<T> query)
        {
            return query.ToList();
        }

        public List<Twits> GetTweets()
        {
            throw new NotImplementedException();
        }
*/
        public ArrayList GetCasesWithSentiment(int fromSent, int toSent)
        {
            ArrayList allRecords = new ArrayList();
            var ctx = new TwitterDataContext();
            IQueryable<Cases> c = from cases in ctx.cases where (cases.overall_sentiment >= fromSent) where (cases.overall_sentiment <= toSent) select new Cases { Id = cases.id, Text = cases.text, Dol = cases.dol, OverallSent = cases.overall_sentiment };

            allRecords.AddRange(c.ToArray());
            Console.WriteLine("test test" + allRecords);
            foreach (Cases obj in allRecords)
            {
                Console.WriteLine(obj.Id);

            }

            return allRecords;
        }

        public ArrayList GetTwitsOfUser(int user_id)
        {
            ArrayList allRecords = new ArrayList();
            var ctx = new TwitterDataContext();
            IQueryable<Twits> c = from twits in ctx.twits where (twits.user_id == user_id) select new Twits { Id = twits.id, Text = twits.text, UserId = twits.user_id, Sentiment = twits.sentiment, Date = twits.date, CaseId = twits.case_id };

            allRecords.AddRange(c.ToArray());
            Console.WriteLine("test test" + allRecords);
            foreach (Twits obj in allRecords)
            {
                Console.WriteLine(obj.Date);

            }

            return allRecords;
        }

        public int CountUsersWithSentiment(int fromSent, int toSent)
        {
            ArrayList allRecordsInRange = new ArrayList();
            var ctx = new TwitterDataContext();
            IQueryable<Twits> c = from twits in ctx.twits where (twits.sentiment >= fromSent) where (twits.sentiment <= toSent) select new Twits { Id = twits.id, Text = twits.text, UserId = twits.user_id, Sentiment = twits.sentiment, Date = twits.date, CaseId = twits.case_id };
            var m = c.Select(g => g.UserId).Distinct().Count();
            /*allRecordsInRange.AddRange(c.ToArray());
            Console.WriteLine("test test" + allRecordsInRange);
            foreach (Twits obj in allRecordsInRange)
            {
                Console.WriteLine(obj.Id);

            }
            */

            return m;
        }




    }
}
