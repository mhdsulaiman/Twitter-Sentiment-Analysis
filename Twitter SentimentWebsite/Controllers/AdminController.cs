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
using TwitterSentimentService;
using System.Runtime.Serialization.Formatters.Soap;

namespace Twitter_SentimentWebsite.Controllers
{
    [Serializable]
    public class AdminController : Controller
    {
        ITwitterSentimentService.ITwitterSentimentService client;
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
        public ActionResult RetrieveTwits()
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
        public ActionResult RetrieveUsers_case()
        {
            ViewBag.check = false;
            return View();
        }
  
        [Obsolete]
        [HttpPost]
        public ActionResult Verify_adduser(AddUser_Data add)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/AddCase");

            client.AddUser(add.first_name, add.last_name, add.dob);
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

            client.RemoveUser(rem.id, rem.first_name, rem.last_name);
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

            ArrayList user_retrieve = client.RetrieveUser(ret.id);
            if (user_retrieve != null)
            {
                ViewBag.user = user_retrieve;
            }

            else
            {
                ViewBag.user = null;
            }
            ChannelServices.UnregisterChannel(channel);
            return View("RetrieveUser");

        }
        [HttpPost]
        [Obsolete]
        public ActionResult Verify_retrievetwits(RetrieveTwits_Data ret)
        {
            ViewBag.check = true;

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetrieveTwits");

            ArrayList twit_retrieve = client.RetrieveTwits(ret.user_id);
            if (twit_retrieve != null)
            {
                ViewBag.twit = twit_retrieve;  
            }

            else
            {
                ViewBag.twit = null;
            }
            ChannelServices.UnregisterChannel(channel);
            return View("RetrieveTwits");
        }

        [Obsolete]
        [HttpPost]
        public ActionResult Verify_addcase(AddCase_Data add)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/AddCase");
           
            client.AddCase(add.case_text);
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

            client.RemoveCase(rem.case_id);
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

            ArrayList case_retrieve = client.RetrieveCases_user(ret.user_id);
            if (case_retrieve != null)
            {
                ViewBag.cases = case_retrieve;
            }

            else
            {
                ViewBag.cases = null;
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

            ArrayList user_retrieve = client.RetrieveUsers_case(ret.case_id);
            if (user_retrieve != null)
            {
                ViewBag.users = user_retrieve;
            }

            else
            {
                ViewBag.users = null;
            }
            ChannelServices.UnregisterChannel(channel);
            return View("RetrieveUsers_case");
        }

      [Obsolete]
        public ActionResult AddTwitSentiment()
        { 

        HttpChannel channel = new HttpChannel();
        ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService) Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetreiveAllTwitsforSentiment");

        ArrayList twits_retrieve = client.RetreiveAllTwitsforSentiment();
            if (twits_retrieve != null)
            {
                ViewBag.twit = twits_retrieve;
            }

            else
            {
                ViewBag.twit = null;
            }
            ChannelServices.UnregisterChannel(channel);
            return View();

        }
        [HttpPost]
        [Obsolete]
        public ActionResult AddSentimentforTwit(AddSentimentforTwit add)
        {

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/AddSentimentforTwit");

            client.AddSentimentforTwit(add.twit_id,add.sentiment,add.case_id);
            ChannelServices.UnregisterChannel(channel);
            
            return View("AddTwitSentiment",AddTwitSentiment());
        }
        [Obsolete]
        public ActionResult RetrieveOverallSentiments()
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (ITwitterSentimentService.ITwitterSentimentService)Activator.GetObject
              (typeof(ITwitterSentimentService.ITwitterSentimentService), "http://localhost:8080/RetrieveOverallSentiments");

            ArrayList cases_retrieve = client.RetrieveOverallSentiments();
            if (cases_retrieve != null)
            {
                ViewBag.cases = cases_retrieve;
            }

            else
            {
                ViewBag.cases = null;
            }
            ChannelServices.UnregisterChannel(channel);
            return View();
        }
    }
}
       