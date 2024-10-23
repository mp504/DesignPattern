using Mediator;

class Program
{


    public static void Main(string[] args)
    {
        IChatMediator chatMediator = new ChatMediator();
        User user1 = new User("Mansour", chatMediator);
        User user2 = new User("Ibra", chatMediator);
        User user3 = new User("Zayed", chatMediator);

        

        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);    
        chatMediator.AddUser(user3);

        user1.SendMessage("Salaaaam shabaaab ");

        user3.SendMessage("hala mansour");

    }
}
