﻿using SendingEmail.Models;

namespace SendingEmail.Services
{
    public interface IEmailServiceSmtp
    {
        void SendEmail(EmailDetails emailRequest);

    }
}
