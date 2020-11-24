﻿using System.Diagnostics;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace TwitterSentimentServer
{
    class Program
    {
        [Obsolete]
        static void Main()
        {
            HttpChannel channel = new HttpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            //________Admin Remoting system
            RemotingConfiguration.RegisterWellKnownServiceType
               (typeof(TwitterSentimentServices.TwitterSentimentServices), "AddUser", WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType
              (typeof(TwitterSentimentServices.TwitterSentimentServices), "RemoveUser", WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(TwitterSentimentServices.TwitterSentimentServices), "RetrieveUser", WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(TwitterSentimentServices.TwitterSentimentServices), "RetrieveTwits", WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(TwitterSentimentServices.TwitterSentimentServices), "AddCase", WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(TwitterSentimentServices.TwitterSentimentServices), "RemoveCase", WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(TwitterSentimentServices.TwitterSentimentServices), "RetrieveCases_user", WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(TwitterSentimentServices.TwitterSentimentServices), "RetrieveUsers_case", WellKnownObjectMode.Singleton);

            RemotingConfiguration.RegisterWellKnownServiceType
               (typeof(TwitterSentimentServices.TwitterSentimentServices), "RetreiveAllTwitsforSentiment", WellKnownObjectMode.Singleton); 
   
             RemotingConfiguration.RegisterWellKnownServiceType
               (typeof(TwitterSentimentServices.TwitterSentimentServices), "AddSentimentforTwit", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType
              (typeof(TwitterSentimentServices.TwitterSentimentServices), "RetrieveOverallSentiments", WellKnownObjectMode.Singleton);
            //_______User Remoting system
            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(TwitterSentimentServices.TwitterSentimentServices), "AddTwit", WellKnownObjectMode.Singleton);
           
            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(TwitterSentimentServices.TwitterSentimentServices), "ParticipateCase", WellKnownObjectMode.Singleton);

            Console.WriteLine("Server has Started at " + DateTime.Now);
            Console.ReadLine();
        }
    }
}

