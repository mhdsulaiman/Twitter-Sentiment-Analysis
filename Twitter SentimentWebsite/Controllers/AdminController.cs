using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using AdminModels;
using TwitterSentimentWcfServiceLibrary;

namespace Twitter_SentimentWebsite.Controllers
{
    [Serializable]
    public class AdminController : Controller
    {
        ITwitterSentimentService.ITwitterSentimentService client;
        TwitterWcfService client2 = new TwitterWcfService();

        // GET: Admin
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult RemoveUser()
        {
            return View();
        }
        public ActionResult RetrieveUser()
        {
            ViewBag.check = false;
            return View();
        }
        public ActionResult RetrieveTweets()
        {
            ViewBag.check = false;
            return View();
        }
        public ActionResult AddCase()
        {
            return View();
        }
        public ActionResult RemoveCase()
        {
            return View();
        }
        public ActionResult RetrieveCases_user()
        {
            ViewBag.check = false;
            return View();
        }
        public ActionResult RetrieveCasesWithSentiment()
        {
            /* ViewBag.check = false;*/
            return View();
        }

        public ActionResult UserSentimentChanges()
        {
            /* ViewBag.check = false;*/
            return View();
        }
        public ActionResult RetrieveUsers_case()
        {
            ViewBag.check = false;
            return View();
        }
        public ActionResult UsersDistribution()
        {
            ViewBag.check = true;
            string labels = "";
            string data = "";
            for (var i = 0; i <= 90; i += 10)
            {
                int from = i;
                int to = i + 10;
                int numOfUsers = client2.CountUsersWithSentiment(from, to);
                labels += "'[" + from + "," + to + "]'" + ",";
                data += numOfUsers + ",";
            }

            ViewBag.labels = labels;
            ViewBag.data = data;
            return View();
        }

        [Obsolete]
        [HttpPost]
        public ActionResult Verify_adduser(AddUser_Data add)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/AddUser");
            try
            {
                string user_check = client.AddUser(add.first_name, add.last_name, add.dob);
                if (user_check == "exsist")
                {
                    ViewBag.user_check = 1;
                }
                else
                {
                    ViewBag.user_check = 0;
                }
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);

            return View("AddUser");
        }
        

        [Obsolete]
        [HttpPost]
        public ActionResult Verify_removeuser(RemoveUser_Data rem)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RemoveUser");

            try
            {
                client.RemoveUser(rem.id, rem.first_name, rem.last_name);
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);

            return View("RemoveUser");
        }
        [Obsolete]
        [HttpPost]
        public ActionResult Verify_retrieveuser(RetrieveUser_Data ret)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetrieveUser");
            try
            {
                ArrayList user_retrieve = client.RetrieveUser(ret.id);

                if (user_retrieve != null)
                {
                    ViewBag.user = user_retrieve;
                }

                else
                {
                    ViewBag.user = null;
                }
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);
            return View("RetrieveUser");

        }
        [HttpPost]
        [Obsolete]
        public ActionResult Verify_retrievetweets(RetrieveTweets_Data ret)
        {
            ViewBag.check = true;

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetrieveTweets");
            try
            {
                ArrayList tweet_retrieve = client.RetrieveTweets(ret.user_id);
                if (tweet_retrieve != null)
                {
                    ViewBag.tweet = tweet_retrieve;
                }

                else
                {
                    ViewBag.tweet = null;
                }
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);
            return View("RetrieveTweets");
        }

        [Obsolete]
        [HttpPost]
        public ActionResult Verify_addcase(AddCase_Data add)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/AddCase");
            try
            {
                client.AddCase(add.case_text);
            }catch(Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);

            return View("AddCase");
        }

        [Obsolete]
        [HttpPost]
        public ActionResult Verify_removecase(RemoveCase_Data rem)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RemoveCase");
            try
            {
                client.RemoveCase(rem.case_id);
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);

            return View("RemoveCase");
        }

        [HttpPost]
        [Obsolete]
        public ActionResult Verify_retrievecases_user(RetrieveCases_user_Data ret)
        {
            ViewBag.check = true;

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetrieveCases_user");
            try
            {
                ArrayList case_retrieve = client.RetrieveCases_user(ret.user_id);
                if (case_retrieve != null)
                {
                    ViewBag.cases = case_retrieve;
                }

                else
                {
                    ViewBag.cases = null;
                }
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);
            return View("RetrieveCases_user");
        }
        [Obsolete]
        [HttpPost]
        public ActionResult Verify_retrieveusers_case(RetrieveUsers_case_Data ret)
        {
            ViewBag.check = true;

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetrieveUsers_case");
            try
            {
                ArrayList user_retrieve = client.RetrieveUsers_case(ret.case_id);
                if (user_retrieve != null)
                {
                    ViewBag.users = user_retrieve;
                }

                else
                {
                    ViewBag.users = null;
                }
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);
            return View("RetrieveUsers_case");
        }

        [Obsolete]
        public ActionResult AddTweetSentiment()
        {

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetreiveAllTweetsforSentiment");
            try
            {
                ArrayList tweets_retrieve = client.RetreiveAllTweetsforSentiment();
                if (tweets_retrieve != null)
                {
                    ViewBag.tweet = tweets_retrieve;
                }

                else
                {
                    ViewBag.tweet = null;
                }
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);
            return View();

        }
        [HttpPost]
        [Obsolete]
        public ActionResult AddSentimentforTweet(AddSentimentforTweet add)
        {

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/AddSentimentforTweet");
            try
            {
                client.AddSentimentforTweet(add.tweet_id, add.sentiment, add.case_id);
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);

            return View("AddTweetSentiment", AddTweetSentiment());
        }
        [Obsolete]
        public ActionResult RetrieveOverallSentiments()
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetrieveOverallSentiments");
            try
            {
                ArrayList cases_retrieve = client.RetrieveOverallSentiments();
                if (cases_retrieve != null)
                {
                    ViewBag.cases = cases_retrieve;
                }

                else
                {
                    ViewBag.cases = null;
                }
            }
            catch (Exception e)
            {
                ChannelServices.UnregisterChannel(channel);

                Console.WriteLine(e);
            }
            ChannelServices.UnregisterChannel(channel);
            return View();
        }

        [HttpPost]
        [Obsolete]
        public ActionResult Verify_GetCases(RetrieveCases range)
        {


            try
            {
                ArrayList cases_recieved = client2.GetCasesWithSentiment(range.from, range.to);
                if (cases_recieved != null)
                {
                    ViewBag.cases = cases_recieved;
                }

                else
                {
                    ViewBag.cases = null;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            return View("RetrieveCases");
        }

        /*        Get_User_Sentiment_Changes */

        /*RetrieveUser_Data*/

        [HttpPost]
        [Obsolete]
        public ActionResult Get_User_Sentiment_Changes(RetrieveUserTweets user)
        {
            ViewBag.check = true;
            ArrayList user_tweets = client2.GetTwitsOfUser(user.id);


            if (user_tweets != null)
            {
                string ids = "";
                string sents = "";
                foreach (Twits obj in user_tweets)
                {
                    var date = obj.Date.Split(' ')[0].Replace("/", "-");
                    var time = obj.Date.Split(' ')[1];
                    ids += "'" + obj.Date + "',";
                    sents += obj.Sentiment.ToString() + ',';
                }
                ViewBag.ids = ids;
                ViewBag.sent = sents;
                ViewBag.tweets = user_tweets;
                ViewBag.userId = user.id;

            }

            else
            {
                ViewBag.ids = "empty";
                ViewBag.sent = "empty";
                ViewBag.tweets = "empty";
                ViewBag.userId = "empty";

            }

            return View("UserSentimentChangesChart");

        }
    }
}
