using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IChatMediator
    {
        void SendChatMessage(string message, User user);
        void AddUser (User username);
    }


    public class ChatMediator: IChatMediator
    {
        private readonly List<User> _users = new List<User>();
        public void AddUser( User user) 
        {
            _users.Add(user);
             

        }

        public void SendChatMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                {
                    u.RecieveMessage(message);

                }


            }
        }

    }

    public class User
    {
        private readonly string _name;
        private IChatMediator _Chatmediator;


        public User(string name, IChatMediator chatMediator )
        {
            _name = name;
            _Chatmediator = chatMediator;
        }


       

        public void SendMessage(string message)
        {
            Console.WriteLine($"{_name}: Sending message= {message}");
            _Chatmediator.SendChatMessage(message,this);


        }

        public void RecieveMessage(string message) 
        {
            Console.WriteLine($"{_name}: Received Message = {message}");
        }

    }



}
