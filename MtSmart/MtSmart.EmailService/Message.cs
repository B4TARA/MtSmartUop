﻿using MimeKit;

namespace MtSmart.EmailService
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string AddresseeName { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public Message(IEnumerable<string> to, string subject, string content, string addresseeName)
        {
            To = new List<MailboxAddress>();

            To.AddRange(to.Select(x => new MailboxAddress(x, x)));
            Subject = subject;
            Content = content;
            AddresseeName = addresseeName;
        }
    }
}
