using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, User>();

            string input = Console.ReadLine();

            string sender;
            string recipient;

            while (input != "exit")
            {
                string[] token = input.Split(' ');

                if (token[0] == "register")
                {
                    string username = token[1];
                    users.Add(username, new User(username));
                }
                else
                {
                    sender = token[0];
                    recipient = token[2];
                    string content = token[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        User senderUser = users[sender];
                        users[recipient].Messages.Add(new Message(content, senderUser));
                    }
                }
                input = Console.ReadLine();
            }

            string[] chatTokens = Console.ReadLine().Split(' ');
            sender = chatTokens[0];
            recipient = chatTokens[1];

            Message[] senderMessages = users[recipient]
                .Messages
                .Where(m => m.Sender.Username == sender)
                .ToArray();
            Message[] recipientMessages = users[sender]
                .Messages
                .Where(m => m.Sender.Username == recipient)
                .ToArray();

            if (senderMessages.Length == 0 && recipientMessages.Length == 0)
            {
                Console.WriteLine("No messages");
            }

            int index = 0;
            while (index < senderMessages.Length && index < recipientMessages.Length)
            {
                Console.WriteLine($"{sender}: {senderMessages[index].Content}");
                Console.WriteLine($"{recipientMessages[index].Content} :{recipient}");
                index++;
            }

            while (index < senderMessages.Length)
            {
                Console.WriteLine($"{sender}: {senderMessages[index].Content}");
                index++;
            }
            while (index < recipientMessages.Length)
            {
                Console.WriteLine($"{recipientMessages[index].Content} :{recipient}");
                index++;
            }
        }
    }
    class User
    {
        public string Username { get; set; }
        public List<Message> Messages { get; set; }

        public User(string usernameInput)
        {
            this.Username = usernameInput; // otnasq se za metod, a ne promenliva
            this.Messages = new List<Message>(); // otnasq se za metod, a ne promenliva
        }
    }
    class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }

        public Message(string contentInput, User senderInput)
        {
            this.Content = contentInput;
            this.Sender = senderInput;
        }
    }
}
