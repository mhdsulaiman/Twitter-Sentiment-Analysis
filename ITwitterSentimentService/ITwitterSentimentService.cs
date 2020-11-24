using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using TwitterSentimentService;

namespace ITwitterSentimentService
{

    public interface ITwitterSentimentService
    {
        //admin methods
        void AddUser(string first_name, string last_name, string DOB);
        void RemoveUser(int id, string first_name, string last_name);
        ArrayList RetrieveUser(int id);
        ArrayList RetrieveTwits(int user_id);
        void AddCase(string case_text);
        void RemoveCase(int case_id);
        ArrayList RetrieveCases_user(int user_id);
        ArrayList RetrieveUsers_case(int case_id);
        void AddSentimentforTwit(int twit_id, int sentiment,int case_id);
        ArrayList RetreiveAllTwitsforSentiment();
        ArrayList RetrieveOverallSentiments();
        //User methods
        string AddTwit(string twit_text,string username);
        string ParticipateCase(int case_id,string twit_text,string username);
    }
}
