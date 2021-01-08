using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TwitterSentimentWcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    [ServiceContract]
    public interface ITwitterWcfService
    {
        /*[OperationContract]
        string GetTweetText(int id);

        [OperationContract]
        List<Twits> GetTweets();*/

        [OperationContract]
        ArrayList GetCasesWithSentiment(int from, int to);

        [OperationContract]
        ArrayList GetTwitsOfUser(int user_id);

        [OperationContract]
        int CountUsersWithSentiment(int from, int to);

    }

    [DataContract]
    public class Twits
    {


        [DataMember]
        public int Id
        {
            get;
            set;
        }

        [DataMember]
        public string Text
        {
            get;
            set;
        }

        [DataMember]
        public int UserId
        {
            get;
            set;
        }

        [DataMember]
        public int Sentiment
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }

        [DataMember]
        public int? CaseId
        {
            get;
            set;
        }

    }
    [DataContract]
    public class Cases
    {

        [DataMember]
        public int Id
        {
            get;
            set;
        }

        [DataMember]
        public string Text
        {
            get;
            set;
        }

        [DataMember]
        public String Dol
        {
            get;
            set;
        }

        [DataMember]
        public int OverallSent
        {
            get;
            set;

        }
    }

    [DataContract]
    public class users
    {

        [DataMember]
        public int Id
        {
            get;
            set;
        }

        [DataMember]
        public string FirstName
        {
            get;
            set;
        }

        [DataMember]
        public String LastName
        {
            get;
            set;
        }

        [DataMember]
        public String Dob
        {
            get;
            set;

        }
    }
}
