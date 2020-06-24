using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.SRP
{
    interface IUser
    {
        bool Login(string usename,string password);
        bool Register(string usename, string password,string Email);

        // At first log error and send email looks ok but User interface responsibility is not logging error and sending email so commenting it out and moving to resonsible interfaces.
        //void LogError(string Error);
        //bool SendEmail(string EmailContent);
    }

    interface ILogger
    {
        void LogError(string Error);
    }

    interface IEmail
    {
        bool SendEmail(string EmailContent);
    }
}
